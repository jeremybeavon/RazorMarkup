using System;
using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Drop.Index;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed class DropIndexVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(DropIndexStatement node)
        {
            if (node.DropIndexClauses.OfType<BackwardsCompatibleDropIndexClause>().Any())
            {
                throw new NotSupportedException("DROP INDEX does not support backwards compatible indexes");
            }

            DropIndexClause firstIndex = (DropIndexClause)node.DropIndexClauses[0];
            IDropIndexAnd and = ProcessIndexClause(firstIndex, Sql.Drop().Index(new IndexName(firstIndex.Index.Value)));
            foreach (DropIndexClause index in node.DropIndexClauses.Skip(1).Cast<DropIndexClause>())
            {
                and = ProcessIndexClause(index, and.And(new IndexName(index.Index.Value)));
            }

            Result = and;
        }

        private static IDropIndexAnd ProcessIndexClause(DropIndexClause clause, IDropIndexStatement statement)
        {
            IDropIndexWith with = statement.On(clause.Object.ToTableName());
            DropIndexOptionVisitor visitor = new DropIndexOptionVisitor(with);
            foreach (IndexOption option in clause.Options)
            {
                option.Accept(visitor);
            }

            return (IDropIndexAnd)visitor.Result ?? with;
        }
    }
}
