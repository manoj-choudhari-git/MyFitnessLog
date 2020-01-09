using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFitnessLog.Business.Contracts
{
    public interface IWorkoutBusiness
    {
        Task<IList<WorkoutEntity>> GetWorkoutRecordsAsync();

        Task SaveWorkoutRecordsAsync(IList<WorkoutEntity> entityCollection);
    }
}
