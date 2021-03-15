using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CARGOTRACKO_BLV3
    {
        public string KEYID { get; set; }
        public string BLPREFIX { get; set; }
        public string REFERENCENO { get; set; }
        public string BLNO { get; set; }
        public string BKGNO { get; set; }
        public string TRFSNO { get; set; }
        public string CTNRNO { get; set; }
        public bool? ISCTNR { get; set; }
        public string BKGVOLUMN { get; set; }
        public string CARRIERCD { get; set; }
        public string CARRIER { get; set; }
        public string CURRENTNODEPLACE { get; set; }
        public DateTime? CURRENTNODETIME { get; set; }
        public string CURRENTNODE { get; set; }
        public DateTime? UPDATETIME { get; set; }
        public DateTime? CREATETIME { get; set; }
        public DateTime? ENDTIME { get; set; }
        public string POL { get; set; }
        public string DTP { get; set; }
        public string TERMINALCD { get; set; }
        public string TERMINAL { get; set; }
        public string VSLNAME { get; set; }
        public string VOY { get; set; }
        public string DECLARATIONNO { get; set; }
        public string CURRENTVSLNAME { get; set; }
        public string CURRENTVOY { get; set; }
        public string DEPOTCD { get; set; }
        public string DEPOT { get; set; }
        public DateTime? EPRLTIME { get; set; }
        public DateTime? STSPTIME { get; set; }
        public string STSPPLACE { get; set; }
        public DateTime? FCGITIME { get; set; }
        public DateTime? CGGITIME { get; set; }
        public DateTime? CLOADTIME { get; set; }
        public DateTime? CYTCTIME { get; set; }
        public string CYTCPLACE { get; set; }
        public DateTime? GITMTIME { get; set; }
        public string GITMPLACE { get; set; }
        public DateTime? PASSTIME { get; set; }
        public string PASSPLACE { get; set; }
        public bool? ISPASS { get; set; }
        public bool? ISPRELOAD { get; set; }
        public DateTime? DLPTTIME { get; set; }
        public DateTime? ETDPOL { get; set; }
        public string DLPTPLACE { get; set; }
        public DateTime? LOBDTIME { get; set; }
        public string LOBDPLACE { get; set; }
        public DateTime? TRSPTIME { get; set; }
        public string TRSPPLACE { get; set; }
        public DateTime? DSCHTIME { get; set; }
        public string DSCHPLACE { get; set; }
        public DateTime? ETAPLD { get; set; }
        public string TERMINALPLD { get; set; }
        public DateTime? STCSTIME { get; set; }
        public string STCSPLACE { get; set; }
        public DateTime? RCVETIME { get; set; }
        public string RCVEPLACE { get; set; }
        public bool? ISTMPS { get; set; }
        public DateTime? TMPSTIME { get; set; }
        public string SCHEDULELISTJSONSTR { get; set; }
    }
}
