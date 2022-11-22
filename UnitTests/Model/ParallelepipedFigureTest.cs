using System;

using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    /// Тестовый набор для класса ParallelepipedFigure.
    /// </summary>
    [TestFixture]
    public class ParallelepipedFigureTest
    {
        // <summary>
        /// Тестирование свойства FigureName.
        /// </summary>
        [Test(Description = "Тестирование свойства FigureName")]
        [TestCase(TestName = "Тестирование свойства FigureName")]
        public void TestFigureName()
        {
            Assert.AreEqual("Параллелепипед",
                new ParallelepipedFigure(10, 20, 30).FigureName);
            Assert.AreEqual("Параллелепипед",
                new ParallelepipedFigure(40, 50, 60).FigureName);
            Assert.AreEqual("Параллелепипед",
                new ParallelepipedFigure(70, 80, 90).FigureName);

            Assert.AreNotEqual("Куб",
                new ParallelepipedFigure(30, 30, 30).FigureName);
            Assert.AreNotEqual("Шар",
                new ParallelepipedFigure(50, 50, 50).FigureName);
        }

        /// <summary>
        /// Тестирование свойства FigureVolume
        /// (положительное тестирование).
        /// </summary>
        /// <param name="sideA">Сторона А параллелепипеда.</param>
        /// <param name="sideB">Сторона B параллелепипеда.</param>
        /// <param name="sideC">Сторона C параллелепипеда.</param>
        [Test]
        [TestCase(ParallelepipedFigure.minSide + 0.001,
            ParallelepipedFigure.minSide + 0.001,
            ParallelepipedFigure.minSide + 0.001,
            TestName = "Tест объёма параллелепипеда" +
            " при минимальных размерах сторон.")]

        [TestCase(ParallelepipedFigure.minSide + 1,
            ParallelepipedFigure.minSide + 1,
            ParallelepipedFigure.minSide + 1,
            TestName = "Tест объёма параллелепипеда" +
            " при минимальных размерах сторон + .")]

        [TestCase(50, 50, 50,
            TestName = "Tест объёма параллелепипеда" +
            " если все стороны равны 50.")]

        [TestCase(ParallelepipedFigure.maxSide - 0.001,
            ParallelepipedFigure.maxSide - 0.001,
            ParallelepipedFigure.maxSide - 0.001,
            TestName = "Tест объёма параллелепипеда" +
            " при максимальных параметрах.")]

        [TestCase(ParallelepipedFigure.maxSide - 1,
            ParallelepipedFigure.maxSide - 1,
            ParallelepipedFigure.maxSide - 1,
            TestName = "Tест объёма параллелепипеда" +
            " при максимальных параметрах - 1.")]

        public void TestPosetivFigureVolume(double sideA,
            double sideB, double sideC)
        {
            ParallelepipedFigure figure =
                new ParallelepipedFigure(sideA, sideB, sideC);

            Assert.True(figure.FigureVolume == sideA * 
                sideB * sideC);
        }

        /// <summary>
        /// Тестирование свойства FigureVolume
        /// (негативное тестирование).
        /// </summary>
        /// <param name="sideA">Сторона А параллелепипеда.</param>
        /// <param name="sideB">Сторона B параллелепипеда.</param>
        /// <param name="sideC">Сторона C параллелепипеда.</param>
        [Test]
        [TestCase(ParallelepipedFigure.maxSide,
            ParallelepipedFigure.maxSide,
            ParallelepipedFigure.maxSide,
            TestName = "Tест объёма параллелепипеда" +
            " при завышенных сторонах.")]

        [TestCase(ParallelepipedFigure.minSide,
            ParallelepipedFigure.minSide,
            ParallelepipedFigure.minSide,
            TestName = "Tест объёма параллелепипеда" +
            " при заниженных сторонах.")]

        public void TestNegotiveFigureVolume(double sideA,
            double sideB, double sideC)
        {
            Assert.Throws<Exception>(delegate ()
            {
                ParallelepipedFigure figure = new
                ParallelepipedFigure(sideA, sideB, sideC);
            });
        }
    }
}