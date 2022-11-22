using System;

namespace Model
{
    /// <summary>
    /// Абстрактный класс для описания трёхмерной геометрической фигуры.
    /// </summary>
    public abstract class BaseFigure
    {
        /// <summary>
        /// Абстрактное свойство описывающее название фигуры.
        /// </summary>
        public abstract string FigureName { get; }

        /// <summary>
        /// Абстрактное свойство описывающее объёма фигуры.
        /// </summary>
        public abstract double FigureVolume { get; }

        /// <summary>
        /// Метод проверки введенного свойства.
        /// </summary>
        /// <param name="propertyName">Название свойства.</param>
        /// <param name="propertyValue">Значение свойства.</param>
        /// <param name="minValue">Минимальное значение свойства.</param>
        /// <param name="maxValue">Максимальное значение свойства.</param>
        /// <returns>Результат проверки.</returns>
        public static double ValidateProperty(string propertyName,
            double propertyValue, double minValue, double maxValue)
        {
            if ((propertyValue > minValue)
                && (propertyValue < maxValue))
            {
                return propertyValue;
            }
            else
            {
                throw new Exception($"Значение свойства {propertyName}" +
                    $" должно быть больше {minValue} и меньше {maxValue}.");
            }
        }
    }
}