using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.GetSendLabelPrint
{
    public class SendLabelPrintResponseModel
    {
        public string CODE { get; set; }
        public List<SendLabelPrintResponseItemsModel> Items { get; set; }
    }
}
