using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Collections.Generic;

namespace TwilioSerializerFunctionApp
{
    public static class TwilioWhatsAppSerializer
    {
        [FunctionName("TwilioWhatsAppSerializer")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger Serializer");
            //application/x-www-form-urlencoded
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            string jsonToRetun = string.Empty;
            var o = QueryStringHelper.QueryStringToDict(requestBody);
            log.LogInformation($"-------{requestBody}");
            var json = JsonConvert.SerializeObject(o, Formatting.Indented);
            //dynamic a = JsonConvert.DeserializeObject(requestBody.Contains("&") ? json : requestBody);
            try
            {

                //log.LogInformation(json);
                //Welcome data = JsonConvert.DeserializeObject<Welcome>(requestBody.Contains("&") ? json : requestBody);
                //Example LINQ to query an one fell
                //var tipo = data.Body.Formdata.Where(x => x.Key.Equals("MediaUrl0")).FirstOrDefault();

                //if (data.Body.ToLower().Contains("call"))
                //{
                //    var number = data.Body.Split(' ').ToList();
                //    number.RemoveAt(0);

                //    var res = number.Select(p => new Root { Number = p });
                //    jsonToRetun = JsonConvert.SerializeObject(res, Formatting.Indented);


                //}
                //else
                {
                    //jsonToRetun = JsonConvert.SerializeObject(data, Formatting.Indented);
                }
                return new ContentResult
                {
                    ContentType = "application/json",
                    Content = json,
                    StatusCode = 200

                };
            }
            catch (Exception ex)
            {
                return new ContentResult
                {
                    ContentType = "application/json",
                    Content = ex.ToString(),
                    StatusCode = 500

                };
            }

            //return (Microsoft.AspNetCore.Mvc.IActionResult)new HttpResponseMessage(HttpStatusCode.OK)
            //{
            //    Content = new StringContent(json, Encoding.UTF8, "application/json")
            //};


        }
    }

    public partial class Root
    {
        [JsonProperty("number")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string Number { get; set; }
    }
}
