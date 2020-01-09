using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFitnessLog.Data.Contracts
{
    public interface IWorkoutRepository
    {
        Task<IList<WorkoutData>> GetWorkoutRecordsAsync();

        Task SaveWorkoutRecordsAsync(IList<WorkoutData> dataCollection);
    }
}
