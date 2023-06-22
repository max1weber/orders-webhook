using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

using Microsoft.Extensions.Logging;

namespace func_orders_webhook
{
    public class OrderWebHookFunc
    {
        private readonly ILogger _logger;

        public OrderWebHookFunc(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<OrderWebHookFunc>();
        }

        [Function("orderwebhook")]
        [ServiceBusOutput("shopify_webhooks_orders", ServiceBusEntityType.Topic, Connection = "ServicebusConnectionString")]
        public async Task<string> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
        
        {


            _logger.LogInformation("Webhook processed a request.");
            string response = string.Empty;

            try
            {
                response = await new StreamReader(req.Body).ReadToEndAsync();

                
            }
            catch (Exception ex)
            {

                _logger.LogError($"Exception thrown: {ex.Message}");
             
            }
            return response;


        }
    }
}
