using Aop;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySqlDataContext.Models;
using PomeloMySqlDataContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestBiz;

namespace UnitTestProject1
{
    [TestClass]
    public class MySqlUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            using var db = new new_schemaContext(new DbContextOptions<new_schemaContext>());
            var query = from o in db.Dogs
                        select new
                        {
                            Id = o.Id,
                            Name = o.Name,
                            Age = o.Age
                        };
            var list = query.Take(10).ToList();
        }

        [TestMethod]
        public void Add()
        {

            using var db = new new_schemaContext(new DbContextOptions<new_schemaContext>());
            db.Database.BeginTransaction();

            var entity = new Dogs();
            entity.Name = "小黑";
            entity.Age = 3;
            db.Dogs.Add(entity);
            db.SaveChanges();
            var id = entity.Id;

            var cat = new Cats();
            cat.Name = "小米";
            db.Cats.Add(cat);
            db.SaveChanges();
            var catId = cat.Id;

            db.Database.CommitTransaction();
        }

        [TestMethod]
        public void Edit()
        {
            using var db = new new_schemaContext(new DbContextOptions<new_schemaContext>());
            var query = from o in db.Dogs
                        where o.Id == 1
                        select o;
            var entity = query.SingleOrDefault();
            entity.Age = 11;
            db.SaveChanges();
        }

        [TestMethod]
        public void Delete()
        {
            using var db = new new_schemaContext(new DbContextOptions<new_schemaContext>());
            db.Database.ExecuteSqlRaw("delete from dogs where Id=4");
            db.SaveChanges();
        }

        [TestMethod]
        public void AddUnitOfWork()
        {
            var col = ServiceCollectionHelper.GetServiceCollection();
            var services = col.Item1;
            var container = InitContainerBuilder(services, col.Item2);
            new AutofacServiceProvider(container);
            var dogManger = container.Resolve<DogManager>();
            dogManger.HandleAdd();
        }

        [TestMethod]
        public void PomeloMysqlTest()
        {
            using var db = new NewShipContext(new DbContextOptions<NewShipContext>());
            var query = from ow in db.ow_surcharge
                        join dtl in db.ow_surcharge_detail.Where(q => q.DELETE_MARK == false) on ow.OW_SURCHARGE_ID equals dtl.OW_SURCHARGE_ID into dtls
                        where ow.CARRIER_ID == 9001
                           && ow.OW_SURCHARGE_ID == 21
                        select new OwSurchargeBrief
                        {
                            Id = ow.OW_SURCHARGE_ID,
                            EffectiveDate = ow.EFFECTIVE_DATE,
                            ExpirationDate = ow.EXPIRATION_DATE,
                            OwType = ow.OW_TYPE,
                            PolId = ow.POL_ID,
                            RouteId = ow.ROUTE_ID,
                            Remark = ow.REMARK,
                            Details = dtls.Select(q => new OwSurchargeDetailBrief
                            {
                                Id = q.OW_SURCHARGE_DETAIL_ID,
                                BeginWeight = q.BEGIN_WEIGHT,
                                EndWeight = q.END_WEIGHT,
                                Remark = q.REMARK,
                                Surcharge = q.SURCHARGE_AMOUNT,
                                ContaSizeType = q.CONTA_SIZETYPE,
                            })
                        };

            var result = query.ToList().FirstOrDefault();
        }

        [TestMethod]
        public void PomeloMysqlTest2()
        {
            using var db = new NewShipContext(new DbContextOptions<NewShipContext>());
            var query = from ow in db.ow_surcharge
                        where ow.CARRIER_ID == 9001
                           && ow.OW_SURCHARGE_ID == 21
                        select new OwSurchargeBrief
                        {
                            Id = ow.OW_SURCHARGE_ID,
                            EffectiveDate = ow.EFFECTIVE_DATE,
                            ExpirationDate = ow.EXPIRATION_DATE,
                            OwType = ow.OW_TYPE,
                            PolId = ow.POL_ID,
                            RouteId = ow.ROUTE_ID,
                            Remark = ow.REMARK,
                            Details = db.ow_surcharge_detail.Where(q => q.DELETE_MARK == false && q.OW_SURCHARGE_ID == ow.OW_SURCHARGE_ID).Select(q => new OwSurchargeDetailBrief
                            {
                                Id = q.OW_SURCHARGE_DETAIL_ID,
                                BeginWeight = q.BEGIN_WEIGHT,
                                EndWeight = q.END_WEIGHT,
                                Remark = q.REMARK,
                                Surcharge = q.SURCHARGE_AMOUNT,
                                ContaSizeType = q.CONTA_SIZETYPE,
                            }).ToList()
                        };

            var result = query.ToList().FirstOrDefault();
        }


        [TestMethod]
        public void PomeloMysqlTest3()
        {
            using var db = new NewShipContext(new DbContextOptions<NewShipContext>());
            var query = from ow in db.ow_surcharge
                        where ow.CARRIER_ID == 9001
                            && ow.OW_SURCHARGE_ID == 21
                        select new OwSurchargeBrief
                        {
                            Id = ow.OW_SURCHARGE_ID,
                            EffectiveDate = ow.EFFECTIVE_DATE,
                            ExpirationDate = ow.EXPIRATION_DATE,
                            OwType = ow.OW_TYPE,
                            PolId = ow.POL_ID,
                            RouteId = ow.ROUTE_ID,
                            Remark = ow.REMARK,
                            Details = db.ow_surcharge_detail.Where(q => q.DELETE_MARK == false && q.OW_SURCHARGE_ID == ow.OW_SURCHARGE_ID).Select(q => new OwSurchargeDetailBrief
                            {
                                Id = q.OW_SURCHARGE_DETAIL_ID,
                                BeginWeight = q.BEGIN_WEIGHT,
                                EndWeight = q.END_WEIGHT,
                                Remark = q.REMARK,
                                Surcharge = q.SURCHARGE_AMOUNT,
                                ContaSizeType = q.CONTA_SIZETYPE,
                            }),
                            ApplyToPods = db.ow_surcharge_port.Where(q => q.DELETE_MARK == false && q.OW_SURCHARGE_ID == ow.OW_SURCHARGE_ID).Select(q => new OwSurchargePortBrief
                            {
                                Id = q.OW_SURCHARGE_PORT_ID,
                                Pod = new SimpleLocation
                                {
                                    LocationId = q.POD_ID
                                }
                            }),
                            ApplyToSchedules = db.ow_surcharge_schedule.Where(q => q.DELETE_MARK == false && q.OW_SURCHARGE_ID == ow.OW_SURCHARGE_ID).Select(q => new OwSurchargeScheduleBrief
                            {
                                Id = q.OW_SURCHARGE_SCHEDULEL_ID,
                                Etd = q.ETD,
                                ScheduleId = q.SCHEDULE_ID,
                                VesselVoyage = q.VESSELVOY,
                            })
                        };

            var result = query.ToList().FirstOrDefault();
        }

        /// <summary>
        /// 初始化 注入容器
        /// </summary>
        private IContainer InitContainerBuilder(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            services.AddDirectoryBrowser();

            var builder = new ContainerBuilder();
            builder.RegisterType<EFUnitOfWorkIInterceptor>();
            //builder.RegisterType<UnitOfWorkIInterceptor>();

            // 首先注册 options，供 DbContext 服务初始化使用
            builder.Register(c =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<new_schemaContext>();
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=xxy;password=xxy@678.com;database=new_schema;TreatTinyAsBoolean=true", b => b.MigrationsAssembly("MySqlDataContext"));
                return optionsBuilder.Options;
            }).InstancePerLifetimeScope();

            // 注册 DbContext
            builder.RegisterType<new_schemaContext>()
                .AsSelf()
                .InstancePerLifetimeScope();

            builder.RegisterType<DBContext>().InstancePerLifetimeScope();
            builder.RegisterType<DogManager>().InstancePerLifetimeScope().InterceptedBy(typeof(EFUnitOfWorkIInterceptor)).EnableClassInterceptors();

            builder.Populate(services);
            return builder.Build();
        }
    }
    public class OwSurchargeBrief
    {
        public OwSurchargeBrief()
        {
            this.Details = new List<OwSurchargeDetailBrief>();
            this.ApplyToPods = new List<OwSurchargePortBrief>();
            this.ApplyToSchedules = new List<OwSurchargeScheduleBrief>();
        }

        public decimal Id { get; set; }

        public decimal OwType { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string Remark { get; set; }

        public decimal RouteId { get; set; }

        public decimal PolId { get; set; }

        public IEnumerable<OwSurchargeDetailBrief> Details { get; set; }

        public IEnumerable<OwSurchargePortBrief> ApplyToPods { get; set; }

        public IEnumerable<OwSurchargeScheduleBrief> ApplyToSchedules { get; set; }
    }
    public class OwSurchargeDetailBrief
    {
        public decimal Id { get; set; }

        public string ContaSizeType { get; set; }

        public decimal BeginWeight { get; set; }

        public decimal EndWeight { get; set; }

        public decimal? Surcharge { get; set; }

        public string Remark { get; set; }
    }

    public class OwSurchargePortBrief
    {
        public decimal Id { get; set; }

        public SimpleLocation Pod { get; set; }
    }
    public class OwSurchargeScheduleBrief
    {
        public decimal Id { get; set; }

        public decimal ScheduleId { get; set; }

        public string VesselVoyage { get; set; }

        public DateTime? Etd { get; set; }
    }
    public class SimpleLocation
    {
        public decimal LocationId { get; set; }
        public string LocationNameEN { get; set; }
        public string LocationNameCN { get; set; }
        public string CityNameEN { get; set; }
        public string CityNameCN { get; set; }
        public string ProvinceNameEN { get; set; }
        public string ProvinceNameCN { get; set; }
        public string CountryNameEN { get; set; }
        public string CountryNameCN { get; set; }
    }
}
