using System;
using System.Globalization;
using System.Threading;

using Model;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс для демонстрации работы проекта Model.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод - точка входа в программу.
        /// </summary>
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");

            CalcBall();
            CalcPyramid();
            CalcParallelepiped();

            Console.ReadKey();
        }

        /// <summary>
        /// Метод вычисления объема шара.
        /// </summary>
        private static void CalcBall()
        {
            string atrRadius = "радиус шара";
            RequestParametr(atrRadius, BallFigure.minRadius,
                BallFigure.maxRadius);
            double radius = CheckParamert(atrRadius,
                BallFigure.minRadius, BallFigure.maxRadius);
            BaseFigure ball = new BallFigure(radius);
            PrintInformation(ball);
        }

        /// <summary>
        /// Метод вычисления объема пирамиды.
        /// </summary>
        private static void CalcPyramid()
        {
            string atrBaseArea = "площадь основания пирамиды";
            RequestParametr(atrBaseArea, PyramidFigure.minBaseArea,
                PyramidFigure.maxBaseArea);
            double baseArea = CheckParamert(atrBaseArea,
                PyramidFigure.minBaseArea, PyramidFigure.maxBaseArea);

            string atrHeigth = "высота пирамиды";
            RequestParametr(atrHeigth, PyramidFigure.minHeigth,
                PyramidFigure.maxHeigth);
            double height = CheckParamert(atrHeigth,
                PyramidFigure.minHeigth, PyramidFigure.maxHeigth);

            BaseFigure pyramid = new PyramidFigure(baseArea, height);
            PrintInformation(pyramid);
        }

        /// <summary>
        /// Метод вычисления объема параллелепипеда.
        /// </summary>
        private static void CalcParallelepiped()
        {
            string atrSideA = "сторона А параллелепипеда";
            RequestParametr(atrSideA, ParallelepipedFigure.minSide,
                ParallelepipedFigure.maxSide);
            double sideA = CheckParamert(atrSideA,
                ParallelepipedFigure.minSide, ParallelepipedFigure.maxSide);

            string atrSideB = "сторона B параллелепипеда";
            RequestParametr(atrSideB,
                ParallelepipedFigure.minSide, ParallelepipedFigure.maxSide);
            double sideB = CheckParamert(atrSideB,
                ParallelepipedFigure.minSide, ParallelepipedFigure.maxSide);

            string atrSideC = "сторона C параллелепипеда";
            RequestParametr(atrSideC, ParallelepipedFigure.minSide,
                ParallelepipedFigure.maxSide);
            double sideC = CheckParamert(atrSideC,
                ParallelepipedFigure.minSide, ParallelepipedFigure.maxSide);

            BaseFigure parallelepiped =
                new ParallelepipedFigure(sideA, sideB, sideC);
            PrintInformation(parallelepiped);
        }

        /// <summary>
        /// Метод запроса на ввода параметров.
        /// </summary>
        /// <param name="name">Название параметра.</param>
        /// <param name="minValue">Минимальное значение.</param>
        /// <param name="maxValue">Максимальное значение.</param>
        private static void RequestParametr(string name,
            int minValue, int maxValue)
        {
            Console.WriteLine($"Введите значение {name}." +
                $" Значение {name} должно быть больше" +
                $" {minValue} и меньше {maxValue}:");
        }

        /// <summary>
        /// Метод валидации параметра.
        /// </summary>
        /// <param name="name">Название параметра.</param>
        /// <param name="minValue">Минимальное значение параметра.</param>
        /// <param name="maxValue">Максимальное значение параметра.</param>
        /// <returns>Результат валицации.</returns>
        private static double CheckParamert(string name,
            int minValue, int maxValue)
        {
            double startValue = 0;
            do
            {
                try
                {
                    string atrValue = Console.ReadLine().Replace(".", ",");
                    if (atrValue.Contains(" "))
                    {
                        throw new Exception("Введено неверное " +
                            "значение. Значение должно содержать только " +
                            "цифры и один разделитель.");
                    }
                    startValue = Convert.ToDouble(atrValue);
                    BaseFigure.ValidateProperty(name, startValue,
                        minValue, maxValue);
                    Console.WriteLine($"Введено значение: {startValue}.");
                    break;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    RequestParametr(name, minValue, maxValue);
                }
            } while (true);
            return startValue;
        }

        /// <summary>
        /// Метод вывода информации.
        /// </summary>
        /// <param name="baseFigure">Объект класса BaseFigure.</param>
        private static void PrintInformation(BaseFigure baseFigure)
        {
            Console.WriteLine($"Название фигуры: {baseFigure.FigureName}");
            Console.WriteLine($"Объём фигуры: {baseFigure.FigureVolume}");
        }
    }
}