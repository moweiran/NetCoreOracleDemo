using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_PERSON
    {
        public decimal PERSON_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string FULLNAME_EN { get; set; }
        public string FULLNAME_CN { get; set; }
        public string PICTURE { get; set; }
        public string GENDER { get; set; }
        public string IDCARD_TYPE { get; set; }
        public string IDCARD_NO { get; set; }
        public string MOBILE { get; set; }
        public string EMAIL { get; set; }
        public string NATIONALITY { get; set; }
        public string COUNTRY { get; set; }
        public string PROVINCE { get; set; }
        public string CITY { get; set; }
        public string ADDRESS { get; set; }
        public string REMARK { get; set; }
        public bool? CONFIRM_IDCARD { get; set; }
        public bool? CONFIRM_MOBILE { get; set; }
        public bool? CONFIRM_EMAIL { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
