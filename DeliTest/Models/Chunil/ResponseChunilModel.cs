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
        public string MAINNB { get; set; }
        public string BWCODE { get; set; }
        public string JBDATE { get; set; }
        public int CHASEQ { get; set; } = 0;
        public string GDSORD { get; set; }
        public int GDSQNT { get; set; } = 0;
        public string SWNAME { get; set; }
        public string SWTEL1 { get; set; }
        public string SWZPCD { get; set; }
        public string SWADDR { get; set; }
        public string REMARK { get; set; }
        public string SELCST { get; set; }
        public string JUMNAM { get; set; }
        public string JUMDAT { get; set; }
        public string JUMNUM { get; set; }
        public string PAYGBN { get; set; }
        public string CPGKEY { get; set; }
        public int CHARGE { get; set; } = 0;
        public string MAINGB { get; set; }
        public string PRTDAT { get; set; }

        //Response
        public string AREGBN { get; set; }
        public string GUBGBN { get; set; }
        public string SIDONG { get; set; }
        public string CUSTNM { get; set; }
        public string TELCST { get; set; }
        public string ADDRE1 { get; set; }
        public string MAINNM { get; set; }
        public string PRDATE { get; set; }
        public int CHASUM { get; set; } = 0;

        public string REGDAT { get; set; }
        public string PROGBN { get; set; }
        public string PRODAT { get; set; }
        public string ERRNAM { get; set; }
    }
}
