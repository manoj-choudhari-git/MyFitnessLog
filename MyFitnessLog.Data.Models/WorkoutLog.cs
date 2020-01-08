﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFitnessLog.Data.Models
{
    public class WorkoutLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string ActivityName { get; set; }

        public int SetNumber { get; set; }

        public int Repeatations { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
