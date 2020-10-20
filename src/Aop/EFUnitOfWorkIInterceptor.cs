using Castle.DynamicProxy;
using Microsoft.EntityFrameworkCore;
using MySqlDataContext.Models;
using System;
using System.Linq;
using System.Reflection;

namespace Aop
{
    public class EFUnitOfWorkIInterceptor : IInterceptor
    {
        private DbContext dBContext;
        public EFUnitOfWorkIInterceptor(new_schemaContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public void Intercept(IInvocation invocation)
        {
            MethodInfo methodInfo = invocation.MethodInvocationTarget;
            if (methodInfo == null)
                methodInfo = invocation.Method;

            UnitOfWorkAttribute transaction = methodInfo.GetCustomAttributes<UnitOfWorkAttribute>(true).FirstOrDefault();
            //如果标记了 [UnitOfWork]，并且不在事务嵌套中。
            if (transaction != null && dBContext.Database.CurrentTransaction == null)
            {
                //开启事务
                dBContext.Database.BeginTransaction();
                try
                {
                    //事务包裹 查询语句 
                    //https://github.com/mysql-net/MySqlConnector/issues/405
                    invocation.Proceed();
                    //提交事务
                    dBContext.Database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    //回滚
                    dBContext.Database.RollbackTransaction();
                    throw;
                }
            }
            else
            {
                //如果没有标记[UnitOfWork]，直接执行方法
                invocation.Proceed();
            }
        }
    }
}
