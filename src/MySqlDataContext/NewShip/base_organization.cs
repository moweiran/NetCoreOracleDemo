using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class base_organization
    {
        public long ORGANIZATION_ID { get; set; }
        public long? COMPANY_ID { get; set; }
        public string ORGANIZATION_CODE { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string CONTACTS { get; set; }
        public string PHONE { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string POSTCODE { get; set; }
        public string ADDRESS { get; set; }
        public long? PARENT_ID { get; set; }
        public string ORGANIZATION_REMARK { get; set; }
        public int? USERS { get; set; }
        public int? SEQUENCE { get; set; }
        public string SEQUENCE_STRING { get; set; }
        public bool? DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? TOP_ORGANIZATION_ID { get; set; }
        public long? CARRIER_ID { get; set; }
    }
}
