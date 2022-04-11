using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.Chunil
{
    /// <summary>
    /// 운송장 출력 데이터
    /// </summary>
    public class ResponseChunilModel
    {
        public string JBDATE { get; set; }
        public string BWCODE { get; set; }
        public int CHASEQ { get; set; }
        public string MAINNB { get; set; }
        public string AREGBN { get; set; }
        public string GUBGBN { get; set; }
        public string SIDONG { get; set; }
        public string CUSTNM { get; set; }
        public string TELCST { get; set; }
        public string ADDRE1 { get; set; }
        public string MAINNM { get; set; }
        public string PRDATE { get; set; }
        public int CHASUM { get; set; } = 0;
    }
}
