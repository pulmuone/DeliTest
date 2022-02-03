using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Services
{
    public class HttpService
    {
        private static readonly HttpService instance = new HttpService();

        private string CONNECT_URL = string.Empty;

        public static HttpService Instance
        {
            get
            {
                return instance;
            }
        }

        public HttpService()
        {
#if DEBUG
            CONNECT_URL = "https://kdapi.kditlab.com:444";
#else
            CONNECT_URL = @"/PRD";
#endif
        }

        public async Task<string> SendRequestAsync(HttpMethod httpMethod, string path, object requestData = null)
        {
            string result = string.Empty;


            // Serialize request data
            var data = requestData == null
                ? null
                : JsonConvert.SerializeObject(requestData);

            try
            {
                using (var request = new HttpRequestMessage(httpMethod, new Uri(string.Format("{0}{1}", CONNECT_URL, path))))
                {
                    if (data != null)
                    {
                        request.Headers.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                        //request.Content = new StringContent(Convert.ToBase64String(Encoding.UTF8.GetBytes(data)), Encoding.UTF8, "application/json"); //CONTENT-TYPE header, 발신 데이터
                        request.Content = new StringContent(data, Encoding.UTF8, "application/json"); //CONTENT-TYPE header, 발신 데이터
                    }

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

        private int retryCount = 3;
        private readonly TimeSpan delay = TimeSpan.FromSeconds(3);

        public async Task<string> ChunilSendRequestAsync(HttpMethod httpMethod, string path, object requestData = null)
        {
            string result = string.Empty;


            // Serialize request data
            var data = requestData == null
                ? null
                : JsonConvert.SerializeObject(requestData);

            int currentRetry = 0;

            for (; ; )
            {
                try
                {
                    using (var request = new HttpRequestMessage(httpMethod, new Uri(string.Format("{0}{1}", "http://localhost:25000/api/Chunil/", path))))
                    {
                        if (data != null)
                        {
                            request.Headers.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                            //request.Content = new StringContent(Convert.ToBase64String(Encoding.UTF8.GetBytes(data)), Encoding.UTF8, "application/json"); //CONTENT-TYPE header, 발신 데이터
                            request.Content = new StringContent(data, Encoding.UTF8, "application/json"); //CONTENT-TYPE header, 발신 데이터
                        }

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
                    
                    Trace.TraceError("Operation Exception");
                    result = string.Format("{0} {1} {2}", "ERROR ", ex.Message.ToString(), ex.InnerException.Message.ToString());
                    currentRetry++;

                    //if (currentRetry > this.retryCount || !IsTransient(ex))
                    if (currentRetry > this.retryCount)
                    {
                        // If this isn't a transient error or we shouldn't retry,
                        // rethrow the exception.
                        return result;
                    }
                }

                await Task.Delay(delay);
            }            
        }

        private bool IsTransient(Exception ex)
        {
            // Determine if the exception is transient.
            // In some cases this is as simple as checking the exception type, in other
            // cases it might be necessary to inspect other properties of the exception.
            //if (ex is OperationTransientException)
            //    return true;

            var webException = ex as WebException;
            if (webException != null)
            {
                Console.WriteLine(webException.Status);
                // If the web exception contains one of the following status values
                // it might be transient.
                return new[] {WebExceptionStatus.ConnectionClosed,
                  WebExceptionStatus.Timeout,
                  WebExceptionStatus.RequestCanceled }.Contains(webException.Status);
            }

            // Additional exception checking logic goes here.
            return false;
        }
    }
}
