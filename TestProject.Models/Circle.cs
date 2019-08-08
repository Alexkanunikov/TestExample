using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace TestProject.Models
{
    public class Circle : FigureBase
    {
        public override FigureType FigureType => FigureType.Circle;

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public int Radius { get; set; }

        public Circle(int radius):base()
        {
            Radius = radius;
        }
    }
}
