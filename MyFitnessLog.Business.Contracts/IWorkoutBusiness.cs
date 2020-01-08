using System;
using System.Collections.Generic;

namespace MyFitnessLog.Business.Contracts
{
    public interface IWorkoutBusiness
    {
        IList<WorkoutEntity> GetWorkoutRecords();

        void SaveWorkoutRecords(IList<WorkoutEntity> entityCollection);
    }
}
