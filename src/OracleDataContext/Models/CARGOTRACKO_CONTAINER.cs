using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CARGOTRACKO_CONTAINER
    {
        public string KEY_ID { get; set; }
        public string B_KEY_ID { get; set; }
        public string V_KEY_ID { get; set; }
        public string CON_NO { get; set; }
        public string SEAL_NO { get; set; }
        public string CSIZE { get; set; }
        public string CTYPE { get; set; }
        public string CTNRTYPE { get; set; }
        public string PKGS { get; set; }
        public string GWGT { get; set; }
        public string VGM { get; set; }
        public string CURRENT_STATUS { get; set; }
        public DateTime? CURRENT_DATE { get; set; }
        public string CURRENT_STATION { get; set; }
        public DateTime? UPDATE_TIME { get; set; }
        public string STATUSJSONSTR { get; set; }
    }
}
