using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class newshipContext : DbContext
    {
        public newshipContext()
        {
        }

        public newshipContext(DbContextOptions<newshipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<b_product_sucharge> b_product_sucharge { get; set; }
        public virtual DbSet<b_products> b_products { get; set; }
        public virtual DbSet<base_carrier> base_carrier { get; set; }
        public virtual DbSet<base_company> base_company { get; set; }
        public virtual DbSet<base_organization> base_organization { get; set; }
        public virtual DbSet<base_role> base_role { get; set; }
        public virtual DbSet<base_role_permission> base_role_permission { get; set; }
        public virtual DbSet<base_userinfo> base_userinfo { get; set; }
        public virtual DbSet<base_zone> base_zone { get; set; }
        public virtual DbSet<base_zone_detail> base_zone_detail { get; set; }
        public virtual DbSet<booking_order> booking_order { get; set; }
        public virtual DbSet<booking_order_approver> booking_order_approver { get; set; }
        public virtual DbSet<booking_order_container> booking_order_container { get; set; }
        public virtual DbSet<booking_order_presale> booking_order_presale { get; set; }
        public virtual DbSet<booking_order_rate> booking_order_rate { get; set; }
        public virtual DbSet<booking_order_so> booking_order_so { get; set; }
        public virtual DbSet<booking_order_surcharge> booking_order_surcharge { get; set; }
        public virtual DbSet<calista_schedule> calista_schedule { get; set; }
        public virtual DbSet<calista_schedule_detail> calista_schedule_detail { get; set; }
        public virtual DbSet<calista_schedule_search> calista_schedule_search { get; set; }
        public virtual DbSet<ff_class> ff_class { get; set; }
        public virtual DbSet<ff_class_set> ff_class_set { get; set; }
        public virtual DbSet<ow_surcharge> ow_surcharge { get; set; }
        public virtual DbSet<ow_surcharge_detail> ow_surcharge_detail { get; set; }
        public virtual DbSet<ow_surcharge_port> ow_surcharge_port { get; set; }
        public virtual DbSet<ow_surcharge_schedule> ow_surcharge_schedule { get; set; }
        public virtual DbSet<port_by_company> port_by_company { get; set; }
        public virtual DbSet<port_change_fee> port_change_fee { get; set; }
        public virtual DbSet<presale_main_list> presale_main_list { get; set; }
        public virtual DbSet<presale_order> presale_order { get; set; }
        public virtual DbSet<presale_order_cancel> presale_order_cancel { get; set; }
        public virtual DbSet<presale_order_change> presale_order_change { get; set; }
        public virtual DbSet<presale_rate> presale_rate { get; set; }
        public virtual DbSet<presale_rate_main> presale_rate_main { get; set; }
        public virtual DbSet<product_main> product_main { get; set; }
        public virtual DbSet<rate_branch> rate_branch { get; set; }
        public virtual DbSet<rate_detail> rate_detail { get; set; }
        public virtual DbSet<rate_land> rate_land { get; set; }
        public virtual DbSet<rate_land_detail> rate_land_detail { get; set; }
        public virtual DbSet<rate_main> rate_main { get; set; }
        public virtual DbSet<rate_main_detail> rate_main_detail { get; set; }
        public virtual DbSet<rate_main_list> rate_main_list { get; set; }
        public virtual DbSet<rate_surcharge> rate_surcharge { get; set; }
        public virtual DbSet<rate_surcharge_detail> rate_surcharge_detail { get; set; }
        public virtual DbSet<rate_sync_cargo> rate_sync_cargo { get; set; }
        public virtual DbSet<rates> rates { get; set; }
        public virtual DbSet<schedule> schedule { get; set; }
        public virtual DbSet<schedule_ports> schedule_ports { get; set; }
        public virtual DbSet<ship_route> ship_route { get; set; }
        public virtual DbSet<ship_route_old> ship_route_old { get; set; }
        public virtual DbSet<ship_route_ports> ship_route_ports { get; set; }
        public virtual DbSet<ship_route_ports_old> ship_route_ports_old { get; set; }
        public virtual DbSet<ship_route_products> ship_route_products { get; set; }
        public virtual DbSet<ship_route_products_old> ship_route_products_old { get; set; }
        public virtual DbSet<ship_route_staff> ship_route_staff { get; set; }
        public virtual DbSet<ship_week> ship_week { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=192.168.0.46;port=13306;user=xxy;password=xxy@678.com;database=newship;TreatTinyAsBoolean=true;SslMode=None;AllowLoadLocalInfile=true;Convert Zero Datetime=True;Allow Zero Datetime=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<b_product_sucharge>(entity =>
            {
                entity.HasKey(e => e.PRODUCT_SUCHARGE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("产品附加费");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");
            });

            modelBuilder.Entity<b_products>(entity =>
            {
                entity.HasKey(e => e.PRODUCT_ID)
                    .HasName("PRIMARY");

                entity.HasComment("航运产品表");

                entity.Property(e => e.PRODUCT_ID).HasComment("产品流水号");

                entity.Property(e => e.AVG_TT).HasComment("平均航程(天)");

                entity.Property(e => e.BACK_FEE_ASSIGN_ID).HasMaxLength(50);

                entity.Property(e => e.BERTH_WEEK).HasComment("班期");

                entity.Property(e => e.CALISTA_SCAC).HasMaxLength(50);

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_NAME)
                    .HasMaxLength(200)
                    .HasComment("承运人名称");

                entity.Property(e => e.CLOSE).HasComment("截重时间");

                entity.Property(e => e.COURSE).HasComment("航向\n0-东\n1-西\n2-南\n3-北");

                entity.Property(e => e.CREATEBY).HasComment("如果是新建则此处为本记录ID，如果是修改的则为原记录的ID，原记录标记为无效");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("运价币种");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\n0-未删除\n1-标记删除");

                entity.Property(e => e.DELIVERY_CITY_ENAME)
                    .HasMaxLength(150)
                    .HasComment("交货地城市英文名称");

                entity.Property(e => e.DELIVERY_CITY_ID).HasComment("交货地城市");

                entity.Property(e => e.DELIVERY_CITY_NAME)
                    .HasMaxLength(150)
                    .HasComment("交货地城市中文名称");

                entity.Property(e => e.DELIVERY_CNAME)
                    .HasMaxLength(150)
                    .HasComment("交货地中文名称");

                entity.Property(e => e.DELIVERY_CODE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("交货地代码");

                entity.Property(e => e.DELIVERY_COUNTRY_CODE)
                    .HasMaxLength(30)
                    .HasComment("交货地国家或地区代码");

                entity.Property(e => e.DELIVERY_COUNTRY_ID).HasComment("交货地国家ID");

                entity.Property(e => e.DELIVERY_COUNTRY_NAME)
                    .HasMaxLength(200)
                    .HasComment("交货地国家或地区名称");

                entity.Property(e => e.DELIVERY_ENAME)
                    .HasMaxLength(150)
                    .HasComment("交货地英文名称");

                entity.Property(e => e.DELIVERY_ID).HasComment("交货地ID");

                entity.Property(e => e.DEPARTURE).HasComment("开船时间");

                entity.Property(e => e.FRONT_FEE_ASSIGN_ID).HasMaxLength(50);

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺平柜成本");

                entity.Property(e => e.GP20_REEFER)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺平柜冻柜附加");

                entity.Property(e => e.GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺平柜成本");

                entity.Property(e => e.GP40_REEFER)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺平柜冻柜附加");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺平柜成本");

                entity.Property(e => e.GP45_REEFER)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺平柜冻柜附加");

                entity.Property(e => e.HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺高柜成本");

                entity.Property(e => e.HQ40_REEFER)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺高柜冻柜附加");

                entity.Property(e => e.IS_FF_CONFIRM).HasComment("货代端是否已确认");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_CITY_CNAME)
                    .HasMaxLength(150)
                    .HasComment("卸货港城市中文名称");

                entity.Property(e => e.POD_CITY_ENAME)
                    .HasMaxLength(150)
                    .HasComment("卸货港城市英文名称");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市");

                entity.Property(e => e.POD_CNAME)
                    .HasMaxLength(150)
                    .HasComment("卸货港中文名称");

                entity.Property(e => e.POD_CODE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("卸货港代码");

                entity.Property(e => e.POD_COUNTRY_CODE)
                    .HasMaxLength(30)
                    .HasComment("卸货港国家或地区代码");

                entity.Property(e => e.POD_COUNTRY_ID).HasComment("卸货港国家ID");

                entity.Property(e => e.POD_COUNTRY_NAME)
                    .HasMaxLength(200)
                    .HasComment("卸货港国家或地区名称");

                entity.Property(e => e.POD_ENAME)
                    .HasMaxLength(150)
                    .HasComment("卸货港英文名称");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_CNAME)
                    .HasMaxLength(150)
                    .HasComment("装货港城市中文名称");

                entity.Property(e => e.POL_CITY_ENAME)
                    .HasMaxLength(150)
                    .HasComment("装货港城市英文名称");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市");

                entity.Property(e => e.POL_CNAME)
                    .HasMaxLength(200)
                    .HasComment("装货港中文名称");

                entity.Property(e => e.POL_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("装货港代码");

                entity.Property(e => e.POL_COUNTRY_CODE)
                    .HasMaxLength(30)
                    .HasComment("装货港国家或地区代码");

                entity.Property(e => e.POL_COUNTRY_ID).HasComment("装货港国家ID");

                entity.Property(e => e.POL_COUNTRY_NAME)
                    .HasMaxLength(200)
                    .HasComment("装货港国家或地区名称");

                entity.Property(e => e.POL_ENAME)
                    .HasMaxLength(200)
                    .HasComment("装货港英文名称");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PRODUCT_NO)
                    .HasMaxLength(35)
                    .HasComment("产品编号");

                entity.Property(e => e.PRODUCT_TYPE).HasComment("产品类型\n10:直航产品\n20:中转产品");

                entity.Property(e => e.PUNCTUAL_RATE)
                    .HasColumnType("decimal(5,1)")
                    .HasComment("准点率");

                entity.Property(e => e.RECEIPT_CITY_CNAME)
                    .HasMaxLength(150)
                    .HasComment("收货地城市中文名称");

                entity.Property(e => e.RECEIPT_CITY_ENAME)
                    .HasMaxLength(150)
                    .HasComment("收货地城市英文名称");

                entity.Property(e => e.RECEIPT_CITY_ID).HasComment("收货地城市");

                entity.Property(e => e.RECEIPT_CNAME)
                    .HasMaxLength(150)
                    .HasComment("收货地中文名称");

                entity.Property(e => e.RECEIPT_CODE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("收货地代码");

                entity.Property(e => e.RECEIPT_COUNTRY_CODE)
                    .HasMaxLength(30)
                    .HasComment("收货地国家或地区代码");

                entity.Property(e => e.RECEIPT_COUNTRY_ID).HasComment("收获地国家ID");

                entity.Property(e => e.RECEIPT_COUNTRY_NAME)
                    .HasMaxLength(200)
                    .HasComment("收货地国家或地区名称");

                entity.Property(e => e.RECEIPT_ENAME)
                    .HasMaxLength(150)
                    .HasComment("收货地英文名称");

                entity.Property(e => e.RECEIPT_ID).HasComment("收货地ID");

                entity.Property(e => e.REMARK).HasComment("说明");

                entity.Property(e => e.ROUTE_CODE)
                    .HasMaxLength(200)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.ROUTE_NAME)
                    .HasMaxLength(100)
                    .HasComment("航线名称");

                entity.Property(e => e.SHIP_ROUTE_AREA_CODE)
                    .HasMaxLength(35)
                    .HasComment("航线区域代码");

                entity.Property(e => e.SHIP_ROUTE_AREA_ID).HasComment("航线区域ID");

                entity.Property(e => e.SHIP_ROUTE_AREA_NAME)
                    .HasMaxLength(200)
                    .HasComment("航线区域名称");

                entity.Property(e => e.STATUS).HasComment("状态:\r\n-1作废\r\n0-草稿\r\n1-有效");

                entity.Property(e => e.TON)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("单吨成本");

                entity.Property(e => e.TOTAL_DAY).HasComment("总天数");

                entity.Property(e => e.TRANS_TYPE_CNAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运输条款中文名称");

                entity.Property(e => e.TRANS_TYPE_CODE)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运输条款代码");

                entity.Property(e => e.TRANS_TYPE_ENAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运输条款英文名称");

                entity.Property(e => e.TT).HasComment("航程");

                entity.Property(e => e.VALID).HasComment("有效性");

                entity.Property(e => e.VIA_CITY_ID).HasComment("中转城市");

                entity.Property(e => e.VIA_CITY_NAME)
                    .HasMaxLength(150)
                    .HasComment("中转城市名称");

                entity.Property(e => e.VIA_CODE)
                    .HasMaxLength(10)
                    .HasComment("中转港代码");

                entity.Property(e => e.VIA_NAME)
                    .HasMaxLength(150)
                    .HasComment("中转港名称");

                entity.Property(e => e.VOYAGE_COUNT).HasComment("航行次数(记录最近一年的数据)");
            });

            modelBuilder.Entity<base_carrier>(entity =>
            {
                entity.HasKey(e => e.CARRIER_ID)
                    .HasName("PRIMARY");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_FULLNAME)
                    .IsRequired()
                    .HasComment("承运人全名");

                entity.Property(e => e.CARRIER_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("承运人名称");

                entity.Property(e => e.CARRIER_SHOT_CODE)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasComment("承运人简码");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\n0-未删除\n1-标记删除");

                entity.Property(e => e.DOMAIN)
                    .HasMaxLength(200)
                    .HasComment("分配给船公司的独立域名");

                entity.Property(e => e.FREE_USE_DAY).HasComment("免费用箱天数");

                entity.Property(e => e.IS_OFFICIAL).HasComment("是否官方维护");

                entity.Property(e => e.LOGO)
                    .HasMaxLength(200)
                    .HasComment("图标");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.NEED_EXTEND).HasComment("是否需要延伸船期查询，1为需要延伸，0为不需要延伸");

                entity.Property(e => e.PRESALE_MODE).HasComment("预售模式\n0-不预售\n1-通用预售\n2-专享预售");

                entity.Property(e => e.REMARK).HasComment("说明");

                entity.Property(e => e.SCHEDULE_MANUAL).HasComment("是否是人工维护的船期 1为人工维护 0为自动导入");

                entity.Property(e => e.SCHEDULE_MODE).HasComment("船公司船期的匹配模式 1: 普通挂港并延伸模式 2:港口对模式 3:挂港但不延伸模式");

                entity.Property(e => e.SEQUENCE_STRING)
                    .HasMaxLength(30)
                    .HasComment("排序字符");

                entity.Property(e => e.VALID).HasComment("状态:\n0-无效\n1-有效");

                entity.Property(e => e.VOYAGE_MODE).HasComment("航次模式\n0.无航向\n1.航向在前\n2.航向在后");

                entity.Property(e => e.WEBSITE)
                    .HasMaxLength(200)
                    .HasComment("船公司的自有网站");
            });

            modelBuilder.Entity<base_company>(entity =>
            {
                entity.HasKey(e => e.COMPANY_ID)
                    .HasName("PRIMARY");

                entity.HasComment("企业信息");

                entity.Property(e => e.COMPANY_ID).HasComment("公司主键");

                entity.Property(e => e.ADDRESS)
                    .HasMaxLength(200)
                    .HasComment("地址");

                entity.Property(e => e.BANK_ACCOUNTNO)
                    .HasMaxLength(200)
                    .HasComment("银行账号");

                entity.Property(e => e.BANK_NAME)
                    .HasMaxLength(200)
                    .HasComment("银行名称");

                entity.Property(e => e.CAMPAIGN_USER_ID).HasComment("推荐人ID");

                entity.Property(e => e.CAMPAIGN_USER_PLATFORM).HasComment("推荐人所属平台 (1货代库 2拖车库 3报关)");

                entity.Property(e => e.CITY_ID).HasComment("城市ID");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("城市中文");

                entity.Property(e => e.CITY_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("城市英文");

                entity.Property(e => e.COMPANY_CLASS)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'")
                    .HasComment("企业分类\r\n	0-运维企业 Operation\r\n	10-船公司(ShipOwner)\r\n	11-船代公司Shipping Agency\r\n	20-货代Freight Forwarding\r\n	30-拖车Trailer\r\n	35-驳船公司BARGE\r\n	40-报关行CustomsBrokers\r\n	50-货主Shipper\r\n	60-仓储公司WareHouse");

                entity.Property(e => e.COMPANY_CODE)
                    .HasMaxLength(50)
                    .HasComment("公司代码");

                entity.Property(e => e.COMPANY_LEVEL)
                    .HasDefaultValueSql("'1'")
                    .HasComment("客户等级");

                entity.Property(e => e.COMPANY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("公司名称简体");

                entity.Property(e => e.COMPANY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("公司名称英文");

                entity.Property(e => e.COMPANY_SHORTNAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("公司简称简体");

                entity.Property(e => e.COMPANY_SHORTNAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("公司简称英文");

                entity.Property(e => e.CONTACTS)
                    .HasMaxLength(35)
                    .HasComment("联系人");

                entity.Property(e => e.CONTACT_PHONE)
                    .HasMaxLength(50)
                    .HasComment("联系电话");

                entity.Property(e => e.COUNTRY_CODE)
                    .HasMaxLength(50)
                    .HasComment("国家代码");

                entity.Property(e => e.COUNTRY_ID).HasComment("国家ID");

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("国家中文");

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("国家英文");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.CURRENT_INTEGRAL)
                    .HasDefaultValueSql("'0'")
                    .HasComment("当前积分");

                entity.Property(e => e.DELETE_MARK)
                    .HasDefaultValueSql("'0'")
                    .HasComment("删除标记\r\n	1：删除，0：正常，-1：锁定");

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(50)
                    .HasComment("邮箱");

                entity.Property(e => e.FAX)
                    .HasMaxLength(25)
                    .HasComment("传真");

                entity.Property(e => e.IS_CERTIFICATION).HasComment("实名认证");

                entity.Property(e => e.IS_SCHEDULE_AUTHORITY)
                    .HasDefaultValueSql("'1'")
                    .HasComment("船期查询权限");

                entity.Property(e => e.IS_SUPER_PARTNER)
                    .HasDefaultValueSql("'0'")
                    .HasComment("超级合伙人");

                entity.Property(e => e.LARGEICON)
                    .HasMaxLength(254)
                    .HasComment("企业图标(大)");

                entity.Property(e => e.LARGEICON_FILE_ID).HasComment("企业图标(大)文件ID");

                entity.Property(e => e.LOGO)
                    .HasMaxLength(254)
                    .HasComment("企业图标(小)");

                entity.Property(e => e.LOGO_FILE_ID).HasComment("企业图标(小)文件ID");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.ORGANIZING_CODE)
                    .HasMaxLength(50)
                    .HasComment("组织机构代码");

                entity.Property(e => e.ORGANIZING_FILE)
                    .HasMaxLength(100)
                    .HasComment("组织机构证图片");

                entity.Property(e => e.ORGANIZING_FILE_ID).HasComment("组织机构证图片文件ID");

                entity.Property(e => e.PARENT_ID).HasComment("上级公司ID");

                entity.Property(e => e.POSTCODE)
                    .HasMaxLength(10)
                    .HasComment("邮政区号");

                entity.Property(e => e.PROVINCE_ID).HasComment("省州ID");

                entity.Property(e => e.PROVINCE_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("省州中文");

                entity.Property(e => e.PROVINCE_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("省州英文");

                entity.Property(e => e.PUSH_RATE_QTY).HasComment("运价推送数量");

                entity.Property(e => e.REFEREE_COMPANY_ID).HasComment("推荐公司ID");

                entity.Property(e => e.REGISTERED_FILE)
                    .HasMaxLength(100)
                    .HasComment("营业执照图片");

                entity.Property(e => e.REGISTERED_FILE_ID).HasComment("营业执照图片文件ID");

                entity.Property(e => e.REGISTERED_NO)
                    .HasMaxLength(50)
                    .HasComment("工商注册号");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(200)
                    .HasComment("备注说明");

                entity.Property(e => e.STATUS).HasComment("状态\r\n	-1:拒绝\r\n	0:未审核\r\n	10:有效");

                entity.Property(e => e.SUPERPARTNER_CREATE_FULLNAME)
                    .HasMaxLength(100)
                    .HasComment("合伙人添加人");

                entity.Property(e => e.TOTAL_REFEREE)
                    .HasColumnType("decimal(8,4)")
                    .HasComment("当前货代推荐的总数量");
            });

            modelBuilder.Entity<base_organization>(entity =>
            {
                entity.HasKey(e => e.ORGANIZATION_ID)
                    .HasName("PRIMARY");

                entity.HasComment("部门信息");

                entity.Property(e => e.ORGANIZATION_ID).HasComment("部门主键");

                entity.Property(e => e.ADDRESS)
                    .HasMaxLength(200)
                    .HasComment("地址");

                entity.Property(e => e.CARRIER_ID).HasComment("货代公司ID");

                entity.Property(e => e.COMPANY_ID).HasComment("所属公司");

                entity.Property(e => e.CONTACTS)
                    .HasMaxLength(100)
                    .HasComment("联系人");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DELETE_MARK)
                    .HasDefaultValueSql("'0'")
                    .HasComment("删除标记1：删除，0：正常");

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(200)
                    .HasComment("邮箱");

                entity.Property(e => e.FAX)
                    .HasMaxLength(50)
                    .HasComment("传真");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.ORGANIZATION_CODE)
                    .HasMaxLength(20)
                    .HasComment("编号");

                entity.Property(e => e.ORGANIZATION_NAME)
                    .HasMaxLength(50)
                    .HasComment("部门名称");

                entity.Property(e => e.ORGANIZATION_REMARK)
                    .HasMaxLength(200)
                    .HasComment("备注说明");

                entity.Property(e => e.PARENT_ID).HasComment("上级部门主键");

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .HasComment("电话");

                entity.Property(e => e.POSTCODE)
                    .HasMaxLength(10)
                    .HasComment("邮政区号");

                entity.Property(e => e.SEQUENCE).HasComment("排序");

                entity.Property(e => e.SEQUENCE_STRING)
                    .HasMaxLength(100)
                    .HasComment("[父级排序串]-[当前排序值]");

                entity.Property(e => e.TOP_ORGANIZATION_ID).HasComment("部门树中，最上级节点的ID");

                entity.Property(e => e.USERS).HasComment("员工成员数");
            });

            modelBuilder.Entity<base_role>(entity =>
            {
                entity.HasKey(e => e.BASE_ROLE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("船东系统角色\r\n内置角色：管理员，航线经理，客服，单证");

                entity.Property(e => e.BASE_ROLE_ID).HasComment("角色流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("船东流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .HasMaxLength(100)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(1000)
                    .HasComment("备注");

                entity.Property(e => e.ROLENAMECN)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("角色中文名");

                entity.Property(e => e.ROLENAMEEN)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("角色英文名");

                entity.Property(e => e.USE_DEFAULT).HasComment("使用默认");
            });

            modelBuilder.Entity<base_role_permission>(entity =>
            {
                entity.HasKey(e => e.BASE_ROLE_PERMISSION_ID)
                    .HasName("PRIMARY");

                entity.HasComment("角色权限点");

                entity.Property(e => e.BASE_ROLE_PERMISSION_ID)
                    .HasMaxLength(100)
                    .HasComment("货代系统角色权限点");

                entity.Property(e => e.BASE_ROLE_ID).HasComment("角色流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("CARRIER_ID");

                entity.Property(e => e.CREATE_FULLNAME)
                    .HasMaxLength(100)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.PERMISSION).HasComment("权限点");

                entity.Property(e => e.PERMISSION_KEY)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasComment("权限代码");
            });

            modelBuilder.Entity<base_userinfo>(entity =>
            {
                entity.HasKey(e => e.USER_ID)
                    .HasName("PRIMARY");

                entity.HasComment("用户信息");

                entity.Property(e => e.USER_ID).HasComment("用户主键");

                entity.Property(e => e.BASE_ROLE_ID).HasComment("用户角色流水号");

                entity.Property(e => e.CAMPAIGN_KEY)
                    .HasMaxLength(50)
                    .HasComment("推广Key");

                entity.Property(e => e.CAMPAIGN_USER_ID).HasComment("推荐用户ID");

                entity.Property(e => e.CAMPAIGN_USER_PLATFORM).HasComment("推荐人所属平台 (1货代库 2拖车库 3报关)");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司流水号");

                entity.Property(e => e.COMPANY_CLASS)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'")
                    .HasComment("企业分类\r\n	20-货代Freight Forwarding\r\n	30-拖车Trailer\r\n	35-驳船公司BARGE\r\n	40-报关行CustomsBrokers\r\n	50-平台直客Shipper\r\n	55-货代客户 Freight Forwarding Shipper\r\n	60-仓储公司WareHouse");

                entity.Property(e => e.COMPANY_ID).HasComment("销售公司流水号");

                entity.Property(e => e.COMPANY_SHORTNAME)
                    .HasMaxLength(200)
                    .HasComment("销售公司简称");

                entity.Property(e => e.CONFIRM_EMAIL).HasComment("邮箱确认");

                entity.Property(e => e.CONFIRM_MOBILE).HasComment("手机确认");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记 \r\n	1：删除，0：正常，-1：锁定");

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(200)
                    .HasComment("电子邮件");

                entity.Property(e => e.FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("用户姓名");

                entity.Property(e => e.FULLNAME_EN)
                    .HasMaxLength(50)
                    .HasComment("英文用户名");

                entity.Property(e => e.GENDER)
                    .HasMaxLength(1)
                    .IsFixedLength(true)
                    .HasComment("性别 M-男、F-女");

                entity.Property(e => e.IS_ADMIN).HasComment("企业管理员");

                entity.Property(e => e.LANGUAGE)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'ENG'")
                    .HasComment("用户默认语言");

                entity.Property(e => e.LOGIN_MOBILE)
                    .HasMaxLength(100)
                    .HasComment("登陆手机号");

                entity.Property(e => e.MOBILE)
                    .HasMaxLength(50)
                    .HasComment("手机");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.PASSWORD)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("用户登录密码");

                entity.Property(e => e.QQ_APPID)
                    .HasMaxLength(200)
                    .HasComment("QQ APPID");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(1000)
                    .HasComment("备注");

                entity.Property(e => e.TEL)
                    .HasMaxLength(50)
                    .HasComment("办公电话");

                entity.Property(e => e.THEMES)
                    .HasMaxLength(50)
                    .HasComment("用户默认主题");

                entity.Property(e => e.TITLE)
                    .HasMaxLength(50)
                    .HasComment("职称");

                entity.Property(e => e.USERNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("用户登陆名");

                entity.Property(e => e.USER_STATUS).HasComment("账号状态(-1停用,0未验证,1正常)");

                entity.Property(e => e.USER_TYPE)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("用户类型：用户角色中文名称");

                entity.Property(e => e.WECHAT_APPID)
                    .HasMaxLength(200)
                    .HasComment("微信APPID");
            });

            modelBuilder.Entity<base_zone>(entity =>
            {
                entity.HasKey(e => e.BASE_ZONE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("区域管理");

                entity.Property(e => e.BASE_ZONE_ID).HasComment("航线ID");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("创建人账号");

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("bit(1)")
                    .HasComment("删除标识");

                entity.Property(e => e.MODIFY_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("更改人账号");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.VALID).HasComment("有效性");

                entity.Property(e => e.ZONE_NAME)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<base_zone_detail>(entity =>
            {
                entity.HasKey(e => e.BASE_ZONE_DETAIL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("区域明细");

                entity.HasIndex(e => e.BASE_ZONE_ID, "IX_BASE_ZONE_DETAIL");

                entity.Property(e => e.BASE_ZONE_ID).HasComment("航线ID");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("创建人账号");

                entity.Property(e => e.LOCAL_TYPE).HasComment("1-国家,2城市,3-地点");

                entity.Property(e => e.MODIFY_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("更改人账号");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.HasOne(d => d.BASE_ZONE)
                    .WithMany(p => p.base_zone_detail)
                    .HasForeignKey(d => d.BASE_ZONE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IX_BASE_ZONE_DETAIL");
            });

            modelBuilder.Entity<booking_order>(entity =>
            {
                entity.HasKey(e => e.BOOKING_ORDER_ID)
                    .HasName("PRIMARY");

                entity.HasComment("现货订单");

                entity.Property(e => e.BOOKING_ORDER_ID).HasComment("订舱流水号");

                entity.Property(e => e.BILL_STATUS).HasComment("账单状态(0未生成 1已生成 5已拒绝  10已确认)");

                entity.Property(e => e.BL_STATUS).HasComment("提单状态( (0草稿 10已签发 20已放单))");

                entity.Property(e => e.BOOKING_NO)
                    .HasMaxLength(1000)
                    .HasComment("订舱编号");

                entity.Property(e => e.BOOKING_ORDER_GUID)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("订舱数据指纹");

                entity.Property(e => e.CARGO_DESC)
                    .HasMaxLength(2000)
                    .HasComment("货物描述");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("承运人销售公司ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CBM)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("总体积");

                entity.Property(e => e.CONSIGNEE_DESC)
                    .HasMaxLength(500)
                    .HasComment("收货人描述");

                entity.Property(e => e.CONTRACT_NO)
                    .HasMaxLength(35)
                    .HasComment("合约编号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CUSTOMER_ID).HasComment("订舱客户ID");

                entity.Property(e => e.CUSTOMER_TYPE).HasComment("客户类型(1直客 2货代)");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.DELIVERY_CITY_ID).HasComment("交货地城市");

                entity.Property(e => e.DELIVERY_ID).HasComment("交货地ID");

                entity.Property(e => e.FF_BOOKING_ORDER_ID).HasComment("货代订单流水号");

                entity.Property(e => e.FF_ID).HasComment("货代公司流水号");

                entity.Property(e => e.FREEDETENTIONN_REMARK_REPLY)
                    .HasMaxLength(1000)
                    .HasComment("用箱申请回复");

                entity.Property(e => e.FREEDETENTIONN_REMARK_REQUEST)
                    .HasMaxLength(1000)
                    .HasComment("用箱申请备注");

                entity.Property(e => e.FREEDETENTIONN_STATUS)
                    .HasDefaultValueSql("'0'")
                    .HasComment("用箱申请状态 (0 未申请 10 已提交 30 已回复 50 已确认)");

                entity.Property(e => e.LAND_DELIVERY_CITY_ID).HasComment("内陆交货城市ID");

                entity.Property(e => e.LAND_DELIVERY_ID).HasComment("内陆交货地点(堆场)");

                entity.Property(e => e.LAND_PRODUCT_PATH_ID).HasComment("陆运产品ID");

                entity.Property(e => e.LAND_RECEIPT_CITY_ID).HasComment("内陆收货地城市ID");

                entity.Property(e => e.LAND_RECEIPT_ID).HasComment("内陆收货地点(堆场)");

                entity.Property(e => e.LINKER_ADDRESS)
                    .HasMaxLength(500)
                    .HasComment("联系人地址");

                entity.Property(e => e.LINKER_EMAIL)
                    .HasMaxLength(100)
                    .HasComment("联系人邮件");

                entity.Property(e => e.LINKER_FAX)
                    .HasMaxLength(50)
                    .HasComment("联系人传真");

                entity.Property(e => e.LINKER_NAME)
                    .HasMaxLength(50)
                    .HasComment("联系人姓名");

                entity.Property(e => e.LINKER_TEL)
                    .HasMaxLength(50)
                    .HasComment("联系人电话\r\n	国家-区号-电话号码-分机号");

                entity.Property(e => e.LOAD_TEU).HasComment("已做柜TEU");

                entity.Property(e => e.MARKS)
                    .HasMaxLength(2000)
                    .HasComment("唛头");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.NOTIFIER_DESC)
                    .HasMaxLength(500)
                    .HasComment("通知人描述");

                entity.Property(e => e.ORDER_NO)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("订单号码");

                entity.Property(e => e.ORDER_REMARK)
                    .HasMaxLength(2000)
                    .HasComment("订舱备注");

                entity.Property(e => e.PAY_LOCATION)
                    .HasMaxLength(35)
                    .HasComment("付款地点代码");

                entity.Property(e => e.PICS)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("数量");

                entity.Property(e => e.PICS_UNIT)
                    .HasMaxLength(50)
                    .HasComment("数量单位");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PPCC)
                    .HasMaxLength(35)
                    .HasComment("付款方式代码");

                entity.Property(e => e.PRODUCT_ID).HasComment("产品ID");

                entity.Property(e => e.RATE_ID).HasComment("运价流水号");

                entity.Property(e => e.RECEIPT_CITY_ID).HasComment("收货地城市");

                entity.Property(e => e.RECEIPT_ID).HasComment("收货地ID");

                entity.Property(e => e.RELEASE_FULLNAME)
                    .HasMaxLength(50)
                    .HasComment("放单人名称");

                entity.Property(e => e.RELEASE_MODE)
                    .HasMaxLength(35)
                    .HasComment("放货方式\r\n	10-正本\r\n	20-电放\r\n	30-SWB");

                entity.Property(e => e.RELEASE_REMARK)
                    .HasMaxLength(2000)
                    .HasComment("放单备注");

                entity.Property(e => e.RELEASE_STATUS)
                    .HasDefaultValueSql("'0'")
                    .HasComment("放单状态 (0未放单 1已放单)");

                entity.Property(e => e.RELEASE_USERID).HasComment("放单人ID");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.SALES_ID).HasComment("业务员ID");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期关联");

                entity.Property(e => e.SHIPPER_DESC)
                    .HasMaxLength(500)
                    .HasComment("发货人描述");

                entity.Property(e => e.SI_STATUS).HasComment("补料状态(0未补料 1提交 5已拒绝  10已确认)");

                entity.Property(e => e.SPECIARATE_REMARK_REPLY)
                    .HasMaxLength(1000)
                    .HasComment("特价申请回复");

                entity.Property(e => e.SPECIARATE_REMARK_REQUEST)
                    .HasMaxLength(1000)
                    .HasComment("特价备注");

                entity.Property(e => e.SPECIARATE_STATUS).HasComment("特价申请状态 (0 未申请.1 已提交. 5 已回复. 10 已确认)");

                entity.Property(e => e.STATUS).HasComment("0草稿 10已提交 50商务已确认 90审核拒绝 100已放舱 101已发送报文 102已重发报文 108放舱失败 109放舱成功 110已打提空单 111已提空 120已返重 200已撤单 201已发撤单报文 202已重发撤单报文 208撤单失败 209撤单成功 300已装船 400已卸船 500已送达 900已完结 999未装船 -10历史 -20已取消 -30已作废");

                entity.Property(e => e.TEU).HasComment("本次订舱(TEU)");

                entity.Property(e => e.TRADETERMS_CODE)
                    .HasMaxLength(35)
                    .HasComment("贸易条款代码");

                entity.Property(e => e.TRAILER_STATUS).HasComment("拖车状态(-1未委托 0未申请,1已申请, 5已提交, 10受理, 15安排 20执行 25完成)");

                entity.Property(e => e.TRANS_TYPE_CODE)
                    .HasMaxLength(35)
                    .HasComment("运输条款代码");

                entity.Property(e => e.TT).HasComment("航程");

                entity.Property(e => e.VESSEL_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("英文船名");

                entity.Property(e => e.VGM_STATUS)
                    .HasDefaultValueSql("'0'")
                    .HasComment("VGM状态(0未提交,1已提交,10已确认)");

                entity.Property(e => e.VOYAGE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航次");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");

                entity.Property(e => e.WEIGHT)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("重量");

                entity.Property(e => e.WEIGHT_UNIT)
                    .HasMaxLength(50)
                    .HasComment("重量单位");
            });

            modelBuilder.Entity<booking_order_approver>(entity =>
            {
                entity.HasKey(e => e.BOOKING_ORDER_APPROVER_ID)
                    .HasName("PRIMARY");

                entity.HasComment("现货订单审核信息");

                entity.Property(e => e.BOOKING_ORDER_APPROVER_ID).HasComment("订单放舱流水号");

                entity.Property(e => e.APPROVED_DESC)
                    .HasMaxLength(2000)
                    .HasComment("放舱备注");

                entity.Property(e => e.APPROVER_ID).HasComment("在审核时保存放舱人的用户账户ID，主要用于报文输出");

                entity.Property(e => e.APPROVER_NAME)
                    .HasMaxLength(50)
                    .HasComment("在审核时保存放舱人的用户姓名，来源于Special_Price_Rule_User");

                entity.Property(e => e.BOOKING_ORDER_ID).HasComment("订单流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.FIRST_SCHEDULE_ID).HasComment("头程船期ID");

                entity.Property(e => e.FIRST_VESSEL_NAME)
                    .HasMaxLength(50)
                    .HasComment("头程船名");

                entity.Property(e => e.FIRST_VOYAGE)
                    .HasMaxLength(35)
                    .HasComment("头程航次");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_TEU).HasComment("重货TEU");

                entity.Property(e => e.PAY_LOCATION)
                    .HasMaxLength(200)
                    .HasComment("付款地点代码");

                entity.Property(e => e.PR_ID).HasComment("还重地点 Place of Return Location");

                entity.Property(e => e.PR_NAME)
                    .HasMaxLength(200)
                    .HasComment("还重地点名称");

                entity.Property(e => e.PU_ID).HasComment("提空地点Pick up Container Location");

                entity.Property(e => e.PU_NAME)
                    .HasMaxLength(200)
                    .HasComment("提空地点名称");

                entity.Property(e => e.SPECIAL_LOAD)
                    .HasMaxLength(500)
                    .HasComment("特殊装载");

                entity.Property(e => e.SPECIAL_REMARK)
                    .HasMaxLength(500)
                    .HasComment("特殊备注");

                entity.Property(e => e.STATUS)
                    .HasDefaultValueSql("'90'")
                    .HasComment("状态(90失败 100成功)");

                entity.Property(e => e.TEU).HasComment("普货TEU");
            });

            modelBuilder.Entity<booking_order_container>(entity =>
            {
                entity.HasKey(e => e.BOOKING_ORDER_CONTAINER_ID)
                    .HasName("PRIMARY");

                entity.HasComment("现货订单箱信息");

                entity.Property(e => e.BOOKING_ORDER_CONTAINER_ID).HasComment("订单箱流水号");

                entity.Property(e => e.BOOKING_NO)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("订舱号");

                entity.Property(e => e.BOOKING_ORDER_ID).HasComment("订单流水号");

                entity.Property(e => e.CARGO_DESC)
                    .HasMaxLength(100)
                    .HasComment("品名");

                entity.Property(e => e.CARGO_PROPERTY)
                    .HasDefaultValueSql("'1'")
                    .HasComment("货物特征(1 普通货 2 冷藏品 3 危险品 4 特种 5 重货)");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CONTAINER_NO)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("箱号");

                entity.Property(e => e.CONTA_PROPERTY)
                    .HasDefaultValueSql("'1'")
                    .HasComment("箱属性(1 COC,2 SOC)");

                entity.Property(e => e.CONTA_SIZE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("箱形尺寸(20,40,40H,45)");

                entity.Property(e => e.CONTA_SIZETYPE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("箱型代码");

                entity.Property(e => e.CONTA_WEIGHT)
                    .HasColumnType("decimal(10,2)")
                    .HasComment("箱重量(KG)");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DANGEROU_LEVEL_CODE)
                    .HasMaxLength(35)
                    .HasComment("危险品等级代码");

                entity.Property(e => e.DANGEROU_LEVEL_ID).HasComment("危险品等级流水号");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.FF_BOOKING_CONTAINER_ID).HasComment("货代箱ID");

                entity.Property(e => e.MAIN_BOOKING_ORDER_ID).HasComment("主订单流水号");

                entity.Property(e => e.MARK)
                    .HasMaxLength(100)
                    .HasComment("唛头");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.PACKAGE_NUM).HasComment("数量");

                entity.Property(e => e.PACKAGE_UNIT)
                    .HasMaxLength(35)
                    .HasComment("单位");

                entity.Property(e => e.PRESALE_ORDER_ID).HasComment("预售订单ID");

                entity.Property(e => e.SEAL_NO)
                    .HasMaxLength(35)
                    .HasComment("铅封号");

                entity.Property(e => e.TEU).HasComment("TEU");

                entity.Property(e => e.VGM_TYPE)
                    .HasDefaultValueSql("'1'")
                    .HasComment("称重方式 (1总重 2合计)");

                entity.Property(e => e.VGM_WEIGHT)
                    .HasColumnType("decimal(10,2)")
                    .HasComment("VGM重量");

                entity.Property(e => e.VOUME)
                    .HasColumnType("decimal(10,2)")
                    .HasComment("体积");

                entity.Property(e => e.WEIGHT)
                    .HasColumnType("decimal(10,2)")
                    .HasComment("重量");
            });

            modelBuilder.Entity<booking_order_presale>(entity =>
            {
                entity.HasKey(e => e.BOOKING_ORDER_PRESALE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("现货订单预售信息");

                entity.Property(e => e.BOOKING_ORDER_PRESALE_ID).HasComment("整箱订单预售信息");

                entity.Property(e => e.BOOKING_ORDER_ID).HasComment("订单流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记");

                entity.Property(e => e.FF_BOOKING_PRESALE_ID).HasComment("货代预售ID");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OR_TEU).HasComment("普货TEU");

                entity.Property(e => e.OW_TEU).HasComment("重货TEU");

                entity.Property(e => e.PRESALE_ORDER_ID).HasComment("预售订单ID");

                entity.Property(e => e.USE_OR_TEU).HasComment("普货已使用TEU");

                entity.Property(e => e.USE_OW_TEU).HasComment("重货已使用TEU");
            });

            modelBuilder.Entity<booking_order_rate>(entity =>
            {
                entity.HasKey(e => e.BOOKING_ORDER_RATE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("现货订单运价信息");

                entity.Property(e => e.BOOKING_ORDER_RATE_ID).HasComment("订舱订单运价流水号");

                entity.Property(e => e.BOOKING_ORDER_ID).HasComment("订单流水号");

                entity.Property(e => e.CARGO_DESC)
                    .HasMaxLength(500)
                    .HasComment("货描描述");

                entity.Property(e => e.CARGO_PROPERTY)
                    .HasMaxLength(35)
                    .HasComment("货物特征代码\r\n	1 普通货\r\n	2 冷藏品\r\n	3 危险品\r\n	4 特种\r\n	5 重货");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CONTA_PROPERTY).HasComment("箱属性(1 COC,2 SOC)");

                entity.Property(e => e.CONTA_QTY).HasComment("箱数");

                entity.Property(e => e.CONTA_SIZE)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("箱型尺寸");

                entity.Property(e => e.CONTA_SIZETYPE_CODE)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("箱型代码");

                entity.Property(e => e.CONTA_WEIGHT)
                    .HasColumnType("decimal(8,0)")
                    .HasComment("单柜重量");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .HasMaxLength(10)
                    .HasComment("币种");

                entity.Property(e => e.DANGEROU_LEVEL_CODE)
                    .HasMaxLength(35)
                    .HasComment("危险品等级代码");

                entity.Property(e => e.DANGEROU_LEVEL_ID).HasComment("危险品等级流水号");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.EIR_QTY)
                    .HasDefaultValueSql("'0'")
                    .HasComment("已申请提箱数");

                entity.Property(e => e.FF_BOOKING_RATE_ID).HasComment("货代运价流水号");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.RATE_COST)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("公司底价");

                entity.Property(e => e.RATE_CUSTOMER)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("客户原价");

                entity.Property(e => e.RATE_CUSTOMER_REPLY)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("回复客户价");

                entity.Property(e => e.RATE_CUSTOMER_REQUEST)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("客户申请价");

                entity.Property(e => e.RATE_FINAL)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("成交价");

                entity.Property(e => e.RATE_SALES_COST)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("业务员底价");

                entity.Property(e => e.RATE_TYPE).HasComment("运价类型\r\n	0:FAK\r\n	10 合约价\r\n	20 预售价\r\n	30 特价");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.TEU).HasComment("舱位");
            });

            modelBuilder.Entity<booking_order_so>(entity =>
            {
                entity.HasKey(e => e.BOOKING_ORDER_SO_ID)
                    .HasName("PRIMARY");

                entity.HasComment("现货订单So信息");

                entity.Property(e => e.BOOKING_ORDER_SO_ID).HasComment("整箱订单流水号");

                entity.Property(e => e.BOOKING_ORDER_ID).HasComment("订单流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.SONO)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("SONo");
            });

            modelBuilder.Entity<booking_order_surcharge>(entity =>
            {
                entity.HasKey(e => e.BOOKING_ORDER_SURCHARGE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("现货订单附加费信息");

                entity.Property(e => e.BOOKING_ORDER_SURCHARGE_ID).HasComment("订舱订单附加费用流水号");

                entity.Property(e => e.AMOUNT)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("金额");

                entity.Property(e => e.BOOKING_ORDER_ID).HasComment("订单流水号");

                entity.Property(e => e.BOOKING_ORDER_RATE_ID).HasComment("订舱订单运价流水号\r\n	跟哪条运价关联的,如果是按票收的,则保存为0");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CONTA_SIZETYPE_CODE)
                    .HasMaxLength(100)
                    .HasComment("箱型代码");

                entity.Property(e => e.COST)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("成本价");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("费用货币");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.FEETYPE_ID).HasComment("费用类型ID");

                entity.Property(e => e.FF_BOOKING_SURCHARGE_ID).HasComment("货代附加费流水号");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.PRICE)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("单价");

                entity.Property(e => e.QTY).HasComment("数量");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .HasComment("说明");

                entity.Property(e => e.UNIT).HasComment("计费单位 0.按箱; 1.按单;");
            });

            modelBuilder.Entity<calista_schedule>(entity =>
            {
                entity.HasKey(e => e.CALISTA_SCHEDULE_ID)
                    .HasName("PRIMARY");

                entity.Property(e => e.CARRIER).HasMaxLength(200);

                entity.Property(e => e.CARRIERCODE).HasMaxLength(50);

                entity.Property(e => e.CARRIER_PARTY_ID).HasMaxLength(50);

                entity.Property(e => e.CY_CUTOFF).HasMaxLength(200);

                entity.Property(e => e.POD_CODE).HasMaxLength(50);

                entity.Property(e => e.POD_ETA).HasMaxLength(200);

                entity.Property(e => e.POD_ETD).HasMaxLength(200);

                entity.Property(e => e.POL_CODE).HasMaxLength(50);

                entity.Property(e => e.POL_ETA).HasMaxLength(200);

                entity.Property(e => e.POL_ETD).HasMaxLength(200);

                entity.Property(e => e.SERVICE).HasMaxLength(50);

                entity.Property(e => e.VESSEL_NAME).HasMaxLength(200);

                entity.Property(e => e.VOYAGE_ID).HasMaxLength(50);

                entity.Property(e => e.VOYAGE_NO).HasMaxLength(50);
            });

            modelBuilder.Entity<calista_schedule_detail>(entity =>
            {
                entity.HasKey(e => e.CALISTA_SCHEDULE_DETAIL_ID)
                    .HasName("PRIMARY");

                entity.Property(e => e.CALISTA_SCHEDULE_DETAIL_ID).HasComment("Id");

                entity.Property(e => e.ARRIVAL_TIME).HasMaxLength(200);

                entity.Property(e => e.CY_CUTOFF_TIME).HasMaxLength(200);

                entity.Property(e => e.DEPARTURE_TIME).HasMaxLength(200);

                entity.Property(e => e.PORT_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PORT_NAME).HasMaxLength(200);

                entity.Property(e => e.SCH_SERVICE).HasMaxLength(50);

                entity.Property(e => e.SCH_VESSEL_NAME).HasMaxLength(200);

                entity.Property(e => e.SCH_VOYAGE_NO).HasMaxLength(30);

                entity.Property(e => e.TRANSPORT_MODE).HasMaxLength(30);
            });

            modelBuilder.Entity<calista_schedule_search>(entity =>
            {
                entity.HasKey(e => e.CALISTA_SCHEDULE_SEARCH_ID)
                    .HasName("PRIMARY");

                entity.Property(e => e.POD_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.POL_CODE)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ff_class>(entity =>
            {
                entity.HasKey(e => e.FF_CLASS_ID)
                    .HasName("PRIMARY");

                entity.HasComment("货代价格等级管理");

                entity.Property(e => e.FF_CLASS_ID).HasComment("货代等级流水号");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_CODE_SALE)
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_ID_SALE).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("承运人名称");

                entity.Property(e => e.CARRIER_NAME_SALE)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("承运人名称");

                entity.Property(e => e.COMPANY_TYPE).HasComment("公司类型\r\n	1.货代\r\n	2.直客");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.FF_CLASS_SET_ID).HasComment("货代等级流水号");

                entity.Property(e => e.FF_ID).HasComment("货代公司ID");

                entity.Property(e => e.FF_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("货代公司中文名");

                entity.Property(e => e.FF_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("货代公司英文名");

                entity.Property(e => e.FF_SHORTNAME)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("货代公司简称");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.ROUTE_CLASS_CODE).HasComment("航线价格等级\r\n	1:T1\r\n	2:T2\r\n	3:T3");

                entity.Property(e => e.ROUTE_CLASS_NAME)
                    .HasMaxLength(10)
                    .HasComment("航线价格等级名称");

                entity.Property(e => e.ROUTE_CODE)
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.ROUTE_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("航线名称");

                entity.Property(e => e.STATUS).HasComment("状态(1有效,0无效)");

                entity.Property(e => e.VALID).HasComment("有效性");
            });

            modelBuilder.Entity<ff_class_set>(entity =>
            {
                entity.HasKey(e => e.FF_CLASS_SET_ID)
                    .HasName("PRIMARY");

                entity.HasComment("货代价格等级管理");

                entity.Property(e => e.FF_CLASS_SET_ID).HasComment("货代等级流水号");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_CODE_SALE)
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_ID_SALE).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("承运人名称");

                entity.Property(e => e.CARRIER_NAME_SALE)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("承运人名称");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DELETE_MARK)
                    .HasDefaultValueSql("'0'")
                    .HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.ROUTE_CLASS_CODE).HasComment("航线价格等级1:T1 2:T2 3:T3 4:T4");

                entity.Property(e => e.ROUTE_CLASS_NAME)
                    .HasMaxLength(10)
                    .HasComment("航线价格等级名称");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.ROUTE_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("航线名称");

                entity.Property(e => e.STATUS)
                    .HasDefaultValueSql("'0'")
                    .HasComment("状态(0有效.1无效)");
            });

            modelBuilder.Entity<ow_surcharge>(entity =>
            {
                entity.HasKey(e => e.OW_SURCHARGE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("超重附加费");

                entity.Property(e => e.OW_SURCHARGE_ID).HasComment("超重附加费ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_TYPE).HasComment("附加类型(1有效期 2船期)");

                entity.Property(e => e.POL_ID).HasComment("装货港");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");
            });

            modelBuilder.Entity<ow_surcharge_detail>(entity =>
            {
                entity.HasKey(e => e.OW_SURCHARGE_DETAIL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("超重附加费明细");

                entity.Property(e => e.OW_SURCHARGE_DETAIL_ID).HasComment("超重附加费明细ID");

                entity.Property(e => e.BEGIN_WEIGHT)
                    .HasColumnType("decimal(8,0)")
                    .HasComment("开始重量");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CONTA_SIZETYPE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("箱型");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.END_WEIGHT)
                    .HasColumnType("decimal(8,0)")
                    .HasComment("结束重量");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_SURCHARGE_ID).HasComment("超重附加费ID");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.SURCHARGE_AMOUNT)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("附加费");
            });

            modelBuilder.Entity<ow_surcharge_port>(entity =>
            {
                entity.HasKey(e => e.OW_SURCHARGE_PORT_ID)
                    .HasName("PRIMARY");

                entity.HasComment("超重附加费港口");

                entity.Property(e => e.OW_SURCHARGE_PORT_ID).HasComment("超重附加费港口ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_SURCHARGE_ID).HasComment("超重附加费ID");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");
            });

            modelBuilder.Entity<ow_surcharge_schedule>(entity =>
            {
                entity.HasKey(e => e.OW_SURCHARGE_SCHEDULEL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("超重附加费船期");

                entity.Property(e => e.OW_SURCHARGE_SCHEDULEL_ID).HasComment("超重附加费船期ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_SURCHARGE_ID).HasComment("超重附加费ID");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期ID");

                entity.Property(e => e.VESSELVOY)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("船名航次");
            });

            modelBuilder.Entity<port_by_company>(entity =>
            {
                entity.HasKey(e => e.PORT_BY_COMPANY_ID)
                    .HasName("PRIMARY");

                entity.HasComment("定义各销售公司可操作的港口");

                entity.Property(e => e.PORT_BY_COMPANY_ID).HasComment("公司港口流水号");

                entity.Property(e => e.BASE_CITY_ID).HasComment("基础城市流水号");

                entity.Property(e => e.BASE_COUNTRY_ID).HasComment("国家地区流水号");

                entity.Property(e => e.BASE_LOCATION_ID).HasComment("地点流水号");

                entity.Property(e => e.BASE_PROVINCE_ID).HasComment("基础省州流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("城市中文名称");

                entity.Property(e => e.CITY_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("城市英文名称");

                entity.Property(e => e.COMPANY_CODE)
                    .HasMaxLength(50)
                    .HasComment("公司代码");

                entity.Property(e => e.COMPANY_ID).HasComment("公司的流水号");

                entity.Property(e => e.COMPANY_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("公司名称简体");

                entity.Property(e => e.COMPANY_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("公司名称英文");

                entity.Property(e => e.COMPANY_SHORTNAME_CN)
                    .HasMaxLength(200)
                    .HasComment("公司简称简体");

                entity.Property(e => e.COMPANY_SHORTNAME_EN)
                    .HasMaxLength(200)
                    .HasComment("公司简称英文");

                entity.Property(e => e.COUNTRY_CODE)
                    .HasMaxLength(30)
                    .HasComment("国家或地区代码");

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("国家中文名称");

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("国家或地区名称");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记   0-未删除   1-标记删除");

                entity.Property(e => e.LOCATION_CODE)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("地点代码");

                entity.Property(e => e.LOCATION_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasComment("地点中文名称");

                entity.Property(e => e.LOCATION_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasComment("地点名称");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.PROVINCE_CODE)
                    .HasMaxLength(30)
                    .HasComment("省或州代码");

                entity.Property(e => e.PROVINCE_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("省或州中文名称");

                entity.Property(e => e.PROVINCE_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("省或州名称");

                entity.Property(e => e.VALID).HasComment("状态:  0-无效  1-有效");
            });

            modelBuilder.Entity<port_change_fee>(entity =>
            {
                entity.HasKey(e => e.PORT_CHANGE_FEE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("港口改期费");

                entity.Property(e => e.PORT_CHANGE_FEE_ID).HasComment("港口改期费ID");

                entity.Property(e => e.CANCEL_AFTER_FEE)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("开仓后退舱费");

                entity.Property(e => e.CANCEL_CLOSE_FEE)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("截单后退舱费");

                entity.Property(e => e.CANCEL_PRE_FEE)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("开仓前退舱费");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CHANGE_FEE)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("改期费");

                entity.Property(e => e.CONFIRM_STEADY_TEU).HasComment("固定舱位已售数量");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.FREE_CHANGE_TIME).HasComment("免费改期次数");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POL_ID).HasComment("装货港");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.STEADY_TEU).HasComment("固定舱位");
            });

            modelBuilder.Entity<presale_main_list>(entity =>
            {
                entity.HasKey(e => e.PRESALE_MAIN_LIST_ID)
                    .HasName("PRIMARY");

                entity.HasComment("预售运价主表");

                entity.Property(e => e.PRESALE_MAIN_LIST_ID).HasComment("预售运价主表");

                entity.Property(e => e.BOOKING_QTY).HasComment("订单数量");

                entity.Property(e => e.BOOKING_TEU).HasComment("订舱数");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.COMPANY_TEU).HasComment("公司舱位数");

                entity.Property(e => e.CONFIRM_COMPANY_TEU).HasComment("公司已放舱位");

                entity.Property(e => e.CONFIRM_OW_TEU).HasComment("超重已放舱位");

                entity.Property(e => e.CONFIRM_PORT_TEU).HasComment("港口已放舱位");

                entity.Property(e => e.CONFIRM_PREBRANCH_TEU).HasComment("前程已放舱");

                entity.Property(e => e.CONFIRM_RATE_TEU).HasComment("运价已放舱位");

                entity.Property(e => e.CONFIRM_TEU).HasComment("已放舱数");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.GP20_DIFF)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20GP预售差价");

                entity.Property(e => e.GP40_DIFF)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40GP预售差价");

                entity.Property(e => e.GP45_DIFF)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45HC预售差价");

                entity.Property(e => e.HQ40_DIFF)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40HC预售差价");

                entity.Property(e => e.IS_AUTO_RELEASE).HasComment("自动放舱");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_TEU).HasComment("超重舱位数");

                entity.Property(e => e.POL_ID).HasComment("装货港");

                entity.Property(e => e.PORT_TEU).HasComment("港口舱位数");

                entity.Property(e => e.PREBRANCH_TEU).HasComment("前程舱位数");

                entity.Property(e => e.RATE_QTY).HasComment("运价数量");

                entity.Property(e => e.RATE_TEU).HasComment("运价舱位");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.STATUS).HasComment("-1停售 0草稿 90已发布");

                entity.Property(e => e.TOTAL_TEU).HasComment("整船舱位数");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<presale_order>(entity =>
            {
                entity.HasKey(e => e.PRESALE_ORDER_ID)
                    .HasName("PRIMARY");

                entity.HasComment("预售订单表");

                entity.Property(e => e.PRESALE_ORDER_ID).HasComment("预售订单ID");

                entity.Property(e => e.CANCEL_TEU).HasComment("已退舱数量");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("承运人销售公司ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CHANGE_TEU).HasComment("已改期TEU");

                entity.Property(e => e.CHANGE_TIME).HasComment("已改期次数");

                entity.Property(e => e.CLOSE_TIME).HasComment("截关");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CUSTOMER_ID).HasComment("订舱客户ID");

                entity.Property(e => e.CUSTOMER_TYPE).HasComment("客户类型(1直客 2货代)");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.DELIVERY_CITY_ID).HasComment("交货地城市");

                entity.Property(e => e.DELIVERY_ID).HasComment("交货地ID");

                entity.Property(e => e.FF_ID).HasComment("货代公司流水号");

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("GP20价");

                entity.Property(e => e.GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("GP40价");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("HC45价");

                entity.Property(e => e.HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("HC40价");

                entity.Property(e => e.LEAVE_TIME).HasComment("开船");

                entity.Property(e => e.LINKER_ADDRESS)
                    .HasMaxLength(500)
                    .HasComment("联系人地址");

                entity.Property(e => e.LINKER_EMAIL)
                    .HasMaxLength(100)
                    .HasComment("联系人邮件");

                entity.Property(e => e.LINKER_FAX)
                    .HasMaxLength(50)
                    .HasComment("联系人传真");

                entity.Property(e => e.LINKER_NAME)
                    .HasMaxLength(50)
                    .HasComment("联系人姓名");

                entity.Property(e => e.LINKER_TEL)
                    .HasMaxLength(50)
                    .HasComment("联系人电话\r\n	国家-区号-电话号码-分机号");

                entity.Property(e => e.MAIN_ORDER_ID).HasComment("原始订单ID(用于改期时)");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.ORDER_NO)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("订单号码");

                entity.Property(e => e.ORDER_REMARK)
                    .HasMaxLength(2000)
                    .HasComment("订舱备注");

                entity.Property(e => e.ORDER_SOURCE)
                    .HasDefaultValueSql("'1'")
                    .HasComment("订单来源(1预售 2改期)");

                entity.Property(e => e.OW_CANCEL_TEU).HasComment("重柜已退舱数量");

                entity.Property(e => e.OW_CHANGE_TEU).HasComment("重柜改期TEU");

                entity.Property(e => e.OW_PRE_TEU).HasComment("重柜TEU");

                entity.Property(e => e.OW_SURPLUS_TEU).HasComment("重柜可用TEU");

                entity.Property(e => e.OW_USE_TEU).HasComment("重柜已使用TEU");

                entity.Property(e => e.PAENT_ORDER_ID).HasComment("上级订单ID(用于改期时)");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PRESALE_RATE_ID).HasComment("预售运价流水号");

                entity.Property(e => e.PRE_TEU).HasComment("订舱TEU");

                entity.Property(e => e.PRODUCT_ID).HasComment("产品ID");

                entity.Property(e => e.PRODUCT_TYPE).HasComment("产品类型\r\n	10:直航产品\r\n	20:中转产品");

                entity.Property(e => e.RECEIPT_CITY_ID).HasComment("收货地城市");

                entity.Property(e => e.RECEIPT_ID).HasComment("收货地ID");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.SHIP_ROUTE_AREA_ID).HasComment("航线区域ID");

                entity.Property(e => e.STATUS).HasComment("100 已预订");

                entity.Property(e => e.SURPLUS_TEU).HasComment("普货可用TEU");

                entity.Property(e => e.TT)
                    .HasDefaultValueSql("'0'")
                    .HasComment("航程");

                entity.Property(e => e.USE_TEU).HasComment("已使用TEU");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<presale_order_cancel>(entity =>
            {
                entity.HasKey(e => e.PRESALE_ORDER_CANCEL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("预售订单退舱信息");

                entity.Property(e => e.PRESALE_ORDER_CANCEL_ID).HasComment("预售订单改期ID");

                entity.Property(e => e.AMOUNT)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("退舱金额");

                entity.Property(e => e.APPLY_ID).HasComment("申请人ID");

                entity.Property(e => e.APPLY_NAME)
                    .HasMaxLength(100)
                    .HasComment("申请人姓名");

                entity.Property(e => e.APPLY_REMARK)
                    .HasMaxLength(2000)
                    .HasComment("申请改期说明");

                entity.Property(e => e.CANCEL_TEU).HasComment("退舱TEU");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CHECK_ID).HasComment("审核人ID");

                entity.Property(e => e.CHECK_NAME)
                    .HasMaxLength(100)
                    .HasComment("审核人姓名");

                entity.Property(e => e.CHECK_REMARK)
                    .HasMaxLength(2000)
                    .HasComment("审核备注");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("退舱币种");

                entity.Property(e => e.DATE_TYPE).HasComment("退舱时间类型: 1开舱前退舱 2开舱后截单前退舱 3截单后退舱");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.FF_ID).HasComment("货代公司ID");

                entity.Property(e => e.MAIN_ORDER_ID).HasComment("原始订单ID(用于改期时)");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_CANCEL_TEU).HasComment("重货退舱TEU");

                entity.Property(e => e.PRESALE_ORDER_ID).HasComment("订单ID");

                entity.Property(e => e.PRICE)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("退舱费-单价");

                entity.Property(e => e.STATUS).HasComment("状态 ( -10已拒绝  0已申请 10改期成功)");
            });

            modelBuilder.Entity<presale_order_change>(entity =>
            {
                entity.HasKey(e => e.PRESALE_ORDER_CHANGE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("预售订单改期信息");

                entity.Property(e => e.PRESALE_ORDER_CHANGE_ID).HasComment("预售订单改期ID");

                entity.Property(e => e.AMOUNT)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("改期金额");

                entity.Property(e => e.APPLY_ID).HasComment("申请人ID");

                entity.Property(e => e.APPLY_NAME)
                    .HasMaxLength(100)
                    .HasComment("申请人姓名");

                entity.Property(e => e.APPLY_REMARK)
                    .HasMaxLength(2000)
                    .HasComment("申请改期说明");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CHANGE_TEU).HasComment("改期TEU");

                entity.Property(e => e.CHECK_ID).HasComment("审核人ID");

                entity.Property(e => e.CHECK_NAME)
                    .HasMaxLength(100)
                    .HasComment("审核人姓名");

                entity.Property(e => e.CHECK_REMARK)
                    .HasMaxLength(2000)
                    .HasComment("审核备注");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .HasMaxLength(50)
                    .HasComment("币种");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.FF_ID).HasComment("货代公司ID");

                entity.Property(e => e.IS_FREE).HasComment("是否免费改期");

                entity.Property(e => e.MAIN_ORDER_ID).HasComment("原始订单ID(用于改期时)");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.NEW_PRESALE_ORDER_ID).HasComment("新订单ID");

                entity.Property(e => e.NEW_WEEK_ID).HasComment("新订单周数");

                entity.Property(e => e.OW_CHANGE_TEU).HasComment("重货改期TEU");

                entity.Property(e => e.PRESALE_ORDER_ID).HasComment("订单ID");

                entity.Property(e => e.PRICE)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("改期单价");

                entity.Property(e => e.STATUS).HasComment("状态 ( -10已拒绝  0已申请 10改期成功)");

                entity.Property(e => e.WEEK_ID).HasComment("原出运周");
            });

            modelBuilder.Entity<presale_rate>(entity =>
            {
                entity.HasKey(e => e.PRESALE_RATE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("预售运价表");

                entity.Property(e => e.PRESALE_RATE_ID).HasComment("预售运价ID");

                entity.Property(e => e.AFTER_BRANCH_PRODUCT_ID)
                    .HasMaxLength(50)
                    .HasComment("后程支线产品ID");

                entity.Property(e => e.AFTER_BRANCH_RATE_ID).HasComment("后程支线运价ID");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CLOSE_TIME).HasComment("截关");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("基本运价币种");

                entity.Property(e => e.CURRENT_GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("当前20尺平柜运价");

                entity.Property(e => e.CURRENT_GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("当前40尺平柜运价");

                entity.Property(e => e.CURRENT_GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("当前45尺柜运价");

                entity.Property(e => e.CURRENT_HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("当前40尺高柜运价");

                entity.Property(e => e.CURRENT_LEVEL)
                    .HasDefaultValueSql("'1'")
                    .HasComment("当前价格等级");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.DELIVERY_CITY_ID).HasComment("交货地城市");

                entity.Property(e => e.DELIVERY_CODE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("交货地代码");

                entity.Property(e => e.DELIVERY_ID).HasComment("交货地ID");

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺平柜运价");

                entity.Property(e => e.GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺平柜运价");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺柜运价");

                entity.Property(e => e.HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺高柜运价");

                entity.Property(e => e.IS_MAIN_PRODUCT).HasComment("是否为干线产品");

                entity.Property(e => e.LEAVE_TIME).HasComment("开船");

                entity.Property(e => e.MAIN_PRODUCT_ID).HasComment("干线产品ID");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市");

                entity.Property(e => e.POD_CODE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("卸货港代码");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市");

                entity.Property(e => e.POL_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("装货港代码");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PRESALE_MAIN_LIST_ID).HasComment("预售运价主表");

                entity.Property(e => e.PRESALE_RATE_MAIN_ID).HasComment("干线预售运价ID");

                entity.Property(e => e.PRE_BRANCH_PRODUCT_ID)
                    .HasMaxLength(50)
                    .HasComment("前程支线产品ID");

                entity.Property(e => e.PRE_BRANCH_RATE_ID).HasComment("前程支线运价ID");

                entity.Property(e => e.PRODUCT_ID).HasComment("产品ID");

                entity.Property(e => e.PRODUCT_TYPE).HasComment("产品类型\r\n	10:直航产品\r\n	20:中转产品");

                entity.Property(e => e.RECEIPT_CITY_ID).HasComment("收货地城市");

                entity.Property(e => e.RECEIPT_CODE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("收货地代码");

                entity.Property(e => e.RECEIPT_ID).HasComment("收货地ID");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.STATUS).HasComment("-1停售  0草稿 90已发布 -10历史");

                entity.Property(e => e.TT).HasComment("航程");

                entity.Property(e => e.VIA_CITY_ID).HasComment("中转城市");

                entity.Property(e => e.VIA_CODE)
                    .HasMaxLength(10)
                    .HasComment("中转港代码");

                entity.Property(e => e.VIA_ID).HasComment("中转港ID");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<presale_rate_main>(entity =>
            {
                entity.HasKey(e => e.PRESALE_RATE_MAIN_ID)
                    .HasName("PRIMARY");

                entity.HasComment("预售干线运价表");

                entity.Property(e => e.PRESALE_RATE_MAIN_ID).HasComment("预售干线运价ID");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("基本运价币种");

                entity.Property(e => e.CURRENT_GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("当前20尺平柜运价");

                entity.Property(e => e.CURRENT_GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("当前40尺平柜运价");

                entity.Property(e => e.CURRENT_GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("当前45尺柜运价");

                entity.Property(e => e.CURRENT_HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("当前40尺高柜运价");

                entity.Property(e => e.CURRENT_LEVEL)
                    .HasDefaultValueSql("'1'")
                    .HasComment("当前价格等级");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺平柜运价");

                entity.Property(e => e.GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺平柜运价");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺柜运价");

                entity.Property(e => e.HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺高柜运价");

                entity.Property(e => e.MAIN_PRODUCT_ID).HasComment("干线产品ID");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PRESALE_MAIN_LIST_ID).HasComment("预售运价主表");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.STATUS).HasComment("-1停售 0草稿 90已发布");

                entity.Property(e => e.VIA_ID).HasComment("中转港ID");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<product_main>(entity =>
            {
                entity.HasKey(e => e.PRODUCT_MAIN_ID)
                    .HasName("PRIMARY");

                entity.HasComment("干线产品");

                entity.Property(e => e.PRODUCT_MAIN_ID).HasComment("干线产品ID");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市ID");

                entity.Property(e => e.POD_CODE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("卸货港代码");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市ID");

                entity.Property(e => e.POL_CODE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("装货港代码");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.ROUTE_ID).HasComment("航线ID");

                entity.Property(e => e.TRUNK_ID).HasComment("Ship56的TrunkID");

                entity.Property(e => e.VIA_CITY_ID).HasComment("中转港城市ID");

                entity.Property(e => e.VIA_CODE)
                    .HasMaxLength(50)
                    .HasComment("中转港代码");

                entity.Property(e => e.VIA_ID).HasComment("中转港ID");
            });

            modelBuilder.Entity<rate_branch>(entity =>
            {
                entity.HasKey(e => e.RATE_BRANCH_ID)
                    .HasName("PRIMARY");

                entity.HasComment("支线运价");

                entity.Property(e => e.RATE_BRANCH_ID).HasComment("支线运价ID");

                entity.Property(e => e.BRANCHPORT_ID).HasComment("支线港口ID");

                entity.Property(e => e.BUSINESS_TYPE).HasComment("业务类型(1出口 2进口)");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺平柜运价");

                entity.Property(e => e.GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺平柜运价");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺柜运价");

                entity.Property(e => e.HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺高柜运价");

                entity.Property(e => e.MAINPORT_ID).HasComment("干线港口ID");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.ROUTE_ID).HasComment("航线ID");

                entity.Property(e => e.SHIP_BRANCH_RATE_ID)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("SHIP56支线费用ID");
            });

            modelBuilder.Entity<rate_detail>(entity =>
            {
                entity.HasKey(e => e.RATE_DETAIL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("整箱运价详细表");

                entity.Property(e => e.RATE_DETAIL_ID).HasComment("货代运价细节流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺平柜运价");

                entity.Property(e => e.GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺平柜运价");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺柜运价");

                entity.Property(e => e.HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺高柜运价");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.RATE_ID).HasComment("货代运价流水号");

                entity.Property(e => e.RATE_TYPE).HasComment("运价类型 -1货代价 ,0 FAK价,1~10各个VIP等级价");
            });

            modelBuilder.Entity<rate_land>(entity =>
            {
                entity.HasKey(e => e.RATE_LAND_ID)
                    .HasName("PRIMARY");

                entity.HasComment("陆运费率");

                entity.Property(e => e.RATE_LAND_ID).HasComment("陆运费率ID");

                entity.Property(e => e.BUSINESS_TYPE).HasComment("业务类型(1出口 2进口)");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("币种");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.LAND_CITY_ID).HasComment("内陆城市ID");

                entity.Property(e => e.LAND_FEE_ID).HasComment("陆运费ID (Ship56.Land_Fee.Land_Fee_ID)");

                entity.Property(e => e.LAND_FEE_ROUTE_ID).HasComment("陆运航线关联ID (Ship56.LAND_FEE_ROUTE. ID)");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.PORT_ID).HasComment("港口ID");

                entity.Property(e => e.ROUTE_ID).HasComment("航线ID");
            });

            modelBuilder.Entity<rate_land_detail>(entity =>
            {
                entity.HasKey(e => e.RATE_LAND_DETAIL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("陆运费明细");

                entity.Property(e => e.RATE_LAND_DETAIL_ID).HasComment("陆运费明细ID");

                entity.Property(e => e.BYWEIGHT_LEVEL_ID).HasComment("LAND_FEE_BYWEIGHT.BASE_TRAILER_PRICE_BYWEIGHT_ID");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺价");

                entity.Property(e => e.GP20_DOUBLE)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺双拖价格");

                entity.Property(e => e.GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺价");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺价");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.RATE_LAND_ID).HasComment("陆运费率ID");
            });

            modelBuilder.Entity<rate_main>(entity =>
            {
                entity.HasKey(e => e.RATE_MAIN_ID)
                    .HasName("PRIMARY");

                entity.HasComment("干线产品运价表");

                entity.Property(e => e.RATE_MAIN_ID).HasComment("干线产品运价流水号");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("基本运价币种");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.MAIN_PRODUCT_ID).HasComment("干线产品ID");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.RATE_MAIN_LIST_ID).HasComment("运价主表流水号");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期流水号");

                entity.Property(e => e.STATUS).HasComment("0草稿 90已发布");

                entity.Property(e => e.VESSEL_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("船名");

                entity.Property(e => e.VIA_ID).HasComment("中转港ID");

                entity.Property(e => e.VOYAGE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("航次");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<rate_main_detail>(entity =>
            {
                entity.HasKey(e => e.RATE_MAIN_DETAIL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("整箱干线运价详细");

                entity.Property(e => e.RATE_MAIN_DETAIL_ID).HasComment("干线运价细节流水号");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺平柜运价");

                entity.Property(e => e.GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺平柜运价");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺柜运价");

                entity.Property(e => e.HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺高柜运价");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.RATE_MAIN_ID).HasComment("干线运价流水号");

                entity.Property(e => e.RATE_TYPE).HasComment("运价类型 -1货代价 ,0 FAK价,1~10各个VIP等级价");
            });

            modelBuilder.Entity<rate_main_list>(entity =>
            {
                entity.HasKey(e => e.RATE_MAIN_LIST_ID)
                    .HasName("PRIMARY");

                entity.HasComment("干线产品运价主表");

                entity.Property(e => e.RATE_MAIN_LIST_ID).HasComment("运价主表流水号");

                entity.Property(e => e.BOOKING_QTY).HasComment("订单数量");

                entity.Property(e => e.BOOKING_TEU).HasComment("订舱数");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.COMPANY_TEU).HasComment("公司舱位数");

                entity.Property(e => e.CONFIRM_COMPANY_TEU).HasComment("公司已放舱位");

                entity.Property(e => e.CONFIRM_OW_TEU).HasComment("超重已放舱位");

                entity.Property(e => e.CONFIRM_PORT_TEU).HasComment("港口已放舱位");

                entity.Property(e => e.CONFIRM_PREBRANCH_TEU).HasComment("前程已放舱");

                entity.Property(e => e.CONFIRM_PRESALE_TEU).HasComment("预售已放舱位");

                entity.Property(e => e.CONFIRM_TEU).HasComment("已放舱数");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.IS_AUTO_RELEASE).HasComment("自动放舱");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_TEU).HasComment("超重舱位数");

                entity.Property(e => e.POL_ID).HasComment("装货港");

                entity.Property(e => e.PORT_TEU).HasComment("港口舱位数");

                entity.Property(e => e.PREBRANCH_TEU).HasComment("前程舱位数");

                entity.Property(e => e.PRESALE_TEU).HasComment("预售舱位数");

                entity.Property(e => e.RATE_QTY).HasComment("运价数量");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期流水号");

                entity.Property(e => e.SCHEDULE_PORT_ID).HasComment("船期挂港ID");

                entity.Property(e => e.STATUS).HasComment("0草稿 90已发布");

                entity.Property(e => e.TOTAL_TEU).HasComment("整船舱位数");

                entity.Property(e => e.VESSEL_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("船名");

                entity.Property(e => e.VOYAGE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("航次");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<rate_surcharge>(entity =>
            {
                entity.HasKey(e => e.BASE_SURCHARGE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("附加费管理");

                entity.Property(e => e.BASE_SURCHARGE_ID).HasComment("航线ID");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CHARGE_BOOKING).HasColumnType("decimal(20,4)");

                entity.Property(e => e.CHARGE_GP20).HasColumnType("decimal(20,4)");

                entity.Property(e => e.CHARGE_GP40).HasColumnType("decimal(20,4)");

                entity.Property(e => e.CHARGE_HC40).HasColumnType("decimal(20,4)");

                entity.Property(e => e.CHARGE_HC45).HasColumnType("decimal(20,4)");

                entity.Property(e => e.CREATE_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("创建人账号");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("bit(1)")
                    .HasComment("删除标识");

                entity.Property(e => e.EFFECTIVE_DATE).HasColumnType("date");

                entity.Property(e => e.EXPIRATION_DATE).HasColumnType("date");

                entity.Property(e => e.MODIFY_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("更改人账号");

                entity.Property(e => e.PPCC)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("PP-预付,CC-到付");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.SURCHARGE_TYPE).HasComment("1-基本附加费,2-发生附加费");

                entity.Property(e => e.UNIT).HasComment("0-按箱,1按单");

                entity.Property(e => e.VALID).HasComment("有效性");
            });

            modelBuilder.Entity<rate_surcharge_detail>(entity =>
            {
                entity.HasKey(e => e.RATE_SURCHARGE_DETAIL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("附加费-明细");

                entity.HasIndex(e => e.BASE_SURCHARGE_ID, "FK_IX_RATE_SURCHARGE_DETAIL");

                entity.Property(e => e.BASE_SURCHARGE_ID).HasComment("航线ID");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("创建人账号");

                entity.Property(e => e.MODIFY_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("更改人账号");

                entity.Property(e => e.SUCHARGE_DETAIL_ID).HasComment("明细ID");

                entity.Property(e => e.SUCHARGE_DETAIL_TYPE).HasComment("0-航线,1-收货区域,2装港区域,3卸港区域,4-交货区域");

                entity.HasOne(d => d.BASE_SURCHARGE)
                    .WithMany(p => p.rate_surcharge_detail)
                    .HasForeignKey(d => d.BASE_SURCHARGE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IX_RATE_SURCHARGE_DETAIL");
            });

            modelBuilder.Entity<rate_sync_cargo>(entity =>
            {
                entity.HasComment("运价同步到Cargo");

                entity.Property(e => e.ID)
                    .HasMaxLength(50)
                    .HasComment("ID");

                entity.Property(e => e.RATE_ID)
                    .HasColumnType("decimal(8,0)")
                    .HasComment("运价ID");

                entity.Property(e => e.STATUS)
                    .HasColumnType("decimal(8,0)")
                    .HasComment("状态 (-10同步失败 0未同步  10同步中  20同步成功)");
            });

            modelBuilder.Entity<rates>(entity =>
            {
                entity.HasKey(e => e.RATE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("整箱运价明细表");

                entity.Property(e => e.RATE_ID).HasComment("运价流水号");

                entity.Property(e => e.AFTER_BRANCH_PRODUCT_ID)
                    .HasMaxLength(50)
                    .HasComment("后程支线产品ID");

                entity.Property(e => e.AFTER_BRANCH_RATE_ID).HasComment("后程支线运价ID");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CLOSE_TIME).HasComment("截关");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("基本运价币种");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.DELIVERY_CITY_ID).HasComment("交货地城市");

                entity.Property(e => e.DELIVERY_CODE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("交货地代码");

                entity.Property(e => e.DELIVERY_ID).HasComment("交货地ID");

                entity.Property(e => e.IS_MAIN_PRODUCT).HasComment("是否为干线产品");

                entity.Property(e => e.LEAVE_TIME).HasComment("开船");

                entity.Property(e => e.MAIN_PRODUCT_ID).HasComment("干线产品ID");

                entity.Property(e => e.MAIN_RATE_ID).HasComment("干线运价ID");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市");

                entity.Property(e => e.POD_CODE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("卸货港代码");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市");

                entity.Property(e => e.POL_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("装货港代码");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PRE_BRANCH_PRODUCT_ID)
                    .HasMaxLength(50)
                    .HasComment("前程支线产品ID");

                entity.Property(e => e.PRE_BRANCH_RATE_ID).HasComment("前程支线运价ID");

                entity.Property(e => e.PRODUCT_ID).HasComment("产品ID");

                entity.Property(e => e.PRODUCT_TYPE).HasComment("产品类型\r\n	10:直航产品\r\n	20:中转产品");

                entity.Property(e => e.RATE_MAIN_LIST_ID).HasComment("运价主表流水号");

                entity.Property(e => e.RECEIPT_CITY_ID).HasComment("收货地城市");

                entity.Property(e => e.RECEIPT_CODE)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("收货地代码");

                entity.Property(e => e.RECEIPT_ID).HasComment("收货地ID");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期流水号");

                entity.Property(e => e.STATUS).HasComment("0草稿 90已发布 -10历史");

                entity.Property(e => e.TT).HasComment("航程");

                entity.Property(e => e.VESSEL_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("船名");

                entity.Property(e => e.VIA_CITY_ID).HasComment("中转城市");

                entity.Property(e => e.VIA_CODE)
                    .HasMaxLength(10)
                    .HasComment("中转港代码");

                entity.Property(e => e.VIA_ID).HasComment("中转港ID");

                entity.Property(e => e.VOYAGE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("航次");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<schedule>(entity =>
            {
                entity.HasKey(e => e.SCHEDULE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("船期信息表");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期流水号");

                entity.Property(e => e.CALLSIGN)
                    .HasMaxLength(35)
                    .HasComment("船舶呼号");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运营人名称");

                entity.Property(e => e.COURSE).HasComment("航向\n0-东\n1-西\n2-南\n3-北");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\n0-未删除\n1-标记删除");

                entity.Property(e => e.MD5_VALIDATE).HasMaxLength(100);

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.REMARK).HasComment("备注");

                entity.Property(e => e.SCHEDULE_TYPE).HasComment("船期类型\n0自有船舶\n5自有船舶(乱序)\n10借买舱位");

                entity.Property(e => e.SHIP_OWNER_NAME_CN)
                    .HasMaxLength(50)
                    .HasComment("船舶的船公司中文名称");

                entity.Property(e => e.SHIP_OWNER_NAME_EN)
                    .HasMaxLength(50)
                    .HasComment("船舶的船公司英文名称");

                entity.Property(e => e.SHIP_OWNER_ROUTE)
                    .HasMaxLength(200)
                    .HasComment("船东航线");

                entity.Property(e => e.SHIP_ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("航线代码");

                entity.Property(e => e.SHIP_ROUTE_ID).HasComment("所属航线关联");

                entity.Property(e => e.SHIP_ROUTE_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("航线名称");

                entity.Property(e => e.STATUS).HasComment("状态:\n0-草稿\n10-已发布\n20-已结束");

                entity.Property(e => e.TEU).HasComment("整船可售舱位");

                entity.Property(e => e.VALID).HasComment("有效性\n0-无效\n1-有效");

                entity.Property(e => e.VESSEL_CODE)
                    .HasMaxLength(200)
                    .HasComment("船舶代码");

                entity.Property(e => e.VESSEL_ID).HasComment("船舶信息关联");

                entity.Property(e => e.VESSEL_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("船舶名称");

                entity.Property(e => e.VESSEL_NAME_CN)
                    .HasMaxLength(100)
                    .HasComment("船舶中文");

                entity.Property(e => e.VESSEL_OWNER).HasComment("船东");

                entity.Property(e => e.VESSEL_TYPE).HasComment("船舶类型\n0干线船\n1支线船");

                entity.Property(e => e.VOYAGE)
                    .HasMaxLength(35)
                    .HasComment("航次");

                entity.Property(e => e.VOYAGE_BACK)
                    .HasMaxLength(35)
                    .HasComment("返程航次");

                entity.Property(e => e.VOYAGE_GO)
                    .HasMaxLength(35)
                    .HasComment("去程航次");

                entity.Property(e => e.WEEKS).HasComment("出运周(周数)");

                entity.Property(e => e.YEARS).HasComment("出运周(年)");
            });

            modelBuilder.Entity<schedule_ports>(entity =>
            {
                entity.HasKey(e => e.SCHEDULE_PORT_ID)
                    .HasName("PRIMARY");

                entity.HasComment("船期信息挂靠港");

                entity.HasIndex(e => e.SCHEDULE_ID, "SCHEDULE_PORTS_SCHEDULEID");

                entity.HasIndex(e => new { e.SHIP_ROUTE_ID, e.PORT_CODE }, "SCHE_PORT_ROUT_INDEX");

                entity.Property(e => e.SCHEDULE_PORT_ID).HasComment("船期挂靠港流水号");

                entity.Property(e => e.BASE_CITY_ID).HasComment("基础城市流水号");

                entity.Property(e => e.BERTH)
                    .HasMaxLength(100)
                    .HasComment("泊位");

                entity.Property(e => e.CALLSIGN)
                    .HasMaxLength(35)
                    .HasComment("船舶呼号");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("承运人代码");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运营人名称");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("城市中文名称");

                entity.Property(e => e.CITY_NAME_EN)
                    .HasMaxLength(200)
                    .HasComment("城市名称");

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("国家或地区代码");

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("国家中文名称");

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("国家或地区名称");

                entity.Property(e => e.COURSE).HasComment("航向\n0-东\n1-西\n2-南\n3-北");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\n0-未删除\n1-标记删除");

                entity.Property(e => e.DEST_PORT_CODE)
                    .HasMaxLength(200)
                    .HasComment("目的港代码");

                entity.Property(e => e.DOCK)
                    .HasMaxLength(50)
                    .HasComment("港区");

                entity.Property(e => e.MD5_VALIDATE).HasMaxLength(100);

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.NEXT_PORT_ID).HasComment("上一港口ID");

                entity.Property(e => e.OPEN_TIME).HasComment("开舱时间在抵港前多少天");

                entity.Property(e => e.PARK_TIME).HasComment("码头靠泊时间(按天)");

                entity.Property(e => e.PHASE).HasComment("类型\n0-装卸港\n10装港\n20卸港\n-10跳港\n-20切入Phase In\n-30切出Phase Out");

                entity.Property(e => e.PORT_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("港口代码");

                entity.Property(e => e.PORT_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("港口中文名称");

                entity.Property(e => e.PORT_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("港口英文名称");

                entity.Property(e => e.PREVIOUS_PORT_ID).HasComment("上一港口ID");

                entity.Property(e => e.PROVINCE_CODE)
                    .HasMaxLength(30)
                    .HasComment("省或州代码");

                entity.Property(e => e.PROVINCE_NAME)
                    .HasMaxLength(200)
                    .HasComment("省或州名称");

                entity.Property(e => e.REPEAT_PORT).HasComment("是否是重复挂港，如果是重复的挂港，则不参与装港匹配");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期流水号");

                entity.Property(e => e.SEQUENCE).HasComment("港序");

                entity.Property(e => e.SHIP_ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("航线代码");

                entity.Property(e => e.SHIP_ROUTE_ID).HasComment("所属航线关联");

                entity.Property(e => e.SHIP_ROUTE_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("航线名称");

                entity.Property(e => e.STATUS).HasComment("状态\n-1-历史\n0-草稿\n10-已发布\n20-已结束");

                entity.Property(e => e.TRANSITTIME)
                    .HasColumnType("decimal(10,1)")
                    .HasComment("航行时间(小时),离开上一港到达本港中间的航行时间");

                entity.Property(e => e.TRANSIT_TIME).HasComment("抵达本港的航行天数");

                entity.Property(e => e.VESSEL_CODE)
                    .HasMaxLength(200)
                    .HasComment("船舶代码");

                entity.Property(e => e.VESSEL_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("船舶名称");

                entity.Property(e => e.VOYAGE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("航次");

                entity.Property(e => e.WEEKS).HasComment("出运周(周数)");

                entity.Property(e => e.WINDOW_TIME_END).HasComment("窗口关闭时间");

                entity.Property(e => e.WINDOW_TIME_START).HasComment("窗口开始时间(整数部分记录周一~周日，小数部分记录0~1440的时分数值)");

                entity.Property(e => e.YEARS).HasComment("出运周(年)");
            });

            modelBuilder.Entity<ship_route>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("航线管理");

                entity.Property(e => e.SHIP_ROUTE_ID).HasComment("航线ID");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("创建人账号");

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("bit(1)")
                    .HasComment("删除标识");

                entity.Property(e => e.MODIFY_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("更改人账号");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.SHIP_ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("航线代码");

                entity.Property(e => e.VALID).HasComment("有效性");
            });

            modelBuilder.Entity<ship_route_old>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_ID)
                    .HasName("PRIMARY");

                entity.HasComment("航线信息表");

                entity.Property(e => e.SHIP_ROUTE_ID).HasComment("航线信息流水号");

                entity.Property(e => e.BERTH_WEEK).HasComment("班期(周一~周日，每天用1位数字表示)");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("运营人代码");

                entity.Property(e => e.CARRIER_ID).HasComment("运营人流水号");

                entity.Property(e => e.CARRIER_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运营人名称");

                entity.Property(e => e.CARRIER_SHORTNAME)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasComment("运营人简称");

                entity.Property(e => e.COURSE)
                    .HasMaxLength(10)
                    .HasComment("航向\n0-东1-西2-南3-北\n021为东南西\n23为南北");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DAYS).HasComment("全程天数");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\n0-未删除\n1-标记删除");

                entity.Property(e => e.FREQUENCY).HasComment("班期频率");

                entity.Property(e => e.LINE_BUSI_TYPE)
                    .HasMaxLength(200)
                    .HasComment("航线运营类型");

                entity.Property(e => e.MANAGER_CODE)
                    .HasMaxLength(50)
                    .HasComment("航线经理代码");

                entity.Property(e => e.MANAGER_FULLNAME)
                    .HasMaxLength(50)
                    .HasComment("航线经理姓名");

                entity.Property(e => e.MANAGER_ID).HasComment("航线经理ID(来源UC的用户表)");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.NEGATIVE_FREIGHT).HasComment("允许负运价");

                entity.Property(e => e.PICTURE)
                    .HasMaxLength(200)
                    .HasComment("航线图片");

                entity.Property(e => e.RATE_RULE).HasComment("价格规则\n0:等级价格\n1:等级折扣");

                entity.Property(e => e.REMARK).HasComment("备注");

                entity.Property(e => e.SALEMAN).HasComment("航线销售员");

                entity.Property(e => e.SHIP_ROUTE_AREA_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线区域代码");

                entity.Property(e => e.SHIP_ROUTE_AREA_ID).HasComment("航线区域关联");

                entity.Property(e => e.SHIP_ROUTE_AREA_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("航线区域名称");

                entity.Property(e => e.SHIP_ROUTE_CIRCLE_CODE)
                    .HasMaxLength(100)
                    .HasComment("航线周期代码");

                entity.Property(e => e.SHIP_ROUTE_CIRCLE_NAME)
                    .HasMaxLength(200)
                    .HasComment("航线周期名称");

                entity.Property(e => e.SHIP_ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("航线代码");

                entity.Property(e => e.SHIP_ROUTE_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("航线名称");

                entity.Property(e => e.SHIP_ROUTE_SHORT_CODE)
                    .HasMaxLength(10)
                    .HasComment("航线简码");

                entity.Property(e => e.SPAN).HasComment("班期跨度");

                entity.Property(e => e.VALID).HasComment("状态:\n0-无效\n1-有效");
            });

            modelBuilder.Entity<ship_route_ports>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_PORT_ID)
                    .HasName("PRIMARY");

                entity.HasComment("航线挂港");

                entity.HasIndex(e => e.SHIP_ROUTE_ID, "FK_SHIP_ROUTE_PORTS");

                entity.Property(e => e.SHIP_ROUTE_PORT_ID).HasComment("航线挂港ID");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CLOSE_TIME).HasComment("截重");

                entity.Property(e => e.CREATE_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("创建人账号");

                entity.Property(e => e.CUT_BOOKING_DATE).HasComment("截舱");

                entity.Property(e => e.CUT_MATERIAL_DATE).HasComment("截文件");

                entity.Property(e => e.CUT_OFF_DATE).HasComment("截关");

                entity.Property(e => e.CUT_VGM_DATE).HasComment("截VGM");

                entity.Property(e => e.CUT_VIA_DATE).HasComment("截中转");

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("bit(1)")
                    .HasComment("删除标识");

                entity.Property(e => e.LEAVE_TIME).HasComment("离港");

                entity.Property(e => e.MODIFY_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("更改人账号");

                entity.Property(e => e.OPEN_TIME).HasComment("开舱");

                entity.Property(e => e.PACK_TIME).HasComment("靠泊");

                entity.Property(e => e.PORT_CITY_ID).HasComment("港口城市ID");

                entity.Property(e => e.PORT_COUNTRY_ID).HasComment("港口国家ID");

                entity.Property(e => e.PORT_ID).HasComment("港口ID");

                entity.Property(e => e.SEQUENCE).HasComment("顺序");

                entity.Property(e => e.SHIP_ROUTE_ID).HasComment("航线ID");

                entity.HasOne(d => d.SHIP_ROUTE)
                    .WithMany(p => p.ship_route_ports)
                    .HasForeignKey(d => d.SHIP_ROUTE_ID)
                    .HasConstraintName("FK_SHIP_ROUTE_PORTS");
            });

            modelBuilder.Entity<ship_route_ports_old>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_PORT_ID)
                    .HasName("PRIMARY");

                entity.HasComment("航线挂港信息");

                entity.Property(e => e.SHIP_ROUTE_PORT_ID).HasComment("航线挂港信息流水号");

                entity.Property(e => e.BASE_CITY_ID).HasComment("基础城市流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("运营人流水号");

                entity.Property(e => e.CITY_NAME)
                    .HasMaxLength(200)
                    .HasComment("城市名称");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .HasComment("城市中文名称");

                entity.Property(e => e.CLOSE_DATE).HasComment("截重 (在抵港前多少天)");

                entity.Property(e => e.CLOSE_TIME).HasComment("截重");

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("国家或地区代码");

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("国家中文名称");

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("国家或地区名称");

                entity.Property(e => e.COURSE).HasComment("航向\n0-东\n1-西\n2-南\n3-北");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.CUT_BOOKING_DATE).HasComment("截舱时间 (在抵港前多少天)");

                entity.Property(e => e.CUT_MATERIAL_DATE).HasComment("截补料 (在抵港前多少天)");

                entity.Property(e => e.CUT_OFF_DATE).HasComment("截关 (在抵港前多少天)");

                entity.Property(e => e.CUT_VIA_DATE).HasComment("截中转 (在抵港前多少天)");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\n0-未删除\n1-标记删除");

                entity.Property(e => e.DOCK)
                    .HasMaxLength(50)
                    .HasComment("港区");

                entity.Property(e => e.LEAVE_TIME).HasComment("开船");

                entity.Property(e => e.MANAGER_CODE)
                    .HasMaxLength(50)
                    .HasComment("口岸航线经理代码");

                entity.Property(e => e.MANAGER_FULLNAME)
                    .HasMaxLength(50)
                    .HasComment("口岸航线经理姓名");

                entity.Property(e => e.MANAGER_ID).HasComment("口岸航线经理ID(来源UC的用户表)");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.OPEN_DATE).HasComment("开舱时间 (在抵港前多少天)");

                entity.Property(e => e.OPEN_TIME).HasComment("开舱时间在抵港前多少天");

                entity.Property(e => e.PARK_TIME).HasComment("码头靠泊时间(单位H,窗口关闭时间-窗口开始时间)");

                entity.Property(e => e.PORT_CODE)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("港口代码");

                entity.Property(e => e.PORT_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("港口中文名称");

                entity.Property(e => e.PORT_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("港口英文名称");

                entity.Property(e => e.PROVINCE_CODE)
                    .HasMaxLength(30)
                    .HasComment("省或州代码");

                entity.Property(e => e.PROVINCE_NAME)
                    .HasMaxLength(200)
                    .HasComment("省或州名称");

                entity.Property(e => e.SEQUENCE).HasComment("港序");

                entity.Property(e => e.SHIP_ROUTE_ID).HasComment("航线信息表流水号");

                entity.Property(e => e.TRANSITTIME).HasComment("航行时间(小时),离开上一港到达本港中间的航行时间");

                entity.Property(e => e.TT).HasComment("航程(小时)");

                entity.Property(e => e.WINDOW_TIME_END)
                    .HasColumnType("decimal(65,30)")
                    .HasComment("窗口关闭时间");

                entity.Property(e => e.WINDOW_TIME_START)
                    .HasColumnType("decimal(65,30)")
                    .HasComment("窗口开始时间(整数部分记录周一~周日，小数部分记录0~1440的时分数值)");
            });

            modelBuilder.Entity<ship_route_products>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_PRODUCT_ID)
                    .HasName("PRIMARY");

                entity.HasComment("航线产品");

                entity.HasIndex(e => e.SHIP_ROUTE_ID, "FK_SHIP_ROUTE_PRODUCTS");

                entity.Property(e => e.SHIP_ROUTE_PRODUCT_ID).HasComment("航线产品ID");

                entity.Property(e => e.ARRIVE_CITY_ID).HasComment("目的港城市ID");

                entity.Property(e => e.ARRIVE_COUNT_ID).HasComment("目的港国家ID");

                entity.Property(e => e.ARRIVE_PORT_ID).HasComment("目的港ID");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CLOSE_TIME).HasComment("截重");

                entity.Property(e => e.CREATE_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("创建人账号");

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("bit(1)")
                    .HasComment("删除标识");

                entity.Property(e => e.DEPARTURE_CITY_ID).HasComment("起运港城市ID");

                entity.Property(e => e.DEPARTURE_COUNT_ID).HasComment("起运港国家ID");

                entity.Property(e => e.DEPARTURE_PORT_ID).HasComment("起运港ID");

                entity.Property(e => e.LEAVE_TIME).HasComment("离港");

                entity.Property(e => e.MODIFY_USERNAME)
                    .HasMaxLength(100)
                    .HasComment("更改人账号");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.SHIP_ROUTE_ID).HasComment("航线ID");

                entity.Property(e => e.TT).HasComment("航程");

                entity.Property(e => e.VALID).HasComment("有效性");

                entity.HasOne(d => d.SHIP_ROUTE)
                    .WithMany(p => p.ship_route_products)
                    .HasForeignKey(d => d.SHIP_ROUTE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHIP_ROUTE_PRODUCTS");
            });

            modelBuilder.Entity<ship_route_products_old>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_PRODUCT_ID)
                    .HasName("PRIMARY");

                entity.HasComment("航线直航产品");

                entity.Property(e => e.SHIP_ROUTE_PRODUCT_ID).HasComment("航线产品流水号");

                entity.Property(e => e.ARRIVE_CITY_CNAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运抵港城市中文名称");

                entity.Property(e => e.ARRIVE_CITY_ENAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运抵港城市名称");

                entity.Property(e => e.ARRIVE_CITY_ID).HasComment("运抵港城市流水号");

                entity.Property(e => e.ARRIVE_CODE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("运抵港代码");

                entity.Property(e => e.ARRIVE_COUNTRY_CNAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运抵港国家中文名称");

                entity.Property(e => e.ARRIVE_COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("运抵港国家或地区代码");

                entity.Property(e => e.ARRIVE_COUNTRY_ENAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运抵港国家或地区名称");

                entity.Property(e => e.ARRIVE_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运抵港中文名称");

                entity.Property(e => e.ARRIVE_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("运抵港英文名称");

                entity.Property(e => e.ARRIVE_PORT_ID).HasComment("运抵挂港流水号");

                entity.Property(e => e.ARRIVE_PROVINCE_CODE)
                    .HasMaxLength(30)
                    .HasComment("运抵港省或州代码");

                entity.Property(e => e.ARRIVE_PROVINCE_NAME)
                    .HasMaxLength(200)
                    .HasComment("运抵港省或州名称");

                entity.Property(e => e.AVG_TT).HasComment("平均航程(天)");

                entity.Property(e => e.CALISTA_SCAC).HasMaxLength(50);

                entity.Property(e => e.CARRIER_ID).HasComment("运营人流水号");

                entity.Property(e => e.CLOSE).HasComment("截重时间");

                entity.Property(e => e.COURSE).HasComment("航向\n0-\n10-东行\n20-西行\n30-南行\n40-北行");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("成本币种");

                entity.Property(e => e.DEPARTURE).HasComment("开船时间");

                entity.Property(e => e.DEPARTURE_CITY_CNAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("启运港城市中文名称");

                entity.Property(e => e.DEPARTURE_CITY_ENAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("启运港城市名称");

                entity.Property(e => e.DEPARTURE_CITY_ID).HasComment("启运港城市流水号");

                entity.Property(e => e.DEPARTURE_CODE)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("启运港代码");

                entity.Property(e => e.DEPARTURE_COUNTRY_CNAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("启运港国家中文名称");

                entity.Property(e => e.DEPARTURE_COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("启运港国家或地区代码");

                entity.Property(e => e.DEPARTURE_COUNTRY_ENAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("启运港国家或地区名称");

                entity.Property(e => e.DEPARTURE_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("启运港中文名称");

                entity.Property(e => e.DEPARTURE_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("启运港英文名称");

                entity.Property(e => e.DEPARTURE_PORT_ID).HasComment("贸易区流水号");

                entity.Property(e => e.DEPARTURE_PROVINCE_CODE)
                    .HasMaxLength(30)
                    .HasComment("启运港省或州代码");

                entity.Property(e => e.DEPARTURE_PROVINCE_NAME)
                    .HasMaxLength(200)
                    .HasComment("启运港省或州名称");

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺平柜成本");

                entity.Property(e => e.GP20_REEFER)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("20尺平柜冻柜附加");

                entity.Property(e => e.GP40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺平柜成本");

                entity.Property(e => e.GP40_REEFER)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺平柜冻柜附加");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺平柜成本");

                entity.Property(e => e.GP45_REEFER)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("45尺平柜冻柜附加");

                entity.Property(e => e.HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺高柜成本");

                entity.Property(e => e.HQ40_REEFER)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("40尺高柜冻柜附加");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.PUBLISHED).HasComment("0未发布 1已发布");

                entity.Property(e => e.PUNCTUAL_RATE)
                    .HasColumnType("decimal(5,1)")
                    .HasComment("准点率(计划航程/平均航程)*100");

                entity.Property(e => e.SHIP_ROUTE_AREA_CODE)
                    .HasMaxLength(35)
                    .HasComment("航线区域代码");

                entity.Property(e => e.SHIP_ROUTE_AREA_ID).HasComment("航线区域ID");

                entity.Property(e => e.SHIP_ROUTE_AREA_NAME)
                    .HasMaxLength(200)
                    .HasComment("航线区域名称");

                entity.Property(e => e.SHIP_ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("航线代码");

                entity.Property(e => e.SHIP_ROUTE_ID).HasComment("航线信息流水号");

                entity.Property(e => e.SHIP_ROUTE_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("航线名称");

                entity.Property(e => e.TOTAL_DAY).HasComment("总小时数");

                entity.Property(e => e.TT).HasComment("航程(天)");

                entity.Property(e => e.VOYAGE_COUNT).HasComment("航行次数(记录最近一年的数据)");
            });

            modelBuilder.Entity<ship_route_staff>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_STAFF_ID)
                    .HasName("PRIMARY");

                entity.HasComment("航线经理、航线销售员、航线客服绑定记录");

                entity.Property(e => e.SHIP_ROUTE_STAFF_ID).HasComment("航线人员流水号");

                entity.Property(e => e.COURSE)
                    .HasDefaultValueSql("'0'")
                    .HasComment("航向\r\n	0-去程\r\n	1-回程");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("创建人姓名");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("创建人帐户");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记\r\n	0-未删除\r\n	1-标记删除");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("修改人帐户");

                entity.Property(e => e.SHIP_ROUTE_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("航线代码");

                entity.Property(e => e.SHIP_ROUTE_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("航线名称");

                entity.Property(e => e.SHIP_ROUTE_PORT_CODE)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'*'")
                    .HasComment("航线挂港代码");

                entity.Property(e => e.SHIP_ROUTE_SHORT_CODE)
                    .HasMaxLength(10)
                    .HasComment("航线简码");

                entity.Property(e => e.USER_ACCOUNT)
                    .HasMaxLength(30)
                    .HasComment("用户账户");

                entity.Property(e => e.USER_CODE)
                    .HasMaxLength(50)
                    .HasComment("用户代码");

                entity.Property(e => e.USER_COMPANY_ID).HasComment("用户公司");

                entity.Property(e => e.USER_COMPANY_NAME)
                    .HasMaxLength(35)
                    .HasComment("用户公司名");

                entity.Property(e => e.USER_EMAIL)
                    .HasMaxLength(100)
                    .HasComment("用户邮箱");

                entity.Property(e => e.USER_FULLNAME)
                    .HasMaxLength(50)
                    .HasComment("用户姓名");

                entity.Property(e => e.USER_ID).HasComment("用户ID");

                entity.Property(e => e.USER_TEL)
                    .HasMaxLength(50)
                    .HasComment("用户电话");

                entity.Property(e => e.USER_TYPE)
                    .HasDefaultValueSql("'0'")
                    .HasComment("用户类型\r\n	0-航线经理\r\n	1-航线销售\r\n	2-航线客服\r\n	3-航线调度");

                entity.Property(e => e.VALID).HasComment("状态");
            });

            modelBuilder.Entity<ship_week>(entity =>
            {
                entity.HasKey(e => e.WEEK_ID)
                    .HasName("PRIMARY");

                entity.HasComment("出运周");

                entity.Property(e => e.WEEK_ID).HasComment("ID");

                entity.Property(e => e.WEEK_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("出运周");

                entity.Property(e => e.YEAR_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("出运年份");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
