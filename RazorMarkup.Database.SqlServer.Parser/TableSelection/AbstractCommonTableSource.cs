using System;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.Query;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonTableSource<
        TTableSource,
        TTableSelectionWithAlias,
        TSubqueryWithAlias,
        TDerivedTableWithAlias,
        TCommonTableSelectionWithAlias,
        TCommonSubqueryWithAlias,
        TCommonDerivedTableWithAlias> : AbstractSource<TTableSource>, ICommonTableSource
        where TTableSource : ICommonTableSource<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias>
        where TCommonTableSelectionWithAlias : ISource<TTableSelectionWithAlias>, ICommonTableSelectionWithAlias, new()
        where TCommonSubqueryWithAlias : ISource<TSubqueryWithAlias>, ICommonSubqueryWithAlias, new()
        where TCommonDerivedTableWithAlias : ISource<TDerivedTableWithAlias>, ICommonDerivedTableWithAlias, new()
    {
        public ICommonTableSelectionWithAlias Table(TableName tableName)
        {
            return new TCommonTableSelectionWithAlias()
            {
                Source = Source.Table(tableName)
            };
        }

        public ICommonTableSelectionWithAlias View(ViewName viewName)
        {
            return new TCommonTableSelectionWithAlias()
            {
                Source = Source.View(viewName)
            };
        }

        public ICommonSubqueryWithAlias Subquery(QueryExpression query)
        {
            return new TCommonSubqueryWithAlias()
            {
                Source = query.AcceptWithResult(
                    new QueryOperandVisitor<IEndSubquery<TSubqueryWithAlias>>(Source.Subquery())).End().Subquery()
            };
        }


        public IQueryOperand<IEndSubquery<ICommonSubqueryWithAlias>> Subquery()
        {
            throw new NotSupportedException();
        }

        public ICommonDerivedTableWithAlias DerivedTable(Expression<Func<object>>[][] values)
        {
            return new TCommonDerivedTableWithAlias()
            {
                Source = Source.DerivedTable(values)
            };
        }
    }
}
