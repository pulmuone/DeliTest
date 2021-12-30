using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Services
{
    public class HttpTrackingService
    {
        private static readonly HttpTrackingService instance = new HttpTrackingService();

        private string CONNECT_URL = string.Empty;

        public static HttpTrackingService Instance
        {
            get
            {
                return instance;
            }
        }

        public HttpTrackingService()
        {
#if DEBUG
            CONNECT_URL = "http://kdtracking.kditlab.com/tracking";
#else
            CONNECT_URL = "";
#endif
        }

        public async Task<string> SendRequestAsync(HttpMethod httpMethod, string barcode)
        {
            string result = string.Empty;
                    
            try
            {
                using (var request = new HttpRequestMessage(httpMethod, new Uri(string.Format("{0}?barcode={1}", CONNECT_URL, barcode))))
                {
                    request.Headers.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                    request.Headers.TryAddWithoutValidation("kdexp-secret", "6276CB47D8D244E6885ECC87D862F4F6");

                    using (var handler = new HttpClientHandler())
                    {
                        using (var client = new HttpClient(handler))
                        {
                            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));//ACCEPT header, 수신 데이터
                            //client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("UTF-8"));

                            Console.WriteLine(client.Timeout.ToString());
                            //client.Timeout = new TimeSpan(0, 3, 0); //3분
                            using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseContentRead))
                            {
                                var content = response.Content == null
                                    ? null
                                    : await response.Content.ReadAsStringAsync();
                                //: Encoding.UTF8.GetString(Convert.FromBase64String(await response.Content.ReadAsStringAsync()));

                                if (response.IsSuccessStatusCode)
                                {
                                    result = content;
                                }
                                else
                                {
                                    result = content;
                                }
                            }

                            return result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //var properties = new Dictionary<string, string>
                //{
                //    {"BaseHttpService", "SendRequestAsync" },
                //    {"UserID", Settings.Userid}
                //};

                return "ERROR " + ex.Message.ToString();
            }
        }

        public async Task<string> SendRequestAsync2(HttpMethod httpMethod, string barcode)
        {
            string result = string.Empty;

            try
            {
                StringBuilder sbUrl = new StringBuilder();
                sbUrl.Append(CONNECT_URL);
                sbUrl.Append(string.Format("?barcode={0}", barcode));

                WebClient wc = new WebClient();
                wc.Headers.Add("Content-Type", "application/json");
                wc.Headers.Add("kdexp-secret", "6276CB47D8D244E6885ECC87D862F4F6");

                result = await wc.DownloadStringTaskAsync(sbUrl.ToString());

            }
            catch (Exception ex)
            {
                //var properties = new Dictionary<string, string>
                //{
                //    {"BaseHttpService", "SendRequestAsync" },
                //    {"UserID", Settings.Userid}
                //};

                return "ERROR " + ex.Message.ToString();
            }

            return result;
        }
    }
}
