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
using RentaCar.Application.Commons.Interfaces.Persistence;
using RentaCar.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new List<User>();
        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }
    }
}
