using MyFitnessLog.Business.Contracts;
using MyFitnessLog.Data.Contracts;
using System;
using System.Collections.Generic;

namespace MyFitnessLog.Business
{
    public class WorkoutBusiness : IWorkoutBusiness
    {
        private readonly IWorkoutRepository workoutRepository;

        public WorkoutBusiness(IWorkoutRepository workoutRepository)
        {
            this.workoutRepository = workoutRepository;
        }

        public IList<WorkoutEntity> GetWorkoutRecords()
        {
            IList<WorkoutEntity> entityCollection = new List<WorkoutEntity>();
            var dataList = workoutRepository.GetWorkoutRecords();
            foreach (var data in dataList)
            {
                var entity = new WorkoutEntity()
                {
                    Id = data.Id,
                    ActivityName = data.ActivityName,
                    SetNumber = data.SetNumber,
                    Repeatations = data.Repeatations,
                    CreatedOn = data.CreatedOn
                };

                entityCollection.Add(entity);
            }

            return entityCollection;
        }

        public void SaveWorkoutRecords(IList<WorkoutEntity> entityCollection)
        {
            if (entityCollection == null || entityCollection.Count == 0)
            {
                throw new ArgumentNullException(nameof(entityCollection));
            }

            IList<WorkoutData> dataCollection = new List<WorkoutData>();
            foreach (var entity in entityCollection)
            {
                var data = new WorkoutData()
                {
                    ActivityName = entity.ActivityName,
                    CreatedOn = entity.CreatedOn,
                    Repeatations = entity.Repeatations,
                    SetNumber = entity.SetNumber
                };

                dataCollection.Add(data);
            }

            workoutRepository.SaveWorkoutRecords(dataCollection);
        }
    }
}
