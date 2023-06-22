using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Text.Json;
using Entities;
using Azure.Messaging.ServiceBus;

namespace func_orders_webhook_inprocess
{
    public static class OrderWebHookFunc
    {
        [FunctionName("OrderWebHookFunc")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function,  "post", Route = "ordersbwebhook2")] HttpRequest req,
            [ServiceBus("shopify_webhooks_orders", Microsoft.Azure.WebJobs.ServiceBus.ServiceBusEntityType.Topic, Connection ="ServicebusConnectionString")] IAsyncCollector<ServiceBusMessage> outputServiceBus,
            ILogger log)
        {
            log.LogInformation("Webhook InProcess TRigger  processed a request.");

          
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ShopifyOrder data = JsonConvert.DeserializeObject<ShopifyOrder>(requestBody);

            ServiceBusMessage sbm = new ServiceBusMessage(BinaryData.FromString(requestBody));
            sbm.Subject = data.Id.ToString();
            sbm.ContentType= "application/json";
          


           await outputServiceBus.AddAsync(sbm);


            return new OkObjectResult(data);
        }
    }
}
