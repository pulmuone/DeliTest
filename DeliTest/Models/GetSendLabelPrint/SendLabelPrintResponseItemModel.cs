using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.GetSendLabelPrint
{
    public class SendLabelPrintResponseItemModel
    {
        public List<string> Commands { get; set; }
        public int Index { get; set; }
    }
}
