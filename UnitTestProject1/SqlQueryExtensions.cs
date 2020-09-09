using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public static class SqlQueryExtensions
    {
        public static T ExecuteScalar<T>(this DbContext context, string rawSql, params object[] parameters)
        {
            using (var conn = context.Database.GetDbConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = rawSql;
                    if (parameters != null)
                        foreach (var p in parameters)
                            command.Parameters.Add(p);
                    conn.Open();
                    return (T)command.ExecuteScalar();
                }
            }
        }

        public static async Task<T> ExecuteScalarAsync<T>(this DbContext context, string rawSql, params object[] parameters)
        {
            using (var conn = context.Database.GetDbConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = rawSql;
                    if (parameters != null)
                        foreach (var p in parameters)
                            command.Parameters.Add(p);
                    await conn.OpenAsync();
                    return (T)await command.ExecuteScalarAsync();
                }
            }
        }
    }

}
