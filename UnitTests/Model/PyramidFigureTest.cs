using System;

using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    /// Тестовый набор для класса PyramidFigure.
    /// </summary>
    [TestFixture]
    public class PyramidFigureTest
    {
        /// <summary>
        /// Тестирование свойства FigureName.
        /// </summary>
        [Test(Description = "Тестирование свойства FigureName")]
        [TestCase(TestName = "Тестирование свойства FigureName")]
        public void TestFigureName()
        {
            Assert.AreEqual("Пирамида",
                new PyramidFigure(10, 20).FigureName);
            Assert.AreEqual("Пирамида",
                new PyramidFigure(120, 120).FigureName);
            Assert.AreEqual("Пирамида",
                new PyramidFigure(100, 120).FigureName);

            Assert.AreNotEqual("Куб",
                new PyramidFigure(50, 30).FigureName);
            Assert.AreNotEqual("Круг",
                new PyramidFigure(101, 77).FigureName);
        }


        /// <summary>
        /// Тестирование свойства FigureVolume
        /// (положительное тестирование).
        /// </summary>
        /// <param name="baseArea">Площадь основания
        /// пирамиды.</param>
        /// <param name="heigth">Высота пирамиды.</param>
        [Test]
        [TestCase(PyramidFigure.minBaseArea + 0.001,
            PyramidFigure.minHeigth + 0.001,
            TestName = "Tест объёма пирамиды" +
            " при минимальных параметрах.")]

        [TestCase(PyramidFigure.minBaseArea + 1,
            PyramidFigure.minHeigth + 1,
            TestName = "Tест объёма пирамиды" +
            " при минимальных параметрах + 1.")]

        [TestCase(100, 110,
            TestName = "Tест объёма пирамиды" +
            " при площади основания равной 100" +
            "и высоте пирамиды равной 110.")]

        [TestCase(PyramidFigure.maxBaseArea - 0.001,
            PyramidFigure.maxHeigth - 0.001,
            TestName = "Tест объёма пирамиды" +
            " при максимальных параметрах.")]

        [TestCase(PyramidFigure.maxBaseArea - 1,
            PyramidFigure.maxHeigth - 1,
            TestName = "Tест объёма пирамиды" +
            " при максимальных параметрах - 1.")]

        public void TestPosetivFigureVolume(double baseArea,
            double heigth)
        {
            PyramidFigure figure =
                new PyramidFigure(baseArea, heigth);

            Assert.True(figure.FigureVolume == 1.0 / 3.0 *
            baseArea * heigth);
        }

        /// <summary>
        /// Тестирование свойства FigureVolume
        ///(негативное тестирование).
        /// </summary>
        /// <param name="baseArea">Площадь основания
        /// пирамиды.</param>
        /// <param name="heigth">Высота пирамиды.</param>
        [Test]
        [TestCase(PyramidFigure.maxBaseArea,
            PyramidFigure.maxHeigth,
            TestName = "Tест объёма пирамиды" +
            " при завышенных значениях.")]

        [TestCase(PyramidFigure.minBaseArea,
            PyramidFigure.minHeigth,
            TestName = "Tест объёма пирамиды" +
            " при заниженных значениях.")]

        public void TestNegotiveFigureVolume(double baseArea,
            double heigth)
        {
            Assert.Throws<Exception>(delegate ()
            {
                PyramidFigure figure = new
                PyramidFigure(baseArea, heigth);
            });
        }
    }
}