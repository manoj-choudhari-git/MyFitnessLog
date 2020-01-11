using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFitnessLogRegisterUserJob
{
    public class Functions
    {
        public static void ProcessQueueMessage([QueueTrigger("my-queue")] string message, ILogger logger)
        {
            logger.LogInformation("START of Execution of your Web Job");
            logger.LogInformation(message);
            logger.LogInformation("END of Execution of your Web Job");
        }
    }
}
