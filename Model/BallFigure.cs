using System;

namespace Model
{
    /// <summary>
    /// Класс для описания трёхмерной геометрической фигуры (шара).
    /// </summary>
    public class BallFigure : BaseFigure
    {
        /// <summary>
        /// Константа с описанием минимального радиуса шара.
        /// </summary>
        public const int minRadius = 0;

        /// <summary>
        /// Константа с описанием максимального радиуса шара.
        /// </summary>
        public const int maxRadius = 130;

        /// <summary>
        /// Конструктор класса BallFigure.
        /// </summary>
        /// <param name="radius">Радиус шара.</param>
        public BallFigure(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Поле с описанием радиуса шара.
        /// </summary>
        private double _radius;

        /// <summary>
        /// Свойство с описанием радиуса шара.
        /// </summary>
        private protected double Radius
        {
            get => _radius;
            set => _radius = ValidateProperty("радиус шара", value,
                minRadius, maxRadius);
        }

        /// <summary>
        /// Переопределённое свойство для описания названия 
        /// трёхмерной геометрической фигуры (шара).
        /// </summary>
        public override string FigureName => "Шар";

        /// <summary>
        /// Переопределённое свойство для описания объёма 
        /// трёхмерной геометрической фигуры (шара).
        /// </summary>
        public override double FigureVolume => 4.0 / 3.0 *
            Math.PI * Math.Pow(Radius, 3);
    }
}