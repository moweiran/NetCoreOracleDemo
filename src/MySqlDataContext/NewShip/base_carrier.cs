using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class base_carrier
    {
        public long CARRIER_ID { get; set; }
        public string CARRIER_SHOT_CODE { get; set; }
        public string CARRIER_CODE { get; set; }
        public string CARRIER_NAME { get; set; }
        public string CARRIER_FULLNAME { get; set; }
        public string LOGO { get; set; }
        public string DOMAIN { get; set; }
        public string WEBSITE { get; set; }
        public int FREE_USE_DAY { get; set; }
        public string REMARK { get; set; }
        public bool VALID { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? MODIFY_COMPANYID { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? CREATE_COMPANYID { get; set; }
        public int? VOYAGE_MODE { get; set; }
        public int PRESALE_MODE { get; set; }
        public bool? IS_OFFICIAL { get; set; }
        public string SEQUENCE_STRING { get; set; }
        public int? SCHEDULE_MODE { get; set; }
        public byte SCHEDULE_MANUAL { get; set; }
        public bool NEED_EXTEND { get; set; }
    }
}
