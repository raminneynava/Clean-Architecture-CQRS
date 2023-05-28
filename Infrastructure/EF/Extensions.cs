using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.Services;
using Domain.Repositories;
using Infrastructure.EF.Contexts;
using Infrastructure.EF.Options;
using Infrastructure.EF.Repositories;
using Infrastructure.EF.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Shared.Options;

namespace Infrastructure.EF
{
    internal static class Extensions
    {
        public static IServiceCollection AddSQLDB(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITravelerCheckListRepository, TravelerCheckListRepository>();
            services.AddScoped<ITravelerCheckListReadService, TravelerCheckListReadService>();

            var options = configuration.GetOptions<DataBaseOptions>("DataBaseConnectionString");
            services.AddDbContext<ReadDbContext>(ctx =>
            ctx.UseSqlServer(options.ConnectionString));
            services.AddDbContext<WriteDbContext>(ctx =>
                ctx.UseSqlServer(options.ConnectionString));

            return services;
        }
    }
}
