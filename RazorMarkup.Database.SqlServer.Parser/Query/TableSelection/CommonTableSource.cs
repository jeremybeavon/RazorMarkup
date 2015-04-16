using System;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSource<TEndType> : ICommonTableSource
    {
        private readonly ITableSource<TEndType> tableSource;

        public CommonTableSource(ITableSource<TEndType> tableSource)
        {
            this.tableSource = tableSource;
        }

        public ICommonTableSelectionWithAlias Table(TableName tableName)
        {
            return new CommonTableSelectionWithAlias<TEndType>(tableSource.Table(tableName));
        }

        public ICommonTableSelectionWithAlias View(ViewName viewName)
        {
            return new CommonTableSelectionWithAlias<TEndType>(tableSource.View(viewName));
        }

        public ICommonSubqueryWithAlias Subquery(QueryExpression query)
        {
            return new CommonSubqueryWithAlias<TEndType>(CreateSubquery(query));
        }

        public ICommonDerivedTableWithAlias DerviedTable(Expression<Func<object>>[][] values)
        {
            return new CommonDerviedTableWithAlias<TEndType>(tableSource.DerivedTable(values));
        }

        private ISubqueryWithAlias<TEndType> CreateSubquery(QueryExpression query)
        {
            return query.AcceptWithResult(
                new QueryOperandVisitor<IEndSubquery<ISubqueryWithAlias<TEndType>>>(tableSource.Subquery())).End().Subquery();
        }
    }
}
