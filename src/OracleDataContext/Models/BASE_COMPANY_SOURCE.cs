using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_SOURCE
    {
        public decimal COMPANY_SOURCE_ID { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string COMPANY_SHORTNAME { get; set; }
        public decimal COMPANY_CLASS { get; set; }
        public decimal SOURCE_TYPE { get; set; }
        public decimal? REF_ID { get; set; }
        public string REF_NO { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
