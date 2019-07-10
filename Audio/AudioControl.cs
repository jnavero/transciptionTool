using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Audio
{
    public class AudioControl : IDisposable
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public delegate void UpdatePositionDelegate(int pos);
        public event UpdatePositionDelegate UpdatePosition;
        Timer t;

        public AudioControl()
        {
            outputDevice = new WaveOutEvent();
        }

        void StartTimer()
        {
            t = new Timer(TimerCallback, null, 0, 100);
        }

        void StopTimer()
        {
            t = null;
        }

        public int GetVolume()
        {
            if (audioFile != null)
            {
                return (int)(audioFile.Volume * 100);
            }

            return 0;
        }

        public void SetVolume(int volume)
        {
            audioFile.Volume = volume / 100f;
        }

        void TimerCallback(Object o)
        {
            UpdatePosition.Invoke((int)audioFile.CurrentTime.TotalSeconds);
        }


        public void LoadFile(string fileName)
        {
            audioFile = new AudioFileReader(fileName);
            if (outputDevice.PlaybackState != PlaybackState.Stopped)
            {
                Stop();
            }
            outputDevice.Init(audioFile);   
        }

        public bool Play()
        {
            if (audioFile == null)
            {
                return false;
            }
            UpdatePosition -= GetCurrentPosition;
            UpdatePosition += GetCurrentPosition;

            outputDevice.Play();
            StartTimer();
            return true;
        }

        public bool Play(string filename)
        {
            LoadFile(filename);
            return Play();
        }

        public void Stop()
        {
            StopTimer();
            outputDevice.Stop();
        }

        public void Rewind()
        {
            audioFile.Position = 0;
        }

        public void Rewind(int seconds)
        {
            seconds = seconds * -1;
            audioFile.CurrentTime = audioFile.CurrentTime.Add(new TimeSpan(0, 0, seconds));
        }

        public int GetDuration()
        {
            if(audioFile != null)
                return (int)audioFile.TotalTime.TotalSeconds;

            return 0;
        }

        public void GetCurrentPosition(int position)
        {            
        }

        public void Dispose()
        {
            outputDevice.Dispose();
            audioFile.Dispose();
            outputDevice = null;
            audioFile = null;
    }
    }
}
