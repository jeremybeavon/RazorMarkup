using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSourceInJoin<TEndType> : AbstractJoinStatement<TEndType>, ICommonTableSource
    {
        private readonly ITableSourceInJoin<TEndType> tableSource;

        public CommonTableSourceInJoin(
            ITableSourceInJoin<TEndType> tableSource,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(endClosure)
        {
            this.tableSource = tableSource;
        }

        public ICommonTableSelectionWithAlias Table(TableName tableName)
        {
            return new CommonTableSelectionWithAliasInJoin<TEndType>(tableSource.Table(tableName), EndClosure);
        }

        public ICommonTableSelectionWithAlias View(ViewName viewName)
        {
            return new CommonTableSelectionWithAliasInJoin<TEndType>(tableSource.View(viewName), EndClosure);
        }

        public ICommonSubqueryWithAlias Subquery(Microsoft.SqlServer.TransactSql.ScriptDom.QueryExpression query)
        {
            throw new NotImplementedException();
        }

        public ICommonDerivedTableWithAlias DerviedTable(Expression<Func<object>>[][] values)
        {
            throw new NotImplementedException();
        }
    }
}
