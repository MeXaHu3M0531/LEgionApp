using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEgionApp
{
    internal class room
    {
        public string name { get; set; }
        public int countHangers
        {
            get
            {
                return countHangers;
            }
            set
            {
                if (value > 0)
                {
                    countHangers = value;
                }
            }
        }
        public int num
        {
            get
            {
                return num;
            }
            set
            {
                if (value > 0)
                {
                    num = value;
                }
            }
        }
        Hanger[] Hangers = new Hanger[500];
        
    }
}
