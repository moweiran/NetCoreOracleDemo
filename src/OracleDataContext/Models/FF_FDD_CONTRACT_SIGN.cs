using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FDD_CONTRACT_SIGN
    {
        public string FF_FDD_CONTRACT_SIGN_ID { get; set; }
        public string TRANSACTION_ID { get; set; }
        public string CUSTOMER_ID { get; set; }
        public string CONTRACT_ID { get; set; }
        public string RESULT_CODE { get; set; }
        public string RESULT_DESC { get; set; }
        public string DOWNLOAD_URL { get; set; }
        public string VIEW_URL { get; set; }
        public decimal STATUS { get; set; }
        public DateTime? CREATE_DATETIME { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
    }
}
