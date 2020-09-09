using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class MULTI_LANGUAGE
    {
        public decimal MULTI_LANGUAGE_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal PLATFORM { get; set; }
        public decimal RESOURCE_TYPE { get; set; }
        public string RESOURCE_CODE { get; set; }
        public string ENGLISH { get; set; }
        public string GBK { get; set; }
        public string BIG5 { get; set; }
        public string FRENCH { get; set; }
        public string SPANISH { get; set; }
        public string PORTUGUESE { get; set; }
        public string ARABIC { get; set; }
        public string JAPANESE { get; set; }
        public string GERMAN { get; set; }
        public string KOREAN { get; set; }
        public string LATIN { get; set; }
        public decimal DELETE_MARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
