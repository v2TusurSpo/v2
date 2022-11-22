using System;

using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    /// Тестовый набор для класса BallFigure.
    /// </summary>
    [TestFixture]
    public class BallFigureTest
    {
        /// <summary>
        /// Тестирование свойства FigureName.
        /// </summary>
        [Test(Description = "Тестирование свойства FigureName")]
        [TestCase(TestName = "Тестирование свойства FigureName")]
        public void TestFigureName()
        {
            Assert.AreEqual("Шар",
                new BallFigure(1).FigureName);
            Assert.AreEqual("Шар",
                new BallFigure(120).FigureName);
            Assert.AreEqual("Шар",
                new BallFigure(100).FigureName);

            Assert.AreNotEqual("Куб",
                new BallFigure(50).FigureName);
            Assert.AreNotEqual("Круг",
                new BallFigure(101).FigureName);
        }

        /// <summary>
        /// Тестирование свойства FigureVolume
        /// (положительное тестирование).
        /// </summary>
        /// <param name="radius">Радиус шара.</param>
        [Test]
        [TestCase(BallFigure.minRadius + 0.001,
            TestName = "Tест объёма шара" +
            " при минимальном радиусе.")]

        [TestCase(BallFigure.minRadius + 1,
            TestName = "Tест объёма шара" +
            " при минимальном радиусе + 1.")]

        [TestCase(50,
            TestName = "Tест объёма шара" +
            " при радиусе равном 50.")]

        [TestCase(BallFigure.maxRadius - 0.001,
            TestName = "Tест объёма шара" +
            " при максимальных параметрах.")]

        [TestCase(BallFigure.maxRadius - 1,
            TestName = "Tест объёма шара" +
            " при максимальных параметрах - 1.")]

        public void TestPosetivFigureVolume(double radius)
        {
            BallFigure figure =
                new BallFigure(radius);

            Assert.True(figure.FigureVolume == 4.0 / 3.0 
                * Math.PI * Math.Pow(radius, 3));
        }

        /// <summary>
        /// Тестирование свойства FigureVolume
        ///(негативное тестирование).
        /// </summary>
        /// <param name="radius">Радиус шара.</param>
        [Test]
        [TestCase(BallFigure.maxRadius,
            TestName = "Tест объёма шара" +
            " при завышенном радиусе.")]

        [TestCase(BallFigure.minRadius-1,
            TestName = "Tест объёма шара" +
            " при заниженном радиусе.")]

        public void TestNegotiveFigureVolume(double radius)
        {
            Assert.Throws<Exception>(delegate ()
            {
                BallFigure figure = new
                BallFigure(radius);
            });
        }
    }
}