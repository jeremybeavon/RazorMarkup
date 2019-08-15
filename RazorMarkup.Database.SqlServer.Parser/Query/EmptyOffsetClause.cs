using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.For;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class EmptyOffsetClause<TEndType> : IEndOffsetClause<TEndType>, IQueryOperator<TEndType>
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

        public IQueryOperand<TEndType> Union()
        {
            return ((IQueryOperator<TEndType>)offsetClause).Union();
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            return ((IQueryOperator<TEndType>)offsetClause).UnionAll();
        }

        public IQueryOperand<TEndType> Except()
        {
            return ((IQueryOperator<TEndType>)offsetClause).Except();
        }

        public IQueryOperand<TEndType> Intersect()
        {
            return ((IQueryOperator<TEndType>)offsetClause).Intersect();
        }
    }
}
