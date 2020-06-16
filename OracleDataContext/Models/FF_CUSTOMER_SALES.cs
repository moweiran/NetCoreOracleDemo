using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_CUSTOMER_SALES
    {
        public decimal FF_CUSTOMER_SALES_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal SALES_ID { get; set; }
        public bool ISOWNER { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal ROUTE_AREA_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATEUSERID { get; set; }
        public string CREATEUSERNAME { get; set; }
        public string CREATEFULLNAME { get; set; }
        public decimal? CREATECOMPANYID { get; set; }
        public DateTime CREATEDATETIME { get; set; }
        public decimal? FF_ID { get; set; }
    }
}
