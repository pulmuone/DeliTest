using BarcodeLib;
using DeliTest.Models.BranchInfo;
using DeliTest.Models.Chunil;
using DeliTest.Models.Delete;
using DeliTest.Models.DeliveryArea;
using DeliTest.Models.DockInfo;
using DeliTest.Models.FindBarcode;
using DeliTest.Models.GetSendLabelPrint;
using DeliTest.Models.Send;
using DeliTest.Models.SendBranch;
using DeliTest.Models.SendResult;
using DeliTest.Services;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using ZXing;

namespace DeliTest
{
    public partial class Form1 : Form
    {
        string API_KEY = "6276CB47D8D244E6885ECC87D862F4F6";
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SendRequestModel request = new SendRequestModel()
                {
                    API_KEY = this.API_KEY,
                    BR_END_NM = "",
                    COM_NM = "",
                    RECV_NM = "보내는분 테스트",
                    RECV_TEL1 = "010-0000-0000",
                    RECV_TEL2 = "",
                    RECV_ZIPCODE = "08594",
                    RECV_ADDR1 = "서울특별시 금천구 가산디지털로 19",
                    RECV_ADDR2 = "18층 1801",
                    SEND_NM = "보내는분 이름",
                    SEND_TEL1 = "010-0000-0000",
                    SEND_TEL2 = "010-0000-0000",
                    SEND_ZIPCODE = "08101",
                    SEND_ADDR1 = "서울시 양천구 목동남로 68",
                    SEND_ADDR2 = "101호",
                    PD_CNT = 1,
                    PD_DELI_GUBUN = "현택",
                    PD_DELI_PAY = 2000,
                    PD_MEMO = "메모 테스트",
                    PD_NM = "컴퓨터 부품",
                    PD_PACK = "박스",
                    PD_PRICE = "30",
                    PD_VOLUME = "30",
                    PD_WEIGHT = "5.5"
                };

                var result = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/Send", request);

                SendResponseModel response = JsonConvert.DeserializeObject<SendResponseModel>(result);

                Console.WriteLine(response);

