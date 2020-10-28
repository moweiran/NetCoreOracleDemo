using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class ow_surcharge
    {
        public long OW_SURCHARGE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public long POL_ID { get; set; }
        public int OW_TYPE { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
