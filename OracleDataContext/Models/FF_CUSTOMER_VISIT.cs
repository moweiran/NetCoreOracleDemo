using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_CUSTOMER_VISIT
    {
        public decimal FF_CUSTOMER_VISIT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal VISIT_TYPE { get; set; }
        public DateTime VISIT_DATE { get; set; }
        public string VISIT_SUBJECT { get; set; }
        public string CONTACTS { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string VISIT_CONTENT { get; set; }
        public decimal? MANAGER_USERID { get; set; }
        public string MANAGER_FULLNAME { get; set; }
        public DateTime? MANAGER_DATE { get; set; }
        public string MANAGER_REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
