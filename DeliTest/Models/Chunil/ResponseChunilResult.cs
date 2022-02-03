using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.Chunil
{
    /// <summary>
    /// 운송장 출력 DTO
    /// </summary>
    public class ResponseChunilResult : ResultModel
    {
        public ResponseChunilModel Result { get; set; } = new ResponseChunilModel();
    }
}
