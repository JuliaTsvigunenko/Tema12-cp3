using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Time
    {
        /// <summary>
        /// количество часов
        /// </summary>
        public double hour;

        /// <summary>
        /// количество минут
        /// </summary>
        public double minutes;

        /// <summary>
        /// Количество секунд
        /// </summary>
        public double second;

        /// <summary>
        /// Конструктор без параметров (по умолчнанию)
        /// </summary>
        public Time()
        {
        }

        
        public Time(double watch, double minutes, double second)
        {
            this.hour = hour;
            this.minutes = minutes;
            this.second = second;
        }

        public override string ToString()
        {
            return $"Кол-во часов - {hour}\nКол-во минут - {minutes}\nКол-во секунд - {second}";
        }






    }
}
