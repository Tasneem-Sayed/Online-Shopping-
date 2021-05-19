using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EShopFashion.Repository
{
    public interface   IRepository<Tbl_Entity> where Tbl_Entity:class
    {
        IEnumerable<Tbl_Entity> GetAllRecords();
        IQueryable<Tbl_Entity> GellAllRecordsIQueryable();
        int GetAllRecoredsCount();
        void add(Tbl_Entity entity);
        void Update(Tbl_Entity entity);
        void UpdateByWhereClause(Expression<Func<Tbl_Entity, bool>> WherePredict, Action<Tbl_Entity> ForEachPredict);
    }
}
