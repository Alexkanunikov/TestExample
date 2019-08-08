using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace TestProject.Models
{
    public  class Triangle : FigureBase
    {
        public override FigureType FigureType => FigureType.Triangle;

        /// <summary>
        /// длина стороны A (усл. ед.)
        /// </summary>
        public int ALength { get; set; }

        /// <summary>
        /// длина стороны B (усл. ед.)
        /// </summary>
        public int BLength { get; set; }

        /// <summary>
        /// длина стороны C (усл. ед.)
        /// </summary>
        public int CLength { get; set; }

        public Triangle(int aLength, int bLength, int cLength) : base()
        {
            ALength = aLength;
            BLength = bLength;
            CLength = cLength;
        }
    }
}
