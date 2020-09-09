using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_SPREAD_BOX
    {
        public decimal BASE_SPREAD_BOX_ID { get; set; }
        public decimal BASE_SPREAD_ID { get; set; }
        public decimal BOX_TYPE { get; set; }
        public string BACK_COLOR { get; set; }
        public decimal? FILE_ID { get; set; }
        public string TITLE_CN { get; set; }
        public string TITLE_EN { get; set; }
        public decimal? TITLE_SIZE { get; set; }
        public string TITLE_COLOR { get; set; }
        public string CONTENT_CN { get; set; }
        public string CONTENT_EN { get; set; }
        public decimal? CONTENT_SIZE { get; set; }
        public string CONTENT_COLOR { get; set; }
        public string BUTTON_CN { get; set; }
        public string BUTTON_EN { get; set; }
        public string BUTTON_BACK_COLOR { get; set; }
        public string BUTTON_COLOR { get; set; }
        public decimal? BUTTON_SIZE { get; set; }
        public string CLICK_PATH_CN { get; set; }
        public string CLICK_PATH_EN { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? EN_FILE_ID { get; set; }
        public decimal SHOW_TYPE { get; set; }
        public string BACK_COLOR_END { get; set; }
        public bool? IS_GRADIENT { get; set; }
    }
}
