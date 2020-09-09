using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_AIR_LINERTRACK
    {
        public string KEYID { get; set; }
        public string FKEYID { get; set; }
        public string AWBNO { get; set; }
        public string FLIGHTNO { get; set; }
        public string ORG { get; set; }
        public string ORGCD { get; set; }
        public string DST { get; set; }
        public string DSTCD { get; set; }
        public string CARRIERCD { get; set; }
        public string CARRIER { get; set; }
        public string AWBNO2 { get; set; }
        public string CARRIERCD2 { get; set; }
        public string CARRIER2 { get; set; }
        public string AWBNO3 { get; set; }
        public string CARRIERCD3 { get; set; }
        public string CARRIER3 { get; set; }
        public string CURRENTNODE { get; set; }
        public DateTime? CURRENTNODETIME { get; set; }
        public string CURRENTNODEPLACE { get; set; }
        public DateTime? UPDATETIME { get; set; }
        public DateTime? CREATETIME { get; set; }
        public string ISBOOKING { get; set; }
        public string ISENDFORCE { get; set; }
        public DateTime? ENDTIME { get; set; }
    }
}
