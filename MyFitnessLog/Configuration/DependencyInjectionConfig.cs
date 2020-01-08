using Microsoft.Extensions.DependencyInjection;
using MyFitnessLog.Business;
using MyFitnessLog.Business.Contracts;
using MyFitnessLog.Data;
using MyFitnessLog.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
