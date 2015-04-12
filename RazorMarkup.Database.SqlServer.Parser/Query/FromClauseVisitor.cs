using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Samples;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class FromClauseVisitor<TEndType> : AbstractSqlVisitor<IEndFromClause<TEndType>>
    {
        private readonly IFromClause<TEndType> fromClause;

        public FromClauseVisitor(IFromClause<TEndType> fromClause)
        {
            this.fromClause = fromClause;
        }

        public override void ExplicitVisit(FromClause node)
        {
            base.ExplicitVisit(node);
        }

        
    }
}
