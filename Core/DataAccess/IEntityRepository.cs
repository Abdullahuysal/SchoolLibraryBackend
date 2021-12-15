using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constraint
    //T Type can be an IEntity or an object that implemenst an IEntity

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Expression comes from linq
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
