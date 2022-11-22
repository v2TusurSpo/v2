using System;

using Model;

namespace View
{
    [Serializable]
    /// <summary>
    /// Класс с информацией о базовой фигуре.
    /// </summary>
    public class FigureBase
    {
        /// <summary>
        /// Свойство с названием фигуры.
        /// </summary>
        public string FigureName { get; set; }

        /// <summary>
        /// Свойство с описанием объёма фигуры.
        /// </summary>
        public double? FigureVolume { get; set; }
    }
}