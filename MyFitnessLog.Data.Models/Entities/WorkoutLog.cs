using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFitnessLog.Data.Models.Entities
{
    public class WorkoutLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ActivityName { get; set; }

        public int SetNumber { get; set; }

        public int Repeatations { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
