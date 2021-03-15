using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_RECRUITMENT
    {
        public decimal RECRUITMENT_ID { get; set; }
        public string POSITION_NAME { get; set; }
        public string RESPONSIBILITY { get; set; }
        public string REQUIREMENT { get; set; }
        public decimal PERSON_NUM { get; set; }
        public string DEPARTMENT { get; set; }
        public string PLACE { get; set; }
        public DateTime PUBLISH_DATE { get; set; }
        public DateTime EXPIRY_DATE { get; set; }
        public string CONTACT { get; set; }
        public string CONTACT_TEL { get; set; }
        public string EMAIL { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
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
        public decimal LANGUAGE_TYPE { get; set; }
    }
}
