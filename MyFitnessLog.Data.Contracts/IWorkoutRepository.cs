using System;
using System.Collections.Generic;

namespace MyFitnessLog.Data.Contracts
{
    public interface IWorkoutRepository
    {
        IList<WorkoutData> GetWorkoutRecords();

        void SaveWorkoutRecords(IList<WorkoutData> dataCollection);
    }
}
