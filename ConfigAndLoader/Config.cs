using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigAndLoader
{
    [Serializable]
    public class Config
    {
        public DateTime sleepTime = DateOnly.FromDateTime(DateTime.Now).ToDateTime(new TimeOnly(21, 0, 0));
        public DateTime wakeTime = DateOnly.FromDateTime(DateTime.Now).ToDateTime(new TimeOnly(9, 0, 0));
        public bool enableRestart = false;
        public bool monday = true;
        public bool tuesday = true;
        public bool wednesday = true;
        public bool thursday = true;
        public bool friday = true;
        public bool saturday = false;
        public bool sunday = false;
    }
}
