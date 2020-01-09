using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyFitnessLog.Business.Contracts;
using MyFitnessLog.Data.Contracts;

namespace MyFitnessLog.Business
{
    public class WorkoutBusiness : IWorkoutBusiness
    {
        private readonly IWorkoutRepository workoutRepository;

        public WorkoutBusiness(IWorkoutRepository workoutRepository)
        {
            this.workoutRepository = workoutRepository;
        }

        public async Task<IList<WorkoutEntity>> GetWorkoutRecordsAsync()
        {
            IList<WorkoutEntity> entityCollection = new List<WorkoutEntity>();
            var dataList = await workoutRepository.GetWorkoutRecordsAsync();

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

        public async Task SaveWorkoutRecordsAsync(IList<WorkoutEntity> entityCollection)
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

            await workoutRepository.SaveWorkoutRecordsAsync(dataCollection);
        }
    }
}
