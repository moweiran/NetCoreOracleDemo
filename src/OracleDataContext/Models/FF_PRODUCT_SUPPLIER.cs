using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_PRODUCT_SUPPLIER
    {
        public decimal FF_PRODUCT_SUPPLIER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal SUPPLIER_ID { get; set; }
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
        public decimal SUPPLIER_TYPE { get; set; }
        public decimal? SALES_GP20_ADD { get; set; }
        public decimal? SALES_GP40_ADD { get; set; }
        public decimal? SALES_HQ40_ADD { get; set; }
        public decimal? SALES_GP45_ADD { get; set; }
        public decimal PRODUCT_SOURCE { get; set; }
    }
}
