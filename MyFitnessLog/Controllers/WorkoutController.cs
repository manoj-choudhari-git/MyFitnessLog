using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFitnessLog.Business.Contracts;
using MyFitnessLog.Models;

namespace MyFitnessLog.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly IWorkoutBusiness workoutBusiness;

        public WorkoutController(IWorkoutBusiness workoutBusiness)
        {
            this.workoutBusiness = workoutBusiness;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(WorkoutEntry model)
        {
            if (model == null || model.NumberOfRepeatations == null || model.NumberOfRepeatations.Count == 0)
            {
                throw new ArgumentNullException(nameof(model));
            }

            IList<WorkoutEntity> workoutEntityCollection = new List<WorkoutEntity>();
            int setNumber = 1;
            foreach(var count in model.NumberOfRepeatations)
            {
                var entity = new WorkoutEntity()
                {
                    ActivityName = model.ActivityName,
                    CreatedOn = DateTime.Now,
                    SetNumber = setNumber,
                    Repeatations = count
                };

                workoutEntityCollection.Add(entity);
            }

            await this.workoutBusiness.SaveWorkoutRecordsAsync(workoutEntityCollection);
            return View();
        }
    }
}