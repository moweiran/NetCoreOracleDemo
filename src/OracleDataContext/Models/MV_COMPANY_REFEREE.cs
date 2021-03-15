using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_COMPANY_REFEREE
    {
        public decimal? FF_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string CONTACTS { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string ADDRESS { get; set; }
        public decimal? STATUS { get; set; }
        public bool? IS_CERTIFICATION { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal USER_ID { get; set; }
        public string USERNAME { get; set; }
        public string FULLNAME { get; set; }
        public decimal? REFEREE_ID { get; set; }
        public string REFEREE_CODE { get; set; }
        public string REFEREE_NAME_CN { get; set; }
        public string REFEREE_NAME_EN { get; set; }
        public string REFEREE_CONTACTS { get; set; }
        public string REFEREE_CONTACT_PHONE { get; set; }
        public string REFEREE_EMAIL { get; set; }
        public string REFEREE_FAX { get; set; }
        public string REFEREE_ADDRESS { get; set; }
        public decimal? REFEREE_STATUS { get; set; }
        public bool? REFEREE_IS_CERTIFICATION { get; set; }
    }
}
