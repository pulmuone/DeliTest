using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.Chunil
{
    /// <summary>
    /// 확정 프로시저 호출
    /// </summary>
    public class RequestConfirmChunilModel
    {
        public string JBDATE { get; set; }
        public string BWCODE { get; set; }
        public int CHASEQ { get; set; }
    }
}
