using Aop;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySqlDataContext.Models;
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
}
