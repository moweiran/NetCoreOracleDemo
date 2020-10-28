using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class ff_class_set
    {
        public long FF_CLASS_SET_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public string CARRIER_NAME { get; set; }
        public long CARRIER_ID_SALE { get; set; }
        public string CARRIER_CODE_SALE { get; set; }
        public string CARRIER_NAME_SALE { get; set; }
        public long ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public string ROUTE_NAME { get; set; }
        public int ROUTE_CLASS_CODE { get; set; }
        public string ROUTE_CLASS_NAME { get; set; }
        public string REMARK { get; set; }
        public int? STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
