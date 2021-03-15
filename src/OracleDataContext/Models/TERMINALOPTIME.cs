using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class TERMINALOPTIME
    {
        public string KEYID { get; set; }
        public string FKEYID { get; set; }
        public string VSLCD { get; set; }
        public string VSLNAME { get; set; }
        public string VSLNAMECN { get; set; }
        public string VOYIN { get; set; }
        public string VOYOUT { get; set; }
        public string SERVICECD { get; set; }
        public string SERVICENAME { get; set; }
        public string CARRIERCD { get; set; }
        public string CARRIER { get; set; }
        public string TERMINALCD { get; set; }
        public string TERMINAL { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ATA { get; set; }
        public DateTime? ATD { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? CYOPENTIME { get; set; }
        public DateTime? FUMIGATIONTIME { get; set; }
        public DateTime? CYCLOSETIME { get; set; }
        public DateTime? CUSTOMCUTOFFTIME { get; set; }
        public DateTime? CYCUTOFFTIME { get; set; }
        public DateTime? CARRIAGECUTOFFTIME { get; set; }
        public DateTime? CUTOFFTIME { get; set; }
        public string REMARKS { get; set; }
        public DateTime? CREATETIME { get; set; }
        public DateTime? UPDATETIME { get; set; }
        public string BERTHNO { get; set; }
    }
}
