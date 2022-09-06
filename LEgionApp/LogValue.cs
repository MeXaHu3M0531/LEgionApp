using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEgionApp
{
    internal class LogValue
    {
        public double temp  //Поле, в котором хранится значение температуры
        {
            get
            {
                return temp;
            }
            set
            {
                if ((value > -40) && (value < 80))
                {
                    temp = value;
                }
            }
        }
        public double humidity  //В этом поле хранится влажность с датчика, если она есть
        {
            get
            {
                return humidity;
            }
            set
            {
                if ((value >= 0) && (value <= 100))
                {
                    humidity = value;
                }
            }
        }

        public int month  //В этом поле хранится месяц, во время которого производится замер
        {
            get
            {
                return month;
            }
            set
            {
                if ((value >= 0) && (value <= 12))
                {
                    month = value;
                }
            }
        }
        public int date
        {
            get
            {
                return date;
            }
            set
            {
                if ((value >= 1) && (value <= 31))
                {
                    date = value;
                }
            }
        }

        public int hour
        {
            get
            {
                return hour;
            }
            set
            {
                if ((value >= 0) && (value <= 23))
                {
                    hour = value;
                }
            }
        }
        public int minute
        {
            get
            {
                return minute;
            }
            set
            {
                if ((value >= 0) && (value <= 59))
                {
                    minute = value;
                }
            }
        }


        public string GetMonthData()
        {
            string result = date.ToString() + "." + month.ToString();

            return result;
        }
        public string GetTime()
        {
            string result = hour.ToString() + ":" + minute.ToString();

            return result;
        }
        public string GetAllTime()
        {
            string result = GetMonthData() + " " + GetTime();

            return result;
        }
    }
}
