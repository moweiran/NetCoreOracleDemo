using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class CUSTOMER_SCN
    {
        public decimal CUSTOMER_SCN_ID { get; set; }
        public decimal SCN_TYPE { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string SCN_NAME { get; set; }
        public string ADDRESS { get; set; }
        public string TEL { get; set; }
        public string FAX { get; set; }
        public string CONTACTS { get; set; }
        public string EMAIL { get; set; }
        public bool? IS_DEFAULT { get; set; }
        public string BILL_DESC { get; set; }
        public string CONSIGNOR_REMARK { get; set; }
        public decimal? USERS { get; set; }
        public DateTime? LAST_USE_TIME { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
