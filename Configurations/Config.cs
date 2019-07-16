using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurations
{
    public class Config
    {
        public bool ProyectSaved { get; set; }

        public string TimesToRepeat { get; set; }
        public string CutTime { get; set; }
        public string Path { get; set; }
        public string PauseBetTime { get; set; }
        public string Position { get; set; }

        public void SaveProyect(string projectFile)
        {
            if (!string.IsNullOrEmpty(projectFile))
            {
                string content = $"TimesToRepeat: {TimesToRepeat}\n";
                content += $"PauseBetTime: {PauseBetTime}\n";
                content += $"CutTime: {CutTime}\n";
                content += $"Path: {Path}\n";
                content += $"Position: {Position}\n";
                File.WriteAllText(projectFile, content);
            }
        }

        public void LoadProject(string projectFile)
        {
            if (!string.IsNullOrEmpty(projectFile))
            {
                var content = File.ReadAllLines(projectFile);
                foreach (var item in content)
                {
                    var variable = item.Split(new char[] { ':' });
                    SetValue(variable[0], variable[1]);
                }
            }
        }

        private void SetValue(string name, string value)
        {
            var property = this.GetType().GetProperty(name);
            if(property != null)
            {
                property.SetValue(this, value);
            }
        }


    }
}
