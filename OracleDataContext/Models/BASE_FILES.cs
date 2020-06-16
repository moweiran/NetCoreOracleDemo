using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_FILES
    {
        public decimal FILE_ID { get; set; }
        public decimal FILE_TYPE { get; set; }
        public decimal COMPANY_ID { get; set; }
        public decimal? REF_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_PATH { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public bool? DELETE_MARK { get; set; }
        public string THUMB_PATH { get; set; }
        public decimal? FF_ID { get; set; }
        public string TITLE_CN { get; set; }
        public string TITLE_EN { get; set; }
        public string CONTENT_CN { get; set; }
        public string CONTENT_EN { get; set; }
        public string ETAG { get; set; }
    }
}
