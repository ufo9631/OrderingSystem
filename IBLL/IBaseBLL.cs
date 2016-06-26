using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IBaseBLL<T> where T : class, new()
    {

        IQueryable<T> GetEntityList(System.Linq.Expressions.Expression<Func<T, bool>> whereLamobda);
        IQueryable<T> GetEntityListPage<s>(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> whereLamobda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLamobda, bool isAsc, out int reCount);
        bool AddEntity(T entity);

        bool EditEntity(T entity);
        bool DeleteEntity(T entity);


    }
}
