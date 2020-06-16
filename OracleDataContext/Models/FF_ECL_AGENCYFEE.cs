using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_AGENCYFEE
    {
        public FF_ECL_AGENCYFEE()
        {
            FF_ECL_AGENCYFEE_PRODUCT = new HashSet<FF_ECL_AGENCYFEE_PRODUCT>();
        }

        public decimal FF_ECL_AGENCYFEE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string SERVICES_PROJECT { get; set; }
        public string FEE { get; set; }
        public string CURRENCY { get; set; }
        public string PPCC { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual ICollection<FF_ECL_AGENCYFEE_PRODUCT> FF_ECL_AGENCYFEE_PRODUCT { get; set; }
    }
}
