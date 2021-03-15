using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CARGOTRACKO_CONTAINERV3
    {
        public string KEYID { get; set; }
        public string FKEYID { get; set; }
        public string CTNRNO { get; set; }
        public string BLNO { get; set; }
        public string CURRENTNODE { get; set; }
        public DateTime? CURRENTNODETIME { get; set; }
        public DateTime? CREATETIME { get; set; }
        public DateTime? UPDATETIME { get; set; }
        public string CTNRSTATUSLISTJSONSTR { get; set; }
    }
}
