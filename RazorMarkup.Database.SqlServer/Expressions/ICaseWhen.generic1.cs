using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    public interface ICaseWhen<TInput> : IHideObjectMethods
    {
        ICaseThen<TInput> When(Expression<Func<TInput>> match);
    }
}
