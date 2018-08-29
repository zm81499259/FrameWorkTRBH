using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Extensions;
using Model.DataModel;

namespace DAL
{
    public partial class BaseDAL<T> where T : class, new()
    {
        public DataBaseContext context { get; set; }
        private T Entity { get; set; }
        public BaseDAL()
        {
            this.context=new DataBaseContext();
            //this.context.Configuration.LazyLoadingEnabled = false;
            this.Entity = default(T);
        }
        public void Add(T t)
        {
            context.Set<T>().Add(t);
        }
        public void Delete(T t)
        {
            context.Set<T>().Remove(t);
        }

        public void Update(T t)
        {
            context.Set<T>().AddOrUpdate(t);
        }

        public IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda)
        {
            return context.Set<T>().Where(whereLambda);
        }
        public T GetFirstOrDefault(Expression<Func<T, bool>> whereLambda)
        {
            return context.Set<T>().Where(whereLambda).FirstOrDefault();
        }

        public IQueryable<T> GetModelsByPage<type>(int pageSize, int pageIndex, bool isAsc,
            Expression<Func<T, type>> OrderByLambda, Expression<Func<T, bool>> WhereLambda)
        {
            //是否升序
            if (isAsc)
            {
                return context.Set<T>().Where(WhereLambda).OrderBy(OrderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            else
            {
                return context.Set<T>().Where(WhereLambda).OrderByDescending(OrderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }
    }
}
