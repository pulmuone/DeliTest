using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.SendResult
{
    public class SendResultRequestModel
    {
        [JsonProperty(Required = Required.Always)]
        public string API_KEY { get; set; }
        [JsonProperty(Required = Required.Always)]
        //public List<SendResultItemModel> Items { get; set; }
        public List<string> Items { get; set; }
    }
}
