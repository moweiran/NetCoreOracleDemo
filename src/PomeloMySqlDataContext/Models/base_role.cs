using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class base_role
    {
        public long BASE_ROLE_ID { get; set; }
        public string ROLENAMECN { get; set; }
        public string ROLENAMEEN { get; set; }
        public long CARRIER_ID { get; set; }
        public bool USE_DEFAULT { get; set; }
        public string REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
