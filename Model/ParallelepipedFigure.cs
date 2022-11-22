namespace Model
{
    /// <summary>
    /// Класс для описания трёхмерной геометрической
    /// фигуры (параллелепипеда).
    /// </summary>
    public class ParallelepipedFigure : BaseFigure
    {
        /// <summary>
        /// Константа с описанием минимальной стороны параллелепипеда.
        /// </summary>
        public const int minSide = 0;

        /// <summary>
        /// Константа с описанием максимальной стороны параллелепипеда.
        /// </summary>
        public const int maxSide = 180;

        /// <summary>
        /// Конструктор класса ParallelepipedFigure.
        /// </summary>
        /// <param name="sideA">Сторона А параллелепипеда.</param>
        /// <param name="sideB">Сторона B параллелепипеда.</param>
        /// <param name="sideC">Сторона C параллелепипеда.</param>
        public ParallelepipedFigure(double sideA,
            double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Поле с описанием стороны А параллелепипеда.
        /// </summary>
        private double _sideA;

        /// <summary>
        /// Свойство с описанием стороны А параллелепипеда.
        /// </summary>
        private protected double SideA
        {
            get => _sideA;
            set => _sideA = ValidateProperty("сторона А параллелепипеда",
                value, minSide, maxSide);
        }

        /// <summary>
        /// Поле с описанием стороны B параллелепипеда.
        /// </summary>
        private double _sideB;

        /// <summary>
        /// Свойство с описанием стороны B параллелепипеда.
        /// </summary>
        private protected double SideB
        {
            get => _sideB;
            set => _sideB = ValidateProperty("сторона B параллелепипеда",
                value, minSide, maxSide);
        }

        /// <summary>
        /// Поле с описанием стороны C параллелепипеда.
        /// </summary>
        private double _sideC;

        /// <summary>
        /// Свойство с описанием стороны C параллелепипеда.
        /// </summary>
        private protected double SideC
        {
            get => _sideC;
            set => _sideC = ValidateProperty("сторона C параллелепипеда",
                value, minSide, maxSide);
        }

        /// <summary>
        /// Переопределённое свойство для описания названия 
        /// трёхмерной геометрической фигуры (параллелепипед).
        /// </summary>
        public override string FigureName => "Параллелепипед";

        /// <summary>
        /// Переопределённое свойство для описания объёма 
        /// трёхмерной геометрической фигуры (параллелепипеда).
        /// </summary>
        public override double FigureVolume => SideA * SideB * SideC;
    }
}