using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.Delete
{
    public class DeleteRequestModel
    {
        [JsonProperty(Required = Required.Always)]
        public string API_KEY { get; set; }
        [JsonProperty(Required = Required.Always)]
        [MaxLength(13)]
        public string PD_BARCODE { get; set; }
    }
}
