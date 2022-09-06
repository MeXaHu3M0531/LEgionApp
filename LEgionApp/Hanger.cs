using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEgionApp
{
    internal class Hanger
    {
        public int number
        {
            get
            {
                return number;
            }
            set
            {
                if (value > 0)
                {
                    number = value;
                }
            }
        }
        public int countLoggers
        {
            get
            {
                return countLoggers;
            }
            set
            {
                if (value > 0)
                {
                    countLoggers = value;
                }
            }
        }
        public class Coordinates
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public Logger[] Loggers = new Logger[5];
    }
}
