using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_HELP_CLASS
    {
        public BASE_HELP_CLASS()
        {
            BASE_HELPINFO = new HashSet<BASE_HELPINFO>();
        }

        public decimal HELP_CLASS_ID { get; set; }
        public decimal PARENT_ID { get; set; }
        public string CLASS_NAME_CN { get; set; }
        public string CLASS_NAME_EN { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATEUSERID { get; set; }
        public string CREATEUSERNAME { get; set; }
        public string CREATEFULLNAME { get; set; }
        public decimal? CREATECOMPANYID { get; set; }
        public DateTime CREATEDATETIME { get; set; }

        public virtual ICollection<BASE_HELPINFO> BASE_HELPINFO { get; set; }
    }
}
