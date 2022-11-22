namespace Model
{
    /// <summary>
    /// Класс для описания трёхмерной геометрической фигуры (пирамиды).
    /// </summary>
    public class PyramidFigure : BaseFigure
    {
        /// <summary>
        /// Константа с описанием минимальной 
        /// площади основания пирамиды.
        /// </summary>
        public const int minBaseArea = 0;

        /// <summary>
        /// Константа с описанием максимальной 
        /// площади основания пирамиды.
        /// </summary>
        public const int maxBaseArea = 200;

        /// <summary>
        /// Константа с описанием минимальной 
        /// высоты пирамиды.
        /// </summary>
        public const int minHeigth = 0;

        /// <summary>
        /// Константа с описанием максимальной
        /// высоты пирамиды.
        /// </summary>
        public const int maxHeigth = 210;

        /// <summary>
        /// Конструктор класса PyramidFigure.
        /// </summary>
        /// <param name="baseArea">Площадь основания
        /// пирамиды.</param>
        /// <param name="heigth">Высота пирамиды.</param>
        public PyramidFigure(double baseArea, double heigth)
        {
            BaseArea = baseArea;
            Heigth = heigth;
        }

        /// <summary>
        /// Поле с описанием значения площади основания пирамиды.
        /// </summary>
        private double _baseArea;

        /// <summary>
        /// Свойство с описанием значения площади основания пирамиды.
        /// </summary>
        private protected double BaseArea
        {
            get => _baseArea;
            set => _baseArea = ValidateProperty("площадь основания" +
                " пирамиды", value, minBaseArea, maxBaseArea);
        }

        /// <summary>
        /// Поле с описанием значения высоты пирамиды.
        /// </summary>
        private double _heigth;

        /// <summary>
        /// Свойство с описанием значения высоты пирамиды.
        /// </summary>
        private protected double Heigth
        {
            get => _heigth;
            set => _heigth = ValidateProperty("высота пирамиды",
                value, minHeigth, maxHeigth);
        }

        /// <summary>
        /// Переопределённое свойство для описания названия 
        /// трёхмерной геометрической фигуры (пирамида).
        /// </summary>
        public override string FigureName => "Пирамида";

        /// <summary>
        /// Переопределённое свойство для описания объёма 
        /// трёхмерной геометрической фигуры (пирамиды).
        /// </summary>
        public override double FigureVolume => 1.0 / 3.0 *
            BaseArea * Heigth;
    }
}