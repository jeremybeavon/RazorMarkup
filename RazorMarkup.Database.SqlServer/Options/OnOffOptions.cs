using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Options
{
    internal sealed class OnOffOptions : SqlBuilder, IOnOffOptions
    {
        public OnOffOptions(string optionName, Expression<Func<IOnOffOptions>> expression)
            : base(string.Format("SET {0}", optionName))
        {
            Initialize(expression);
        }

        public OnOffOptions(string optionName, Expression<Func<IOnOffOptions>> expression, TableName tableName)
            : base(string.Format("SET {0} {1}", optionName, tableName.ToSqlString()))
        {
            Initialize(expression, tableName);
        }

        public ISqlString Off()
        {
            Append(" OFF");
            Append((IOnOffOptions input) => input.Off());
            return this;
        }

        public ISqlString On()
        {
            Append(" ON");
            Append((IOnOffOptions input) => input.On());
            return this;
        }
    }
}
