using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByAnd<TEndType> : EndGroupByClause<TEndType>, IGroupByAnd<TEndType>, IClauseStart<IGroupByAnd<TEndType>>
    {
        public GroupByAnd(GroupByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public GroupByAnd(Expression<Func<object>> groupingExpression, TEndType endClosure)
            : base(new GroupByClauseBuilder(groupingExpression), endClosure)
        {
        }

        public IGroupByFunction<TEndType> And()
        {
            return new GroupByFunction<TEndType>(Statement, EndClosure);
        }

        public IGroupByAnd<TEndType> And(Expression<Func<object>> groupingExpression)
        {
            Statement.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            return this;
        }

        public IGroupByAnd<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
