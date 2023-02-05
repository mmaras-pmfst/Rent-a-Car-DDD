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
using MediatR;
using RentaCar.Application.Commons.Interfaces.Authentication;
using RentaCar.Application.Commons.Interfaces.Persistence;
using RentaCar.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneOf;
using FluentResults;
using ErrorOr;
using RentaCar.Domain.Common.Errors;
using RentaCar.Application.Authentication.Common;

namespace RentaCar.Application.Authentication.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            //1. Validate the user doesn't exist
            if (_userRepository.GetUserByEmail(command.Email) != null)
            {
                return Errors.User.DuplicateEmail;
            }

            //2. Create user(generate unique ID) and Persist to DB
            var user = new User
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                Password = command.Password
            };

            _userRepository.AddUser(user);

            //3. Create JWT token
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
    }
}
