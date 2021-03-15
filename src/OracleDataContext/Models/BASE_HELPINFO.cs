using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_HELPINFO
    {
        public decimal HELPINFO_ID { get; set; }
        public decimal? HELP_CLASS_ID { get; set; }
        public string HELPINFO_TITLE { get; set; }
        public string KEY_WORD { get; set; }
        public string HELPINFO_CONTENT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? READ_NUMBER { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATEUSERID { get; set; }
        public string CREATEUSERNAME { get; set; }
        public string CREATEFULLNAME { get; set; }
        public decimal? CREATECOMPANYID { get; set; }
        public DateTime CREATEDATETIME { get; set; }

        public virtual BASE_HELP_CLASS HELP_CLASS { get; set; }
    }
}
