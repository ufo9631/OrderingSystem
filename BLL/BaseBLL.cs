using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BaseBLL<T> : IBLL.IBaseBLL<T> where T : class, new()
    {
        public IDAL.IBaseDAL<T> DAL;

        public abstract void Initialize();
        public IQueryable<T> GetEntityList(System.Linq.Expressions.Expression<Func<T, bool>> whereLamobda)
        {
            return DAL.GetEntityList(whereLamobda);
        }

        public IQueryable<T> GetEntityListPage<s>(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> whereLamobda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLamobda, bool isAsc, out int reCount)
        {
            return DAL.GetEntityListPage(pageIndex, pageSize, whereLamobda, orderbyLamobda, isAsc, out reCount);
        }

        public bool AddEntity(T entity)
        {
            return DAL.AddEntity(entity);
        }

        public bool EditEntity(T entity)
        {
            return DAL.EditEntity(entity);
        }

        public bool DeleteEntity(T entity)
        {
            return DAL.DeleteEntity(entity);
        }
    }
}
