using AreaOfShapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfShapes.Shapes
{
    /// <summary>Вычисление площади фигуры без знания типа фигуры
    /// </summary>
    public class Shape: IShape
    {
        private Interfaces.IShape shape;
        public double Area => shape.Area;

        public Shape(Interfaces.IShape figure)
        {
            shape = figure;
        }
    }
}
