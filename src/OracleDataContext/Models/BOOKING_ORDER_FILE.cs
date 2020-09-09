using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BOOKING_ORDER_FILE
    {
        public decimal BOOKING_ORDER_FILE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal FILE_TYPE { get; set; }
        public decimal FILE_ID { get; set; }
        public bool CUSTOMER_VIEW { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public bool? PLATFORM_VIEW { get; set; }
    }
}
