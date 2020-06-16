using ClassLibrary1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using(var db = new CARGOContext())
            {
                var query = from o in db.BASE_COMPANY
                            where o.DELETE_MARK != 1
                            select new BaseCompany
                            {
                                CompanyId = o.COMPANY_ID,
                                CompanyNameCN = o.COMPANY_NAME_CN,
                            };
                var list = query.Take(10).ToList();
            }
        }

        [TestMethod]
        public void AddCustomer()
        {
            //using (var db = new CARGOContext())
            //{
            //    var user = new BASE_USERINFO();
            //    user.useri
            //}
        }

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
                const string ConnectionString = @"User Id=CARGO;Password=CARGO;Data Source=192.168.0.43:1521/ORCL;";
                const string SQL = @"SELECT * FROM all_sequences WHERE SEQUENCE_OWNER = 'CARGO'";

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
            using (IDataReader idr = GetReader(sql,ConnectionString))
            {
                while (idr.Read())
                {
                    string seqName = idr["SEQUENCE_NAME"].ToString();
                    descs.Add(seqName);
                }
            }

            return descs;
        }

    }
}
