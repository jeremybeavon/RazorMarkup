using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexWhere : ICreateIndexWith
    {
        ICreateIndexWith Where(Expression<Func<bool>> predicate);
    }
}
