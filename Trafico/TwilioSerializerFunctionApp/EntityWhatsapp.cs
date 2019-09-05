
namespace TwilioSerializerFunctionApp
{
    using System;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("SmsMessageSid")]
        public string SmsMessageSid { get; set; }

        [JsonProperty("NumMedia")]
        [JsonConverter(typeof(string))]
        public string NumMedia { get; set; }

        [JsonProperty("SmsSid")]
        public string SmsSid { get; set; }

        [JsonProperty("SmsStatus")]
        public string SmsStatus { get; set; }

        [JsonProperty("Body")]
        public string Body { get; set; }

        [JsonProperty("To")]
        public string To { get; set; }

        [JsonProperty("NumSegments")]
        [JsonConverter(typeof(string))]
        public string NumSegments { get; set; }

        [JsonProperty("MessageSid")]
        public string MessageSid { get; set; }

        [JsonProperty("AccountSid")]
        public string AccountSid { get; set; }

        [JsonProperty("From")]
        public string From { get; set; }

        [JsonProperty("ApiVersion")]
        public string ApiVersion { get; set; }

        [JsonProperty("MediaUrl0")]
        public string MediaUrl { get; set; }

        [JsonProperty("MediaContentType0")]
        public string MediaContentType { get; set; }
    }




}
