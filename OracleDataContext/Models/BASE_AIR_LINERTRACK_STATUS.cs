using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_AIR_LINERTRACK_STATUS
    {
        public string KEYID { get; set; }
        public string FKEYID { get; set; }
        public string AWBNO { get; set; }
        public string STATUSCD { get; set; }
        public DateTime? STATUSTIME { get; set; }
        public string STATUSPLACE { get; set; }
        public string FLIGHTNO { get; set; }
        public string ISEST { get; set; }
        public DateTime? CREATETIME { get; set; }
        public DateTime? UPDATETIME { get; set; }
    }
}
