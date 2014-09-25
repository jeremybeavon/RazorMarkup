using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    public interface ICaseThen<TInput, TResult> : IHideObjectMethods
    {
        ICaseWhenOrElseOrEnd<TInput, TResult> Then(Expression<Func<TResult>> result);
    }
}
