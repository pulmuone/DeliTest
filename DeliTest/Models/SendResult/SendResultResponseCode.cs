using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.SendResult
{
    public class SendResultResponseCode
    {
        private static readonly SendResultResponseCode instance = new SendResultResponseCode();
        private Dictionary<string, string> _result { get; set; } = new Dictionary<string, string>();

        public static SendResultResponseCode Instance()
        {
            return instance;
        }

        private SendResultResponseCode()
        {
            _result.Add("0", "API Key가 null or “”로 보낸 경우");
            _result.Add("1", "운송장번호가 들어있는 Items Array가 비어 있는 경우");
            _result.Add("2", "삭제되거나 없는 운송장번호");
            _result.Add("3", "해당 Key에 권한이 없는 운송장번호");
            _result.Add("200", "성공");
            _result.Add("901", "API KEY가 비어있거나 인증되지 않은 키");
            _result.Add("905", "정의되지 않은 예외");
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
