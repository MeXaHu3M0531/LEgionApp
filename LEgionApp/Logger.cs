using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEgionApp
{
    internal class Logger
    {
        public string name { set; get; } 
        public int count
        {
            get
            {
                return count;
            }
            set
            {
                if (value > 0)
                {
                    count = value;
                }
            }
        }
        
        public Extremum ExtremeTemp = new Extremum();
        public Extremum ExtremeHumidity = new Extremum();

        public Extremum LimitTemp = new Extremum();
        public Extremum LimitHumidity = new Extremum();

        public double averageTemp { set; get; }
        public double averageHumidity { set; get; }
        public double height { set; get; }

        public LogValue[] values = new LogValue[10000];
    }
}
