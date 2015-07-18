using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query.OrderBy;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndWhereClause<TEndType> : AbstractQueryStatement<WhereClauseBuilder, TEndType>,
        IEndWhereClause<TEndType>, IClauseStart<IEndWhereClause<TEndType>>
    {
        public EndWhereClause(ExpressionBuilder expressionBuilder, Expression<Func<bool>> searchCondition, TEndType endClosure)
            : base(new WhereClauseBuilder(expressionBuilder, searchCondition), endClosure)
        {
        }

        public IGroupByAnd<TEndType> GroupBy(Expression<Func<object>> groupingExpression)
        {
            Statement.Append((IEndWhereClause<TEndType> input) => input.GroupBy(null), groupingExpression);
            return new GroupByAnd<TEndType>(ExpressionBuilder, groupingExpression, EndClosure).AsNextClause(Statement);
        }

        public IGroupByFunction<TEndType> GroupBy()
        {
            Statement.Append((IEndWhereClause<TEndType> input) => input.GroupBy());
            return new GroupByFunction<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Union()
        {
            Statement.Append((IEndWhereClause<TEndType> input) => input.Union());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Union, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            Statement.Append((IEndWhereClause<TEndType> input) => input.UnionAll());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.UnionAll, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Except()
        {
            Statement.Append((IEndWhereClause<TEndType> input) => input.Except());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Except, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Intersect()
        {
            Statement.Append((IEndWhereClause<TEndType> input) => input.Intersect());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Intersect, EndClosure).AsNextClause(Statement);
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            Statement.Append((IEndWhereClause<TEndType> input) => input.OrderBy(null), expression);
            return new OrderByCollate<TEndType>(ExpressionBuilder, expression, EndClosure).AsNextClause(Statement);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            Statement.Append((IEndWhereClause<TEndType> input) => input.For());
            return new ForBrowseOrXml<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }

        public IEndWhereClause<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
