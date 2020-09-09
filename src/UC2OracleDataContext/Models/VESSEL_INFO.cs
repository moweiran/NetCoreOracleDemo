using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class VESSEL_INFO
    {
        public decimal VESSEL_INFO_ID { get; set; }
        public decimal? OWNER_ID { get; set; }
        public string OWNER_CODE { get; set; }
        public string OWNER_SHORTNAME { get; set; }
        public string OWNER_NAME { get; set; }
        public string VESSEL_CODE { get; set; }
        public string VESSEL_NAME_CN { get; set; }
        public string VESSEL_NAME_EN { get; set; }
        public string CALLSIGN { get; set; }
        public string IMO_CODE { get; set; }
        public string VESSEL_REG_PORT_CODE { get; set; }
        public string VESSEL_REG_PORT_NAME_CN { get; set; }
        public string VESSEL_REG_PORT_NAME_EN { get; set; }
        public string VESSEL_NATION_CODE { get; set; }
        public string VESSEL_NATION_NAME_CN { get; set; }
        public string VESSEL_NATION_NAME_EN { get; set; }
        public string VESSEL_TYPE_CODE { get; set; }
        public string VESSEL_TYPE_NAME { get; set; }
        public string VESSEL_CLASS_CODE { get; set; }
        public string VESSEL_CLASS_NAME { get; set; }
        public string GATE_CODE { get; set; }
        public string VESSEL_BUSI_TYPE_CODE { get; set; }
        public string VESSEL_BUSI_TYPE_NAME { get; set; }
        public string MMSI { get; set; }
        public string BUNTING { get; set; }
        public DateTime? PUT_DATE { get; set; }
        public string VESSEL_COMMAND_FULLNAME { get; set; }
        public string VESSEL_COMMAND_PHONE { get; set; }
        public decimal? TEUS { get; set; }
        public decimal? TEU_ONDESK { get; set; }
        public decimal? TEU_INCABIN { get; set; }
        public string MAIN_POWER { get; set; }
        public string SECOND_POWER { get; set; }
        public string ICEBOX_SOCKET { get; set; }
        public string SPEED { get; set; }
        public string TEN_ALL { get; set; }
        public string TEN_EMPTY { get; set; }
        public string TEN_CARGO { get; set; }
        public string MTCM { get; set; }
        public string SIZE_LENGTH { get; set; }
        public string SIZE_WIDTH { get; set; }
        public string SIZE_DEEP { get; set; }
        public string SIZE_DEEP_FULL { get; set; }
        public string SIZE_KEEL_HEIGHT { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
