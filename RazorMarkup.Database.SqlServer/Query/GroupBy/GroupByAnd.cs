using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByAnd<TEndType> : EndGroupByClause<TEndType>, IGroupByAnd<TEndType>, IClauseStart<IGroupByAnd<TEndType>>
    {
        public GroupByAnd(GroupByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public GroupByAnd(ExpressionBuilder expressionBuilder, Expression<Func<object>> groupingExpression, TEndType endClosure)
            : base(new GroupByClauseBuilder(expressionBuilder, groupingExpression), endClosure)
        {
        }

        public IGroupByFunction<TEndType> And()
        {
            Statement.Append((IGroupByAnd<TEndType> input) => input.And());
            return new GroupByFunction<TEndType>(Statement, EndClosure);
        }

        public IGroupByAnd<TEndType> And(Expression<Func<object>> groupingExpression)
        {
            Statement.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            Statement.Append((IGroupByAnd<TEndType> input) => input.And(null), groupingExpression);
            return this;
        }

        public IGroupByAnd<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
