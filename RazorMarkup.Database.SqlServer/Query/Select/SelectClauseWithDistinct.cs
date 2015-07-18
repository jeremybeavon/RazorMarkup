using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClauseWithDistinct<TEndType> : SelectClauseWithTop<TEndType>,
        ISelectClauseWithDistinct<TEndType>, IClauseStart<ISelectClauseWithDistinct<TEndType>>
    {
        public SelectClauseWithDistinct(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public SelectClauseWithDistinct(ExpressionBuilder expressionBuilder, TEndType endClosure)
            : base(new SelectClauseBuilder(expressionBuilder), endClosure)
        { 
        }

        public ISelectClauseWithTop<TEndType> All()
        {
            Statement.IsDistinct = false;
            Statement.Append((ISelectClauseWithDistinct<TEndType> input) => input.All());
            return this;
        }

        public ISelectClauseWithTop<TEndType> Distinct()
        {
            Statement.IsDistinct = true;
            Statement.Append((ISelectClauseWithDistinct<TEndType> input) => input.Distinct());
            return this;
        }

        public ISelectClauseWithDistinct<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
