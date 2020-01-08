using MyFitnessLog.Data.Contracts;
using System;
using System.Collections.Generic;

namespace MyFitnessLog.Data
{
    public class WorkoutRepository : IWorkoutRepository
    {
        public IList<WorkoutData> GetWorkoutRecords()
        {
            throw new NotImplementedException();
        }

        public void SaveWorkoutRecords(IList<WorkoutData> dataCollection)
        {
            throw new NotImplementedException();
        }
    }
}
