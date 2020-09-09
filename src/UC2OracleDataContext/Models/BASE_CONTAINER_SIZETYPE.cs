using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_CONTAINER_SIZETYPE
    {
        public decimal CONTAINER_SIZETYPE_ID { get; set; }
        public string ISO_CODE { get; set; }
        public string CONTAINER_CODE { get; set; }
        public string CONTAINER_NAME { get; set; }
        public string CONTAINER_SIZE { get; set; }
        public decimal CONTAINER_TYPE { get; set; }
        public decimal TEU { get; set; }
        public decimal? UIINDEX { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public decimal? CREATE_COMPANY_ID { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
