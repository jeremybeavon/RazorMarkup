using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClauseWithPercent<TEndType> : SelectClauseWithTies<TEndType>,
        ISelectClauseWithPercent<TEndType>
    {
        public SelectClauseWithPercent(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseWithTies<TEndType> Percent()
        {
            Statement.IsPercent = true;
            Statement.Append((ISelectClauseWithPercent<TEndType> input) => input.Percent());
            return this;
        }
    }
}
