using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.Send
{
    public sealed class SendResponseCode
    {
        private static readonly SendResponseCode instance = new SendResponseCode();
        private Dictionary<string, string> _result { get; set; } = new Dictionary<string, string>();

        public static SendResponseCode Instance()
        {
            return instance;
        }

        private SendResponseCode()
        {
            _result.Add("0", "Request 데이터가 형식이 맞지 않는 경우");
            _result.Add("1", "DB에 접속할 수 없는 경우, 전산실 문의 요망");
            _result.Add("2", "Request에 도착 영업소명이 없는 경우 당사의 배달구역에서의 도착영업소 정보를 찾을 수 없는 경우, 전산실 문의 요망");
            _result.Add("3", "Request에 도착 영업소명(BR_END_NM)이 당사의 영업소명과 일치하지 않는 경우");
            _result.Add("4", "Request에 운임 PD_DELI_GUBUN의 값이 현택 / 착택 / 현불 / 착불 이 아닌 경우");
            _result.Add("5", "Request에 보내는분 성함(SEND_NM)이 null 이거나 허용하는 데이터 크기 를 넘어서는 경우");
            _result.Add("6", "Request에 보내는분 전화번호(SEND_TEL1)가 null 이거나 잘 못된 형식");
            _result.Add("7", "Request에 보내는분 기타 전화번호(SEND_TEL2)가 잘 못된 형식");
            _result.Add("8", "택배인 경우 Request에 보내는분 우편번호(SEND_ZIPCODE)가 null 이거나 형식에 맞지 않는 경우");
            _result.Add("9", "택배인 경우 Request에 보내는분 주소(SEND_ADDR1)가 null 이거나 허용하 는 데이터 크기를 넘어서는 경우");
            _result.Add("10", "택배인 경우 Request에 보내는분 상세주소(SEND_ADDR2)가 허용하는 데이 터 크기를 넘어서는 경우");
            _result.Add("11", "Request에 받는분 성함(RECV_NM)이 null 이거나 허용하는 데이터 크기를 넘어서는 경우");
            _result.Add("12", "Request에 받는분 전화번호(RECV_TEL1)가 null 이거나 잘 못된 형식");
            _result.Add("13", "Request에 받는분 기타 전화번호(RECV_TEL2)가 잘 못된 형식");
            _result.Add("14", "택배인 경우 Request에 받는분 우편번호(RECV_ZIPCODE)가 null 이거나 형 식에 맞지 않는 경우");
            _result.Add("15", "택배인 경우 Request에 받는분 주소(RECV_ADDR1)가 null 이거나 허용하는 데이터 크기를 넘어서는 경우");
            _result.Add("16", "택배인 경우 Request에 받는분 상세주소(RECV_ADDR2가 허용하는 데이터 크기를 넘어서는 경우");
            _result.Add("17", "Request에 품목명(PD_NM)이 null 이거나 허용하는 데이터 크기를 넘어서는 경우");
            _result.Add("18", "Request에 포장상태(PD_PACK)가 null 이거나 허용하는 데이터 크기를 넘어 서는 경우");
            _result.Add("19", "Request에 운임(PD_DELI_PAY)이 당사의 최저운임 방침보다 작은 경우");
            _result.Add("20", "Request에 수량(PD_CNT)이 1개 미만이거나 100개를 초과하는 경우");
            _result.Add("21", "Request에 개별단가(PD_INDIV_PRICE)가 수량과 맞지 않거나 형식에 맞지 않 는 경우");
            _result.Add("22", "Request에 부피(PD_INDIV_VOLUME)가 수량과 맞지 않거나 형식에 맞지 않 는 경우");
            _result.Add("23", "Request에 무게(PD_INDIV_WEIGHT)가 수량과 맞지 않거나 형식에 맞지 않 는 경우");
            _result.Add("24", "Request에 메모(PD_MEMO)가 허용하는 데이터 크기를 넘어서는 경우");
            _result.Add("25", "수탁번호 생성에 실패, 전산실 문의 요망");
            _result.Add("26", "해당 지역을 배달구역에서 찾지 못 하였거나 올바른 우편번호가 아닌 경우");
            _result.Add("27", "노선 할당 실패, 전산실 문의 요망");
            _result.Add("28", "도크 할당 실패, 전산실 문의 요망");
            _result.Add("29", "배차 정보 읽기 실패, 전산실 문의 요망");
            _result.Add("30", "발송 정보 입력에 실패, 재시도 후에도 동일 증상이 발생하면 전산실 문의 요망");
            _result.Add("200", "성공");
            _result.Add("900", "화물인 경우 찾을 수 없는 영업소명인 경우");
            _result.Add("901", "API KEY가 비어있거나 인증되지 않은 키");
            _result.Add("902", "유효하지 않은 거래처명");
            _result.Add("903", "운송장번호를 자체 생성하여 사용하시는 경우에 생성 규칙에 맞지 않는 경우");
            _result.Add("904", "운송장번호를 자체 생성하여 사용하시는 경우에 사용된 운송장 번호");
            _result.Add("905", "정의되지 않은 예외");
            _result.Add("906", "일요일에는 전산실에서 허용한 ID외에는 발송 자료 저장이 불가");
            _result.Add("907", "경동 프로그램 운영 시간 외에 발송을 한 경우");
            _result.Add("9999", "null 허용 안함");
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
