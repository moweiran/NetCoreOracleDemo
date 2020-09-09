using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_MESSAGE
    {
        public decimal MESSAGE_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_NAME { get; set; }
        public string NOTIFIER { get; set; }
        public string NOTIFIER_NAME { get; set; }
        public string MESSAGE_TYPE { get; set; }
        public string MESSAGE_TITLE { get; set; }
        public string MESSAGE_CONTENT { get; set; }
        public string PARAMETER { get; set; }
        public decimal? PARAMETER1 { get; set; }
        public decimal? PARAMETER2 { get; set; }
        public decimal? PARAMETER3 { get; set; }
        public decimal? PARAMETER4 { get; set; }
        public decimal? PARAMETER5 { get; set; }
        public string RESPONSE { get; set; }
        public bool? CONFIRM { get; set; }
        public decimal? Order { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public string CREATER { get; set; }
        public string CREATER_NAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public decimal? READ_TIME { get; set; }
        public DateTime? READ_DATE { get; set; }
        public DateTime? CONFIRM_DATE { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
    }
}
