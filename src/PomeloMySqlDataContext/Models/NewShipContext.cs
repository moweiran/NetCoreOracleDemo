using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace PomeloMySqlDataContext.Models
{
    public partial class NewShipContext : DbContext
    {
        public NewShipContext(DbContextOptions<NewShipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<base_company> base_company { get; set; }
        public virtual DbSet<base_organization> base_organization { get; set; }
        public virtual DbSet<base_role> base_role { get; set; }
        public virtual DbSet<base_role_permission> base_role_permission { get; set; }
        public virtual DbSet<base_userinfo> base_userinfo { get; set; }
        public virtual DbSet<booking_order> booking_order { get; set; }
        public virtual DbSet<booking_order_approver> booking_order_approver { get; set; }
        public virtual DbSet<booking_order_container> booking_order_container { get; set; }
        public virtual DbSet<booking_order_presale> booking_order_presale { get; set; }
        public virtual DbSet<booking_order_rate> booking_order_rate { get; set; }
        public virtual DbSet<booking_order_so> booking_order_so { get; set; }
        public virtual DbSet<booking_order_surcharge> booking_order_surcharge { get; set; }
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
        public virtual DbSet<rate_sync_cargo> rate_sync_cargo { get; set; }
        public virtual DbSet<rates> rates { get; set; }
        public virtual DbSet<ship_route_staff> ship_route_staff { get; set; }
        public virtual DbSet<ship_week> ship_week { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder
                    .UseMySql("server=192.168.0.46;port=13306;user=xxy;password=xxy@678.com;database=newship", x => x.ServerVersion("8.0.21-mysql"))
                    .UseLoggerFactory(
                        LoggerFactory.Create(
                            logging => logging
                                .AddDebug()
                                .AddFilter(level => level >= LogLevel.Information)))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<base_company>(entity =>
            {
                entity.HasKey(e => e.COMPANY_ID)
                    .HasName("PRIMARY");

                entity.HasComment("企业信息");

                entity.Property(e => e.COMPANY_ID).HasComment("公司主键");

                entity.Property(e => e.ADDRESS)
                    .HasColumnType("varchar(200)")
                    .HasComment("地址")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.BANK_ACCOUNTNO)
                    .HasColumnType("varchar(200)")
                    .HasComment("银行账号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.BANK_NAME)
                    .HasColumnType("varchar(200)")
                    .HasComment("银行名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CAMPAIGN_USER_ID).HasComment("推荐人ID");

                entity.Property(e => e.CAMPAIGN_USER_PLATFORM).HasComment("推荐人所属平台 (1货代库 2拖车库 3报关)");

                entity.Property(e => e.CITY_ID).HasComment("城市ID");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasColumnType("varchar(200)")
                    .HasComment("城市中文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CITY_NAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("城市英文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_CLASS)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasComment(@"企业分类
	0-运维企业 Operation
	10-船公司(ShipOwner)
	11-船代公司Shipping Agency
	20-货代Freight Forwarding
	30-拖车Trailer
	35-驳船公司BARGE
	40-报关行CustomsBrokers
	50-货主Shipper
	60-仓储公司WareHouse")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_CODE)
                    .HasColumnType("varchar(50)")
                    .HasComment("公司代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_LEVEL)
                    .HasDefaultValueSql("'1'")
                    .HasComment("客户等级");

                entity.Property(e => e.COMPANY_NAME_CN)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("公司名称简体")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_NAME_EN)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("公司名称英文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_SHORTNAME_CN)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("公司简称简体")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_SHORTNAME_EN)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("公司简称英文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CONTACTS)
                    .HasColumnType("varchar(35)")
                    .HasComment("联系人")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CONTACT_PHONE)
                    .HasColumnType("varchar(50)")
                    .HasComment("联系电话")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COUNTRY_CODE)
                    .HasColumnType("varchar(50)")
                    .HasComment("国家代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COUNTRY_ID).HasComment("国家ID");

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .HasColumnType("varchar(200)")
                    .HasComment("国家中文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("国家英文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("创建人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CURRENT_INTEGRAL)
                    .HasDefaultValueSql("'0'")
                    .HasComment("当前积分");

                entity.Property(e => e.DELETE_MARK)
                    .HasDefaultValueSql("'0'")
                    .HasComment(@"删除标记
	1：删除，0：正常，-1：锁定");

                entity.Property(e => e.EMAIL)
                    .HasColumnType("varchar(50)")
                    .HasComment("邮箱")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.FAX)
                    .HasColumnType("varchar(25)")
                    .HasComment("传真")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.IS_CERTIFICATION).HasComment("实名认证");

                entity.Property(e => e.IS_SCHEDULE_AUTHORITY)
                    .HasDefaultValueSql("'1'")
                    .HasComment("船期查询权限");

                entity.Property(e => e.IS_SUPER_PARTNER)
                    .HasDefaultValueSql("'0'")
                    .HasComment("超级合伙人");

                entity.Property(e => e.LARGEICON)
                    .HasColumnType("varchar(254)")
                    .HasComment("企业图标(大)")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LARGEICON_FILE_ID).HasComment("企业图标(大)文件ID");

                entity.Property(e => e.LOGO)
                    .HasColumnType("varchar(254)")
                    .HasComment("企业图标(小)")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LOGO_FILE_ID).HasComment("企业图标(小)文件ID");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("修改人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ORGANIZING_CODE)
                    .HasColumnType("varchar(50)")
                    .HasComment("组织机构代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ORGANIZING_FILE)
                    .HasColumnType("varchar(100)")
                    .HasComment("组织机构证图片")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ORGANIZING_FILE_ID).HasComment("组织机构证图片文件ID");

                entity.Property(e => e.PARENT_ID).HasComment("上级公司ID");

                entity.Property(e => e.POSTCODE)
                    .HasColumnType("varchar(10)")
                    .HasComment("邮政区号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PROVINCE_ID).HasComment("省州ID");

                entity.Property(e => e.PROVINCE_NAME_CN)
                    .HasColumnType("varchar(200)")
                    .HasComment("省州中文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PROVINCE_NAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("省州英文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PUSH_RATE_QTY).HasComment("运价推送数量");

                entity.Property(e => e.REFEREE_COMPANY_ID).HasComment("推荐公司ID");

                entity.Property(e => e.REGISTERED_FILE)
                    .HasColumnType("varchar(100)")
                    .HasComment("营业执照图片")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.REGISTERED_FILE_ID).HasComment("营业执照图片文件ID");

                entity.Property(e => e.REGISTERED_NO)
                    .HasColumnType("varchar(50)")
                    .HasComment("工商注册号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(200)")
                    .HasComment("备注说明")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.STATUS).HasComment(@"状态
	-1:拒绝
	0:未审核
	10:有效");

                entity.Property(e => e.SUPERPARTNER_CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("合伙人添加时间");

                entity.Property(e => e.SUPERPARTNER_CREATE_FULLNAME)
                    .HasColumnType("varchar(100)")
                    .HasComment("合伙人添加人")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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
                    .HasColumnType("varchar(200)")
                    .HasComment("地址")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_ID).HasComment("货代公司ID");

                entity.Property(e => e.COMPANY_ID).HasComment("所属公司");

                entity.Property(e => e.CONTACTS)
                    .HasColumnType("varchar(100)")
                    .HasComment("联系人")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("创建人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK)
                    .HasDefaultValueSql("'0'")
                    .HasComment("删除标记1：删除，0：正常");

                entity.Property(e => e.EMAIL)
                    .HasColumnType("varchar(200)")
                    .HasComment("邮箱")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.FAX)
                    .HasColumnType("varchar(50)")
                    .HasComment("传真")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("修改人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ORGANIZATION_CODE)
                    .HasColumnType("varchar(20)")
                    .HasComment("编号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ORGANIZATION_NAME)
                    .HasColumnType("varchar(50)")
                    .HasComment("部门名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ORGANIZATION_REMARK)
                    .HasColumnType("varchar(200)")
                    .HasComment("备注说明")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PARENT_ID).HasComment("上级部门主键");

                entity.Property(e => e.PHONE)
                    .HasColumnType("varchar(50)")
                    .HasComment("电话")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.POSTCODE)
                    .HasColumnType("varchar(10)")
                    .HasComment("邮政区号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SEQUENCE).HasComment("排序");

                entity.Property(e => e.SEQUENCE_STRING)
                    .HasColumnType("varchar(100)")
                    .HasComment("[父级排序串]-[当前排序值]")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.TOP_ORGANIZATION_ID).HasComment("部门树中，最上级节点的ID");

                entity.Property(e => e.USERS).HasComment("员工成员数");
            });

            modelBuilder.Entity<base_role>(entity =>
            {
                entity.HasKey(e => e.BASE_ROLE_ID)
                    .HasName("PRIMARY");

                entity.HasComment(@"船东系统角色
内置角色：管理员，航线经理，客服，单证");

                entity.Property(e => e.BASE_ROLE_ID).HasComment("角色流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("船东流水号");

                entity.Property(e => e.CREATE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .HasColumnType("varchar(100)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROLENAMECN)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("角色中文名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROLENAMEEN)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("角色英文名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USE_DEFAULT).HasComment("使用默认");
            });

            modelBuilder.Entity<base_role_permission>(entity =>
            {
                entity.HasKey(e => e.BASE_ROLE_PERMISSION_ID)
                    .HasName("PRIMARY");

                entity.HasComment("角色权限点");

                entity.Property(e => e.BASE_ROLE_PERMISSION_ID)
                    .HasColumnType("varchar(100)")
                    .HasComment("货代系统角色权限点")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.BASE_ROLE_ID).HasComment("角色流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("CARRIER_ID");

                entity.Property(e => e.CREATE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .HasColumnType("varchar(100)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.PERMISSION).HasComment("权限点");

                entity.Property(e => e.PERMISSION_KEY)
                    .IsRequired()
                    .HasColumnType("varchar(300)")
                    .HasComment("权限代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");
            });

            modelBuilder.Entity<base_userinfo>(entity =>
            {
                entity.HasKey(e => e.USER_ID)
                    .HasName("PRIMARY");

                entity.HasComment("用户信息");

                entity.Property(e => e.USER_ID).HasComment("用户主键");

                entity.Property(e => e.BASE_ROLE_ID).HasComment("用户角色流水号");

                entity.Property(e => e.CAMPAIGN_KEY)
                    .HasColumnType("varchar(50)")
                    .HasComment("推广Key")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CAMPAIGN_USER_ID).HasComment("推荐用户ID");

                entity.Property(e => e.CAMPAIGN_USER_PLATFORM).HasComment("推荐人所属平台 (1货代库 2拖车库 3报关)");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司流水号");

                entity.Property(e => e.COMPANY_CLASS)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasComment(@"企业分类
	20-货代Freight Forwarding
	30-拖车Trailer
	35-驳船公司BARGE
	40-报关行CustomsBrokers
	50-平台直客Shipper
	55-货代客户 Freight Forwarding Shipper
	60-仓储公司WareHouse")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_ID).HasComment("销售公司流水号");

                entity.Property(e => e.COMPANY_SHORTNAME)
                    .HasColumnType("varchar(200)")
                    .HasComment("销售公司简称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CONFIRM_EMAIL).HasComment("邮箱确认");

                entity.Property(e => e.CONFIRM_MOBILE).HasComment("手机确认");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("创建人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记 
	1：删除，0：正常，-1：锁定");

                entity.Property(e => e.EMAIL)
                    .HasColumnType("varchar(200)")
                    .HasComment("电子邮件")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("用户姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.FULLNAME_EN)
                    .HasColumnType("varchar(50)")
                    .HasComment("英文用户名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.GENDER)
                    .HasColumnType("char(1)")
                    .HasComment("性别 M-男、F-女")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.IS_ADMIN).HasComment("企业管理员");

                entity.Property(e => e.LANGUAGE)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'ENG'")
                    .HasComment("用户默认语言")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LOGIN_MOBILE)
                    .HasColumnType("varchar(100)")
                    .HasComment("登陆手机号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MOBILE)
                    .HasColumnType("varchar(50)")
                    .HasComment("手机")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("修改人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PASSWORD)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("用户登录密码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.QQ_APPID)
                    .HasColumnType("varchar(200)")
                    .HasComment("QQ APPID")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.TEL)
                    .HasColumnType("varchar(50)")
                    .HasComment("办公电话")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.THEMES)
                    .HasColumnType("varchar(50)")
                    .HasComment("用户默认主题")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.TITLE)
                    .HasColumnType("varchar(50)")
                    .HasComment("职称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("用户登陆名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USER_STATUS).HasComment("账号状态(-1停用,0未验证,1正常)");

                entity.Property(e => e.USER_TYPE)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("用户类型：用户角色中文名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.WECHAT_APPID)
                    .HasColumnType("varchar(200)")
                    .HasComment("微信APPID")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");
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
                    .HasColumnType("varchar(1000)")
                    .HasComment("订舱编号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.BOOKING_ORDER_GUID)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("订舱数据指纹")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARGO_DESC)
                    .HasColumnType("varchar(2000)")
                    .HasComment("货物描述")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("承运人销售公司ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CBM)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("总体积");

                entity.Property(e => e.CLOSE_DT)
                    .HasColumnType("datetime")
                    .HasComment("截关日期");

                entity.Property(e => e.CONSIGNEE_DESC)
                    .HasColumnType("varchar(500)")
                    .HasComment("收货人描述")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CONTRACT_NO)
                    .HasColumnType("varchar(35)")
                    .HasComment("合约编号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CUSTOMER_ID).HasComment("订舱客户ID");

                entity.Property(e => e.CUSTOMER_TYPE).HasComment("客户类型(1直客 2货代)");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.DELIVERY_CITY_ID).HasComment("交货地城市");

                entity.Property(e => e.DELIVERY_ID).HasComment("交货地ID");

                entity.Property(e => e.ETA)
                    .HasColumnType("datetime")
                    .HasComment("卸港到港日期");

                entity.Property(e => e.ETD)
                    .HasColumnType("datetime")
                    .HasComment("装港离港日期");

                entity.Property(e => e.FF_BOOKING_ORDER_ID).HasComment("货代订单流水号");

                entity.Property(e => e.FF_ID).HasComment("货代公司流水号");

                entity.Property(e => e.FREEDETENTIONN_REMARK_REPLY)
                    .HasColumnType("varchar(1000)")
                    .HasComment("用箱申请回复")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.FREEDETENTIONN_REMARK_REQUEST)
                    .HasColumnType("varchar(1000)")
                    .HasComment("用箱申请备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.FREEDETENTIONN_STATUS)
                    .HasDefaultValueSql("'0'")
                    .HasComment("用箱申请状态 (0 未申请 10 已提交 30 已回复 50 已确认)");

                entity.Property(e => e.LAND_DELIVERY_CITY_ID).HasComment("内陆交货城市ID");

                entity.Property(e => e.LAND_DELIVERY_ID).HasComment("内陆交货地点(堆场)");

                entity.Property(e => e.LAND_PRODUCT_PATH_ID).HasComment("陆运产品ID");

                entity.Property(e => e.LAND_RECEIPT_CITY_ID).HasComment("内陆收货地城市ID");

                entity.Property(e => e.LAND_RECEIPT_ID).HasComment("内陆收货地点(堆场)");

                entity.Property(e => e.LINKER_ADDRESS)
                    .HasColumnType("varchar(500)")
                    .HasComment("联系人地址")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LINKER_EMAIL)
                    .HasColumnType("varchar(100)")
                    .HasComment("联系人邮件")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LINKER_FAX)
                    .HasColumnType("varchar(50)")
                    .HasComment("联系人传真")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LINKER_NAME)
                    .HasColumnType("varchar(50)")
                    .HasComment("联系人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LINKER_TEL)
                    .HasColumnType("varchar(50)")
                    .HasComment(@"联系人电话
	国家-区号-电话号码-分机号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LOAD_TEU).HasComment("已做柜TEU");

                entity.Property(e => e.MARKS)
                    .HasColumnType("varchar(2000)")
                    .HasComment("唛头")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.NOTIFIER_DESC)
                    .HasColumnType("varchar(500)")
                    .HasComment("通知人描述")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ORDER_NO)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("订单号码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ORDER_REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("订舱备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PAY_LOCATION)
                    .HasColumnType("varchar(35)")
                    .HasComment("付款地点代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PICS)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("数量");

                entity.Property(e => e.PICS_UNIT)
                    .HasColumnType("varchar(50)")
                    .HasComment("数量单位")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PPCC)
                    .HasColumnType("varchar(35)")
                    .HasComment("付款方式代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PRODUCT_ID).HasComment("产品ID");

                entity.Property(e => e.RATE_ID).HasComment("运价流水号");

                entity.Property(e => e.RECEIPT_CITY_ID).HasComment("收货地城市");

                entity.Property(e => e.RECEIPT_ID).HasComment("收货地ID");

                entity.Property(e => e.RELEASE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("放单时间");

                entity.Property(e => e.RELEASE_FULLNAME)
                    .HasColumnType("varchar(50)")
                    .HasComment("放单人名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.RELEASE_MODE)
                    .HasColumnType("varchar(35)")
                    .HasComment(@"放货方式
	10-正本
	20-电放
	30-SWB")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.RELEASE_REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("放单备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.RELEASE_STATUS)
                    .HasDefaultValueSql("'0'")
                    .HasComment("放单状态 (0未放单 1已放单)");

                entity.Property(e => e.RELEASE_USERID).HasComment("放单人ID");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.SALES_ID).HasComment("业务员ID");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期关联");

                entity.Property(e => e.SHIPPER_DESC)
                    .HasColumnType("varchar(500)")
                    .HasComment("发货人描述")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SI_STATUS).HasComment("补料状态(0未补料 1提交 5已拒绝  10已确认)");

                entity.Property(e => e.SPECIARATE_REMARK_REPLY)
                    .HasColumnType("varchar(1000)")
                    .HasComment("特价申请回复")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SPECIARATE_REMARK_REQUEST)
                    .HasColumnType("varchar(1000)")
                    .HasComment("特价备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SPECIARATE_STATUS).HasComment("特价申请状态 (0 未申请.1 已提交. 5 已回复. 10 已确认)");

                entity.Property(e => e.STATUS).HasComment("0草稿 10已提交 50商务已确认 90审核拒绝 100已放舱 101已发送报文 102已重发报文 108放舱失败 109放舱成功 110已打提空单 111已提空 120已返重 200已撤单 201已发撤单报文 202已重发撤单报文 208撤单失败 209撤单成功 300已装船 400已卸船 500已送达 900已完结 999未装船 -10历史 -20已取消 -30已作废");

                entity.Property(e => e.SUBMIT_DATE)
                    .HasColumnType("datetime")
                    .HasComment("提交时间");

                entity.Property(e => e.TEU).HasComment("本次订舱(TEU)");

                entity.Property(e => e.TRADETERMS_CODE)
                    .HasColumnType("varchar(35)")
                    .HasComment("贸易条款代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.TRAILER_STATUS).HasComment("拖车状态(-1未委托 0未申请,1已申请, 5已提交, 10受理, 15安排 20执行 25完成)");

                entity.Property(e => e.TRANS_TYPE_CODE)
                    .HasColumnType("varchar(35)")
                    .HasComment("运输条款代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.TT).HasComment("航程");

                entity.Property(e => e.VESSEL_NAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("英文船名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.VGM_STATUS)
                    .HasDefaultValueSql("'0'")
                    .HasComment("VGM状态(0未提交,1已提交,10已确认)");

                entity.Property(e => e.VOYAGE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航次")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");

                entity.Property(e => e.WEIGHT)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("重量");

                entity.Property(e => e.WEIGHT_UNIT)
                    .HasColumnType("varchar(50)")
                    .HasComment("重量单位")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");
            });

            modelBuilder.Entity<booking_order_approver>(entity =>
            {
                entity.HasKey(e => e.BOOKING_ORDER_APPROVER_ID)
                    .HasName("PRIMARY");

                entity.HasComment("现货订单审核信息");

                entity.Property(e => e.BOOKING_ORDER_APPROVER_ID).HasComment("订单放舱流水号");

                entity.Property(e => e.APPROVED_DATE)
                    .HasColumnType("datetime")
                    .HasComment("在审核时保存放舱时间，主要用于报文输出");

                entity.Property(e => e.APPROVED_DESC)
                    .HasColumnType("varchar(2000)")
                    .HasComment("放舱备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.APPROVER_ID).HasComment("在审核时保存放舱人的用户账户ID，主要用于报文输出");

                entity.Property(e => e.APPROVER_NAME)
                    .HasColumnType("varchar(50)")
                    .HasComment("在审核时保存放舱人的用户姓名，来源于Special_Price_Rule_User")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.BOOKING_ORDER_ID).HasComment("订单流水号");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.FIRST_SCHEDULE_ID).HasComment("头程船期ID");

                entity.Property(e => e.FIRST_VESSEL_NAME)
                    .HasColumnType("varchar(50)")
                    .HasComment("头程船名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.FIRST_VOYAGE)
                    .HasColumnType("varchar(35)")
                    .HasComment("头程航次")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_TEU).HasComment("重货TEU");

                entity.Property(e => e.PAY_LOCATION)
                    .HasColumnType("varchar(200)")
                    .HasComment("付款地点代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PR_ID).HasComment("还重地点 Place of Return Location");

                entity.Property(e => e.PR_NAME)
                    .HasColumnType("varchar(200)")
                    .HasComment("还重地点名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PU_ID).HasComment("提空地点Pick up Container Location");

                entity.Property(e => e.PU_NAME)
                    .HasColumnType("varchar(200)")
                    .HasComment("提空地点名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SPECIAL_LOAD)
                    .HasColumnType("varchar(500)")
                    .HasComment("特殊装载")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SPECIAL_REMARK)
                    .HasColumnType("varchar(500)")
                    .HasComment("特殊备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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
                    .HasColumnType("varchar(50)")
                    .HasComment("订舱号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.BOOKING_ORDER_ID).HasComment("订单流水号");

                entity.Property(e => e.CARGO_DESC)
                    .HasColumnType("varchar(100)")
                    .HasComment("品名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARGO_PROPERTY)
                    .HasDefaultValueSql("'1'")
                    .HasComment("货物特征(1 普通货 2 冷藏品 3 危险品 4 特种 5 重货)");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CONTAINER_NO)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("箱号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CONTA_PROPERTY)
                    .HasDefaultValueSql("'1'")
                    .HasComment("箱属性(1 COC,2 SOC)");

                entity.Property(e => e.CONTA_SIZE)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("箱形尺寸(20,40,40H,45)")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CONTA_SIZETYPE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("箱型代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CONTA_WEIGHT)
                    .HasColumnType("decimal(10,2)")
                    .HasComment("箱重量(KG)");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DANGEROU_LEVEL_CODE)
                    .HasColumnType("varchar(35)")
                    .HasComment("危险品等级代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DANGEROU_LEVEL_ID).HasComment("危险品等级流水号");

                entity.Property(e => e.DELETE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.FF_BOOKING_CONTAINER_ID).HasComment("货代箱ID");

                entity.Property(e => e.MAIN_BOOKING_ORDER_ID).HasComment("主订单流水号");

                entity.Property(e => e.MARK)
                    .HasColumnType("varchar(100)")
                    .HasComment("唛头")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.PACKAGE_NUM).HasComment("数量");

                entity.Property(e => e.PACKAGE_UNIT)
                    .HasColumnType("varchar(35)")
                    .HasComment("单位")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PRESALE_ORDER_ID).HasComment("预售订单ID");

                entity.Property(e => e.SEAL_NO)
                    .HasColumnType("varchar(35)")
                    .HasComment("铅封号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.TEU).HasComment("TEU");

                entity.Property(e => e.VGM_DATE)
                    .HasColumnType("datetime")
                    .HasComment("VGM日期");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记");

                entity.Property(e => e.FF_BOOKING_PRESALE_ID).HasComment("货代预售ID");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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
                    .HasColumnType("varchar(500)")
                    .HasComment("货描描述")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARGO_PROPERTY)
                    .HasColumnType("varchar(35)")
                    .HasComment(@"货物特征代码
	1 普通货
	2 冷藏品
	3 危险品
	4 特种
	5 重货")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CONTA_PROPERTY).HasComment("箱属性(1 COC,2 SOC)");

                entity.Property(e => e.CONTA_QTY).HasComment("箱数");

                entity.Property(e => e.CONTA_SIZE)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("箱型尺寸")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CONTA_SIZETYPE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("箱型代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CONTA_WEIGHT)
                    .HasColumnType("decimal(8,0)")
                    .HasComment("单柜重量");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .HasColumnType("varchar(10)")
                    .HasComment("币种")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DANGEROU_LEVEL_CODE)
                    .HasColumnType("varchar(35)")
                    .HasComment("危险品等级代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DANGEROU_LEVEL_ID).HasComment("危险品等级流水号");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.EIR_QTY)
                    .HasDefaultValueSql("'0'")
                    .HasComment("已申请提箱数");

                entity.Property(e => e.FF_BOOKING_RATE_ID).HasComment("货代运价流水号");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.RATE_TYPE).HasComment(@"运价类型
	0:FAK
	10 合约价
	20 预售价
	30 特价");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.SONO)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("SONo")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");
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

                entity.Property(e => e.BOOKING_ORDER_RATE_ID).HasComment(@"订舱订单运价流水号
	跟哪条运价关联的,如果是按票收的,则保存为0");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CONTA_SIZETYPE_CODE)
                    .HasColumnType("varchar(100)")
                    .HasComment("箱型代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COST)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("成本价");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("费用货币")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.FEETYPE_ID).HasComment("费用类型ID");

                entity.Property(e => e.FF_BOOKING_SURCHARGE_ID).HasComment("货代附加费流水号");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.PRICE)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("单价");

                entity.Property(e => e.QTY).HasComment("数量");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(500)")
                    .HasComment("说明")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.UNIT).HasComment("计费单位 0.按箱; 1.按单;");
            });

            modelBuilder.Entity<ff_class>(entity =>
            {
                entity.HasKey(e => e.FF_CLASS_ID)
                    .HasName("PRIMARY");

                entity.HasComment("货代价格等级管理");

                entity.Property(e => e.FF_CLASS_ID).HasComment("货代等级流水号");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_CODE_SALE)
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_ID_SALE).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_NAME)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("承运人名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_NAME_SALE)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("承运人名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_TYPE).HasComment(@"公司类型
	1.货代
	2.直客");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("创建人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.FF_CLASS_SET_ID).HasComment("货代等级流水号");

                entity.Property(e => e.FF_ID).HasComment("货代公司ID");

                entity.Property(e => e.FF_NAME_CN)
                    .HasColumnType("varchar(200)")
                    .HasComment("货代公司中文名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.FF_NAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("货代公司英文名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.FF_SHORTNAME)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("货代公司简称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("修改人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_CLASS_CODE).HasComment(@"航线价格等级
	1:T1
	2:T2
	3:T3");

                entity.Property(e => e.ROUTE_CLASS_NAME)
                    .HasColumnType("varchar(10)")
                    .HasComment("航线价格等级名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_CODE)
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.ROUTE_NAME)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("航线名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_CODE_SALE)
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_ID_SALE).HasComment("承运人流水号");

                entity.Property(e => e.CARRIER_NAME)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("承运人名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_NAME_SALE)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("承运人名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("创建人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK)
                    .HasDefaultValueSql("'0'")
                    .HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("修改人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_CLASS_CODE).HasComment("航线价格等级1:T1 2:T2 3:T3 4:T4");

                entity.Property(e => e.ROUTE_CLASS_NAME)
                    .HasColumnType("varchar(10)")
                    .HasComment("航线价格等级名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.ROUTE_NAME)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("航线名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.EFFECTIVE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("生效时间");

                entity.Property(e => e.EXPIRATION_DATE)
                    .HasColumnType("datetime")
                    .HasComment("过期时间");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_TYPE).HasComment("附加类型(1有效期 2船期)");

                entity.Property(e => e.POL_ID).HasComment("装货港");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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
                    .HasColumnType("varchar(50)")
                    .HasComment("箱型")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.END_WEIGHT)
                    .HasColumnType("decimal(8,0)")
                    .HasComment("结束重量");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_SURCHARGE_ID).HasComment("超重附加费ID");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.ETD)
                    .HasColumnType("datetime")
                    .HasComment("ETD");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_SURCHARGE_ID).HasComment("超重附加费ID");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期ID");

                entity.Property(e => e.VESSELVOY)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasComment("船名航次")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");
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
                    .HasColumnType("varchar(200)")
                    .HasComment("城市中文名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CITY_NAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("城市英文名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_CODE)
                    .HasColumnType("varchar(50)")
                    .HasComment("公司代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_ID).HasComment("公司的流水号");

                entity.Property(e => e.COMPANY_NAME_CN)
                    .HasColumnType("varchar(200)")
                    .HasComment("公司名称简体")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_NAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("公司名称英文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_SHORTNAME_CN)
                    .HasColumnType("varchar(200)")
                    .HasComment("公司简称简体")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COMPANY_SHORTNAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("公司简称英文")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COUNTRY_CODE)
                    .HasColumnType("varchar(30)")
                    .HasComment("国家或地区代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .HasColumnType("varchar(200)")
                    .HasComment("国家中文名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("国家或地区名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("创建人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK).HasComment("删除标记   0-未删除   1-标记删除");

                entity.Property(e => e.LOCATION_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasComment("地点代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LOCATION_NAME_CN)
                    .IsRequired()
                    .HasColumnType("varchar(150)")
                    .HasComment("地点中文名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LOCATION_NAME_EN)
                    .IsRequired()
                    .HasColumnType("varchar(150)")
                    .HasComment("地点名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("修改人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PROVINCE_CODE)
                    .HasColumnType("varchar(30)")
                    .HasComment("省或州代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PROVINCE_NAME_CN)
                    .HasColumnType("varchar(200)")
                    .HasComment("省或州中文名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PROVINCE_NAME_EN)
                    .HasColumnType("varchar(200)")
                    .HasComment("省或州名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.FREE_CHANGE_TIME).HasComment("免费改期次数");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POL_ID).HasComment("装货港");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

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

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_TEU).HasComment("超重舱位数");

                entity.Property(e => e.POL_ID).HasComment("装货港");

                entity.Property(e => e.PORT_TEU).HasComment("港口舱位数");

                entity.Property(e => e.PREBRANCH_TEU).HasComment("前程舱位数");

                entity.Property(e => e.RATE_QTY).HasComment("运价数量");

                entity.Property(e => e.RATE_TEU).HasComment("运价舱位");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("承运人销售公司ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CHANGE_TEU).HasComment("已改期TEU");

                entity.Property(e => e.CHANGE_TIME).HasComment("已改期次数");

                entity.Property(e => e.CLOSE_TIME).HasComment("截关");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CUSTOMER_ID).HasComment("订舱客户ID");

                entity.Property(e => e.CUSTOMER_TYPE).HasComment("客户类型(1直客 2货代)");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.DELIVERY_CITY_ID).HasComment("交货地城市");

                entity.Property(e => e.DELIVERY_ID).HasComment("交货地ID");

                entity.Property(e => e.FF_ID).HasComment("货代公司流水号");

                entity.Property(e => e.GO40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("GO40价");

                entity.Property(e => e.GP20)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("GP20价");

                entity.Property(e => e.GP45)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("HC45价");

                entity.Property(e => e.HQ40)
                    .HasColumnType("decimal(14,2)")
                    .HasComment("HC40价");

                entity.Property(e => e.LEAVE_TIME).HasComment("开船");

                entity.Property(e => e.LINKER_ADDRESS)
                    .HasColumnType("varchar(500)")
                    .HasComment("联系人地址")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LINKER_EMAIL)
                    .HasColumnType("varchar(100)")
                    .HasComment("联系人邮件")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LINKER_FAX)
                    .HasColumnType("varchar(50)")
                    .HasComment("联系人传真")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LINKER_NAME)
                    .HasColumnType("varchar(50)")
                    .HasComment("联系人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.LINKER_TEL)
                    .HasColumnType("varchar(50)")
                    .HasComment(@"联系人电话
	国家-区号-电话号码-分机号")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MAIN_ORDER_ID).HasComment("原始订单ID(用于改期时)");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.ORDER_NO)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("订单号码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ORDER_REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("订舱备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.PRODUCT_TYPE).HasComment(@"产品类型
	10:直航产品
	20:中转产品");

                entity.Property(e => e.RECEIPT_CITY_ID).HasComment("收货地城市");

                entity.Property(e => e.RECEIPT_ID).HasComment("收货地ID");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.APPLY_DATE)
                    .HasColumnType("datetime")
                    .HasComment("申请时间");

                entity.Property(e => e.APPLY_ID).HasComment("申请人ID");

                entity.Property(e => e.APPLY_NAME)
                    .HasColumnType("varchar(100)")
                    .HasComment("申请人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.APPLY_REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("申请改期说明")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CANCEL_TEU).HasComment("退舱TEU");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CHECK_DATE)
                    .HasColumnType("datetime")
                    .HasComment("审核时间");

                entity.Property(e => e.CHECK_ID).HasComment("审核人ID");

                entity.Property(e => e.CHECK_NAME)
                    .HasColumnType("varchar(100)")
                    .HasComment("审核人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CHECK_REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("审核备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("退舱币种")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DATE_TYPE).HasComment("退舱时间类型: 1开舱前退舱 2开舱后截单前退舱 3截单后退舱");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.FF_ID).HasComment("货代公司ID");

                entity.Property(e => e.MAIN_ORDER_ID).HasComment("原始订单ID(用于改期时)");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.APPLY_DATE)
                    .HasColumnType("datetime")
                    .HasComment("申请时间");

                entity.Property(e => e.APPLY_ID).HasComment("申请人ID");

                entity.Property(e => e.APPLY_NAME)
                    .HasColumnType("varchar(100)")
                    .HasComment("申请人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.APPLY_REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("申请改期说明")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CHANGE_TEU).HasComment("改期TEU");

                entity.Property(e => e.CHECK_DATE)
                    .HasColumnType("datetime")
                    .HasComment("审核时间");

                entity.Property(e => e.CHECK_ID).HasComment("审核人ID");

                entity.Property(e => e.CHECK_NAME)
                    .HasColumnType("varchar(100)")
                    .HasComment("审核人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CHECK_REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("审核备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .HasColumnType("varchar(50)")
                    .HasComment("币种")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.FF_ID).HasComment("货代公司ID");

                entity.Property(e => e.IS_FREE).HasComment("是否免费改期");

                entity.Property(e => e.MAIN_ORDER_ID).HasComment("原始订单ID(用于改期时)");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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
                    .HasColumnType("varchar(50)")
                    .HasComment("后程支线产品ID")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.AFTER_BRANCH_RATE_ID).HasComment("后程支线运价ID");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CLOSE_TIME).HasComment("截关");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("基本运价币种")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.DELIVERY_CITY_ID).HasComment("交货地城市");

                entity.Property(e => e.DELIVERY_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("交货地代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市");

                entity.Property(e => e.POD_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("卸货港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市");

                entity.Property(e => e.POL_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("装货港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PRESALE_MAIN_LIST_ID).HasComment("预售运价主表");

                entity.Property(e => e.PRESALE_RATE_MAIN_ID).HasComment("干线预售运价ID");

                entity.Property(e => e.PRE_BRANCH_PRODUCT_ID)
                    .HasColumnType("varchar(50)")
                    .HasComment("前程支线产品ID")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PRE_BRANCH_RATE_ID).HasComment("前程支线运价ID");

                entity.Property(e => e.PRODUCT_ID).HasComment("产品ID");

                entity.Property(e => e.PRODUCT_TYPE).HasComment(@"产品类型
	10:直航产品
	20:中转产品");

                entity.Property(e => e.RECEIPT_CITY_ID).HasComment("收货地城市");

                entity.Property(e => e.RECEIPT_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("收货地代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.RECEIPT_ID).HasComment("收货地ID");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.STATUS).HasComment("-1停售  0草稿 90已发布 -10历史");

                entity.Property(e => e.TT).HasComment("航程");

                entity.Property(e => e.VIA_CITY_ID).HasComment("中转城市");

                entity.Property(e => e.VIA_CODE)
                    .HasColumnType("varchar(10)")
                    .HasComment("中转港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("基本运价币种")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

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

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PRESALE_MAIN_LIST_ID).HasComment("预售运价主表");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市ID");

                entity.Property(e => e.POD_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("卸货港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市ID");

                entity.Property(e => e.POL_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("装货港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.ROUTE_ID).HasComment("航线ID");

                entity.Property(e => e.TRUNK_ID).HasComment("Ship56的TrunkID");

                entity.Property(e => e.VIA_CITY_ID).HasComment("中转港城市ID");

                entity.Property(e => e.VIA_CODE)
                    .HasColumnType("varchar(50)")
                    .HasComment("中转港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.EFFECTIVE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("生效时间");

                entity.Property(e => e.EXPIRATION_DATE)
                    .HasColumnType("datetime")
                    .HasComment("过期时间");

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

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.ROUTE_ID).HasComment("航线ID");

                entity.Property(e => e.SHIP_BRANCH_RATE_ID)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("SHIP56支线费用ID")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");
            });

            modelBuilder.Entity<rate_detail>(entity =>
            {
                entity.HasKey(e => e.RATE_DETAIL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("整箱运价详细表");

                entity.Property(e => e.RATE_DETAIL_ID).HasComment("货代运价细节流水号");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

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

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.RATE_ID).HasComment("货代运价流水号");

                entity.Property(e => e.RATE_TYPE).HasComment("运价类型 -1货代价 ,0 FAK价,1~10各个VIP等级价");

                entity.Property(e => e.RATE_UPDATEDATE)
                    .HasColumnType("datetime")
                    .HasComment("运价更新时间");
            });

            modelBuilder.Entity<rate_land>(entity =>
            {
                entity.HasKey(e => e.RATE_LAND_ID)
                    .HasName("PRIMARY");

                entity.HasComment("陆运费率");

                entity.Property(e => e.RATE_LAND_ID).HasComment("陆运费率ID");

                entity.Property(e => e.BUSINESS_TYPE).HasComment("业务类型(1出口 2进口)");

                entity.Property(e => e.CARRIER_ID).HasComment("船公司ID");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("币种")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.EFFECTIVE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("生效时间");

                entity.Property(e => e.EXPIRATION_DATE)
                    .HasColumnType("datetime")
                    .HasComment("过期时间");

                entity.Property(e => e.LAND_CITY_ID).HasComment("内陆城市ID");

                entity.Property(e => e.LAND_FEE_ID).HasComment("陆运费ID (Ship56.Land_Fee.Land_Fee_ID)");

                entity.Property(e => e.LAND_FEE_ROUTE_ID).HasComment("陆运航线关联ID (Ship56.LAND_FEE_ROUTE. ID)");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

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

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("基本运价币种")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.EFFECTIVE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("生效时间");

                entity.Property(e => e.ETD)
                    .HasColumnType("datetime")
                    .HasComment("装货港ETD");

                entity.Property(e => e.EXPIRATION_DATE)
                    .HasColumnType("datetime")
                    .HasComment("过期时间");

                entity.Property(e => e.MAIN_PRODUCT_ID).HasComment("干线产品ID");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.RATE_MAIN_LIST_ID).HasComment("运价主表流水号");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期流水号");

                entity.Property(e => e.STATUS).HasComment("0草稿 90已发布");

                entity.Property(e => e.VESSEL_NAME)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("船名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.VIA_ID).HasComment("中转港ID");

                entity.Property(e => e.VOYAGE)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("航次")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<rate_main_detail>(entity =>
            {
                entity.HasKey(e => e.RATE_MAIN_DETAIL_ID)
                    .HasName("PRIMARY");

                entity.HasComment("整箱干线运价详细");

                entity.Property(e => e.RATE_MAIN_DETAIL_ID).HasComment("干线运价细节流水号");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

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

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

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

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.EFFECTIVE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("生效时间");

                entity.Property(e => e.ETD)
                    .HasColumnType("datetime")
                    .HasComment("ETD");

                entity.Property(e => e.EXPIRATION_DATE)
                    .HasColumnType("datetime")
                    .HasComment("过期时间");

                entity.Property(e => e.IS_AUTO_RELEASE).HasComment("自动放舱");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.OW_TEU).HasComment("超重舱位数");

                entity.Property(e => e.POL_ID).HasComment("装货港");

                entity.Property(e => e.PORT_TEU).HasComment("港口舱位数");

                entity.Property(e => e.PREBRANCH_TEU).HasComment("前程舱位数");

                entity.Property(e => e.PRESALE_TEU).HasComment("预售舱位数");

                entity.Property(e => e.RATE_QTY).HasComment("运价数量");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期流水号");

                entity.Property(e => e.SCHEDULE_PORT_ID).HasComment("船期挂港ID");

                entity.Property(e => e.STATUS).HasComment("0草稿 90已发布");

                entity.Property(e => e.TOTAL_TEU).HasComment("整船舱位数");

                entity.Property(e => e.VESSEL_NAME)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("船名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.VOYAGE)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("航次")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<rate_sync_cargo>(entity =>
            {
                entity.HasComment("运价同步到Cargo");

                entity.Property(e => e.ID)
                    .HasColumnType("varchar(50)")
                    .HasComment("ID")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

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
                    .HasColumnType("varchar(50)")
                    .HasComment("后程支线产品ID")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.AFTER_BRANCH_RATE_ID).HasComment("后程支线运价ID");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("承运人代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CARRIER_COMPANY_ID).HasComment("口岸公司ID");

                entity.Property(e => e.CARRIER_ID).HasComment("承运人流水号");

                entity.Property(e => e.CLOSE_TIME).HasComment("截关");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CURRENCY)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("基本运价币种")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.DELIVERY_CITY_ID).HasComment("交货地城市");

                entity.Property(e => e.DELIVERY_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("交货地代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELIVERY_ID).HasComment("交货地ID");

                entity.Property(e => e.EFFECTIVE_DATE)
                    .HasColumnType("datetime")
                    .HasComment("生效时间");

                entity.Property(e => e.EXPIRATION_DATE)
                    .HasColumnType("datetime")
                    .HasComment("过期时间");

                entity.Property(e => e.IS_MAIN_PRODUCT).HasComment("是否为干线产品");

                entity.Property(e => e.LEAVE_TIME).HasComment("开船");

                entity.Property(e => e.MAIN_PRODUCT_ID).HasComment("干线产品ID");

                entity.Property(e => e.MAIN_RATE_ID).HasComment("干线运价ID");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.POD_CITY_ID).HasComment("卸货港城市");

                entity.Property(e => e.POD_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("卸货港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.POD_ID).HasComment("卸货港ID");

                entity.Property(e => e.POL_CITY_ID).HasComment("装货港城市");

                entity.Property(e => e.POL_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("装货港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.POL_ETD)
                    .HasColumnType("datetime")
                    .HasComment("装货港ETD");

                entity.Property(e => e.POL_ID).HasComment("装货港ID");

                entity.Property(e => e.PRE_BRANCH_PRODUCT_ID)
                    .HasColumnType("varchar(50)")
                    .HasComment("前程支线产品ID")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.PRE_BRANCH_RATE_ID).HasComment("前程支线运价ID");

                entity.Property(e => e.PRODUCT_ID).HasComment("产品ID");

                entity.Property(e => e.PRODUCT_TYPE).HasComment(@"产品类型
	10:直航产品
	20:中转产品");

                entity.Property(e => e.RATE_MAIN_LIST_ID).HasComment("运价主表流水号");

                entity.Property(e => e.RECEIPT_CITY_ID).HasComment("收货地城市");

                entity.Property(e => e.RECEIPT_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("收货地代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.RECEIPT_ID).HasComment("收货地ID");

                entity.Property(e => e.REMARK)
                    .HasColumnType("varchar(2000)")
                    .HasComment("备注")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.ROUTE_ID).HasComment("航线关联");

                entity.Property(e => e.SCHEDULE_ID).HasComment("船期流水号");

                entity.Property(e => e.STATUS).HasComment("0草稿 90已发布 -10历史");

                entity.Property(e => e.TT).HasComment("航程");

                entity.Property(e => e.VESSEL_NAME)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasComment("船名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.VIA_CITY_ID).HasComment("中转城市");

                entity.Property(e => e.VIA_CODE)
                    .HasColumnType("varchar(10)")
                    .HasComment("中转港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.VIA_ID).HasComment("中转港ID");

                entity.Property(e => e.VOYAGE)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("航次")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.WEEK_ID).HasComment("出运周ID");
            });

            modelBuilder.Entity<ship_route_staff>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_STAFF_ID)
                    .HasName("PRIMARY");

                entity.HasComment("航线经理、航线销售员、航线客服绑定记录");

                entity.Property(e => e.SHIP_ROUTE_STAFF_ID).HasComment("航线人员流水号");

                entity.Property(e => e.COURSE)
                    .HasDefaultValueSql("'0'")
                    .HasComment(@"航向
	0-去程
	1-回程");

                entity.Property(e => e.CREATE_COMPANYID).HasComment("创建人公司");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.CREATE_USERID).HasComment("创建人ID");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("创建人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.DELETE_MARK).HasComment(@"删除标记
	0-未删除
	1-标记删除");

                entity.Property(e => e.MODIFY_COMPANYID).HasComment("修改人公司");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.MODIFY_USERID).HasComment("修改人ID");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("修改人帐户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SHIP_ROUTE_CODE)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasComment("航线代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SHIP_ROUTE_NAME)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("航线名称")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SHIP_ROUTE_PORT_CODE)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'*'")
                    .HasComment("航线挂港代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.SHIP_ROUTE_SHORT_CODE)
                    .HasColumnType("varchar(10)")
                    .HasComment("航线简码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USER_ACCOUNT)
                    .HasColumnType("varchar(30)")
                    .HasComment("用户账户")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USER_CODE)
                    .HasColumnType("varchar(50)")
                    .HasComment("用户代码")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USER_COMPANY_ID).HasComment("用户公司");

                entity.Property(e => e.USER_COMPANY_NAME)
                    .HasColumnType("varchar(35)")
                    .HasComment("用户公司名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USER_EMAIL)
                    .HasColumnType("varchar(100)")
                    .HasComment("用户邮箱")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USER_FULLNAME)
                    .HasColumnType("varchar(50)")
                    .HasComment("用户姓名")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USER_ID).HasComment("用户ID");

                entity.Property(e => e.USER_TEL)
                    .HasColumnType("varchar(50)")
                    .HasComment("用户电话")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.USER_TYPE)
                    .HasDefaultValueSql("'0'")
                    .HasComment(@"用户类型
	0-航线经理
	1-航线销售
	2-航线客服
	3-航线调度");

                entity.Property(e => e.VALID).HasComment("状态");
            });

            modelBuilder.Entity<ship_week>(entity =>
            {
                entity.HasKey(e => e.WEEK_ID)
                    .HasName("PRIMARY");

                entity.HasComment("出运周");

                entity.Property(e => e.WEEK_ID).HasComment("ID");

                entity.Property(e => e.WEEK_BEGIN_DATE)
                    .HasColumnType("datetime")
                    .HasComment("出运周开始时间");

                entity.Property(e => e.WEEK_END_DATE)
                    .HasColumnType("datetime")
                    .HasComment("出运周结束时间");

                entity.Property(e => e.WEEK_NO)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("出运周")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");

                entity.Property(e => e.YEAR_NO)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("出运年份")
                    .HasCharSet("gb2312")
                    .HasCollation("gb2312_chinese_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
