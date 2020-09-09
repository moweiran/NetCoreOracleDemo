using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UC2OracleDataContext.Models
{
    public partial class UC2Context : DbContext
    {
        public UC2Context()
        {
        }

        public UC2Context(DbContextOptions<UC2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AIRLINE> AIRLINE { get; set; }
        public virtual DbSet<AIRPORT> AIRPORT { get; set; }
        public virtual DbSet<BASE_APPEND_PROPERTY> BASE_APPEND_PROPERTY { get; set; }
        public virtual DbSet<BASE_APPEND_PROPERTY_FUNCTION> BASE_APPEND_PROPERTY_FUNCTION { get; set; }
        public virtual DbSet<BASE_APPEND_PROPERTY_INSTANCE> BASE_APPEND_PROPERTY_INSTANCE { get; set; }
        public virtual DbSet<BASE_APPLICATIONS> BASE_APPLICATIONS { get; set; }
        public virtual DbSet<BASE_APPLICATION_ROLES> BASE_APPLICATION_ROLES { get; set; }
        public virtual DbSet<BASE_APPLICATION_ROLE_RIGHT> BASE_APPLICATION_ROLE_RIGHT { get; set; }
        public virtual DbSet<BASE_BUTTON> BASE_BUTTON { get; set; }
        public virtual DbSet<BASE_CITYS> BASE_CITYS { get; set; }
        public virtual DbSet<BASE_COMPANY> BASE_COMPANY { get; set; }
        public virtual DbSet<BASE_COMPANY_RIGHT> BASE_COMPANY_RIGHT { get; set; }
        public virtual DbSet<BASE_COMPANY_ROLE> BASE_COMPANY_ROLE { get; set; }
        public virtual DbSet<BASE_CONTAINER_LOCATION> BASE_CONTAINER_LOCATION { get; set; }
        public virtual DbSet<BASE_CONTAINER_SIZETYPE> BASE_CONTAINER_SIZETYPE { get; set; }
        public virtual DbSet<BASE_COUNTRY> BASE_COUNTRY { get; set; }
        public virtual DbSet<BASE_CROSS_DOMAIN> BASE_CROSS_DOMAIN { get; set; }
        public virtual DbSet<BASE_CROSS_ENTERPRISE> BASE_CROSS_ENTERPRISE { get; set; }
        public virtual DbSet<BASE_CURRENCY> BASE_CURRENCY { get; set; }
        public virtual DbSet<BASE_DANGEROU_LEVELS> BASE_DANGEROU_LEVELS { get; set; }
        public virtual DbSet<BASE_DISTRICT> BASE_DISTRICT { get; set; }
        public virtual DbSet<BASE_FEETYPE> BASE_FEETYPE { get; set; }
        public virtual DbSet<BASE_FEETYPE_2> BASE_FEETYPE_2 { get; set; }
        public virtual DbSet<BASE_HSCATEGORY> BASE_HSCATEGORY { get; set; }
        public virtual DbSet<BASE_HSCODE> BASE_HSCODE { get; set; }
        public virtual DbSet<BASE_LOCATION> BASE_LOCATION { get; set; }
        public virtual DbSet<BASE_LOCATION_BAK> BASE_LOCATION_BAK { get; set; }
        public virtual DbSet<BASE_LOCATION_BAK1118> BASE_LOCATION_BAK1118 { get; set; }
        public virtual DbSet<BASE_LOGINLOG> BASE_LOGINLOG { get; set; }
        public virtual DbSet<BASE_MENU> BASE_MENU { get; set; }
        public virtual DbSet<BASE_MESSAGE> BASE_MESSAGE { get; set; }
        public virtual DbSet<BASE_MODULE> BASE_MODULE { get; set; }
        public virtual DbSet<BASE_MODULE_BACKUP> BASE_MODULE_BACKUP { get; set; }
        public virtual DbSet<BASE_MODULE_BUTTON> BASE_MODULE_BUTTON { get; set; }
        public virtual DbSet<BASE_NAVIGATION> BASE_NAVIGATION { get; set; }
        public virtual DbSet<BASE_ONLINE> BASE_ONLINE { get; set; }
        public virtual DbSet<BASE_ORGANIZATION> BASE_ORGANIZATION { get; set; }
        public virtual DbSet<BASE_ORGANIZATION_RIGHT> BASE_ORGANIZATION_RIGHT { get; set; }
        public virtual DbSet<BASE_PERSON> BASE_PERSON { get; set; }
        public virtual DbSet<BASE_PROVINCES> BASE_PROVINCES { get; set; }
        public virtual DbSet<BASE_RAILWAY_PRICE_LEVEL> BASE_RAILWAY_PRICE_LEVEL { get; set; }
        public virtual DbSet<BASE_RAILWAY_PRICE_LEV_DET> BASE_RAILWAY_PRICE_LEV_DET { get; set; }
        public virtual DbSet<BASE_RECYCLEBIN> BASE_RECYCLEBIN { get; set; }
        public virtual DbSet<BASE_STAFF_ORGANIZE> BASE_STAFF_ORGANIZE { get; set; }
        public virtual DbSet<BASE_STREET_BAK> BASE_STREET_BAK { get; set; }
        public virtual DbSet<BASE_TERMINAL> BASE_TERMINAL { get; set; }
        public virtual DbSet<BASE_TRAILER_PRICE_LEVEL> BASE_TRAILER_PRICE_LEVEL { get; set; }
        public virtual DbSet<BASE_TRAIL_PRICE_LEV_DET> BASE_TRAIL_PRICE_LEV_DET { get; set; }
        public virtual DbSet<BASE_USERGROUP> BASE_USERGROUP { get; set; }
        public virtual DbSet<BASE_USERGROUP_RIGHT> BASE_USERGROUP_RIGHT { get; set; }
        public virtual DbSet<BASE_USERINFO> BASE_USERINFO { get; set; }
        public virtual DbSet<BASE_USERINFO_BAK> BASE_USERINFO_BAK { get; set; }
        public virtual DbSet<BASE_USERINFO_USERGROUP> BASE_USERINFO_USERGROUP { get; set; }
        public virtual DbSet<BASE_USERROLE> BASE_USERROLE { get; set; }
        public virtual DbSet<BASE_USERROLE_RIGHT> BASE_USERROLE_RIGHT { get; set; }
        public virtual DbSet<BASE_USER_RIGHT> BASE_USER_RIGHT { get; set; }
        public virtual DbSet<BASE_USER_USERROLES> BASE_USER_USERROLES { get; set; }
        public virtual DbSet<BUSINESS_FILTER> BUSINESS_FILTER { get; set; }
        public virtual DbSet<BUSINESS_FILTER_CONDITION> BUSINESS_FILTER_CONDITION { get; set; }
        public virtual DbSet<FBAREPOSITORIE> FBAREPOSITORIE { get; set; }
        public virtual DbSet<LOC_IM> LOC_IM { get; set; }
        public virtual DbSet<LOC_IM_BAK> LOC_IM_BAK { get; set; }
        public virtual DbSet<LOC_IM_TODO> LOC_IM_TODO { get; set; }
        public virtual DbSet<LOC_IM_TODO_BAK> LOC_IM_TODO_BAK { get; set; }
        public virtual DbSet<MULTI_LANGUAGE> MULTI_LANGUAGE { get; set; }
        public virtual DbSet<MV_AIRPORT_COUNTRY> MV_AIRPORT_COUNTRY { get; set; }
        public virtual DbSet<MV_PORT_AREA> MV_PORT_AREA { get; set; }
        public virtual DbSet<MV_PORT_COUNTRY> MV_PORT_COUNTRY { get; set; }
        public virtual DbSet<NAVIGATION> NAVIGATION { get; set; }
        public virtual DbSet<SHIPINFO> SHIPINFO { get; set; }
        public virtual DbSet<SHIP_ROUTE_AREA> SHIP_ROUTE_AREA { get; set; }
        public virtual DbSet<SHIP_ROUTE_AREA_CITY> SHIP_ROUTE_AREA_CITY { get; set; }
        public virtual DbSet<SHIP_ROUTE_AREA_PORT> SHIP_ROUTE_AREA_PORT { get; set; }
        public virtual DbSet<TASK_CONFIG> TASK_CONFIG { get; set; }
        public virtual DbSet<TASK_DEFINE> TASK_DEFINE { get; set; }
        public virtual DbSet<TASK_GROUP> TASK_GROUP { get; set; }
        public virtual DbSet<TASK_GROUP_DEFINE> TASK_GROUP_DEFINE { get; set; }
        public virtual DbSet<TASK_MONITOR> TASK_MONITOR { get; set; }
        public virtual DbSet<TASK_PARAMETER> TASK_PARAMETER { get; set; }
        public virtual DbSet<TOAD_PLAN_TABLE> TOAD_PLAN_TABLE { get; set; }
        public virtual DbSet<USER_PERMISSION_PAGE> USER_PERMISSION_PAGE { get; set; }
        public virtual DbSet<USER_PERMISSION_PAGEBUTTON> USER_PERMISSION_PAGEBUTTON { get; set; }
        public virtual DbSet<VESSEL_INFO> VESSEL_INFO { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("User Id=UC2;Password=UC2;Data Source=192.168.0.44:1521/orcl.xxy.com;",opt=>
                {
                    opt.UseOracleSQLCompatibility("11");
                });
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "UC2");

            modelBuilder.Entity<AIRLINE>(entity =>
            {
                entity.Property(e => e.AIRLINEID).HasColumnType("NUMBER");

                entity.Property(e => e.ADDRESS).HasMaxLength(200);

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COUNTRY_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.DIGITAL_CODE).HasMaxLength(10);

                entity.Property(e => e.MODIFT_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.NAME_CN)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.NAME_EN)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TWO_LETTERS_CODE)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<AIRPORT>(entity =>
            {
                entity.Property(e => e.AIRPORTID).HasColumnType("NUMBER");

                entity.Property(e => e.ADDRESS).HasMaxLength(200);

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.FOUR_LETTERS_CODE).HasMaxLength(10);

                entity.Property(e => e.MODIFT_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.NAME_CN).HasMaxLength(50);

                entity.Property(e => e.NAME_EN)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.THREE_LETTERS_CODE)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BASE_APPEND_PROPERTY>(entity =>
            {
                entity.HasKey(e => e.PROPERTY_ID)
                    .HasName("PK_APPENDPROPERTY");

                entity.Property(e => e.PROPERTY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PROPERTY_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PROPERTY_COLSPAN).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PROPERTY_CONTROL_DATA_SOURCE).HasMaxLength(500);

                entity.Property(e => e.PROPERTY_CONTROL_ID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PROPERTY_CONTROL_LENGTH)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PROPERTY_CONTROL_MAXLENGTH).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PROPERTY_CONTROL_STYLE).HasMaxLength(50);

                entity.Property(e => e.PROPERTY_CONTROL_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PROPERTY_CONTROL_VALIDATOR).HasMaxLength(200);

                entity.Property(e => e.PROPERTY_EVENT)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PROPERTY_FUNCTION_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PROPERTY_FUNCTION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PROPERTY_FUNCTION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PROPERTY_FUNCTION_URL).HasMaxLength(200);

                entity.Property(e => e.PROPERTY_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<BASE_APPEND_PROPERTY_FUNCTION>(entity =>
            {
                entity.HasKey(e => e.PROPERTY_FUNCTION_ID)
                    .HasName("PK_APPENDPROPERTYFUNCTION");

                entity.HasIndex(e => e.PROPERTY_FUNCTION_CODE)
                    .HasName("AK_APPENDPROPERTYFUNCTION")
                    .IsUnique();

                entity.Property(e => e.PROPERTY_FUNCTION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PROPERTY_FUNCTION_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PROPERTY_FUNCTION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PROPERTY_FUNCTION_URL).HasMaxLength(200);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<BASE_APPEND_PROPERTY_INSTANCE>(entity =>
            {
                entity.HasKey(e => e.PROPERTY_INSTANCE_ID)
                    .HasName("PK_APPENDPROPERTYINSTANCE");

                entity.Property(e => e.PROPERTY_INSTANCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PROPERTY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PROPERTY_INSTANCE_KEY).HasMaxLength(50);
            });

            modelBuilder.Entity<BASE_APPLICATIONS>(entity =>
            {
                entity.HasKey(e => e.APPLICATION_ID);

                entity.HasIndex(e => e.APPLICATION_CODE)
                    .HasName("AK_BASE_APPLICATIONSCODE")
                    .IsUnique();

                entity.HasIndex(e => e.APPLICATION_KEY)
                    .HasName("AK_BASE_APPLICATIONSKEY")
                    .IsUnique();

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_KEY)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BINDING)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(500);

                entity.Property(e => e.ICON).HasMaxLength(254);

                entity.Property(e => e.IP).HasMaxLength(40);

                entity.Property(e => e.SEQUENCE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql(@"0
");

                entity.Property(e => e.URL).HasMaxLength(50);
            });

            modelBuilder.Entity<BASE_APPLICATION_ROLES>(entity =>
            {
                entity.HasKey(e => e.APPLICATION_ROLE_ID)
                    .HasName("PK_BASE_APPLICATIONROLES");

                entity.Property(e => e.APPLICATION_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLAY_TO)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.APPLICATION_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_KEY)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.ROLE_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ROLE_REMARK).HasMaxLength(200);

                entity.Property(e => e.ROLE_RESTRICTION).HasMaxLength(200);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(100);
            });

            modelBuilder.Entity<BASE_APPLICATION_ROLE_RIGHT>(entity =>
            {
                entity.HasKey(e => e.APPLICATION_ROLE_RIGHT_ID)
                    .HasName("PK_BASE_APPLICATIONROLERIGHT");

                entity.Property(e => e.APPLICATION_ROLE_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.AUTHORIZE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PERMISSION_TYPE).HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<BASE_BUTTON>(entity =>
            {
                entity.HasKey(e => e.BUTTON_ID);

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BUTTON_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_EVENT)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_ICON)
                    .IsRequired()
                    .HasMaxLength(254);

                entity.Property(e => e.BUTTON_IMG)
                    .IsRequired()
                    .HasMaxLength(254);

                entity.Property(e => e.BUTTON_METHOD)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_REMARK).HasMaxLength(200);

                entity.Property(e => e.BUTTON_TITLE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<BASE_CITYS>(entity =>
            {
                entity.HasKey(e => e.BASE_CITY_ID);

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<BASE_COMPANY>(entity =>
            {
                entity.HasKey(e => e.COMPANY_ID);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ADDRESS).HasMaxLength(200);

                entity.Property(e => e.CERTIFICATE).HasMaxLength(50);

                entity.Property(e => e.CITY).HasMaxLength(200);

                entity.Property(e => e.CITY_EN).HasMaxLength(200);

                entity.Property(e => e.CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_CLASS)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(50);

                entity.Property(e => e.COMPANY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COMPANY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COMPANY_NAME_TW).HasMaxLength(200);

                entity.Property(e => e.COMPANY_SHORTNAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COMPANY_SHORTNAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COMPANY_SHORTNAME_TW).HasMaxLength(200);

                entity.Property(e => e.COMPANY_TYPE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0' ");

                entity.Property(e => e.CONTACTS).HasMaxLength(35);

                entity.Property(e => e.CONTACT_PHONE).HasMaxLength(50);

                entity.Property(e => e.COUNTRY).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_CODE).HasMaxLength(30);

                entity.Property(e => e.COUNTRY_EN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_ID)
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DIGITAL_CERTIFICATE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DIGITAL_CERTIFICATE_KEY).HasMaxLength(512);

                entity.Property(e => e.DIGITAL_CERTIFICATE_REMARK).HasMaxLength(1000);

                entity.Property(e => e.EMPLOYEES).HasMaxLength(50);

                entity.Property(e => e.FAX).HasMaxLength(25);

                entity.Property(e => e.IS_ONLY_FEEDER_CUSTOMER)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_PUBLIC_CARRIER).HasDefaultValueSql("0");

                entity.Property(e => e.LARGEICON).HasMaxLength(254);

                entity.Property(e => e.LICENSES).HasColumnType("NUMBER(38)");

                entity.Property(e => e.LOGO).HasMaxLength(254);

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(50);

                entity.Property(e => e.ORGANIZING_CODE).HasMaxLength(50);

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PHONE).HasMaxLength(50);

                entity.Property(e => e.POSTCODE).HasMaxLength(10);

                entity.Property(e => e.PROVINCE).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_EN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.REGISTERED_CAPITAL).HasMaxLength(50);

                entity.Property(e => e.REGISTERED_NO).HasMaxLength(50);

                entity.Property(e => e.REMARK).HasMaxLength(200);

                entity.Property(e => e.SCAS_CODE)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'' ");

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(100);

                entity.Property(e => e.STATUS)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.USERS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.YDW_CODE).HasMaxLength(100);
            });

            modelBuilder.Entity<BASE_COMPANY_RIGHT>(entity =>
            {
                entity.HasKey(e => e.COMPANY_RIGHT_ID)
                    .HasName("PK_BASE_COMPANYRIGHT");

                entity.Property(e => e.COMPANY_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.AUTHORIZE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.MENU_ID).HasColumnType("NUMBER");

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PERMISSION_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.USERGROUP_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERROLE_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_RIGHT_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.COMPANY_)
                    .WithMany(p => p.BASE_COMPANY_RIGHT)
                    .HasForeignKey(d => d.COMPANY_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_COMPANYRIGHT_COMPANY");
            });

            modelBuilder.Entity<BASE_COMPANY_ROLE>(entity =>
            {
                entity.HasKey(e => e.COMPANY_ROLE_ID)
                    .HasName("PK_BASE_COMPANYROLE");

                entity.Property(e => e.COMPANY_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(50);

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PLATFORM_NAME)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ROLE_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.COMPANY_)
                    .WithMany(p => p.BASE_COMPANY_ROLE)
                    .HasForeignKey(d => d.COMPANY_ID)
                    .HasConstraintName("FK_COMPANY_ROLE");
            });

            modelBuilder.Entity<BASE_CONTAINER_LOCATION>(entity =>
            {
                entity.HasKey(e => e.BASE_CONTAINER_LOCATION_ID);

                entity.HasIndex(e => e.CONTAINER_LOCATION_NAME)
                    .HasName("BASE_CONT_LOC_NAME");

                entity.HasIndex(e => e.DELETE_MARK)
                    .HasName("BASE_CONT_LOC_DELETEMARK");

                entity.HasIndex(e => e.VALID)
                    .HasName("BASE_CONT_LOC_VALID");

                entity.Property(e => e.BASE_CONTAINER_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CONTAINER_LOCATION_ADDRESS).HasMaxLength(200);

                entity.Property(e => e.CONTAINER_LOCATION_NAME).HasMaxLength(200);

                entity.Property(e => e.CONTAINER_LOCATION_TEL).HasMaxLength(50);

                entity.Property(e => e.CONTAINER_LOCATION_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PROVINCE_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<BASE_CONTAINER_SIZETYPE>(entity =>
            {
                entity.HasKey(e => e.CONTAINER_SIZETYPE_ID);

                entity.Property(e => e.CONTAINER_SIZETYPE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CONTAINER_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CONTAINER_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CONTAINER_SIZE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CONTAINER_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.CREATE_COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE_TIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULL_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USER_NAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ISO_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.REMARK).HasMaxLength(200);

                entity.Property(e => e.TEU).HasColumnType("NUMBER(38)");

                entity.Property(e => e.UIINDEX).HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<BASE_COUNTRY>(entity =>
            {
                entity.HasKey(e => e.BASE_COUNTRY_ID);

                entity.HasIndex(e => e.COUNTRY_CODE)
                    .HasName("AK_BASE_COUNTRYCODE")
                    .IsUnique();

                entity.HasIndex(e => e.COUNTRY_NAME_EN)
                    .HasName("AK_BASE_COUNTRYNAME")
                    .IsUnique();

                entity.HasIndex(e => e.UNCODE)
                    .HasName("AK_BASE_COUNTRYISO")
                    .IsUnique();

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_ISO)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.UNCODE)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<BASE_CROSS_DOMAIN>(entity =>
            {
                entity.HasKey(e => e.CROSS_DOMAIN_ID)
                    .HasName("PK_CROSSDOMAIN");

                entity.Property(e => e.CROSS_DOMAIN_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLY_TO)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.CROSS_OBJECT)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CROSS_SCOPE)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.STATUS)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<BASE_CROSS_ENTERPRISE>(entity =>
            {
                entity.HasKey(e => e.CROSS_ENTERPRISE_ID)
                    .HasName("PK_CROSSENTERPRISE");

                entity.Property(e => e.CROSS_ENTERPRISE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.COMPANYS)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.STATUS)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.USERGROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.ORGANIZATION_)
                    .WithMany(p => p.BASE_CROSS_ENTERPRISE)
                    .HasForeignKey(d => d.ORGANIZATION_ID)
                    .HasConstraintName("FK_CROSSENTERPRISE_ORG");

                entity.HasOne(d => d.USERROLE_)
                    .WithMany(p => p.BASE_CROSS_ENTERPRISE)
                    .HasForeignKey(d => d.USERROLE_ID)
                    .HasConstraintName("FK_CROSSENTERPRISE_USERROLE");
            });

            modelBuilder.Entity<BASE_CURRENCY>(entity =>
            {
                entity.HasKey(e => e.BASE_CURRENCY_ID)
                    .HasName("PK_CURRENCY");

                entity.HasIndex(e => e.CURRENCY_CODE)
                    .HasName("AK_CURRENCY")
                    .IsUnique();

                entity.Property(e => e.BASE_CURRENCY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COUNTRY_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CURRENCY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CURRENCY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CURRENCY_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<BASE_DANGEROU_LEVELS>(entity =>
            {
                entity.HasKey(e => e.DANGEROU_ID);

                entity.Property(e => e.DANGEROU_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE               ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DANGEROU_CODE).HasMaxLength(35);

                entity.Property(e => e.DANGEROU_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.DANGEROU_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0                     ");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE               ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0                     ");
            });

            modelBuilder.Entity<BASE_DISTRICT>(entity =>
            {
                entity.HasKey(e => e.BASE_LOCATION_ID)
                    .HasName("PK_BASE_DISTICT");

                entity.Property(e => e.BASE_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COORDINATES)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK).HasDefaultValueSql("0");

                entity.Property(e => e.DKCODE).HasMaxLength(10);

                entity.Property(e => e.IS_AIRPORT)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_BORDER)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_FIXED)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_INLAND)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_ISO)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_OTHER)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_PORT)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_POSTAL)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_RAILTERMINAL)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_ROADTERMINAL)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.LOCATION_CODE)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LOCATION_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LOCATION_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LOC_TYPE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ORDER_SEQ)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("10000");

                entity.Property(e => e.PORT_TYPE_CODE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PORT_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.P_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.UNCODE).HasMaxLength(10);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<BASE_FEETYPE>(entity =>
            {
                entity.HasKey(e => e.BASE_FEETYPE_ID);

                entity.Property(e => e.BASE_FEETYPE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ADAPT_TO)
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.FEE_CODE)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FEE_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FEE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.FEE_REMARK).HasMaxLength(500);

                entity.Property(e => e.FEE_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.ISCOMMON)
                    .IsRequired()
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IS_AIR)
                    .IsRequired()
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.IS_BASIC)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_COMMISSION).HasDefaultValueSql("0");

                entity.Property(e => e.IS_CUSTOMS)
                    .IsRequired()
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.IS_ECL)
                    .IsRequired()
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.IS_OFCL)
                    .IsRequired()
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.IS_OLCL)
                    .IsRequired()
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.IS_RFCL)
                    .IsRequired()
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.IS_RLCL)
                    .IsRequired()
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.IS_TRAILER)
                    .IsRequired()
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SEQUENCE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("1000");

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<BASE_FEETYPE_2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BASE_FEETYPE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE               ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0                     ");

                entity.Property(e => e.FEE_CODE)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FEE_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FEE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.FEE_REMARK).HasMaxLength(500);

                entity.Property(e => e.FEE_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.ISCOMMON)
                    .IsRequired()
                    .HasDefaultValueSql("0                     ");

                entity.Property(e => e.IS_COMMISSION).HasDefaultValueSql(@"0
");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE               ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SEQUENCE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("1000");

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0                     ");
            });

            modelBuilder.Entity<BASE_HSCATEGORY>(entity =>
            {
                entity.HasKey(e => e.BASE_HSCATEGORY_ID);

                entity.Property(e => e.BASE_HSCATEGORY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CATEGORY_NAME).HasMaxLength(500);

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<BASE_HSCODE>(entity =>
            {
                entity.HasKey(e => e.BASE_HSCODE_ID);

                entity.Property(e => e.BASE_HSCODE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CONSUMPTION_TAX).HasMaxLength(100);

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.EXPORT_REBATE_TAX).HasMaxLength(100);

                entity.Property(e => e.EXPORT_TAX).HasMaxLength(100);

                entity.Property(e => e.HSCATEGORY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.HSCODE).HasMaxLength(100);

                entity.Property(e => e.HSNAME).HasMaxLength(500);

                entity.Property(e => e.IMPORT_TAX_GENERAL).HasMaxLength(100);

                entity.Property(e => e.IMPORT_TAX_MFN).HasMaxLength(100);

                entity.Property(e => e.IMPORT_TAX_TEMPORARY).HasMaxLength(100);

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.UNIT1).HasMaxLength(100);

                entity.Property(e => e.UNIT2).HasMaxLength(100);

                entity.Property(e => e.VAT).HasMaxLength(100);
            });

            modelBuilder.Entity<BASE_LOCATION>(entity =>
            {
                entity.HasKey(e => e.BASE_LOCATION_ID);

                entity.Property(e => e.BASE_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COORDINATES)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK).HasDefaultValueSql("0");

                entity.Property(e => e.DKCODE).HasMaxLength(10);

                entity.Property(e => e.IS_AIRPORT)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_BORDER)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_FIXED)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_INLAND)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_ISO)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_OTHER)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_PORT)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_POSTAL)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_RAILTERMINAL)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_ROADTERMINAL)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.LOCATION_CODE)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LOCATION_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LOCATION_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LOC_TYPE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql(@"0
");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PORT_TYPE_CODE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PORT_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.SEQUENCE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql(@"10000
");

                entity.Property(e => e.UNCODE).HasMaxLength(10);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.YDW_CODE).HasMaxLength(100);
            });

            modelBuilder.Entity<BASE_LOCATION_BAK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COORDINATES)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DKCODE).HasMaxLength(10);

                entity.Property(e => e.LOCATION_CODE)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LOCATION_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LOCATION_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PORT_TYPE_CODE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PORT_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.UNCODE).HasMaxLength(10);
            });

            modelBuilder.Entity<BASE_LOCATION_BAK1118>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COORDINATES)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DKCODE).HasMaxLength(10);

                entity.Property(e => e.LOCATION_CODE)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LOCATION_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LOCATION_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PORT_TYPE_CODE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PORT_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.UNCODE).HasMaxLength(10);
            });

            modelBuilder.Entity<BASE_LOGINLOG>(entity =>
            {
                entity.HasKey(e => e.LOGIN_LOG_ID);

                entity.Property(e => e.LOGIN_LOG_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_CODE).HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_KEY)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_NAME).HasMaxLength(50);

                entity.Property(e => e.CLIENT_VERSION).HasMaxLength(50);

                entity.Property(e => e.HEIGHT).HasColumnType("NUMBER(38)");

                entity.Property(e => e.LOGIN_ACCOUNT).HasMaxLength(50);

                entity.Property(e => e.LOGIN_IP).HasMaxLength(50);

                entity.Property(e => e.LOGIN_STATUS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.LOGIN_TIME).HasColumnType("DATE");

                entity.Property(e => e.OS).HasMaxLength(50);

                entity.Property(e => e.OWNER_ADDRESS).HasMaxLength(500);

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.WIDTH).HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<BASE_MENU>(entity =>
            {
                entity.HasKey(e => e.MENU_ID);

                entity.Property(e => e.MENU_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_KEY).HasMaxLength(50);

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ROLE_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BUTTONS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.BUTTON_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_EVENT)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_ICON)
                    .IsRequired()
                    .HasMaxLength(254);

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BUTTON_IMG)
                    .IsRequired()
                    .HasMaxLength(254);

                entity.Property(e => e.BUTTON_METHOD)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_TITLE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DIRECTORY).HasMaxLength(300);

                entity.Property(e => e.FILENAME).HasMaxLength(300);

                entity.Property(e => e.MENU_CLASS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.MENU_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MENU_ICON).HasMaxLength(50);

                entity.Property(e => e.MENU_IMG).HasMaxLength(50);

                entity.Property(e => e.MENU_LAYER)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MENU_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MENU_TITLE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MENU_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODULE_CODE)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.NAVIGATE_URL).HasMaxLength(300);

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.QUERY_STRING).HasMaxLength(300);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(100);

                entity.Property(e => e.TARGET)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BASE_MESSAGE>(entity =>
            {
                entity.HasKey(e => e.MESSAGE_ID);

                entity.Property(e => e.MESSAGE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(50);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CONFIRM)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CONFIRM_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATER).HasMaxLength(50);

                entity.Property(e => e.CREATER_NAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EXPIRE_DATE).HasColumnType("DATE");

                entity.Property(e => e.MESSAGE_CONTENT).HasMaxLength(50);

                entity.Property(e => e.MESSAGE_TITLE).HasMaxLength(50);

                entity.Property(e => e.MESSAGE_TYPE).HasMaxLength(50);

                entity.Property(e => e.NOTIFIER)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NOTIFIER_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Order)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PARAMETER).HasMaxLength(100);

                entity.Property(e => e.PARAMETER1)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PARAMETER2)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PARAMETER3)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PARAMETER4)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PARAMETER5)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.READ_DATE).HasColumnType("DATE");

                entity.Property(e => e.READ_TIME).HasColumnType("NUMBER(38)");

                entity.Property(e => e.RESPONSE).HasMaxLength(500);
            });

            modelBuilder.Entity<BASE_MODULE>(entity =>
            {
                entity.HasKey(e => e.MODULE_ID);

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DIRECTORY).HasMaxLength(300);

                entity.Property(e => e.FILENAME).HasMaxLength(300);

                entity.Property(e => e.ICON).HasMaxLength(254);

                entity.Property(e => e.IMG).HasMaxLength(254);

                entity.Property(e => e.INFORMATION).HasMaxLength(500);

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODULE_CODE)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.MODULE_LAYER).HasColumnType("NUMBER(38)");

                entity.Property(e => e.MODULE_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODULE_RIGHT_CODE).HasMaxLength(200);

                entity.Property(e => e.MODULE_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.NAVIGATE_URL).HasMaxLength(300);

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.QUERY_STRING).HasMaxLength(300);

                entity.Property(e => e.SEQUENCE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(500);

                entity.Property(e => e.VERSION).HasMaxLength(50);

                entity.HasOne(d => d.APPLICATION_)
                    .WithMany(p => p.BASE_MODULE)
                    .HasForeignKey(d => d.APPLICATION_ID)
                    .HasConstraintName("FK_BASE_MODULE_APPLICATION");
            });

            modelBuilder.Entity<BASE_MODULE_BACKUP>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.APPLICATION_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK).HasColumnType("NUMBER(38)");

                entity.Property(e => e.DIRECTORY).HasMaxLength(300);

                entity.Property(e => e.FILENAME).HasMaxLength(300);

                entity.Property(e => e.ICON).HasMaxLength(254);

                entity.Property(e => e.IMG).HasMaxLength(254);

                entity.Property(e => e.INFORMATION).HasMaxLength(500);

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODULE_CODE)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.MODULE_LAYER).HasColumnType("NUMBER(38)");

                entity.Property(e => e.MODULE_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODULE_RIGHT_CODE).HasMaxLength(200);

                entity.Property(e => e.MODULE_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.NAVIGATE_URL).HasMaxLength(300);

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.QUERY_STRING).HasMaxLength(300);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(500);

                entity.Property(e => e.VERSION).HasMaxLength(50);
            });

            modelBuilder.Entity<BASE_MODULE_BUTTON>(entity =>
            {
                entity.HasKey(e => e.MODULE_BUTTON_ID)
                    .HasName("PK_BASE_MODULEBUTTON");

                entity.Property(e => e.MODULE_BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.RESPONSE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.SEQUENCE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BASE_NAVIGATION>(entity =>
            {
                entity.HasKey(e => e.NAVIGATION_ID);

                entity.Property(e => e.NAVIGATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ICON).HasMaxLength(50);

                entity.Property(e => e.NAVIGATE_URL)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.NAVIGATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.REMAK).HasMaxLength(200);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(100);

                entity.Property(e => e.TARGET).HasMaxLength(50);

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<BASE_ONLINE>(entity =>
            {
                entity.HasKey(e => new { e.PLATFORM, e.TOKEN, e.USERNAME });

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TOKEN).HasMaxLength(50);

                entity.Property(e => e.USERNAME).HasMaxLength(50);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_NAME).HasMaxLength(200);

                entity.Property(e => e.FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LAST_URL).HasMaxLength(500);

                entity.Property(e => e.LOGIN_IP).HasMaxLength(50);

                entity.Property(e => e.LOGIN_IP_ADDRESS).HasMaxLength(200);

                entity.Property(e => e.LOGIN_TIME).HasColumnType("DATE");

                entity.Property(e => e.ONLINE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.REFRESH_TIME).HasColumnType("DATE");
            });

            modelBuilder.Entity<BASE_ORGANIZATION>(entity =>
            {
                entity.HasKey(e => e.ORGANIZATION_ID);

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.LAYER)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_ADDRESS).HasMaxLength(200);

                entity.Property(e => e.ORGANIZATION_ASSISTANT_MANAGER).HasColumnType("NUMBER");

                entity.Property(e => e.ORGANIZATION_CODE)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ORGANIZATION_EMAIL).HasMaxLength(200);

                entity.Property(e => e.ORGANIZATION_FAX).HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_INNER_PHONE).HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_MANAGER).HasColumnType("NUMBER");

                entity.Property(e => e.ORGANIZATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_OUTER_PHONE).HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_POSTCODE).HasMaxLength(10);

                entity.Property(e => e.ORGANIZATION_REMARK).HasMaxLength(200);

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(100);

                entity.Property(e => e.USERS).HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<BASE_ORGANIZATION_RIGHT>(entity =>
            {
                entity.HasKey(e => e.ORGANIZATION_RIGHT_ID)
                    .HasName("PK_BASE_ORGANIZATIONRIGHT");

                entity.Property(e => e.ORGANIZATION_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.AUTHORIZE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MENU_ID).HasColumnType("NUMBER");

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PERMISSION_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.USERGROUP_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERROLE_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_RIGHT_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.MENU_)
                    .WithMany(p => p.BASE_ORGANIZATION_RIGHT)
                    .HasForeignKey(d => d.MENU_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ORGANIZERIGHT_MENU");

                entity.HasOne(d => d.ORGANIZATION_)
                    .WithMany(p => p.BASE_ORGANIZATION_RIGHT)
                    .HasForeignKey(d => d.ORGANIZATION_ID)
                    .HasConstraintName("FK_ORGANIZERIGHT_ORGANIZE");
            });

            modelBuilder.Entity<BASE_PERSON>(entity =>
            {
                entity.HasKey(e => e.PERSON_ID);

                entity.HasIndex(e => new { e.IDCARD_TYPE, e.IDCARD_NO })
                    .HasName("AK_BASE_PERSON")
                    .IsUnique();

                entity.Property(e => e.PERSON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ADDRESS).HasMaxLength(200);

                entity.Property(e => e.CITY).HasMaxLength(50);

                entity.Property(e => e.CONFIRM_EMAIL)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CONFIRM_IDCARD)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CONFIRM_MOBILE)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.COUNTRY).HasMaxLength(50);

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.FIRST_NAME).HasMaxLength(50);

                entity.Property(e => e.FULLNAME_CN).HasMaxLength(50);

                entity.Property(e => e.FULLNAME_EN)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GENDER)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'M'");

                entity.Property(e => e.IDCARD_NO)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IDCARD_TYPE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LAST_NAME).HasMaxLength(50);

                entity.Property(e => e.MOBILE).HasMaxLength(50);

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(50);

                entity.Property(e => e.NATIONALITY).HasMaxLength(50);

                entity.Property(e => e.PICTURE).HasMaxLength(200);

                entity.Property(e => e.PROVINCE).HasMaxLength(50);

                entity.Property(e => e.REMARK).HasMaxLength(1000);
            });

            modelBuilder.Entity<BASE_PROVINCES>(entity =>
            {
                entity.HasKey(e => e.BASE_PROVINCE_ID)
                    .HasName("PK_BASE_PROVINCE");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UNCODE)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.BASE_COUNTRY_)
                    .WithMany(p => p.BASE_PROVINCES)
                    .HasForeignKey(d => d.BASE_COUNTRY_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BASE_PROVINCES");
            });

            modelBuilder.Entity<BASE_RAILWAY_PRICE_LEVEL>(entity =>
            {
                entity.HasKey(e => e.BASE_RAILWAY_PRICE_LEVEL_ID);

                entity.Property(e => e.BASE_RAILWAY_PRICE_LEVEL_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.CITY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CLASS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.COUNTRY_CODE).HasMaxLength(20);

                entity.Property(e => e.COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(100);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.GP20_DOUBLE_LOWER)
                    .HasColumnType("NUMBER(10,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.GP20_DOUBLE_UPPER)
                    .HasColumnType("NUMBER(10,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.GP20_LOWER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP20_UPPER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP40_LOWER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP40_UPPER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP45_LOWER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP45_UPPER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.STATUS).HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.CITY_)
                    .WithMany(p => p.BASE_RAILWAY_PRICE_LEVEL)
                    .HasForeignKey(d => d.CITY_ID)
                    .HasConstraintName("FK_BASE_RAI_RF_BASE_R_BASE_CIT");

                entity.HasOne(d => d.COUNTRY_)
                    .WithMany(p => p.BASE_RAILWAY_PRICE_LEVEL)
                    .HasForeignKey(d => d.COUNTRY_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BASE_RAI_RF_BASE_R_BASE_COU");

                entity.HasOne(d => d.PROVINCE_)
                    .WithMany(p => p.BASE_RAILWAY_PRICE_LEVEL)
                    .HasForeignKey(d => d.PROVINCE_ID)
                    .HasConstraintName("FK_BASE_RAI_RF_BASE_R_BASE_PRO");
            });

            modelBuilder.Entity<BASE_RAILWAY_PRICE_LEV_DET>(entity =>
            {
                entity.HasKey(e => e.BASE_RAIL_PRICE_LEV_DET_ID)
                    .HasName("SYS_C0040013");

                entity.Property(e => e.BASE_RAIL_PRICE_LEV_DET_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_RAIL_PRICE_LEV_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ISUNRESTRICTED)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MAXMUM).HasColumnType("NUMBER");

                entity.Property(e => e.MINNUM).HasColumnType("NUMBER");

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.HasOne(d => d.BASE_RAIL_PRICE_LEV_)
                    .WithMany(p => p.BASE_RAILWAY_PRICE_LEV_DET)
                    .HasForeignKey(d => d.BASE_RAIL_PRICE_LEV_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BASE_RAILWAY_PRICE_LEV_DET");
            });

            modelBuilder.Entity<BASE_RECYCLEBIN>(entity =>
            {
                entity.HasKey(e => e.RECYCLEBIN_ID)
                    .HasName("PK_BASE_RECYCLEBINS");

                entity.Property(e => e.RECYCLEBIN_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.RECYCLEBIN_DATABASE).HasMaxLength(50);

                entity.Property(e => e.RECYCLEBIN_FIELD_KEY).HasMaxLength(50);

                entity.Property(e => e.RECYCLEBIN_FIELD_VALUE).HasMaxLength(50);

                entity.Property(e => e.RECYCLEBIN_NAME).HasMaxLength(50);

                entity.Property(e => e.RECYCLEBIN_TABLE).HasMaxLength(50);
            });

            modelBuilder.Entity<BASE_STAFF_ORGANIZE>(entity =>
            {
                entity.HasKey(e => e.STAFF_ORGANIZE_ID)
                    .HasName("PK_BASE_STAFFORGANIZE");

                entity.Property(e => e.STAFF_ORGANIZE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.ORGANIZATION_)
                    .WithMany(p => p.BASE_STAFF_ORGANIZE)
                    .HasForeignKey(d => d.ORGANIZATION_ID)
                    .HasConstraintName("FK_STAFFORGANIZE_ORGANIZATION");
            });

            modelBuilder.Entity<BASE_STREET_BAK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LOC_CODE).HasMaxLength(30);

                entity.Property(e => e.LOC_NAME).HasMaxLength(30);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PARENTID).HasColumnType("NUMBER");

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.STREETID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<BASE_TERMINAL>(entity =>
            {
                entity.HasKey(e => e.BASE_TERMINAL_ID);

                entity.Property(e => e.BASE_TERMINAL_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK).HasDefaultValueSql("0");

                entity.Property(e => e.LOCATION_CODE)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LOCATION_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LOCATION_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.TERMINAL_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TERMINAL_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.BASE_LOCATION_)
                    .WithMany(p => p.BASE_TERMINAL)
                    .HasForeignKey(d => d.BASE_LOCATION_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BASE_TER_FK_BASE_T_BASE_LOC");
            });

            modelBuilder.Entity<BASE_TRAILER_PRICE_LEVEL>(entity =>
            {
                entity.HasKey(e => e.BASE_TRAILER_PRICE_LEVEL_ID)
                    .HasName("PK_BASE_TRAILER_PRICE_BYWEIGHT");

                entity.Property(e => e.BASE_TRAILER_PRICE_LEVEL_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.CITY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CLASS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.COUNTRY_CODE).HasMaxLength(20);

                entity.Property(e => e.COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(100);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.GP20_LOWER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP20_LOWER_DOUBLE).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP20_UPPER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP20_UPPER_DOUBLE).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP40_LOWER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP40_UPPER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP45_LOWER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.GP45_UPPER).HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.STATUS).HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.CITY_)
                    .WithMany(p => p.BASE_TRAILER_PRICE_LEVEL)
                    .HasForeignKey(d => d.CITY_ID)
                    .HasConstraintName("FK_BASE_TRA_RF_BASE_T_BASE_CIT");

                entity.HasOne(d => d.COUNTRY_)
                    .WithMany(p => p.BASE_TRAILER_PRICE_LEVEL)
                    .HasForeignKey(d => d.COUNTRY_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BASE_TRA_RF_BASE_T_BASE_COU");

                entity.HasOne(d => d.PROVINCE_)
                    .WithMany(p => p.BASE_TRAILER_PRICE_LEVEL)
                    .HasForeignKey(d => d.PROVINCE_ID)
                    .HasConstraintName("FK_BASE_TRA_RF_BASE_T_BASE_PRO");
            });

            modelBuilder.Entity<BASE_TRAIL_PRICE_LEV_DET>(entity =>
            {
                entity.HasKey(e => e.BASE_TRAI_PRICE_LEVEL_DET_ID)
                    .HasName("SYS_C0039728");

                entity.Property(e => e.BASE_TRAI_PRICE_LEVEL_DET_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_TRAI_PRICE_LEVEL_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ISUNRESTRICTED)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MAXMUM).HasColumnType("NUMBER");

                entity.Property(e => e.MINNUM).HasColumnType("NUMBER");

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.HasOne(d => d.BASE_TRAI_PRICE_LEVEL_)
                    .WithMany(p => p.BASE_TRAIL_PRICE_LEV_DET)
                    .HasForeignKey(d => d.BASE_TRAI_PRICE_LEVEL_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BASE_TRAIL_PRICE_LEV_DET");
            });

            modelBuilder.Entity<BASE_USERGROUP>(entity =>
            {
                entity.HasKey(e => e.USERGROUP_ID);

                entity.Property(e => e.USERGROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ADMIN).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.LAYER)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(100);

                entity.Property(e => e.USERGROUP_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.USERGROUP_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.USERGROUP_REMARK).HasMaxLength(200);
            });

            modelBuilder.Entity<BASE_USERGROUP_RIGHT>(entity =>
            {
                entity.HasKey(e => e.USERGROUP_RIGHT_ID)
                    .HasName("PK_BASE_USERGROUPRIGHT");

                entity.Property(e => e.USERGROUP_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.AUTHORIZE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MENU_ID).HasColumnType("NUMBER");

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ORGANIZATION_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PERMISSION_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.USERGROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERROLE_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_RIGHT_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.MENU_)
                    .WithMany(p => p.BASE_USERGROUP_RIGHT)
                    .HasForeignKey(d => d.MENU_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UGRIGHT_MENU");

                entity.HasOne(d => d.ORGANIZATION_RIGHT_)
                    .WithMany(p => p.BASE_USERGROUP_RIGHT)
                    .HasForeignKey(d => d.ORGANIZATION_RIGHT_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UGRIGHT_ORGANIZERIGHT");

                entity.HasOne(d => d.USERGROUP_)
                    .WithMany(p => p.BASE_USERGROUP_RIGHT)
                    .HasForeignKey(d => d.USERGROUP_ID)
                    .HasConstraintName("FK_UGRIGHT_USERGROUP");
            });

            modelBuilder.Entity<BASE_USERINFO>(entity =>
            {
                entity.HasKey(e => e.USER_ID);

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ANSWER).HasMaxLength(50);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COMPANY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COMPANY_NAME_TW).HasMaxLength(200);

                entity.Property(e => e.COMPANY_SHORTNAME_CN).HasMaxLength(200);

                entity.Property(e => e.COMPANY_SHORTNAME_EN).HasMaxLength(200);

                entity.Property(e => e.COMPANY_SHORTNAME_TW).HasMaxLength(200);

                entity.Property(e => e.CONFIRM_EMAIL)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CONFIRM_MOBILE)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DIGITAL_CERTIFICATE_KEY).HasMaxLength(512);

                entity.Property(e => e.DIGITAL_CERTIFICATE_REMARK).HasMaxLength(1000);

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GENDER).HasColumnType("CHAR(1)");

                entity.Property(e => e.IS_ADMIN)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IS_LOCAL)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.LANGUAGE)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'ENG'");

                entity.Property(e => e.LOCK_DAY)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.MOBILE_PHONE).HasMaxLength(50);

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(50);

                entity.Property(e => e.NAVIGATE).HasMaxLength(50);

                entity.Property(e => e.OFFICE_PHONE).HasMaxLength(50);

                entity.Property(e => e.PAGE_SIZE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PASSWORD)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PERSONAL_AUTHENTICATION)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PERSON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.QUESTION).HasMaxLength(50);

                entity.Property(e => e.REMARK).HasMaxLength(1000);

                entity.Property(e => e.SOURCE_NAME).HasMaxLength(100);

                entity.Property(e => e.SOURCE_URL).HasMaxLength(100);

                entity.Property(e => e.THEME).HasMaxLength(50);

                entity.Property(e => e.THEMES).HasMaxLength(50);

                entity.Property(e => e.TITLE).HasMaxLength(50);

                entity.Property(e => e.USERCODE).HasMaxLength(50);

                entity.Property(e => e.USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.USER_TYPE).HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<BASE_USERINFO_BAK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ANSWER).HasMaxLength(50);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COMPANY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COMPANY_NAME_TW).HasMaxLength(200);

                entity.Property(e => e.COMPANY_SHORTNAME_CN).HasMaxLength(200);

                entity.Property(e => e.COMPANY_SHORTNAME_EN).HasMaxLength(200);

                entity.Property(e => e.COMPANY_SHORTNAME_TW).HasMaxLength(200);

                entity.Property(e => e.CONFIRM_EMAIL)
                    .IsRequired()
                    .HasDefaultValueSql("0                     ");

                entity.Property(e => e.CONFIRM_MOBILE)
                    .IsRequired()
                    .HasDefaultValueSql("0                     ");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0                     ");

                entity.Property(e => e.DIGITAL_CERTIFICATE_KEY).HasMaxLength(512);

                entity.Property(e => e.DIGITAL_CERTIFICATE_REMARK).HasMaxLength(1000);

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GENDER).HasColumnType("CHAR(1)");

                entity.Property(e => e.IS_ADMIN)
                    .IsRequired()
                    .HasDefaultValueSql("0                     ");

                entity.Property(e => e.IS_LOCAL)
                    .IsRequired()
                    .HasDefaultValueSql("0                     ");

                entity.Property(e => e.LANGUAGE)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'ENG'");

                entity.Property(e => e.LOCK_DAY)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.MOBILE_PHONE).HasMaxLength(50);

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(50);

                entity.Property(e => e.NAVIGATE).HasMaxLength(50);

                entity.Property(e => e.OFFICE_PHONE).HasMaxLength(50);

                entity.Property(e => e.PAGE_SIZE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PASSWORD)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PERSONAL_AUTHENTICATION)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PERSON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.QUESTION).HasMaxLength(50);

                entity.Property(e => e.REMARK).HasMaxLength(1000);

                entity.Property(e => e.SOURCE_NAME).HasMaxLength(100);

                entity.Property(e => e.SOURCE_URL).HasMaxLength(100);

                entity.Property(e => e.THEME).HasMaxLength(50);

                entity.Property(e => e.THEMES).HasMaxLength(50);

                entity.Property(e => e.TITLE).HasMaxLength(50);

                entity.Property(e => e.USERCODE).HasMaxLength(50);

                entity.Property(e => e.USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_TYPE).HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<BASE_USERINFO_USERGROUP>(entity =>
            {
                entity.HasKey(e => e.USERINFO_USERGROUP_ID)
                    .HasName("PK_BASE_USERINFOUSERGROUP");

                entity.Property(e => e.USERINFO_USERGROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.USERGROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<BASE_USERROLE>(entity =>
            {
                entity.HasKey(e => e.USERROLE_ID)
                    .HasName("PK_BASE_USERROLES");

                entity.Property(e => e.USERROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ADMIN).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ROLE_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ROLE_REMARK).HasMaxLength(200);

                entity.Property(e => e.ROLE_RESTRICTION).HasMaxLength(200);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(100);
            });

            modelBuilder.Entity<BASE_USERROLE_RIGHT>(entity =>
            {
                entity.HasKey(e => e.USERROLE_RIGHT_ID)
                    .HasName("PK_BASE_USERROLERIGHT");

                entity.Property(e => e.USERROLE_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.AUTHORIZE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MENU_ID).HasColumnType("NUMBER");

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ORGANIZATION_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PERMISSION_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.USERGROUP_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_RIGHT_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.MENU_)
                    .WithMany(p => p.BASE_USERROLE_RIGHT)
                    .HasForeignKey(d => d.MENU_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USERROLERIGHT_MENU");

                entity.HasOne(d => d.ORGANIZATION_RIGHT_)
                    .WithMany(p => p.BASE_USERROLE_RIGHT)
                    .HasForeignKey(d => d.ORGANIZATION_RIGHT_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USERROLERIGHT_ORGANIZERIGHT");

                entity.HasOne(d => d.USERGROUP_RIGHT_)
                    .WithMany(p => p.BASE_USERROLE_RIGHT)
                    .HasForeignKey(d => d.USERGROUP_RIGHT_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USERROLERIGHT_UGRIGHT");

                entity.HasOne(d => d.USERROLE_)
                    .WithMany(p => p.BASE_USERROLE_RIGHT)
                    .HasForeignKey(d => d.USERROLE_ID)
                    .HasConstraintName("FK_USERROLERIGHT_USERROLE");
            });

            modelBuilder.Entity<BASE_USER_RIGHT>(entity =>
            {
                entity.HasKey(e => e.USER_RIGHT_ID)
                    .HasName("PK_BASE_USERRIGHT");

                entity.Property(e => e.USER_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.APPLICATION_ROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.AUTHORIZE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.MENU_ID).HasColumnType("NUMBER");

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.ORGANIZATION_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PERMISSION_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.USERGROUP_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERROLE_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.ORGANIZATION_RIGHT_)
                    .WithMany(p => p.BASE_USER_RIGHT)
                    .HasForeignKey(d => d.ORGANIZATION_RIGHT_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USERRIGHT_ORGANIZERIGHT");

                entity.HasOne(d => d.USERGROUP_RIGHT_)
                    .WithMany(p => p.BASE_USER_RIGHT)
                    .HasForeignKey(d => d.USERGROUP_RIGHT_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USERRIGHT_USERGROUPRIGHT");

                entity.HasOne(d => d.USERROLE_RIGHT_)
                    .WithMany(p => p.BASE_USER_RIGHT)
                    .HasForeignKey(d => d.USERROLE_RIGHT_ID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USERRIGHT_USERROLERIGHT");

                entity.HasOne(d => d.USER_)
                    .WithMany(p => p.BASE_USER_RIGHT)
                    .HasForeignKey(d => d.USER_ID)
                    .HasConstraintName("FK_BASE_USERRIGHT_USERINFO");
            });

            modelBuilder.Entity<BASE_USER_USERROLES>(entity =>
            {
                entity.HasKey(e => e.USER_USERROLE_ID)
                    .HasName("PK_BASE_USERROLE");

                entity.Property(e => e.USER_USERROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.USERROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<BUSINESS_FILTER>(entity =>
            {
                entity.HasKey(e => e.BUSINESS_FILTER_ID)
                    .HasName("PK_BUSINESSFILTER");

                entity.Property(e => e.BUSINESS_FILTER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUSINESS_FILTER_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUSINESS_FILTER_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.REMARK)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.STATUS)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.USER_GROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_ROLE_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<BUSINESS_FILTER_CONDITION>(entity =>
            {
                entity.HasKey(e => e.BUSINESS_FILTER_CONDITION_ID)
                    .HasName("PK_BUSINESSFILTERCONDITION");

                entity.Property(e => e.BUSINESS_FILTER_CONDITION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BUSINESS_FILTER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.FILTER_FIELD)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FILTER_OPERATOR).HasMaxLength(10);

                entity.Property(e => e.FILTER_VALUE)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(50);

                entity.Property(e => e.OPERATOR).HasMaxLength(10);

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<FBAREPOSITORIE>(entity =>
            {
                entity.HasKey(e => e.FBAREPOSID)
                    .HasName("SYS_C0031874");

                entity.Property(e => e.FBAREPOSID).HasColumnType("NUMBER");

                entity.Property(e => e.ADDRESS).HasMaxLength(500);

                entity.Property(e => e.COUNTRY)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.COUNTRYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.FBAREPOSCODE)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MODIFT_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.PROVINCEID).HasColumnType("NUMBER");

                entity.Property(e => e.PROVINCENAME).HasMaxLength(200);

                entity.Property(e => e.PROVINCESHORTNAME).HasMaxLength(200);

                entity.Property(e => e.ZIPCODE).HasMaxLength(20);
            });

            modelBuilder.Entity<LOC_IM>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COORDINATES)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE).HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(30);

                entity.Property(e => e.DKCODE).HasMaxLength(10);

                entity.Property(e => e.LOCATION_CODE).HasMaxLength(20);

                entity.Property(e => e.LOCATION_NAME_CN).HasMaxLength(150);

                entity.Property(e => e.LOCATION_NAME_EN).HasMaxLength(150);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(30);

                entity.Property(e => e.PORT_TYPE_CODE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PORT_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.UNCODE).HasMaxLength(10);
            });

            modelBuilder.Entity<LOC_IM_BAK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COORDINATES)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE).HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(30);

                entity.Property(e => e.DKCODE).HasMaxLength(10);

                entity.Property(e => e.LOCATION_CODE).HasMaxLength(20);

                entity.Property(e => e.LOCATION_NAME_CN).HasMaxLength(150);

                entity.Property(e => e.LOCATION_NAME_EN).HasMaxLength(150);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(30);

                entity.Property(e => e.PORT_TYPE_CODE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PORT_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.UNCODE).HasMaxLength(10);
            });

            modelBuilder.Entity<LOC_IM_TODO>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COORDINATES)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE).HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(30);

                entity.Property(e => e.DKCODE).HasMaxLength(10);

                entity.Property(e => e.LOCATION_CODE).HasMaxLength(20);

                entity.Property(e => e.LOCATION_NAME_CN).HasMaxLength(150);

                entity.Property(e => e.LOCATION_NAME_EN).HasMaxLength(150);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(30);

                entity.Property(e => e.PORT_TYPE_CODE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PORT_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.UNCODE).HasMaxLength(10);
            });

            modelBuilder.Entity<LOC_IM_TODO_BAK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AREA_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BASE_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_LOCATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BASE_PROVINCE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COORDINATES)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY_CODE).HasMaxLength(30);

                entity.Property(e => e.COUNTRY_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(30);

                entity.Property(e => e.DKCODE).HasMaxLength(10);

                entity.Property(e => e.LOCATION_CODE).HasMaxLength(20);

                entity.Property(e => e.LOCATION_NAME_CN).HasMaxLength(150);

                entity.Property(e => e.LOCATION_NAME_EN).HasMaxLength(150);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME).HasMaxLength(30);

                entity.Property(e => e.PORT_TYPE_CODE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PORT_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(30);

                entity.Property(e => e.PROVINCE_NAME_CN).HasMaxLength(200);

                entity.Property(e => e.PROVINCE_NAME_EN).HasMaxLength(200);

                entity.Property(e => e.REMARK).HasMaxLength(500);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.UNCODE).HasMaxLength(10);
            });

            modelBuilder.Entity<MULTI_LANGUAGE>(entity =>
            {
                entity.HasKey(e => e.MULTI_LANGUAGE_ID);

                entity.HasIndex(e => new { e.APPLICATION_ID, e.PLATFORM, e.RESOURCE_TYPE, e.RESOURCE_CODE })
                    .HasName("AK_MULTI_LANGUAGE")
                    .IsUnique();

                entity.Property(e => e.MULTI_LANGUAGE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ARABIC)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BIG5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME).HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME).HasMaxLength(50);

                entity.Property(e => e.DELETE_MARK)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ENGLISH)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FRENCH)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GBK)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GERMAN)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.JAPANESE)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.KOREAN)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LATIN)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PORTUGUESE)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RESOURCE_CODE)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RESOURCE_TYPE)
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SPANISH)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MV_AIRPORT_COUNTRY>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MV_AIRPORT_COUNTRY");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TOTAL_COUNT).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<MV_PORT_AREA>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MV_PORT_AREA");

                entity.Property(e => e.SHIP_ROUTE_AREA_CNAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_ROUTE_AREA_ENAME)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_ROUTE_AREA_ID).HasColumnType("NUMBER");

                entity.Property(e => e.TOTAL_COUNT).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<MV_PORT_COUNTRY>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MV_PORT_COUNTRY");

                entity.Property(e => e.BASE_COUNTRY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COUNTRY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.COUNTRY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TOTAL_COUNT).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<NAVIGATION>(entity =>
            {
                entity.HasKey(e => e.NAVIGATION_ID);

                entity.Property(e => e.NAVIGATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Default)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_DATE).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NAVIGATE_ICON)
                    .IsRequired()
                    .HasMaxLength(254);

                entity.Property(e => e.NAVIGATE_REMARK).HasMaxLength(200);

                entity.Property(e => e.NAVIGATE_URL)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.NAVIGATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TARGET)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SHIPINFO>(entity =>
            {
                entity.HasKey(e => e.SHIPINFO_ID);

                entity.Property(e => e.SHIPINFO_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CALLSIGN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CARRIER_CODE).HasMaxLength(30);

                entity.Property(e => e.CARRIER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CARRIER_NAME).HasMaxLength(200);

                entity.Property(e => e.CARRIER_SHORT_NAME).HasMaxLength(15);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IMO_CODE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SHIP_CODE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_NAME_CN)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_OWNER)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TEN_CARGO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TEUS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TEU_INCABIN).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TEU_ONDESK).HasColumnType("NUMBER(38)");

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.VESSEL_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SHIP_ROUTE_AREA>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_AREA_ID)
                    .HasName("PK_SHIPROUTEAREA");

                entity.Property(e => e.SHIP_ROUTE_AREA_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CARRIER_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CARRIER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CARRIER_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CARRIER_SHORT_NAME)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_ROUTE_AREA_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_ROUTE_AREA_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<SHIP_ROUTE_AREA_CITY>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_AREA_CITY_ID)
                    .HasName("SYS_C0032563");

                entity.Property(e => e.SHIP_ROUTE_AREA_CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CITY_COUNTRY_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CITY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CITY_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CITY_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SHIP_ROUTE_AREA_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SHIP_ROUTE_AREA_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SHIP_ROUTE_AREA_PORT>(entity =>
            {
                entity.HasKey(e => e.SHIP_ROUTE_AREA_PORT_ID)
                    .HasName("PK_SHIPROUTEAREAPORT");

                entity.Property(e => e.SHIP_ROUTE_AREA_PORT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PORT_CODE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PORT_COUNTRY_CODE)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PORT_COUNTRY_NAME)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PORT_NAME_CN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PORT_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_ROUTE_AREA_CODE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHIP_ROUTE_AREA_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.SHIP_ROUTE_AREA_)
                    .WithMany(p => p.SHIP_ROUTE_AREA_PORT)
                    .HasForeignKey(d => d.SHIP_ROUTE_AREA_ID)
                    .HasConstraintName("FK_SHIPROUTEAREAPORT");
            });

            modelBuilder.Entity<TASK_CONFIG>(entity =>
            {
                entity.HasKey(e => e.TASK_CONFIG_ID);

                entity.Property(e => e.TASK_CONFIG_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_KEY)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.COMPANY_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DAYBYMONTH)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EFFECTIVE_FROM).HasColumnType("DATE");

                entity.Property(e => e.EFFECTIVE_TO).HasColumnType("DATE");

                entity.Property(e => e.EXECUTE_METHOD)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.INTERVALS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.LAST_RUN_TIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MULTI).HasColumnType("NUMBER(38)");

                entity.Property(e => e.P01).IsUnicode(false);

                entity.Property(e => e.P02).IsUnicode(false);

                entity.Property(e => e.P03).IsUnicode(false);

                entity.Property(e => e.P04).IsUnicode(false);

                entity.Property(e => e.P05).IsUnicode(false);

                entity.Property(e => e.P06).IsUnicode(false);

                entity.Property(e => e.P07).IsUnicode(false);

                entity.Property(e => e.P08).IsUnicode(false);

                entity.Property(e => e.P09).IsUnicode(false);

                entity.Property(e => e.P10).IsUnicode(false);

                entity.Property(e => e.P11).IsUnicode(false);

                entity.Property(e => e.P12).IsUnicode(false);

                entity.Property(e => e.P13).IsUnicode(false);

                entity.Property(e => e.P14).IsUnicode(false);

                entity.Property(e => e.P15).IsUnicode(false);

                entity.Property(e => e.P16).IsUnicode(false);

                entity.Property(e => e.P17).IsUnicode(false);

                entity.Property(e => e.P18).IsUnicode(false);

                entity.Property(e => e.P19).IsUnicode(false);

                entity.Property(e => e.P20).IsUnicode(false);

                entity.Property(e => e.P21).IsUnicode(false);

                entity.Property(e => e.P22).IsUnicode(false);

                entity.Property(e => e.P23).IsUnicode(false);

                entity.Property(e => e.P24).IsUnicode(false);

                entity.Property(e => e.P25).IsUnicode(false);

                entity.Property(e => e.P26).IsUnicode(false);

                entity.Property(e => e.P27).IsUnicode(false);

                entity.Property(e => e.P28).IsUnicode(false);

                entity.Property(e => e.P29).IsUnicode(false);

                entity.Property(e => e.P30).IsUnicode(false);

                entity.Property(e => e.P31).IsUnicode(false);

                entity.Property(e => e.P32).IsUnicode(false);

                entity.Property(e => e.P33).IsUnicode(false);

                entity.Property(e => e.P34).IsUnicode(false);

                entity.Property(e => e.P35).IsUnicode(false);

                entity.Property(e => e.P36).IsUnicode(false);

                entity.Property(e => e.P37).IsUnicode(false);

                entity.Property(e => e.P38).IsUnicode(false);

                entity.Property(e => e.P39).IsUnicode(false);

                entity.Property(e => e.P40).IsUnicode(false);

                entity.Property(e => e.P41).IsUnicode(false);

                entity.Property(e => e.P42).IsUnicode(false);

                entity.Property(e => e.P43).IsUnicode(false);

                entity.Property(e => e.P44).IsUnicode(false);

                entity.Property(e => e.P45).IsUnicode(false);

                entity.Property(e => e.P46).IsUnicode(false);

                entity.Property(e => e.P47).IsUnicode(false);

                entity.Property(e => e.P48).IsUnicode(false);

                entity.Property(e => e.P49).IsUnicode(false);

                entity.Property(e => e.P50).IsUnicode(false);

                entity.Property(e => e.P51).IsUnicode(false);

                entity.Property(e => e.P52).IsUnicode(false);

                entity.Property(e => e.P53).IsUnicode(false);

                entity.Property(e => e.P54).IsUnicode(false);

                entity.Property(e => e.P55).IsUnicode(false);

                entity.Property(e => e.P56).IsUnicode(false);

                entity.Property(e => e.P57).IsUnicode(false);

                entity.Property(e => e.P58).IsUnicode(false);

                entity.Property(e => e.P59).IsUnicode(false);

                entity.Property(e => e.P60).IsUnicode(false);

                entity.Property(e => e.P61).IsUnicode(false);

                entity.Property(e => e.P62).IsUnicode(false);

                entity.Property(e => e.P63).IsUnicode(false);

                entity.Property(e => e.P64).IsUnicode(false);

                entity.Property(e => e.P65).IsUnicode(false);

                entity.Property(e => e.P66).IsUnicode(false);

                entity.Property(e => e.P67).IsUnicode(false);

                entity.Property(e => e.P68).IsUnicode(false);

                entity.Property(e => e.P69).IsUnicode(false);

                entity.Property(e => e.P70).IsUnicode(false);

                entity.Property(e => e.P71).IsUnicode(false);

                entity.Property(e => e.P72).IsUnicode(false);

                entity.Property(e => e.P73).IsUnicode(false);

                entity.Property(e => e.P74).IsUnicode(false);

                entity.Property(e => e.P75).IsUnicode(false);

                entity.Property(e => e.P76).IsUnicode(false);

                entity.Property(e => e.P77).IsUnicode(false);

                entity.Property(e => e.P78).IsUnicode(false);

                entity.Property(e => e.P79).IsUnicode(false);

                entity.Property(e => e.P80).IsUnicode(false);

                entity.Property(e => e.P81).IsUnicode(false);

                entity.Property(e => e.P82).IsUnicode(false);

                entity.Property(e => e.P83).IsUnicode(false);

                entity.Property(e => e.P84).IsUnicode(false);

                entity.Property(e => e.P85).IsUnicode(false);

                entity.Property(e => e.P86).IsUnicode(false);

                entity.Property(e => e.P87).IsUnicode(false);

                entity.Property(e => e.P88).IsUnicode(false);

                entity.Property(e => e.P89).IsUnicode(false);

                entity.Property(e => e.P90).IsUnicode(false);

                entity.Property(e => e.P91).IsUnicode(false);

                entity.Property(e => e.P92).IsUnicode(false);

                entity.Property(e => e.P93).IsUnicode(false);

                entity.Property(e => e.P94).IsUnicode(false);

                entity.Property(e => e.P95).IsUnicode(false);

                entity.Property(e => e.P96).IsUnicode(false);

                entity.Property(e => e.P97).IsUnicode(false);

                entity.Property(e => e.P98).IsUnicode(false);

                entity.Property(e => e.P99).IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SUCCESS_RUN_TIME).HasColumnType("DATE");

                entity.Property(e => e.TASK_CODE)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_ID).HasColumnType("NUMBER");

                entity.Property(e => e.TASK_NAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_OBJECT)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_REMARK)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TIMEBYDAY)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<TASK_DEFINE>(entity =>
            {
                entity.HasKey(e => e.TASK_DEFINE_ID);

                entity.HasIndex(e => new { e.APPLICATION_ID, e.TASK_CODE })
                    .HasName("AK_TASK_DEFINE")
                    .IsUnique();

                entity.Property(e => e.TASK_DEFINE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_KEY)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.EXECUTE_METHOD).HasColumnType("NUMBER(38)");

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MULTI).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TASK_CODE)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_NAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_OBJECT)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_REMARK)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_TYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<TASK_GROUP>(entity =>
            {
                entity.HasKey(e => e.TASK_GROUP_ID);

                entity.HasIndex(e => new { e.GROUP_ID, e.TASK_CONFIG_ID, e.COMPANY_ID })
                    .HasName("AK_AK_TASK_GROUP_TASK_GRO")
                    .IsUnique();

                entity.Property(e => e.TASK_GROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_USER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USER_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.GROUP_NAME)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_CONFIG_ID).HasColumnType("NUMBER");

                entity.Property(e => e.TASK_ID).HasColumnType("NUMBER");

                entity.Property(e => e.TASK_NAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_REMARK)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.VALID)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.GROUP_)
                    .WithMany(p => p.TASK_GROUP)
                    .HasForeignKey(d => d.GROUP_ID)
                    .HasConstraintName("FK_TASK_GROUP");
            });

            modelBuilder.Entity<TASK_GROUP_DEFINE>(entity =>
            {
                entity.HasKey(e => e.GROUP_ID);

                entity.HasIndex(e => new { e.GROUP_NAME, e.COMPANY_ID })
                    .HasName("AK_TASK_GROUP_DEFINE")
                    .IsUnique();

                entity.Property(e => e.GROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"SYSDATE
");

                entity.Property(e => e.GROUP_NAME)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GROUP_REMARK)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<TASK_MONITOR>(entity =>
            {
                entity.HasKey(e => e.TASK_MONITOR_ID);

                entity.Property(e => e.TASK_MONITOR_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_CODE)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.COMPANY_ID).HasColumnType("NUMBER");

                entity.Property(e => e.COMPANY_NAME)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.LAST_RUN_TIME).HasColumnType("DATE");

                entity.Property(e => e.MONITOR_NOTES)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN_TIME).HasColumnType("DATE");

                entity.Property(e => e.STATUS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TASK_GROUPS)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_LIST_ID).HasColumnType("NUMBER");

                entity.Property(e => e.TASK_NAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TASK_REMARK)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TIMEOUT)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<TASK_PARAMETER>(entity =>
            {
                entity.HasKey(e => e.TASK_PARAMETER_ID);

                entity.Property(e => e.TASK_PARAMETER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME).HasColumnType("DATE");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PARAMETER_CODE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PARAMETER_DATASOURCE)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PARAMETER_DATATYPE)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PARAMETER_MAX)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("1000 ");

                entity.Property(e => e.PARAMETER_MIN)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PARAMETER_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PARAMETER_REMARK).HasMaxLength(500);

                entity.Property(e => e.TASK_DEFINE_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.TASK_DEFINE_)
                    .WithMany(p => p.TASK_PARAMETER)
                    .HasForeignKey(d => d.TASK_DEFINE_ID)
                    .HasConstraintName("FK_TASK_PARAMETER");
            });

            modelBuilder.Entity<TOAD_PLAN_TABLE>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ACCESS_PREDICATES).IsUnicode(false);

                entity.Property(e => e.BYTES).HasColumnType("NUMBER(38)");

                entity.Property(e => e.CARDINALITY).HasColumnType("NUMBER(38)");

                entity.Property(e => e.COST).HasColumnType("NUMBER(38)");

                entity.Property(e => e.CPU_COST).HasColumnType("NUMBER(38)");

                entity.Property(e => e.DEPTH).HasColumnType("NUMBER(38)");

                entity.Property(e => e.DISTRIBUTION)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FILTER_PREDICATES).IsUnicode(false);

                entity.Property(e => e.ID).HasColumnType("NUMBER(38)");

                entity.Property(e => e.IO_COST).HasColumnType("NUMBER(38)");

                entity.Property(e => e.OBJECT_ALIAS)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.OBJECT_INSTANCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.OBJECT_NAME)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OBJECT_NODE)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OBJECT_OWNER)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OBJECT_TYPE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OPERATION)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OPTIMIZER)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OPTIONS)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OTHER).HasColumnType("LONG");

                entity.Property(e => e.OTHER_TAG)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OTHER_XML).HasColumnType("CLOB");

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PARTITION_ID).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PARTITION_START)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PARTITION_STOP)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN_ID).HasColumnType("NUMBER");

                entity.Property(e => e.POSITION).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PROJECTION).IsUnicode(false);

                entity.Property(e => e.QBLOCK_NAME)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.REMARKS).IsUnicode(false);

                entity.Property(e => e.SEARCH_COLUMNS).HasColumnType("NUMBER");

                entity.Property(e => e.STATEMENT_ID)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TEMP_SPACE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TIME).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TIMESTAMP).HasColumnType("DATE");
            });

            modelBuilder.Entity<USER_PERMISSION_PAGE>(entity =>
            {
                entity.HasKey(e => e.USER_PERMISSION_PAGE_ID)
                    .HasName("PK_USERPERMISSIONPAGE");

                entity.Property(e => e.USER_PERMISSION_PAGE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTONS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.BUTTON_CODE).HasMaxLength(50);

                entity.Property(e => e.BUTTON_EVENT).HasMaxLength(50);

                entity.Property(e => e.BUTTON_ICON).HasMaxLength(254);

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BUTTON_IMG).HasMaxLength(254);

                entity.Property(e => e.BUTTON_METHOD).HasMaxLength(50);

                entity.Property(e => e.BUTTON_NAME).HasMaxLength(50);

                entity.Property(e => e.BUTTON_TITLE).HasMaxLength(50);

                entity.Property(e => e.BUTTON_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DIRECTORY).HasMaxLength(300);

                entity.Property(e => e.FILENAME).HasMaxLength(300);

                entity.Property(e => e.MENU_CLASS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.MENU_CODE).HasMaxLength(50);

                entity.Property(e => e.MENU_ICON).HasMaxLength(50);

                entity.Property(e => e.MENU_ID).HasColumnType("NUMBER");

                entity.Property(e => e.MENU_IMG).HasMaxLength(50);

                entity.Property(e => e.MENU_LAYER)
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MENU_NAME).HasMaxLength(50);

                entity.Property(e => e.MENU_TITLE).HasMaxLength(50);

                entity.Property(e => e.MENU_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.MODULE_CODE)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.MODULE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.NAVIGATE_URL).HasMaxLength(300);

                entity.Property(e => e.ORGANIZATION_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.PERMISSION_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.PLATFORM).HasColumnType("NUMBER(38)");

                entity.Property(e => e.QUERY_STRING).HasMaxLength(300);

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(100);

                entity.Property(e => e.TARGET).HasMaxLength(50);

                entity.Property(e => e.USERGROUP_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERGROUP_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERROLE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERROLE_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_RIGHT_ID).HasColumnType("NUMBER");

                entity.HasOne(d => d.USER_)
                    .WithMany(p => p.USER_PERMISSION_PAGE)
                    .HasForeignKey(d => d.USER_ID)
                    .HasConstraintName("FK_USERPP_USERINFO");
            });

            modelBuilder.Entity<USER_PERMISSION_PAGEBUTTON>(entity =>
            {
                entity.HasKey(e => e.USER_PERMISSION_PAGEBUTTON_ID)
                    .HasName("PK_USERPERMISSIONPAGEBUTTON");

                entity.Property(e => e.USER_PERMISSION_PAGEBUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_ID).HasColumnType("NUMBER");

                entity.Property(e => e.APPLICATION_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_CODE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_EVENT)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_ICON)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BUTTON_IMG)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_METHOD)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_NAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_TITLE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BUTTON_TYPE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ORGANIZATION_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.SEQUENCE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.SEQUENCE_STRING).HasMaxLength(100);

                entity.Property(e => e.USERGROUP_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USERROLE_RIGHT_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_PERMISSION_PAGE_ID).HasColumnType("NUMBER");

                entity.Property(e => e.USER_RIGHT_ID).HasColumnType("NUMBER");
            });

            modelBuilder.Entity<VESSEL_INFO>(entity =>
            {
                entity.HasKey(e => e.VESSEL_INFO_ID)
                    .HasName("PK_VESSELINFO");

                entity.Property(e => e.VESSEL_INFO_ID).HasColumnType("NUMBER");

                entity.Property(e => e.BUNTING)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CALLSIGN).HasMaxLength(15);

                entity.Property(e => e.CREATE_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.CREATE_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATE_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.CREATE_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DELETE_MARK)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.GATE_CODE)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ICEBOX_SOCKET)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMO_CODE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MAIN_POWER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MMSI)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MODIFY_COMPANYID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_DATETIME)
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.MODIFY_FULLNAME)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MODIFY_USERID).HasColumnType("NUMBER");

                entity.Property(e => e.MODIFY_USERNAME)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MTCM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_CODE).HasMaxLength(30);

                entity.Property(e => e.OWNER_ID).HasColumnType("NUMBER");

                entity.Property(e => e.OWNER_NAME).HasMaxLength(200);

                entity.Property(e => e.OWNER_SHORTNAME).HasMaxLength(15);

                entity.Property(e => e.PUT_DATE).HasColumnType("DATE");

                entity.Property(e => e.SECOND_POWER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIZE_DEEP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIZE_DEEP_FULL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIZE_KEEL_HEIGHT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIZE_LENGTH)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIZE_WIDTH)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPEED)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TEN_ALL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TEN_CARGO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TEN_EMPTY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TEUS).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TEU_INCABIN).HasColumnType("NUMBER(38)");

                entity.Property(e => e.TEU_ONDESK).HasColumnType("NUMBER(38)");

                entity.Property(e => e.VALID)
                    .IsRequired()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.VESSEL_BUSI_TYPE_CODE)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_BUSI_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_CLASS_CODE)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_CLASS_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_CODE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_COMMAND_FULLNAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_COMMAND_PHONE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_NAME_CN)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_NAME_EN)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_NATION_CODE)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_NATION_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_NATION_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_REG_PORT_CODE)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_REG_PORT_NAME_CN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_REG_PORT_NAME_EN)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_TYPE_CODE)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VESSEL_TYPE_NAME)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence("AIRLINE_SEQ");

            modelBuilder.HasSequence("AIRPORT_SEQ");

            modelBuilder.HasSequence("APPEND_PROPERTY_FUNCTION_SEQ");

            modelBuilder.HasSequence("APPEND_PROPERTY_INSTANCE_SEQ");

            modelBuilder.HasSequence("APPLICATION_ROLE_RIGHT_SEQ");

            modelBuilder.HasSequence("APPLICATION_ROLE_SEQ");

            modelBuilder.HasSequence("APPLICATIONS_SEQ");

            modelBuilder.HasSequence("BASE_CITY_SEQ");

            modelBuilder.HasSequence("BASE_CITYS_SEQ");

            modelBuilder.HasSequence("BASE_CONTAINER_LOCATION_SEQ");

            modelBuilder.HasSequence("BASE_COUNTRY_SEQ");

            modelBuilder.HasSequence("BASE_CURRENCY_SEQ");

            modelBuilder.HasSequence("BASE_DISTRICT_SEQ");

            modelBuilder.HasSequence("BASE_FEETYPE_SEQ");

            modelBuilder.HasSequence("BASE_HSCATEGORY_SEQ");

            modelBuilder.HasSequence("BASE_HSCODE_SEQ");

            modelBuilder.HasSequence("BASE_LOCATION_SEQ");

            modelBuilder.HasSequence("BASE_PROVINCE_SEQ");

            modelBuilder.HasSequence("BASE_PROVINCES_SEQ");

            modelBuilder.HasSequence("BASE_RAILWAY_PRICE_LEV_DET_SEQ");

            modelBuilder.HasSequence("BASE_RAILWAY_PRICE_LEVEL_SEQ");

            modelBuilder.HasSequence("BASE_TERMINAL_SEQ");

            modelBuilder.HasSequence("BASE_TRAIL_PRICE_LEV_DET_SEQ");

            modelBuilder.HasSequence("BASE_TRAILER_PRICE_LEVEL_SEQ");

            modelBuilder.HasSequence("BUSINESS_FILTER_CONDITION_SEQ");

            modelBuilder.HasSequence("BUSINESS_FILTER_SEQ");

            modelBuilder.HasSequence("BUTTON_SEQ");

            modelBuilder.HasSequence("COMPANY_RIGHT_SEQ");

            modelBuilder.HasSequence("COMPANY_ROLE_SEQ");

            modelBuilder.HasSequence("COMPANY_SEQ");

            modelBuilder.HasSequence("CONTAINER_SIZETYPE_SEQ");

            modelBuilder.HasSequence("CROSS_DOMAIN_SEQ");

            modelBuilder.HasSequence("CROSS_ENTERPRISE_SEQ");

            modelBuilder.HasSequence("FBAREPOSITORIE_SEQ");

            modelBuilder.HasSequence("GROUP_SEQ");

            modelBuilder.HasSequence("LANGUAGESEQ");

            modelBuilder.HasSequence("LOGGER_SEQ");

            modelBuilder.HasSequence("LOGINLOG_SEQ");

            modelBuilder.HasSequence("MENU_SEQ");

            modelBuilder.HasSequence("MESSAGE_SEQ");

            modelBuilder.HasSequence("MODULE_BUTTON_SEQ");

            modelBuilder.HasSequence("MODULE_SEQ");

            modelBuilder.HasSequence("MULTI_LANGUAGE_SEQ");

            modelBuilder.HasSequence("NAVIGATION_SEQ");

            modelBuilder.HasSequence("ONLINE_SEQ");

            modelBuilder.HasSequence("ORGANIZATION_RIGHT_SEQ");

            modelBuilder.HasSequence("ORGANIZATION_SEQ");

            modelBuilder.HasSequence("PERSON_SEQ");

            modelBuilder.HasSequence("PROPERTY_SEQ");

            modelBuilder.HasSequence("RECYCLEBIN_SEQ");

            modelBuilder.HasSequence("SHIP_ROUTE_AREA_CITY_SEQ");

            modelBuilder.HasSequence("SHIP_ROUTE_AREA_PORT_SEQ");

            modelBuilder.HasSequence("SHIP_ROUTE_AREA_SEQ");

            modelBuilder.HasSequence("SHIPINFO_SEQ");

            modelBuilder.HasSequence("STAFF_ORGANIZE_SEQ");

            modelBuilder.HasSequence("TASK_CONFIG_SEQ");

            modelBuilder.HasSequence("TASK_DEFINE_SEQ");

            modelBuilder.HasSequence("TASK_GROUP_SEQ");

            modelBuilder.HasSequence("TASK_MONITOR_SEQ");

            modelBuilder.HasSequence("TASK_PARAMETER_SEQ");

            modelBuilder.HasSequence("USER_PERMISSION_PAGE_SEQ");

            modelBuilder.HasSequence("USER_PERMISSION_PAGEBUTTON_SEQ");

            modelBuilder.HasSequence("USER_RIGHT_SEQ");

            modelBuilder.HasSequence("USER_SEQ");

            modelBuilder.HasSequence("USER_USERROLES_SEQ");

            modelBuilder.HasSequence("USERGROUP_RIGHT_SEQ");

            modelBuilder.HasSequence("USERGROUP_SEQ");

            modelBuilder.HasSequence("USERINFO_USERGROUP_SEQ");

            modelBuilder.HasSequence("USERROLE_RIGHT_SEQ");

            modelBuilder.HasSequence("USERROLE_SEQ");

            modelBuilder.HasSequence("VESSEL_INFO_SEQ");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
