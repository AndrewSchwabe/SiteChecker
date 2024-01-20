using System;
using System.Collections.Generic;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace SiteChecker
{
    public static class SiteCheckerSchedule
    {
        [FunctionName("SiteChecker")]
        public static void Run([TimerTrigger("0 0 */12 * * *")]
            TimerInfo timer,
            ILogger log)
        {
            
        }
    }
}
