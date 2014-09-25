﻿using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndOffsetClause<TEndType> : AbstractQueryStatement<OffsetClauseBuilder, TEndType>, IEndOffsetClause<TEndType>
    {
        public EndOffsetClause(OffsetClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return new ForBrowseOrXml<TEndType>(EndClosure).AsNextClause(Statement);
        }
    }
}
