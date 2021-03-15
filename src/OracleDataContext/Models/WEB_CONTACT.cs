using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class WEB_CONTACT
    {
        public decimal WEB_CONTACT_ID { get; set; }
        public decimal? REF_TYPE { get; set; }
        public decimal? REF_ID { get; set; }
        public string TITLECN { get; set; }
        public string TITLEEN { get; set; }
        public string CONTACT_NAMECN { get; set; }
        public string CONTACT_NAMEEN { get; set; }
        public string TEL { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string ADDRESS { get; set; }
        public string CATEGORYCN { get; set; }
        public string CATEGORYEN { get; set; }
        public decimal? SEQENCE { get; set; }
        public bool? MAIN_CONTACT { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
    }
}
