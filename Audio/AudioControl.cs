using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Audio
{
    public class AudioControl
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

        void TimerCallback(Object o)
        {
            //UpdatePosition(outputDevice.GetPosition());
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
            outputDevice.Stop();
            StopTimer();
        }

        public void Rewind()
        {
            audioFile.Position = 0;
        }

        public void Rewind(long position)
        {
            audioFile.Position = audioFile.Position - position;
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



    }
}
