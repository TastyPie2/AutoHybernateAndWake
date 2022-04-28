using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Updater
{
    public class StampedValue<T>
    {
        public bool CanExpire { get; set; }
        public DateTime TimeStamp { get; private set; }
        public TimeSpan TimeToLive { get; private set; }
        private T value { get; set; }

        public StampedValue()
        {
            CanExpire = false;
            TimeToLive = TimeSpan.MaxValue;
            SetValue(default(T));
        }

        public StampedValue(TimeSpan timeToLive)
        {
            CanExpire = true;
            TimeToLive = timeToLive;
            SetValue(default(T));
        }

        public StampedValue(T value)
        {
            CanExpire = false;
            TimeToLive = TimeSpan.MaxValue;
            SetValue(value);
        }

        public StampedValue(T value, TimeSpan timeToLive)
        {
            CanExpire = true;
            TimeToLive = timeToLive;
            SetValue(value);
        }



        public T GetValue()
        {
            return value;
        }

        public void SetValue(T v)
        {
            value = v;
            TimeStamp = DateTime.Now;
        }

        public bool IsExpiered()
        {
            if (!CanExpire)
                return false;

            if((DateTime.Now - TimeStamp) > TimeToLive)
            {
                return true;
            }
            return false;
        }
    }
}
