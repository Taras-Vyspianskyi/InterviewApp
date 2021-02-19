using InterviewApp.Common.Service;
using InterviewApp.Services.Service;
using Microsoft.Extensions.DependencyInjection;

namespace InterviewApp.Services.Module
{
    public static class ServicesModule
    {
        public static IServiceCollection LoadServiceModule(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGroupService, GroupService>();

            return services;
        }
    }
}
