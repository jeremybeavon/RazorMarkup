using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    public interface ICaseThen<TInput> : IHideObjectMethods
    {
        ICaseWhenOrElseOrEnd<TInput, TResult> Then<TResult>(Expression<Func<TResult>> result);
    }
}
