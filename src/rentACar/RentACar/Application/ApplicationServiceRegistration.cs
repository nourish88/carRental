

using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(conf => { conf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()); });

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;

    }
}