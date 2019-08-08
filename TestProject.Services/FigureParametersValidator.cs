using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using TestProject.Models;
using TestProject.Services.Execptions;
using TestProject.Services.Interfaces;

namespace TestProject.Services
{
    public partial class FigureParametersValidator: IFigureParametersValidator
    {
        public bool Validate(FigureBase figure)
        {
            switch (figure.FigureType)
            {
                case FigureType.Circle:
                    if (!(figure is Circle)) throw new FigureNegativeParameterException();

                    return ValidateCicleParameters(figure as Circle);

                case FigureType.Triangle:
                    if (!(figure is Triangle)) throw new FigureNegativeParameterException();

                    return ValidateTriangleParameters(figure as Triangle);

                default:
                    throw new FigureNegativeParameterException();

            }
        }

        private bool ValidateTriangleParameters(Triangle triangle) {
            if (triangle.ALength < 0 || triangle.BLength < 0 || triangle.CLength < 0) throw new FigureNegativeParameterException();

            return true;
        }

        private bool ValidateCicleParameters(Circle circle) {

            if(circle.Radius < 0)  throw new FigureNegativeParameterException();

            return true;
        }

    }
}
