using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_HOMEPAGE
    {
        public decimal FF_HOMEPAGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string PICTURE_PATH { get; set; }
        public string COMPANY_DESCRIBE { get; set; }
        public decimal? TEMPLATE_ID { get; set; }
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
        public decimal? PICTURE_FILE_ID { get; set; }
        public string COMPANY_DESCRIBE_EN { get; set; }
    }
}
