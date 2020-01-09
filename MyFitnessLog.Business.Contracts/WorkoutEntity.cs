using System;

namespace MyFitnessLog.Business.Contracts
{
    public class WorkoutEntity
    {
        public int Id { get; set; }

        public string ActivityName { get; set; }

        public int SetNumber { get; set; }

        public int Repeatations { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
