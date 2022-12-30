using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RentaCar.Application.Authentication.Commands.Register;
using RentaCar.Application.Authentication.Common;
using ErrorOr;
using RentaCar.Application.Commons.Behaviors;
using FluentValidation;
using System.Reflection;

namespace RentaCar.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        //services.AddScoped<IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>, ValidationBehavior>();
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;

    }
}