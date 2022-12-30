/**********************
**
** Copyright © Softly d.o.o. 2022
** All rights reserved.
** Author : Marko Mihael Maras
** E-mail : mmaras@softlyst.eu
** Title  : Api sports worker service.
**********************/
/**********************
**
** URL https://api.statscore.com/v2/seasons
** Method: GET
** Description: 
** Cache: 60 seconds
** Authorization: required Yes
**********************/
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentaCar.Api.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class RentsController : ApiController
    {
        [HttpGet]
        public IActionResult ListRents()
        {
            return Ok(Array.Empty<string>());
        }
    }
}
