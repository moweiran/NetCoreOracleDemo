using Aop;
using MySqlDataContext.Models;
using System;

namespace UnitTestBiz
{
    public class DogManager
    {
        public new_schemaContext db;
        public DogManager(new_schemaContext db)
        {
            this.db = db;
        }
        public DogManager() { }

        [UnitOfWork]
        public virtual void HandleAdd()
        {
            var entity = new Dogs();
            entity.Name = "小黑";
            entity.Age = 3;
            db.Dogs.Add(entity);
            db.SaveChanges();
            var id = entity.Id;

            var cat = new Cats();
            cat.Name = "小米小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小米小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑" +
                "小米小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小米小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小米小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小米小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小米小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑小黑";
            db.Cats.Add(cat);
            db.SaveChanges();
            var catId = cat.Id;

        }
    }
}
