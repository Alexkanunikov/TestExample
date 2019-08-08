using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using TestProject.Models;

namespace TestProject.Services.Interfaces
{
    public  interface IFigureParametersValidator {
        bool Validate(FigureBase figure);
    }
}
