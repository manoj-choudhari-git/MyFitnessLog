using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFitnessLog.Data.Contracts;
using MyFitnessLog.Data.Models;
using MyFitnessLog.Data.Models.Entities;

namespace MyFitnessLog.Data
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private readonly MyFitnessLogContext _context;

        public WorkoutRepository(MyFitnessLogContext context)
        {
            _context = context;
        }

        public async Task<IList<WorkoutData>> GetWorkoutRecordsAsync()
        {
            IList<WorkoutData> dataCollection = new List<WorkoutData>();
            var workoutLogCollection = await _context.Workouts.AsNoTracking().ToListAsync();

            foreach (var log in workoutLogCollection)
            {
                var data = new WorkoutData()
                {
                    Id = log.Id,
                    ActivityName = log.ActivityName,
                    Repeatations = log.Repeatations,
                    SetNumber = log.SetNumber,
                    CreatedOn = log.CreatedOn
                };

                dataCollection.Add(data);
            }

            return dataCollection;
        }

        public async Task SaveWorkoutRecordsAsync(IList<WorkoutData> dataCollection)
        {
            IList<WorkoutLog> workoutLogCollection = new List<WorkoutLog>();
            foreach (var data in dataCollection)
            {
                var workoutLog = new WorkoutLog()
                {
                    ActivityName = data.ActivityName,
                    CreatedOn = data.CreatedOn,
                    Repeatations = data.Repeatations,
                    SetNumber = data.SetNumber
                };

                workoutLogCollection.Add(workoutLog);
            }

            await _context.Workouts.AddRangeAsync(workoutLogCollection);
            await _context.SaveChangesAsync();
        }
    }
}
