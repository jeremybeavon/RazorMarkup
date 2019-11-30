using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.Query;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser
{
    // Do later: BEGIN, BeginCatch, BeginTry, Else, End, EndCatch, EndTry, If, While
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(TSqlBatch node)
        {
            node.AcceptChildren(this);
        }

        public override void ExplicitVisit(TSqlScript node)
        {
            node.AcceptChildren(this);
        }

        public override void ExplicitVisit(BreakStatement node)
        {
            Result = Sql.Break();
        }

        public override void ExplicitVisit(ContinueStatement node)
        {
            Result = Sql.Continue();
        }

        public override void ExplicitVisit(GoToStatement node)
        {
            Result = Sql.Goto(new LabelName(node.LabelName.Value));
        }

        public override void ExplicitVisit(LabelStatement node)
        {
            Result = Sql.Label(new LabelName(node.Value));
        }

        public override void ExplicitVisit(PrintStatement node)
        {
            Result = Sql.Print(node.Expression.ToExpression<Text>());
        }

        public override void ExplicitVisit(ReturnStatement node)
        {
            Result = node.Expression == null ? Sql.Return() : Sql.Return(node.Expression.ToExpression<object>());
        }

        public override void ExplicitVisit(SelectStatement node)
        {
            IQueryStatements query = Sql.Query();
            IQueryOperand<IEndQuery> operand =
                WithClauseBuilder.BuildCommonTableExpressions<IQueryOperand<IEndQuery>, IEndCommonTableExpression>(
                    query,
                    query,
                    node.WithCtesAndXmlNamespaces);
            Result = node.QueryExpression.AcceptWithResult(new QueryOperandVisitor<IEndQuery>(operand, node)).End().Query();
        }
    }
}
