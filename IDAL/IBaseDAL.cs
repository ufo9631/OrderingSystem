using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseDAL<T> where T : class
    {
        bool AddEntity(T entity);

        bool EditEntity(T entity);
        bool DeleteEntity(T entity);
        IQueryable<T> GetEntityList(Expression<Func<T, bool>> whereLamobda, out int total);
        IQueryable<T> GetEntityListPage<s>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLamobda, Expression<Func<T, s>> orderbyLamobda, bool isAsc, out int reCount);


    }
}
