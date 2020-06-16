using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_HOMEPAGE_COREBUSINESS
    {
        public decimal FF_HOMEPAGE_COREBUSINESS_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal PICTURE_FILE_ID { get; set; }
        public string BUSINESS_CNAME { get; set; }
        public string BUSINESS_ENAME { get; set; }
        public string CONTENT_CN { get; set; }
        public string CONTENT_EN { get; set; }
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
    }
}