                if (SendResponseCode.Instance().Code.ContainsKey(response.CODE))
                {
                    Console.WriteLine(SendResponseCode.Instance().Code[response.CODE]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRequestModel request = new DeleteRequestModel()
                {
                    API_KEY = this.API_KEY,
                    PD_BARCODE = "9999910520002"
                };

                var result = await HttpService.Instance.SendRequestAsync(HttpMethod.Delete, "/v1/Delete", request);

                DeleteResponseModel response = JsonConvert.DeserializeObject<DeleteResponseModel>(result);

                Console.WriteLine(response);

                if (SendResponseCode.Instance().Code.ContainsKey(response.CODE))
                {
                    Console.WriteLine(SendResponseCode.Instance().Code[response.CODE]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void btnDockInfo_Click(object sender, EventArgs e)
        {
            try
            {
                DockInfoRequestModel request = new DockInfoRequestModel()
                {
                    API_KEY = this.API_KEY
                };

                var result = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/getDockInfo", request);

                var response = JsonConvert.DeserializeObject<List<DockInfoResponseModel>>(result);

                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void btnBranchInfo_Click(object sender, EventArgs e)
        {
            try
            {
                BranchInfoRequestModel request = new BranchInfoRequestModel()
                {
                    API_KEY = this.API_KEY
                };

                var result = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/getBranchInfo", request);

                var response = JsonConvert.DeserializeObject<List<BranchInfoResponseModel>>(result);

                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void btnFindBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                FindBarcodeRequestModel request = new FindBarcodeRequestModel()
                {
                    API_KEY = this.API_KEY,
                    PD_BARCODE = "9999910520002"
                };

                var result = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/FindBarcode", request);

                var response = JsonConvert.DeserializeObject<FindBarcodeResponseModel>(result);

                Console.WriteLine(response);

                if (FindBarcodeResponseCode.Instance().Code.ContainsKey(response.CODE))
                {
                    Console.WriteLine(FindBarcodeResponseCode.Instance().Code[response.CODE]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void btnSendBranch_Click(object sender, EventArgs e)
        {
            try
            {
                SendBranchRequestModel request = new SendBranchRequestModel()
                {
                    API_KEY = this.API_KEY
                };

                var result = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/getSendBranch", request);

                var response = JsonConvert.DeserializeObject<SendBranchResponseModel>(result);

                Console.WriteLine(response);

                if (SendBranchResponseCode.Instance().Code.ContainsKey(response.CODE))
                {
                    Console.WriteLine(SendBranchResponseCode.Instance().Code[response.CODE]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void btnDeliveryArea_Click(object sender, EventArgs e)
        {
            try
            {
                DeliveryAreaRequestModel request = new DeliveryAreaRequestModel()
                {
                    API_KEY = this.API_KEY,
                    Keyword = "11415"
                };

                var result = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/getDeliveryArea", request);

                var response = JsonConvert.DeserializeObject<List<DeliveryAreaResponseModel>>(result);

                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 9.발송 결과 확인
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSendResult_Click(object sender, EventArgs e)
        {
            try
            {
                //List<SendResultItemModel> items = new List<SendResultItemModel>();
                //items.Add(new SendResultItemModel() { item = "9999910190001" });
                //items.Add(new SendResultItemModel() { item = "9999910190002" });

                SendResultRequestModel request = new SendResultRequestModel()
                {
                    API_KEY = this.API_KEY,
                    Items = new List<string> { "9999910520002" }
                };

                var result = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/SendResult", request);

                var response = JsonConvert.DeserializeObject<List<SendResponseModel>>(result);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        if (SendResultResponseCode.Instance().Code.ContainsKey(item.CODE))
                        {
                            Console.WriteLine(SendBranchResponseCode.Instance().Code[item.CODE]);
                        }
                    }
                }

                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void btnTracking_Click(object sender, EventArgs e)
        {

            try
            {
                //var result = await HttpTrackingService.Instance.SendRequestAsync(HttpMethod.Get, "9999910190001");
                var result = await HttpTrackingService.Instance.SendRequestAsync2(HttpMethod.Get, "9999910190001");

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private async void btnLabelPrint_Click(object sender, EventArgs e)
        {
            List<SendLabelPrintItemRequestModel> items = new List<SendLabelPrintItemRequestModel>();
            List<int> page = new List<int>();
            items.Add(new SendLabelPrintItemRequestModel() { PD_BARCODE = "9999915310002", BarcodeIndexList = page });

            SendLabelPrintRequestModel sendLabelPrintRequestModel = new SendLabelPrintRequestModel()
            {
                API_KEY = this.API_KEY,
                PrintType = 2,
                TerminalBoxWidth = 0,
                TerminalBoxHeight = 0,
                Items = items
            };

            var result = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/GetSendLabelPrint", sendLabelPrintRequestModel);


            SendLabelPrintResponseModel labelPrint = (SendLabelPrintResponseModel)Newtonsoft.Json.JsonConvert.DeserializeObject(result, typeof(SendLabelPrintResponseModel));

            //응답코드 확인
            if (labelPrint.CODE == "200")
            {
                List<SendLabelPrintResponseItemsModel> itemsResult = labelPrint.Items;

                foreach (var item in itemsResult)
                {
                    Console.WriteLine(item.CODE);
                    Console.WriteLine(item.PD_BARCODE); //운송장 번호

                    if (item.CODE == "200")
                    {
                        List<SendLabelPrintResponseItemModel> itemResult2 = item.Items;

                        foreach (var item2 in itemResult2)
                        {
                            //인덱스 번호
                            Console.WriteLine(string.Format("index, {0}", item2.Index));

                            Console.WriteLine(String.Join(", ", item2.Commands.ToArray()));
                            //Console.WriteLine(item2.Commands.Aggregate((x, y) => x + ", " + y)); //이 방법은 매우 느리며 권장하지 않음. foreach루프를 실행하고 각 요소를 연결하는 것과 같다.

                            //명령어 라인단위로
                            foreach (var item3 in item2.Commands)
                            {
                                Console.WriteLine(item3.ToString());

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(SendLabelPrintResponseCode.Instance().ResponseDataCode[item.CODE]);
                    }
                }
            }
            else
            {
                Console.WriteLine(SendLabelPrintResponseCode.Instance().ResponseDataCode[labelPrint.CODE]);
            }
        }

        private async void btnLabelPrint2_Click(object sender, EventArgs e)
        {
            //발송 영업소 정보 확인
            SendBranchRequestModel SendBranchRequestModel = new SendBranchRequestModel()
            {
                API_KEY = this.API_KEY
            };
            var SendBranchRequestResult = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/getSendBranch", SendBranchRequestModel);
            SendBranchResponseModel sendBranchResponseModel = JsonConvert.DeserializeObject<SendBranchResponseModel>(SendBranchRequestResult);

            //int price= 50;
            List<int> lstPrice = new List<int>();
            lstPrice.Add(50);
            lstPrice.Add(50);

            string PD_PRICE = string.Join("|", lstPrice);

            //송장발송
            SendRequestModel sendRequestModel = new SendRequestModel()
            {
                API_KEY = this.API_KEY,
                BR_END_NM = "경주외동석계1317",
                COM_NM = "",
                RECV_NM = "받는분 테스트",
                RECV_TEL1 = "010-0000-0000",
                RECV_TEL2 = "",
                RECV_ZIPCODE = "11921",
                RECV_ADDR1 = "경기도 구리시 건원대로 34번길 25 (안창동, 인아월드코아)",
                RECV_ADDR2 = "405호",
                SEND_NM = "보내는분 이름",
                SEND_TEL1 = "010-0000-0000",
                SEND_TEL2 = "010-0000-0000",
                SEND_ZIPCODE = "18583",
                SEND_ADDR1 = "경기 화성시 장안면 독정리 474-3",
                SEND_ADDR2 = "문의 031-8608-8707",
                PD_CNT = 2,
                PD_DELI_GUBUN = "현택",
                PD_DELI_PAY = 2000,
                PD_MEMO = "메모 테스트",
                PD_NM = "컴퓨터 부품",
                PD_PACK = "박스",
                PD_PRICE = string.Join("|", lstPrice), //필수, 물건 각각의 단가
                PD_VOLUME = "",
                PD_WEIGHT = ""
            };

            var sendRequestModelResult = await HttpService.Instance.SendRequestAsync(HttpMethod.Post, "/v1/Send", sendRequestModel);
            SendResponseModel sendResponseModel = JsonConvert.DeserializeObject<SendResponseModel>(sendRequestModelResult);

            //대량으로 출력시 싱글톤으로 처리
            //XtraReport report = new XtraReport();
            //report.LoadLayout(Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "kdexp2.repx"));
            //XtraReport report = XtraReport.FromFile(Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "Repx/kdexp2.repx"), true);
            string path = Directory.GetCurrentDirectory();
            XtraReport report = XtraReport.FromFile(Path.Combine(path, "Repx/kdexp2.repx"), true);

            //XtraReport report = XtraReport.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "Repx/kdexp.repx"), true);

            for (int i = 1; i <= sendRequestModel.PD_CNT; i++)
            {
                report.CreateDocument(true); //파라민터를 재 할당 해서 사용 가능, true로 해야 한다.
                //report.ParametersRequestValueChanged += Report_ParametersRequestValueChanged;

                //화면에 진행하는 창 안보이게
                report.PrintingSystem.ShowMarginsWarning = false;
                report.PrintingSystem.ShowPrintStatusDialog = false;
                report.ShowPrintStatusDialog = false;

                //report.ShowPrintMarginsWarning = false;
                //report.PrintOnEmptyDataSource = false;

                //report.ShowPreviewMarginLines = true;
                //report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.PrintDirect, CommandVisibility.None);

                report.RequestParameters = false;

                //report.ExportToPdf(@"d:\z_print\"+i+".pdf"); 

                report.Parameters["SEND_DATE_INFO"].Value = string.Format("{0} ({1}.{2})", "2021.12.27", "17.27", string.Format("{0:F2}", sendRequestModel.PD_DELI_PAY / 1000.0)); //발송일자 일시 운임
                report.Parameters["BR_NM"].Value = sendBranchResponseModel.BR_NM; //SendBranchResponseModel.BR_NM, 발송 영업소 API KEY로 "7.발송 영업소 확인"
                report.Parameters["BR_TEL"].Value = sendBranchResponseModel.BR_TEL; //SendBranchResponseModel.BR_TEL, 발송 영업소 전화번호
                report.Parameters["SEND_NM"].Value = sendRequestModel.SEND_NM; //보내는 사람 이름
                report.Parameters["SEND_TEL1"].Value = sendRequestModel.SEND_TEL1; //보내는 사람 연락처1
                report.Parameters["SEND_TEL2"].Value = sendRequestModel.SEND_TEL2; //보내는 사람 연락처2
                report.Parameters["SEND_ZIPCODE"].Value = sendRequestModel.SEND_ZIPCODE; //보내는분 우편주소
                report.Parameters["SEND_ADDR1"].Value = sendRequestModel.SEND_ADDR1; //보내는 사람 주소1
                report.Parameters["SEND_ADDR2"].Value = sendRequestModel.SEND_ADDR2; //보내는 사람 주소2
                report.Parameters["PD_BARCODE"].Value = string.Format("S/N {0}", sendResponseModel.PD_BARCODE); //Response.PD_BAROCDE S/N 9999915310002 
                report.Parameters["PD_NM"].Value = sendRequestModel.PD_NM; //품목명
                if (sendRequestModel.PD_DELI_GUBUN == "현택")
                {
                    report.Parameters["PD_DELI_GUBUN"].Value = "선불택배"; //택배구분-현택(선불택배), 착택(후불택배), 현불(선불화물), 착불(후불화물)
                }
                else if (sendRequestModel.PD_DELI_GUBUN == "착택")
                {
                    report.Parameters["PD_DELI_GUBUN"].Value = "후불택배";
                }
                else if (sendRequestModel.PD_DELI_GUBUN == "현불")
                {
                    report.Parameters["PD_DELI_GUBUN"].Value = "선불화물";
                }
                else if (sendRequestModel.PD_DELI_GUBUN == "착불")
                {
                    report.Parameters["PD_DELI_GUBUN"].Value = "후불화물";
                }

                //report.Parameters["PAGE_INFO"].Value = "총 1개 1-1"; //페이지 정보 "총 1개 1-1"
                report.Parameters["PAGE_INFO"].Value = string.Format("총 {0}개 {1}-{2}", sendRequestModel.PD_CNT, sendRequestModel.PD_CNT, i);  //"총 1개 1-1"; //페이지 정보 "총 1개 1-1"
                report.Parameters["PD_PACK"].Value = sendRequestModel.PD_PACK; //포장상태
                report.Parameters["PD_DOCK1"].Value = sendResponseModel.PD_DOCK1; //Response.PD_DOCK1
                //report.Parameters["PD_BARCODE_SEQ"].Value = string.Format("{0}.{1}", sendResponseModel.PD_BARCODE, 1); //송장 순번 9999915310002.2 뒷에 순번을 붙인다.
                report.Parameters["PD_BARCODE_SEQ"].Value = string.Format("{0}.{1}", sendResponseModel.PD_BARCODE, i); //송장 순번 9999915310002.2 뒷에 순번을 붙인다.

                report.Parameters["BR_END_NM"].Value = sendResponseModel.BR_END_NM; //Response.BR_END_NM 도착 영업소명
                report.Parameters["PD_TEMP"].Value = sendResponseModel.PD_TEMP; //Response.PD_TEMP 물품 분류를 위해 라벨 출력 시에 오른쪽 상단에 출력
                report.Parameters["BR_END_TEL"].Value = sendResponseModel.BR_END_TEL; //Response.BR_END_TEL 도착 영업소 전화번호
                report.Parameters["RECV_NM"].Value = sendRequestModel.RECV_NM; //받는분 성함
                report.Parameters["RECV_TEL1"].Value = sendRequestModel.RECV_TEL1; //받는분 전화번호
                report.Parameters["RECV_TEL2"].Value = sendRequestModel.RECV_TEL2; //받는분 기타 연락처
                report.Parameters["RECV_ZIPCODE"].Value = sendRequestModel.RECV_ZIPCODE; //받는분 우편주소
                report.Parameters["RECV_ADDR1"].Value = sendRequestModel.RECV_ADDR1; //받는분 주소
                report.Parameters["RECV_ADDR2"].Value = sendRequestModel.RECV_ADDR2; //받는분 상세주소

                report.Parameters["PD_MEMO"].Value = sendRequestModel.PD_MEMO; // New Line은 "\r\n"
                report.Parameters["PD_DOCK2"].Value = sendResponseModel.PD_DOCK2; //Response.PD_DOCK2 두번째 터미널 도크
                report.Parameters["CUSTOMER_CENTER"].Value = "고객센터 : 1899-5368"; //고객센터

                report.Parameters["PD_TERMINAL1"].Value = sendResponseModel.PD_TERMINAL1;
                //report.Parameters["PD_TERMINAL1"].Value = "칠곡";

                //BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                //barcode.Encode(BarcodeLib.TYPE.CODE128, "12345");

                XRPictureBox pictureBox = (XRPictureBox)report.FindControl("pictureBox1", true);

                //var writer = new BarcodeWriter();
                //writer.Format = BarcodeFormat.QR_CODE;
                //writer.Options.PureBarcode = true; //바코드만 나오게 할건지?
                //writer.Options.Width = 300;
                //writer.Options.Height = 100;
                var writer = BarcodeGenerator.Instance.Writer;
                writer.Format = BarcodeFormat.QR_CODE;
                //writer.Options.PureBarcode = true; //바코드만 나오게 할건지?
                //writer.Options.Width = 100;
                //writer.Options.Height = 80;

                var options = BarcodeGenerator.Instance.Options;
                options.PureBarcode = true;
                options.Width = 100;
                options.Height = 100;
                options.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H;

                writer.Options = options;

                pictureBox.Image = writer.Write("AB213");

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    printControl1.PrintingSystem = printTool.PrintingSystem;
                    //printControl1.PrintingSystem = printTool.PrintingSystem;
                    //인쇄방향, 용지 설정
                    //PrintControl printControl = printTool.PreviewForm.PrintControl;
                    //printTool.Print("Microsoft Print to PDF"); //프린터 지정해서 바로 인쇄, OneNote 16으로 보내기

                    //printControl.ExecCommand(PrintingSystemCommand.ViewWholePage);
                    //printControl.ExecCommand(PrintingSystemCommand.PrintDirect);
                    //printTool.PrintingSystem.PrintProgress += PrintingSystem_PrintProgress;
                    //printTool.Print("Adobe PDF");
                    //printTool.Print("OneNote 16으로 보내기");                    

                    printTool.Print();
                }
            }
        }

        private void PrintingSystem_PrintProgress1(object sender, PrintProgressEventArgs e)
        {
            Debug.WriteLine("e.PageIndex1 : " + e.PageIndex);
        }

        private void PrintingSystem_PrintProgress(object sender, PrintProgressEventArgs e)
        {
            Debug.WriteLine("e.PageIndex : " + e.PageIndex);
        }

        private void Report_ParametersRequestValueChanged(object sender, DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs e)
        {
            Console.WriteLine(e.ChangedParameterInfo);
            Console.WriteLine(e.ParametersInformation);
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            //int price= 50;
            List<int> lstPrice = new List<int>();
            lstPrice.Add(50);
            lstPrice.Add(50);
            lstPrice.Add(50);

            string PD_PRICE = string.Join("|", lstPrice);

            Console.WriteLine(string.Format("{0:F2}", 2500 / 1000.0));

            string DELE_DATE = string.Format(@"{0:yyyy.MM.dd} ({1:HH.mm}.{2:F2})", DateTime.Now, DateTime.Now, 2500 / 1000.0);
            Console.WriteLine(DELE_DATE); // 2021.12.29 (15.06.2.50)
        }

        private async void btnChunilSend_Click(object sender, EventArgs e)
        {
            try
            {
                RequestSendChunilModel request = new RequestSendChunilModel()
                {
                    MAINNB = "92190000014",
                    BWCODE = "2000010",
                    JBDATE = "2022-02-03",
                    CHASEQ = 6,
                    GDSORD = "[택배봉투-도매][C1-21-02] [410] ( 100 * 20ea )",
                    GDSQNT = 1,
                    SWNAME = "로리스토어",
                    SWTEL1 = "010-9343-3978",
                    SWZPCD = "07531",
                    SWADDR = "서울특별시 강서구 허준로 217 (가양동, 가양테크노타운) 804-1호",
                    REMARK = "API 테스트",
                    SELCST = string.Empty,
                    JUMNAM = string.Empty,
                    JUMDAT = string.Empty,
                    JUMNUM = "C586497796039975",
                    PAYGBN = "신용",
                    CPGKEY = "A",
                    CHARGE = 2500,
                    MAINGB = "O", //(일반:O, 반품:R)
                    PRTDAT = String.Empty,
                    AREGBN = string.Empty,
                    GUBGBN = string.Empty,
                    SIDONG = string.Empty,
                    CUSTNM = string.Empty,
                    TELCST = string.Empty,
                    ADDRE1 = string.Empty,
                    MAINNM = string.Empty,
                    PRDATE = string.Empty,
                    CHASUM = 0,
                    REGDAT = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    PROGBN = "RDY", //필수(RDY) 등록 : RDY / 정상처리 : OK / 오류 : ERR
                    PRODAT = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    ERRNAM = string.Empty
                };


                string result = string.Empty;

                result = await HttpService.Instance.ChunilSendRequestAsync(HttpMethod.Post, "Send", request);

                if (result.StartsWith("ERROR"))
                {
                    Console.WriteLine("서버에 도착전 에러 :" + result);
                    //실패 로그 기록
                }
                else
                {
                    ResultModel response = JsonConvert.DeserializeObject<ResultModel>(result);
                    Console.WriteLine(response);

                    if (response.ResultCode == "00")
                    {
                        //정상처리
                        Console.WriteLine("");
                    }
                    else
                    {
                        //실패 로그 기록
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void btnChunilSendConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string result = string.Empty;

                RequestConfirmChunilModel request = new RequestConfirmChunilModel()
                {
                    JBDATE = "2022-01-26",
                    BWCODE = "2000010"
                };

                result = await HttpService.Instance.ChunilSendRequestAsync(HttpMethod.Post, "SendConfirm", request);

                if (result.StartsWith("ERROR"))
                {
                    Console.WriteLine("서버에 도착전 에러 :" + result);
                    //실패 로그 기록
                }
                else
                {
                    ResultModel response = JsonConvert.DeserializeObject<ResultModel>(result);
                    Console.WriteLine(response);

                    if (response.ResultCode == "00")
                    {
                        //정상처리
                        Console.WriteLine("");
                    }
                    else
                    {
                        //실패 로그 기록
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void btnChunilSendResult_Click(object sender, EventArgs e)
        {
            try
            {
                string result = string.Empty;

                RequestSendResultChunilModel request = new RequestSendResultChunilModel()
                {
                    MAINNB = "92190000001"
                };


                result = await HttpService.Instance.ChunilSendRequestAsync(HttpMethod.Post, "SendResult", request);

                if (result.StartsWith("ERROR"))
                {
                    Console.WriteLine("서버에 도착전 에러 :" + result);
                    //실패 로그 기록
                }
                else
                {
                    ResponseChunilResult response = JsonConvert.DeserializeObject<ResponseChunilResult>(result);
                    Console.WriteLine(response);

                    if (response.ResultCode == "00")
                    {
                        //정상처리
                        Console.WriteLine(response.Result);

                    }
                    else
                    {
                        //실패 로그 기록
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        PrintControl printControl1 = new PrintControl();

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            XtraReport report = XtraReport.FromFile(Path.Combine(path, "Repx/kdexp2.repx"), true);
            report.CreateDocument(true); //파라민터를 재 할당 해서 사용 가능, true로 해야 한다.

            printControl1.PrintingSystem = report.PrintingSystem;

            PrintBarManager printBarManager1 = new PrintBarManager();
            printBarManager1.Form = printControl1;
            printBarManager1.Initialize(printControl1);
            printBarManager1.MainMenu.Visible = false;
            printBarManager1.AllowCustomization = false;

            printControl1.PrintingSystem.SetCommandVisibility(new PrintingSystemCommand[]{
                PrintingSystemCommand.Open,
                PrintingSystemCommand.Save,
                PrintingSystemCommand.ClosePreview,
                PrintingSystemCommand.Customize,
                PrintingSystemCommand.SendCsv,
                PrintingSystemCommand.SendFile,
                PrintingSystemCommand.SendGraphic,
                PrintingSystemCommand.SendMht,
                PrintingSystemCommand.SendPdf,
                PrintingSystemCommand.SendRtf,
                PrintingSystemCommand.SendTxt,
                PrintingSystemCommand.SendXls
            }, CommandVisibility.None);

        }
    }
}
