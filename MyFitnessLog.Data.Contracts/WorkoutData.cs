using System;

namespace MyFitnessLog.Data.Contracts
{
    public class WorkoutData
    {
        public int Id { get; set; }

        public string ActivityName { get; set; }

        public int SetNumber { get; set; }

        public int Repeatations { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
