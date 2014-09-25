﻿using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class QueryOperatorGroupEnd<TEndType> : AbstractQueryStatement<QueryOperatorGroupBuilder, TEndType>,
        IQueryOperatorGroupEnd<TEndType>
    {
        public QueryOperatorGroupEnd(TEndType endClosure, Expression initialExpression)
            : base(new QueryOperatorGroupBuilder(initialExpression), endClosure)
        {
        }

        public IEndQueryOperatorGroup<TEndType> OperatorGroup()
        {
            return new EndQueryOperatorGroup<TEndType>(Statement, EndClosure);
        }

        public QueryOperand<IQueryOperatorGroupEnd<TEndType>> AsOperand()
        {
            return new QueryOperand<IQueryOperatorGroupEnd<TEndType>>(Statement.Operand, this);
        }
    }
}
