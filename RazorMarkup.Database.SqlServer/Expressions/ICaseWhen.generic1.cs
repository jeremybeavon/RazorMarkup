using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    public interface ICaseWhen<TInput> : IHideObjectMethods
    {
        ICaseThen<TInput> When(Expression<Func<TInput>> match);
    }
}
