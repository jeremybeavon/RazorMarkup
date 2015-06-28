using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Query;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class EmptyForClause<TEndType> : IEndForClause<TEndType>, IQueryOperator<TEndType>
    {
        private readonly IEndOffsetClause<TEndType> forClause;

        public EmptyForClause(IEndOffsetClause<TEndType> forClause)
        {
            this.forClause = forClause;
        }

        public TEndType End()
        {
            return forClause.End();
        }

        public IQueryOperand<TEndType> Union()
        {
            return ((IQueryOperator<TEndType>)forClause).Union();
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            return ((IQueryOperator<TEndType>)forClause).UnionAll();
        }

        public IQueryOperand<TEndType> Except()
        {
            return ((IQueryOperator<TEndType>)forClause).Except();
        }

        public IQueryOperand<TEndType> Intersect()
        {
            return ((IQueryOperator<TEndType>)forClause).Intersect();
        }
    }
}
