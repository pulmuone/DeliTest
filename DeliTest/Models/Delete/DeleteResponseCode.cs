using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.Delete
{
    public sealed class DeleteResponseCode
    {
        private static readonly DeleteResponseCode instance = new DeleteResponseCode();
        private Dictionary<string, string> _result { get; set; } = new Dictionary<string, string>();

        public static DeleteResponseCode Instance()
        {
            return instance;
        }

        private DeleteResponseCode()
        {
            _result.Add("0", "DeleteRequest 데이터가 형식이 맞지 않는 경우");
            _result.Add("1", "DB에 접속할 수 없는 경우, 전산실 문의 요망");
            _result.Add("2", "작업중 오류");
            _result.Add("3", "API KEY 인증 실패");
            _result.Add("4", "삭제할 행이 없는 경우");
            _result.Add("5", "적재운임 취소에 실패");
            _result.Add("200", "성공");
            _result.Add("907", "경동 프로그램 운영 시간 외에 삭제를 한 경우");
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
