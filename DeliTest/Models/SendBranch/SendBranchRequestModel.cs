using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.SendBranch
{
    public class SendBranchRequestModel
    {
        [JsonProperty(Required = Required.Always)]
        public string API_KEY { get; set; }
    }
}
