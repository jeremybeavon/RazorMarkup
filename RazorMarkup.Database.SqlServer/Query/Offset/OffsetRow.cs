using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.Offset
{
    internal class OffsetRow<TEndType> : AbstractQueryStatement<OffsetClauseBuilder, TEndType>, IOffsetRow<TEndType>,
        IClauseStart<IOffsetRow<TEndType>>
    {
        public OffsetRow(Expression<Func<Integer>> expression, TEndType endClosure)
            : base(new OffsetClauseBuilder(expression), endClosure)
        {
        }

        public IOffsetFetch<TEndType> Row()
        {
            Statement.IsSingleRow = true;
            Statement.Append((IOffsetRow<TEndType> input) => input.Row());
            return new OffsetFetch<TEndType>(Statement, EndClosure);
        }

        public IOffsetFetch<TEndType> Rows()
        {
            Statement.IsSingleRow = false;
            Statement.Append((IOffsetRow<TEndType> input) => input.Rows());
            return new OffsetFetch<TEndType>(Statement, EndClosure);
        }

        public IOffsetRow<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
