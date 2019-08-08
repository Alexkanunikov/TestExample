using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace TestProject.Services.Execptions
{
    public partial class FigureNegativeParameterException : ApplicationException
    {
        public FigureNegativeParameterException(string message) : base(message)
        {

        }

        public FigureNegativeParameterException() : base()
        {

        }
    }
}
