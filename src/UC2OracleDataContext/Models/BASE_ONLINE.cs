using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_ONLINE
    {
        public decimal ONLINE_ID { get; set; }
        public decimal PLATFORM { get; set; }
        public string TOKEN { get; set; }
        public string USERNAME { get; set; }
        public string FULLNAME { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public string LOGIN_IP { get; set; }
        public DateTime? LOGIN_TIME { get; set; }
        public DateTime? REFRESH_TIME { get; set; }
        public string LOGIN_IP_ADDRESS { get; set; }
        public string LAST_URL { get; set; }
    }
}
