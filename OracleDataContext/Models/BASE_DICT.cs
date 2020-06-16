using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_DICT
    {
        public decimal DICT_ID { get; set; }
        public string DICT_TYPE { get; set; }
        public string DICT_DESC { get; set; }
        public string DICT_CODE { get; set; }
        public string DICT_NAME_EN { get; set; }
        public string DICT_NAME_CN { get; set; }
        public string DICT_NAME_BIG5 { get; set; }
        public bool? VALID { get; set; }
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
        public string DICT_RESTRICTION { get; set; }
    }
}
