using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaOfShapes;
using AreaOfShapes.Shapes;

namespace AreaOfShapesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleAreaWIthoutValues()
        {
            //arrange
            AreaOfShapes.Shapes.Circle circle = new AreaOfShapes.Shapes.Circle();
            //act
            var area = circle.Area;
            //assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void CircleAreaWIthValues()
        {
            //arrange
            AreaOfShapes.Shapes.Circle circle = new AreaOfShapes.Shapes.Circle(6);
            var correctArea = Math.PI * Math.Pow(6, 2);
            //act
            var area = circle.Area;
            
            //assert
            Assert.AreEqual(correctArea, area);
        }

        [TestMethod]
        public void TriangleAreaWIthoutValues()
        {
            //arrange
            AreaOfShapes.Shapes.Triangle triangle = new AreaOfShapes.Shapes.Triangle();
            
            //act
            var area = triangle.Area;

            //assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void TriangleAreaWIthValues()
        {
            //arrange
            AreaOfShapes.Shapes.Triangle triangle = new AreaOfShapes.Shapes.Triangle(3,4,5);
           
            //act
            var area = triangle.Area;

            //assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void TriangleIsRight()
        {
            //arrange
            AreaOfShapes.Shapes.Triangle triangle = new AreaOfShapes.Shapes.Triangle(3, 4, 5);

            //act
            bool isRight = triangle.IsRightTriangle();

            //assert
            Assert.IsTrue(isRight);
        }

        [TestMethod]
        public void AreaOfShape()
        {
            //arrange
            AreaOfShapes.Shapes.Shape shape = new AreaOfShapes.Shapes.Shape(new Circle());

            //act
            var area = shape.Area;

            //assert
            Assert.AreEqual(0, area);
        }
    }
}
