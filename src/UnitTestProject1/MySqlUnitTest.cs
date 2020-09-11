using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySqlDataContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var entity = new Dogs();
            entity.Name = "小黑";
            entity.Age = 3;
            db.Dogs.Add(entity);
            db.SaveChanges();
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


    }
}
