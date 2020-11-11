using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TheTest.Server.Data;

namespace TheTest.Server.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {

        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();
            var dbContext = services.ServiceProvider.GetService<TheTestDbContext>();

            dbContext.Database.Migrate();
        }
    }
}
