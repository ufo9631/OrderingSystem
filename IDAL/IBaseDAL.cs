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
        bool DeleteEntity(Expression<Func<T, bool>> strWhere);
        /// <summary>
        /// 更新指定字段
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="fileds">更新字段数组</param>
        bool UpdateEntityFields(T entity, List<string> fileds);


        IQueryable<T> GetEntityList(Expression<Func<T, bool>> whereLamobda, out int total);
        IQueryable<T> GetEntityListPage<s>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLamobda, Expression<Func<T, s>> orderbyLamobda, bool isAsc, out int reCount);


    }
}
