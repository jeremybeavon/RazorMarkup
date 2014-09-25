using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.Query.Select;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class QueryOperandVisitor<TEndType> : AbstractSqlVisitor<object>
    {
        private IQueryOperand<TEndType> operand;

        public QueryOperandVisitor(IQueryOperand<TEndType> operand, QueryExpression query)
        {
            this.operand = operand;
            query.Accept(this);
        }

        public override void Visit(QueryParenthesisExpression node)
        {
            IQueryOperand<IQueryOperatorGroupEnd<TEndType>> operatorGroup = operand.BeginOperatorGroup();
            object result = new QueryOperandVisitor<IQueryOperatorGroupEnd<TEndType>>(operatorGroup, node.QueryExpression).Result;
            Result = ((IHasEnd<IQueryOperatorGroupEnd<TEndType>>)result).End().OperatorGroup();
        }

        public override void Visit(QuerySpecification node)
        {
            ISelectClauseWithInto<TEndType> select = operand.Select().BuildAllOrDistinct(node).BuildTop(node).BuildColumns(node);
            Result = select;
        }

        public override void Visit(BinaryQueryExpression node)
        {
            Visit(node.FirstQueryExpression);
            IQueryOperator<TEndType> queryOperator = (IQueryOperator<TEndType>)Result;
            switch (node.BinaryQueryExpressionType)
            {
                case BinaryQueryExpressionType.Union:
                    operand = node.All ? queryOperator.UnionAll() : queryOperator.Union();
                    break;
                case BinaryQueryExpressionType.Except:
                    operand = queryOperator.Except();
                    break;
                case BinaryQueryExpressionType.Intersect:
                    operand = queryOperator.Intersect();
                    break;
            }

            Visit(node.SecondQueryExpression);
        }
    }
}
