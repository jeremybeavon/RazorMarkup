using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Expressions;

namespace RazorMarkup.Database.SqlServer
{
    public static class Case
    {
        public static ICaseWhen<TInput> Value<TInput>(Expression<Func<TInput>> input)
        {
            throw new NotInExpressionException();
        }

        public static ICaseThen<bool> When(Expression<Func<bool>> test)
        {
            throw new NotInExpressionException();
        }
    }
}
