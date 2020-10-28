using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class base_role_permission
    {
        public string BASE_ROLE_PERMISSION_ID { get; set; }
        public long BASE_ROLE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string PERMISSION_KEY { get; set; }
        public int PERMISSION { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
