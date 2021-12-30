using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.DockInfo
{
    public class DockInfoRequestModel
    {
        [JsonProperty(Required = Required.Always)]
        public string API_KEY { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int REQUEST_TYPE { get; set; }
    }
}
