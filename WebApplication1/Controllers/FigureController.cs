using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProject.Services;
using TestProject.Services.Execptions;

namespace TestProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FigureController : ControllerBase
    {
        readonly FigureService _figreService;

        public FigureController(FigureService figureService)
        {
            _figreService = figureService;
        }


        [HttpGet]
        [Route("test")]
        public ActionResult<string> Test()
        {
            return "ok";
        }

        /// <summary>
        /// вычислениие площади треугольника
        /// </summary>
        /// <param name="aLenght">Длина стороны a(мм)</param>
        /// <param name="bLength">Длина стороны b(мм)</param>
        /// <param name="cLength">Длина стороны c(мм)</param>
        /// <returns>площадь мм:2</returns>

        [HttpGet]
        [Route("calculate-triangle-square/{aLenght}/{bLength}/{cLength}")]
        public ActionResult<double> CalculateTriangleSquare(int aLenght, int bLength, int cLength)
        {
            try
            {
                var result = _figreService.CalculateTriangleSquare(aLenght, bLength, cLength);

                if(result < 0)
                {
                    return NotFound("Невозможно ввычеслить площадь по данным параметрам.");
                }

                return result;
            }
            catch (FigureNegativeParameterException)
            {
                //logging here
                return NotFound("Длины всех сторон должны быть положительными.");
            }
            catch (TRiangleDoesNotExistException)
            {
                return NotFound("Треугольник не существует.");
            }
            catch (Exception)
            {
                //logging here
                return NotFound("Невозможно ввычеслить площадь по данным параметрам.");
            }

        }

        /// <summary>
        /// проверяет является ли треугольник прямоугольным
        /// </summary>
        /// <param name="aLenght">Длина стороны a(мм)</param>
        /// <param name="bLength">Длина стороны b(мм)</param>
        /// <param name="cLength">Длина стороны c(мм)</param>
        /// <returns>true - треугольник являетсяпрямоугольным</returns>
        [HttpGet]
        [Route("check-triangle-is-right/{aLenght}/{bLength}/{cLength}")]
        public ActionResult<bool> CheckTriangleIsRight(int aLenght, int bLength, int cLength)
        {
            try
            {
                var result = _figreService.CheckifTiangleIsRight(aLenght, bLength, cLength);


                return result;
            }
            catch (FigureNegativeParameterException)
            {
                //logging here
                return NotFound("Длины всех сторон должны быть положительными.");
            }
            catch (TRiangleDoesNotExistException)
            {
                return NotFound("Треугольник не существует.");
            }
            catch (Exception)
            {
                //logging here
                return NotFound("Невозможно ввычеслить площадь по данным параметрам.");
            }

        }

        /// <summary>
        /// вычислениие площади круга
        /// </summary>
        /// <param name="radius"> радиус мм</param>
        /// <returns>площадь мм:2</returns>
        [HttpGet]
        [Route("calculate-circle-square/{radius}")]
        public ActionResult<double> CalculateCircleSquare(int radius)
        {
            try
            {
                var result = _figreService.CalculateCircleSquare(radius);

                if (result < 0)
                {
                    return NotFound("Невозможно ввычеслить площадь по данным параметрам.");
                }

                return result;
            }
            catch (FigureNegativeParameterException)
            {
                //logging here
                return NotFound("Радиус должен быть положительным.");
            }
            catch (Exception)
            {
                //logging here
                return NotFound("невозможно ввычеслить площадь по данным параметрам.");
            }

        }
    }
}