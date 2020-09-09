using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oracle.ManagedDataAccess.Client;
using OracleDataContext.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UC2OracleDataContext;
using UC2OracleDataContext.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using var db = new CARGOContext(new DbContextOptions<CARGOContext>());
            var query = from o in db.BASE_COMPANY
                        where o.DELETE_MARK != 1
                        select new BaseCompany
                        {
                            CompanyId = o.COMPANY_ID,
                            CompanyNameCN = o.COMPANY_NAME_CN,
                        };
            var list = query.Take(10).ToList();
        }

        [TestMethod]
        public void AddCustomer()
        {
            using var db = new CARGOContext(new DbContextOptions<CARGOContext>());
            //var user = new BASE_USERINFO();
            //db.Database.ex
            //user.USER_ID =
        }

        //public static decimal GetNextVal(this DbContext ctx, string seqName)
        //{
        //    return ctx.Query<decimal>(string.Format("SELECT {0}.NEXTVAL FROM DUAL", seqName)).First();
        //}

        [TestMethod]
        public void TestOracleManagedDataAccessCore()
        {
            try
            {
                string lsCnn = "User Id=CARGO;Password=CARGO;Data Source=192.168.0.43:1521/ORCL;";
                using (OracleConnection loCnn = new OracleConnection(lsCnn))
                {
                    loCnn.Open();
                    using (OracleCommand loCmd = loCnn.CreateCommand())
                    {
                        loCmd.CommandText = "SELECT Company_Id FROM Base_Company";
                        OracleDataReader loReader = loCmd.ExecuteReader();
                        while (loReader.Read())
                        {
                            var companyId = loReader.GetDecimal(0);
                            System.Diagnostics.Debug.Write($"{companyId}");
                        }
                    }
                    loCnn.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        [TestMethod]
        public void TestOracleManagedDataAccessCore2()
        {
            try
            {
                const string ConnectionString = @"Persist Security Info=True;DATA SOURCE=192.168.0.43:1521/ORCL;USER ID=CARGO;PASSWORD=CARGO;";
                const string SQL = @"SELECT * FROM all_sequences WHERE SEQUENCE_OWNER = 'CARGO'";
                var sqs = LoadSequences(SQL, ConnectionString);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public IDataReader GetReader(string sql, string ConnectionString)
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand(sql, conn);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

            }

            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public List<string> LoadSequences(string sql, string ConnectionString)
        {
            var descs = new List<string>();
            using (IDataReader idr = GetReader(sql, ConnectionString))
            {
                while (idr.Read())
                {
                    string seqName = idr["SEQUENCE_NAME"].ToString();
                    descs.Add(seqName);
                }
            }

            return descs;
        }

        [TestMethod]
        public void TestConnectionManager()
        {
            IDbConnection conn = ConnectionManager.GetConnection();
            ConnectionManager.CloseConnection(conn);
        }

        [TestMethod]
        public void TestExecuteAction()
        {
            var seqName = "BASE_ALLIANCE_SEQ";
            var query = string.Format("SELECT {0}.NEXTVAL FROM DUAL", seqName);
            IDbConnection connection = ConnectionManager.GetConnection();
            var result = connection.QueryFirst<decimal>(query);
            ConnectionManager.CloseConnection(connection);

        }

        [TestMethod]
        public void TestExecuteSqlQuery()
        {
            using var db = new CARGOContext(new DbContextOptions<CARGOContext>());
            var seqName = "BASE_ALLIANCE_SEQ";
            var query = $"SELECT {seqName}.NEXTVAL AS ID FROM DUAL;";
            var result = db.EntityIdentified.FromSqlRaw(query).ToList();
        }

        [TestMethod]
        public void Test1()
        {
            using var db = new CARGOContext(new DbContextOptions<CARGOContext>());
            var seqName = "BASE_ALLIANCE_SEQ";
            var query = string.Format("SELECT {0}.NEXTVAL FROM DUAL", seqName);
            var result = db.ExecuteScalar<decimal>(query);
        }

        [TestMethod]
        public void Add()
        {
            var options = new DbContextOptions<UC2Context>();
            using var db = new UC2Context(options);
            var query = $"SELECT {Sequences.BASE_LOCATION_SEQ.ToString()}.NEXTVAL AS ID FROM DUAL;";
            var id = db.EntityIdentified.FromSqlRaw(query).ToList();
            var entity = db.BASE_LOCATION.Where(q => q.BASE_LOCATION_ID == 111).SingleOrDefault();
            //var id = db.GetNextVal(Sequences.NAVIGATION_SEQ); 
            //var entity = new BASE_NAVIGATION();
            //entity.NAVIGATION_ID = db.GetNextVal(Sequences.NAVIGATION_SEQ);
            //var id = db.ENTITY_IDENTIFY.GetNextVal(Sequences.NAVIGATION_SEQ);
            //entity.USER_ID = 0;
            //entity.NAVIGATION_NAME = "test";
            //entity.NAVIGATE_URL = "urltest";
            //db.BASE_NAVIGATION.Add(entity);
            //db.SaveChanges();
        }

        [TestMethod]
        public void TestPagination()
        {
            //UseOracleSQLCompatibility("11");
            using var db = new UC2Context(new DbContextOptions<UC2Context>());

            var query = from o in db.BASE_LOCATION
                        orderby o.BASE_LOCATION_ID descending
                        select o;
            var skipQuery = query.Skip(0).Take(10);
            var resultQuery = skipQuery.ToList();
        }
    }
}
