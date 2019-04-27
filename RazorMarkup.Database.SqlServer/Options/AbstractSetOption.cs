using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Options
{
    internal abstract class AbstractSetOption : SqlBuilder
    {
        protected AbstractSetOption(string optionName, Expression<Func<ISetStatements, object>> expression, params ISqlString[] parameters)
            : base(string.Format("SET {0}", optionName))
        {
            Initialize(() => Sql.Set());
            Append(expression, parameters);
        }
    }
}
