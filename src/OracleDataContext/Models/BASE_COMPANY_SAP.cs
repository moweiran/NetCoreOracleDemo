using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_SAP
    {
        public decimal ID { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string SAPFTPSERVERIP { get; set; }
        public string SAPFTPUSERID { get; set; }
        public string SAPFTPUSERPWD { get; set; }
    }
}
