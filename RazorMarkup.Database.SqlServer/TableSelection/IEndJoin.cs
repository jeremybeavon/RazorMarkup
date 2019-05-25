using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface IEndJoin<TJoinEndType> : IHideObjectMethods
    {
        TJoinEndType On(Expression<Func<bool>> searchCondition);
    }
}
