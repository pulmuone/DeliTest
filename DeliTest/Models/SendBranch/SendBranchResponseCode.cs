using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.SendBranch
{
    public class SendBranchResponseCode
    {
        private static readonly SendBranchResponseCode instance = new SendBranchResponseCode();
        private Dictionary<string, string> _result { get; set; } = new Dictionary<string, string>();

        public static SendBranchResponseCode Instance()
        {
            return instance;
        }

        private SendBranchResponseCode()
        {
            _result.Add("0", "Request 데이터가 형식이 맞지 않는 경우");
            _result.Add("200", "성공");
            _result.Add("901", "API KEY가 비어있거나 인증되지 않은 키");
            _result.Add("905", "처리되지 않은 예외");
        }

        public Dictionary<string, string> Code
        {
            get
            {
                return this._result;
            }
        }
    }
}
