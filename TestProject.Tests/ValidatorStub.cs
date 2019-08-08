using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Models;
using TestProject.Services;
using TestProject.Services.Execptions;
using TestProject.Services.Interfaces;

namespace TestProject.Tests
{

    public class ValidatorStub : IFigureParametersValidator
    {
        public bool Validate(FigureBase figure)
        {
            return true;
        }
    }
}
