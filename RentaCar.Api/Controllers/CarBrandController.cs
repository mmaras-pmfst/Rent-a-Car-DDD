using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Contracts.CarBrands;

namespace RentaCar.Api.Controllers
{
    [Route("api/carbrands")]
    [AllowAnonymous]

    public class CarBrandController : ApiController
    {
        [HttpPost]
        public IActionResult CreateCarBrand(CreateCarBrandRequest request)
        {
            return Ok(request);
        }
    }
}
