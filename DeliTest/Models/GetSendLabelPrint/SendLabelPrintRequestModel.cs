using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.GetSendLabelPrint
{
    public class SendLabelPrintRequestModel
    {
        public string API_KEY { get; set; }
        public int PrintType { get; set; }
        public int TerminalBoxWidth { get; set; }
        public int TerminalBoxHeight { get; set; }
        public List<SendLabelPrintItemRequestModel> Items { get; set; }
    }
}
