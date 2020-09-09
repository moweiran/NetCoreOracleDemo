using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_LOGINLOG
    {
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_KEY { get; set; }
        public string APPLICATION_CODE { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal PLATFORM { get; set; }
        public decimal LOGIN_LOG_ID { get; set; }
        public string LOGIN_IP { get; set; }
        public DateTime? LOGIN_TIME { get; set; }
        public string LOGIN_ACCOUNT { get; set; }
        public decimal? LOGIN_STATUS { get; set; }
        public string OWNER_ADDRESS { get; set; }
        public string OS { get; set; }
        public string CLIENT_VERSION { get; set; }
        public decimal? WIDTH { get; set; }
        public decimal? HEIGHT { get; set; }
    }
}
