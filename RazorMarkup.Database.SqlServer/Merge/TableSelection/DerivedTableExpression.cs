using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class DerivedTableExpression : ISqlString
    {
        private readonly Expression<Func<object>>[][] values;

        public DerivedTableExpression(Expression<Func<object>>[][] values)
        {
            this.values = values;
        }

        public Expression ToExpression()
        {
            IList<Expression> rowExpressions = new List<Expression>();
            foreach (Expression<Func<object>>[] row in values)
            {
                IEnumerable<Expression> columnExpressions = row.Select(column => column.ToExpressionBuilder().ToExpression());
                rowExpressions.Add(Expression.NewArrayInit(typeof(Expression<Func<object>>[]), columnExpressions));
            }

            return Expression.NewArrayInit(typeof(Expression<Func<object>>[][]), rowExpressions);
        }

        public string ToSqlString()
        {
            throw new NotSupportedException();
        }
    }
}
