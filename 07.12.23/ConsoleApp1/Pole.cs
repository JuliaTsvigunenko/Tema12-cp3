using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс описывающий строение
    /// </summary>
    class Pole
    {
        /// <summary>
        /// Создание поля 1 вещественного числа
        /// </summary>
        public double number1;
        /// <summary>
        /// Создание поля 2 вещественного числа 
        /// </summary>
        public double number2;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Pole()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="pole1"></param>
        /// <param name="pole2"></param>
        public Pole(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public override string ToString()
        {
            return $"Первое число - {number1}\nВторое число - {number2}";
        }


        /// <summary>
        /// Вычислили корень квадратный из произведения чисел.
        /// </summary>
        public void Coreni()
        {
            Console.WriteLine($"Корень квадратный из произведения чисел: {Math.Sqrt(number1 * number2)}");
        }










    }
}
