using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    public interface ICaseWhenOrElseOrEnd<TInput, TResult> : ICaseWhen<TInput, TResult>, ICaseEnd<TResult>
    {
        ICaseEnd<TResult> Else(Expression<Func<TInput>> @else);
    }
}
