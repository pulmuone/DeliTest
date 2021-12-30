using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.Send
{
    public class SendResponseModel
    {
        public string CODE { get; set; }
        public string PD_BARCODE { get; set; }
        public string BR_END_NM { get; set; }
        public string BR_END_TEL { get; set; }
        public int PD_BOHUM_PAY { get; set; }
        public int PD_DOSUN_PAY { get; set; }
        public string PD_DOCK1 { get; set; }
        public string PD_DOCK2 { get; set; }
        public string PD_TEMP { get; set; }
        public string PD_TERMINAL1 { get; set; }
        public string PD_TERMINAL2 { get; set; }
    }
}
