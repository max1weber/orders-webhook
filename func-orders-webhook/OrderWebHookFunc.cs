using System.Net;
using func_orders_webhook.entity;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

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
        public async Task<object> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "ordersbwebhook")] HttpRequestData req)
        
        {


            _logger.LogInformation("Webhook processed a request.");
            HttpResponseData response;

            try
            {
                string requestbody = await new StreamReader(req.Body).ReadToEndAsync();

                return requestbody;
                
            }
            catch (Exception ex)
            {

                _logger.LogError($"Exception thrown: {ex.Message}");
                response = req.CreateResponse(HttpStatusCode.InternalServerError);
            }
            return response;


        }
    }
}
