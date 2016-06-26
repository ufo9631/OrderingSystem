using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BaseBLL<T> : IBLL.IBaseBLL<T> where T : class, new()
    {
        public IDAL.IBaseDAL<T> DalInstance;

        public abstract void Initialize();
        public IQueryable<T> GetEntityList(System.Linq.Expressions.Expression<Func<T, bool>> whereLamobda, out int total)
        {
            var data = DalInstance.GetEntityList(whereLamobda, out total);
            total = data.Count();
            return data;
        }

        public IQueryable<T> GetEntityListPage<s>(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> whereLamobda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLamobda, bool isAsc, out int reCount)
        {
            return DalInstance.GetEntityListPage(pageIndex, pageSize, whereLamobda, orderbyLamobda, isAsc, out reCount);
        }

        public bool AddEntity(T entity)
        {
            return DalInstance.AddEntity(entity);
        }

        public bool EditEntity(T entity)
        {
            return DalInstance.EditEntity(entity);
        }

        public bool DeleteEntity(T entity)
        {
            return DalInstance.DeleteEntity(entity);
        }
    }
}
