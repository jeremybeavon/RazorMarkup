using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    public interface ICaseWhen<TInput, TResult> : IHideObjectMethods
    {
        ICaseThen<TInput, TResult> When(Expression<Func<TResult>> match);
    }
}
