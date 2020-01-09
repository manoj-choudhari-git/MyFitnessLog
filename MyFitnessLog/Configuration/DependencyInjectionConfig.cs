using Microsoft.Extensions.DependencyInjection;
using MyFitnessLog.Business;
using MyFitnessLog.Business.Contracts;
using MyFitnessLog.Data;
using MyFitnessLog.Data.Contracts;

namespace MyFitnessLog.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IWorkoutBusiness, WorkoutBusiness>();
            services.AddScoped<IWorkoutRepository, WorkoutRepository>();
        }
    }
}
