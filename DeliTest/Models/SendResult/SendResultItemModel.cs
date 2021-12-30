using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.SendResult
{
    public class SendResultItemModel
    {
        [JsonProperty(Required = Required.Always)]
        [MaxLength(13)]
        public string item { get; set; }
    }
}
