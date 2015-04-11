using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class EmptyOffsetClause<TEndType> : IEndOffsetClause<TEndType>
    {
        private readonly IEndOrderByClause<TEndType> offsetClause;

        public EmptyOffsetClause(IEndOrderByClause<TEndType> offsetClause)
        {
            this.offsetClause = offsetClause;
        }

        public TEndType End()
        {
            return offsetClause.End();
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return offsetClause.For();
        }
    }
}
