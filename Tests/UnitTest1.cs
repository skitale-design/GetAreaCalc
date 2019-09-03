using NUnit.Framework;
using System;

namespace CircleAreaStandardDotNet
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void circleWithRadius10_returns_314159()
        {
            Figure circle = new Figure(new double[] { 10 });

            Assert.AreEqual(314.159 , Math.Round(circle.GetArea(),3));
        }

        [Test]
        public void triangle_3_4_5_isRightAngled()
        {
            Figure triangle = new Figure(new double[] { 3, 4, 5 });

            Assert.AreEqual(true, triangle.IsRightAngledTriangle());
        }

        [Test]
        public void GetPerimeterOfTriangle_3_4_5_returns_6()
        {
            Figure figure = new Figure(new double[] { 1, 2, 3 });

            Assert.AreEqual(6, figure.GetPerimeter());
        }        

        [Test]
        public void Triangle_1_2_4_isNotValid()
        {
            Figure figure = new Figure(new double[] { 1, 2, 4 });

            Assert.AreEqual(false, figure.IsValidTriangle());
        }
        
    }
}