using System.Collections.Generic;

namespace MyFitnessLog.Models
{
    public class WorkoutEntry
    {
        public string ActivityName { get; set; }

        public IList<int> NumberOfRepeatations { get; set; }
    }
}
