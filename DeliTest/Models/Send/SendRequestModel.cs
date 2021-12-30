using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.Send
{
    public class SendRequestModel
    {
        [JsonProperty(Required = Required.Always)]
        public string API_KEY { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(13)]
        public string PD_BARCODE { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(30)]
        public string COM_NM { get; set; }
        [JsonProperty(Required = Required.Default)]
        public string BR_END_NM { get; set; }
        [JsonProperty(Required = Required.Always)]
        [MaxLength(50)]
        public string SEND_NM { get; set; }
        [JsonProperty(Required = Required.Always)]
        [MaxLength(14)]
        public string SEND_TEL1 { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(14)]
        public string SEND_TEL2 { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(5)]
        public string SEND_ZIPCODE { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(60)]
        public string SEND_ADDR1 { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(64)]
        public string SEND_ADDR2 { get; set; }
        [JsonProperty(Required = Required.Always)]
        [MaxLength(50)]
        public string RECV_NM { get; set; }
        [JsonProperty(Required = Required.Always)]
        [MaxLength(14)]
        public string RECV_TEL1 { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(14)]
        public string RECV_TEL2 { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(5)]
        public string RECV_ZIPCODE { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(60)]
        public string RECV_ADDR1 { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(64)]
        public string RECV_ADDR2 { get; set; }
        [JsonProperty(Required = Required.Always)]
        [MaxLength(50)]
        public string PD_NM { get; set; }
        [JsonProperty(Required = Required.Always)]
        [MaxLength(30)]
        public string PD_PACK { get; set; }
        [JsonProperty(Required = Required.Always)]
        public int PD_DELI_PAY { get; set; }
        [JsonProperty(Required = Required.Always)]
        [MaxLength(6)]
        public string PD_DELI_GUBUN { get; set; }
        [JsonProperty(Required = Required.Always)]
        public int PD_CNT { get; set; }
        [JsonProperty(Required = Required.Always)]
        [MaxLength(850)]
        public string PD_PRICE { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(850)]
        public string PD_WEIGHT { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(850)]
        public string PD_VOLUME { get; set; }
        [JsonProperty(Required = Required.Default)]
        [MaxLength(300)]
        public string PD_MEMO { get; set; }
    }
}
