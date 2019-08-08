using System;
using TestProject.Models;
using TestProject.Services.Interfaces;

namespace TestProject.Services
{
    public class FigureService
    {
        readonly IFigureParametersValidator _figureParametersValidator;

        public FigureService(IFigureParametersValidator figureParametersValidator)
        {
            _figureParametersValidator = figureParametersValidator;
        }

        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <param name="aLength">длина сторооны a</param>
        /// <param name="bLenght">длина сторооны b</param>
        /// <param name="cLength">длина сторооны c</param>
        /// <returns>площадь троеугольника(усл. ед. ^2").</returns>
        public double CalculateTriangleSquare(int aLength, int bLenght, int cLength)
        {
            var triangle = new Triangle(aLength, bLenght, cLength);

            if (_figureParametersValidator.Validate(triangle)) {


                //p = (aLength + bLenght + cLength) / 2; - полупериметр
                double p = (aLength + bLenght + cLength) /(double) 2;

                //S=sqrt{p*(p-a)*(p-b)*(p-c)}
                return Math.Round(Math.Sqrt(p * (p - aLength) * (p - bLenght) * (p - cLength)), 2);
            }

            return -1;
        }

        /// <summary>
        /// Расчет площади круга
        /// </summary>
        /// <param name="radius">радиус окружности</param>
        /// <returns> площадь круга(усл. ед. ^2")</returns>
        public double CalculateCircleSquare(int radius)
        {
            var circle = new Circle(radius);

            if (_figureParametersValidator.Validate(circle))
            {
                return Math.Round(Math.PI* circle.Radius*circle.Radius,2);
            }

            return -1;
        }

        /// <summary>
        ///Проверяет является ли треугольрник прямоугольным
        /// </summary>
        /// <param name="aLength">длина сторооны a</param>
        /// <param name="bLenght">длина сторооны b</param>
        /// <param name="cLength">длина сторооны c</param>
        /// <returns>true-  треуугольник прямоугольный</returns>
        public bool CheckifTiangleIsRight(int aLength, int bLenght, int cLength)
        {
            var triangle = new Triangle(aLength, bLenght, cLength);

            if (_figureParametersValidator.Validate(triangle))
            {
                if (aLength > bLenght && aLength > cLength) return cLength * cLength + bLenght * bLenght == aLength * aLength;

                if (bLenght > aLength && bLenght > cLength) return cLength * cLength + aLength * aLength == bLenght * bLenght;

                if (cLength > aLength && cLength > aLength) return bLenght * bLenght + aLength * aLength == cLength * cLength;
            }

            return false;
        }

    }
}
