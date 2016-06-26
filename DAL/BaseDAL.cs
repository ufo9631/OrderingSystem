using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseDAL<T> : IBaseDAL<T> where T : class, new()
    {
        public DbEntities dbContext { get; set; }


        public BaseDAL()
        {
            dbContext = new DbEntities();
            dbContext.Database.Initialize(true);
        }
        public IQueryable<T> GetEntityList(System.Linq.Expressions.Expression<Func<T, bool>> whereLamobda)
        {
            return dbContext.Set<T>().Where(whereLamobda);
        }
        public IQueryable<T> GetEntityListPage<S>(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> whereLamobda, System.Linq.Expressions.Expression<Func<T, S>> orderbyLamobda, bool isAsc, out int reCount)
        {
            var datas = dbContext.Set<T>().Where(whereLamobda);
            int beginIndex = (pageIndex - 1) * pageSize + 1;
            reCount = datas.Count();
            if (isAsc)
            {
                datas = datas.OrderBy<T, S>(orderbyLamobda);
            }
            else
            {
                datas = datas.OrderByDescending<T, S>(orderbyLamobda);
            }
            return datas.Skip(beginIndex).Take(pageSize);

        }
        public bool AddEntity(T entity)
        {
            dbContext.Entry<T>(entity).State = EntityState.Added;
            return dbContext.SaveChanges() > 0;
        }

        public bool EditEntity(T entity)
        {
            dbContext.Entry<T>(entity).State = EntityState.Modified;
            return dbContext.SaveChanges() > 0;
        }
        public bool DeleteEntity(T entity)
        {
            dbContext.Entry<T>(entity).State = EntityState.Deleted;
            return dbContext.SaveChanges() > 0;
        }
    }
}
