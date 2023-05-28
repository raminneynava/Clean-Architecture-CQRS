using Application.Services;

using Infrastructure.EF;
using Infrastructure.Logging;
using Infrastructure.Services;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Shared.Abstractions.Commands;
using Shared.Queries;

namespace Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSQLDB(configuration);
            services.AddQueries();
            services.AddSingleton<IWeatherService, DumbWeatherService>();

            services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

            return services;
        }
    }
}
