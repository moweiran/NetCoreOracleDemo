using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_HOMEPAGE_MENU
    {
        public decimal FF_HOMEPAGE_MENU_ID { get; set; }
        public string MENU_CNAME { get; set; }
        public string MENU_ENAME { get; set; }
        public string PAGE_CONTENT { get; set; }
        public decimal FF_ID { get; set; }
        public decimal UI_INDEX { get; set; }
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
        public bool? IS_SHOW { get; set; }
        public string PAGE_CODE { get; set; }
        public string PAGE_CONTENT_EN { get; set; }
    }
}
