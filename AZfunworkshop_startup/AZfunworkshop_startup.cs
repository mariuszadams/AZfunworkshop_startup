﻿using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AZfunworkshop_startup
{
    public class AZfunworkshop_startup
    {
        [FunctionName("AZfunworkshop_startup")]
        public void Run([ServiceBusTrigger("myqueue", Connection = "test-connection-string")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}

