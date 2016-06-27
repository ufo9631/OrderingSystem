using IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

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
        public IQueryable<T> GetEntityList(System.Linq.Expressions.Expression<Func<T, bool>> whereLamobda, out int total)
        {
            if (whereLamobda != null)
            {
                var data = dbContext.Set<T>().Where(whereLamobda);
                total = data.Count();
                return data;
            }
            else
            {
                var data = dbContext.Set<T>().AsQueryable();
                total = data.Count();
                return data;
            }

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

        public bool UpdateEntityFields(T entity, List<string> fileds)
        {
            if (entity != null && fileds != null)
            {
                //4.1将 对象 添加到 EF中
                DbEntityEntry entry = dbContext.Entry<T>(entity);
                //4.2先设置 对象的包装 状态为 Unchanged
                entry.State = EntityState.Unchanged;
                //4.3循环 被修改的属性名 数组
                foreach (string proName in fileds)
                {
                    //4.4将每个 被修改的属性的状态 设置为已修改状态;后面生成update语句时，就只为已修改的属性 更新
                    entry.Property(proName).IsModified = true;
                }
            }
            return dbContext.SaveChanges() > 0;
        }

        public bool DeleteEntity(Expression<Func<T, bool>> strWhere)
        {
            dbContext.Set<T>().Remove(dbContext.Set<T>().Where(strWhere).SingleOrDefault());
            return dbContext.SaveChanges() > 0;
        }
    }
}
