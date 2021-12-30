using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.GetSendLabelPrint
{
    public class SendLabelPrintResponseCode
    {
        private static readonly SendLabelPrintResponseCode instance = new SendLabelPrintResponseCode();
        private Dictionary<string, string> _itemModelCode { get; set; } = new Dictionary<string, string>();
        private Dictionary<string, string> _responseDataCode { get; set; } = new Dictionary<string, string>();

        public static SendLabelPrintResponseCode Instance()
        {
            return instance;
        }

        private SendLabelPrintResponseCode()
        {
            _responseDataCode.Add("0", "Request 데이터가 형식에 맞지 않는 경우");
            _responseDataCode.Add("1", "DB에 접속 할 수 없는 경우, 전산실 문의 요망");
            _responseDataCode.Add("200", "API Key인증 성공");
            _responseDataCode.Add("901", "API Key인증 실패");
            _responseDataCode.Add("905", "처리되지 않은 오류");

            _itemModelCode.Add("2", "운송장번호 없음");
            _itemModelCode.Add("3", "권한이 없는 운송장번호");
            _itemModelCode.Add("4", "커맨드 생성 실패");
            _itemModelCode.Add("200", "성공");
        }

        public Dictionary<string, string> ItemModelCode
        {
            get
            {
                return this._itemModelCode;
            }
        }

        public Dictionary<string, string> ResponseDataCode
        {
            get
            {
                return this._responseDataCode;
            }
        }
    }
}
