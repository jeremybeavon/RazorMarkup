using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
