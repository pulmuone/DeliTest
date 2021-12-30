using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.FindBarcode
{
    public class FindBarcodeResponseCode
    {
        private static readonly FindBarcodeResponseCode instance = new FindBarcodeResponseCode();
        private Dictionary<string, string> _result { get; set; } = new Dictionary<string, string>();

        public static FindBarcodeResponseCode Instance()
        {
            return instance;
        }

        private FindBarcodeResponseCode()
        {
            _result.Add("0", "Request 데이터가 형식이 맞지 않는 경우");
            _result.Add("1", "운송장번호가 형식에 맞지 않거나 조회할 수 없는 운송장번호인 경우");
            _result.Add("2", "사용하지 않은 운송장번호");
            _result.Add("200", "사용한 운송장번호, 정상적으로 Data가 입력됨");
            _result.Add("901", "API Key 인증 실패");
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
