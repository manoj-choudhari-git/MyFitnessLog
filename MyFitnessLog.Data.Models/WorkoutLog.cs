using System;
using System.Collections.Generic;
using System.Text;

namespace MyFitnessLog.Data.Models
{
    public class WorkoutLog
    {
        public int Id { get; set; }

        public string WorkoutType { get; set; }

        public string SetNumber { get; set; }

        public string Repeatations { get; set; }

        public string CreatedOn { get; set; }

        public string CreatedBy { get; set; }
    }
}
