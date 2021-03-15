using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CTNRDYNAMIC
    {
        public string KEYID { get; set; }
        public string FKEYID { get; set; }
        public string CTNRNO { get; set; }
        public string BLNO { get; set; }
        public string TRUCKNO { get; set; }
        public DateTime? IETIME { get; set; }
        public string IEID { get; set; }
        public string IEGATE { get; set; }
        public string OWNER { get; set; }
        public string VSLNAME { get; set; }
        public string VOY { get; set; }
        public string TRAILER { get; set; }
        public string CNTRDYNAMIC { get; set; }
        public string EFID { get; set; }
        public string TERMINALCD { get; set; }
        public string TERMINAL { get; set; }
        public string CSIZE { get; set; }
        public string CTYPE { get; set; }
        public string SLOT { get; set; }
        public string SEALNO { get; set; }
        public string EIRNO { get; set; }
        public string AVDM { get; set; }
        public string PIECES { get; set; }
        public string GROSSWGT { get; set; }
        public string VOLUME { get; set; }
        public DateTime? UPDATETIME { get; set; }
        public DateTime? CREATETIME { get; set; }
        public string CUSTOMSTATUS { get; set; }
        public string TERMINALSTATUS { get; set; }
        public string FEE { get; set; }
        public string POUNDWGT { get; set; }
        public string VGM { get; set; }
        public string NETWGT { get; set; }
        public string INSPECTIONSTATUS { get; set; }
    }
}
