﻿using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_USER_RIGHT
    {
        public decimal USER_RIGHT_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal PLATFORM { get; set; }
        public decimal? APPLICATION_ROLE_ID { get; set; }
        public decimal USER_ID { get; set; }
        public decimal? ORGANIZATION_ID { get; set; }
        public decimal? ORGANIZATION_RIGHT_ID { get; set; }
        public decimal? USERROLE_RIGHT_ID { get; set; }
        public decimal? USERGROUP_RIGHT_ID { get; set; }
        public decimal PERMISSION_TYPE { get; set; }
        public decimal MODULE_ID { get; set; }
        public decimal? MENU_ID { get; set; }
        public decimal? BUTTON_ID { get; set; }
        public decimal? AUTHORIZE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }

        public virtual BASE_ORGANIZATION_RIGHT ORGANIZATION_RIGHT_ { get; set; }
        public virtual BASE_USERGROUP_RIGHT USERGROUP_RIGHT_ { get; set; }
        public virtual BASE_USERROLE USERROLE_RIGHT_ { get; set; }
        public virtual BASE_USERINFO USER_ { get; set; }
    }
}
