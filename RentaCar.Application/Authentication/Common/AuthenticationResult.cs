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
using RentaCar.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Application.Authentication.Common
{
    public class AuthenticationResult
    {
        public User User { get; set; }
        public string Token { get; set; }
        public AuthenticationResult(User user, string token)
        {
            User = user;
            Token = token;
        }


        //public AuthenticationResult(Guid id, string firstName, string lastName, string email, string password, string token)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Email = email;
        //    Password = password;
        //    Token = token;
        //}
    }
}
