using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Models;
using TestProject.Services;
using TestProject.Services.Execptions;

namespace TestProject.Tests
{
    [TestClass]
    public class RectangleRightTests
    {

        FigureService _figureService = new FigureService(new ValidatorStub());

        [TestMethod]
        public void Triangle_Not_Right()
        {  
            var result = _figureService.CheckifTiangleIsRight(1, 10, 2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Triangle_Is_Right()
        {
            var result = _figureService.CheckifTiangleIsRight(3, 4, 5);

            Assert.IsTrue(result);
        }
    }
}
