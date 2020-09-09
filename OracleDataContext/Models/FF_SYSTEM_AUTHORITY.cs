using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_SYSTEM_AUTHORITY
    {
        public decimal FF_SYSTEM_AUTHORITY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal SYSTEM_FUNCTION { get; set; }
        public decimal OPERATION_TYPE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime? CREATE_DATETIME { get; set; }
    }
}
