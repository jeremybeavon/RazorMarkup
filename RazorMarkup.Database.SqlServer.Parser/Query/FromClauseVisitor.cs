using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query;

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
            ICommonTableSelectionWithJoin tableSelection = null;
            foreach (TableReference tableReference in node.TableReferences)
            {
                ICommonTableSource tableSource = 
                    tableSelection == null ?
                    new CommonTableSource<TEndType>() { Source = fromClause } :
                    tableSelection.And();
                tableSelection = tableReference.AcceptWithResult(new TableReferenceVisitor(tableSource));
            }

            Result = ((ISource)tableSelection).GetSource<IEndFromClause<TEndType>>();
        }
    }
}
