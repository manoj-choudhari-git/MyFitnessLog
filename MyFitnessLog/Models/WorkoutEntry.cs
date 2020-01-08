using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFitnessLog.Models
{
    public class WorkoutEntry
    {
        public string ActivityName { get; set; }

        public IList<int> NumberOfRepeatations { get; set; }
    }
}
