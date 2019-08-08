using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Models;
using TestProject.Services;
using TestProject.Services.Execptions;

namespace TestProject.Tests
{
    [TestClass]
    public class SquareCalculationTests
    {

        FigureService _figureService = new FigureService(new ValidatorStub());

        [TestMethod]
        public void Triangle_ZeroParameters_zero_Square()
        {
            var result = _figureService.CalculateTriangleSquare(0, 0, 0);

            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void Triangle_PositiveParameters_GreatherZero_Result()
        {
            var result = _figureService.CalculateTriangleSquare(10, 10, 10);

            Assert.IsTrue(result > 0.0);
        }

        [TestMethod]
        public void Triangle_PositiveParameters__Result()
        {
            var result = _figureService.CalculateTriangleSquare(10, 10, 10);

            Assert.AreEqual(43.3, result);
        }

        [TestMethod]
        public void Circle_ZeroParameters_zero_Square()
        {
            var result = _figureService.CalculateCircleSquare(0);

            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void Circle_Square_Equals()
        {
            var result = _figureService.CalculateCircleSquare(10);

            Assert.IsTrue(result > 0.0);
            Assert.AreEqual(314.16, result);
        }
    }
}

