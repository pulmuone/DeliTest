using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.GetSendLabelPrint
{
    public class SendLabelPrintItemRequestModel
    {
        [JsonProperty(Required = Required.Always)]
        public string PD_BARCODE { get; set; }
        [JsonProperty(Required = Required.Always)]
        public List<int> BarcodeIndexList { get; set; }
    }
}