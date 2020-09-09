using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class CUSTOMCLEARING
    {
        public string KEYID { get; set; }
        public string DECLARATIONNO { get; set; }
        public string STATUS { get; set; }
        public string STATUSCD { get; set; }
        public DateTime? UPDATETIME { get; set; }
        public string CCHISTORICALLINKSTR { get; set; }
    }
}
