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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Contracts.Authentication
{
    public record LoginRequest(
        string Email,
        string Password);

    //public class LoginRequest
    //{
    //    public string Email { get; set; }
    //    public string Password { get; set; }
    //}
}
