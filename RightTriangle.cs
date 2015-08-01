using System;

namespace RightTriangle
{
    public static class RightTriangle
    {
        private const double UnimportantDifference = 0.0001;

        /// <summary>
        /// Вычисляет площадь прямоугольного треугольника
        /// </summary>
        /// <param name="сathetus1">Длина первого катета</param>
        /// <param name="сathetus2">Длина второго катета</param>
        /// <param name="hypotenuse">Длина гипотенузы</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Выбрасывается, когда один или несколько аргументов неположительные</exception>
        /// <exception cref="System.Exception">Выбрасывается, когда треугольник не является прямоугольным</exception>
        /// <returns>Площадь прямоугольного треугольника</returns>
        public static double Area(double сathetus1, double сathetus2, double hypotenuse)
        {
            if (сathetus1 <= 0)
            {
                throw new ArgumentOutOfRangeException("сathetus1", "Длина первого катета не может быть отрицательной или равной нулю.");
            }

            if (сathetus2 <= 0)
            {
                throw new ArgumentOutOfRangeException("сathetus2", "Длина второго катета не может быть отрицательной или равной нулю.");
            }

            if (hypotenuse <= 0)
            {
                throw new ArgumentOutOfRangeException("hypotenuse", "Длина гипотенузы не может быть отрицательной или равной нулю.");
            }

            if (Math.Abs(hypotenuse * hypotenuse - (сathetus1 * сathetus1 + сathetus2 * сathetus2)) > UnimportantDifference)
            {
                throw new Exception("Треугольник не является прямоугольным.");
            }

            return сathetus1 * сathetus2 / 2;
        }

    }
}
