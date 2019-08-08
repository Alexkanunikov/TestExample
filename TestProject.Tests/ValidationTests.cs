using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Models;
using TestProject.Services;
using TestProject.Services.Execptions;

namespace TestProject.Tests
{
    [TestClass]
    public class ValidationTests
    {
        FigureParametersValidator _validator = new FigureParametersValidator();

        [TestMethod]
        [ExpectedException(typeof(FigureNegativeParameterException))]
        public void Triangle_Nigative_Parameter_Exception()
        {
            Triangle triangle = new Triangle(-1, 10, 2);

            _validator.Validate(triangle);
        }

        [TestMethod]
        [ExpectedException(typeof(FigureNegativeParameterException))]
        public void Triangle_Nigative_All_Parameter_Exception()
        {
            Triangle triangle = new Triangle(-1, -10, -2);

            _validator.Validate(triangle);
        }

        [TestMethod]
        public void Triangle_Zero_All_Parameter_Valid()
        {
            Triangle triangle = new Triangle(0, 0, 0);

           var result=  _validator.Validate(triangle);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Triangle_Positive_Parameters_Valid()
        {
            Triangle triangle = new Triangle(10, 10, 0);

            var result = _validator.Validate(triangle);

            Assert.IsTrue(result);
        }


        [TestMethod]
        [ExpectedException(typeof(FigureNegativeParameterException))]
        public void Circle_Nigative_Parameter_Exception()
        {
            Circle circle = new Circle(-1);

            _validator.Validate(circle);
        }

        [TestMethod]
        public void Circle_Zero_Parameter_Valid()
        {
            Circle circle = new Circle(0);

            var result = _validator.Validate(circle);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Circle_Positive_Parameter_Valid()
        {
            Circle circle = new Circle(10);

            var result = _validator.Validate(circle);

            Assert.IsTrue(result);
        }
    }
}
