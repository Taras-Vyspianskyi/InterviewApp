﻿using InterviewApp.Common.UnitOfWork;
using InterviewApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InterviewApp.DataAccess.Module
{
    public static class DataAccessModule
    {
        public static IServiceCollection LoadDataAccessModule(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();

            return services;
        }
    }
}
