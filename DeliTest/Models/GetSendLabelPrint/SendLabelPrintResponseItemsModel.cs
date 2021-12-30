using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.GetSendLabelPrint
{
    public class SendLabelPrintResponseItemsModel
    {
        public string CODE { get; set; }
        public string PD_BARCODE { get; set; }
        public List<SendLabelPrintResponseItemModel> Items { get; set; }
    }
}
