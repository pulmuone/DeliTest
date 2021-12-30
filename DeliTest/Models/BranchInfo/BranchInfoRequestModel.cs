using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.BranchInfo
{
    public class BranchInfoRequestModel
    {
        [JsonProperty(Required = Required.Always)]
        public string API_KEY { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int REQUEST_TYPE { get; set; }
    }
}
