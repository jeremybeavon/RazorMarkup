using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal sealed class CommonPivotClauseAlias<TEndType> :
        AbstractCommonPivotClauseAlias<
            IPivotClauseAlias<TEndType>,
            ITableSourceInJoin<ITableSelectionWithJoin<TEndType>>,
            ITableSource<TEndType>,
            IPivotClause<TEndType>,
            IUnpivotClause<TEndType>,
            ITableSelectionWithJoin<TEndType>,
            CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>, CommonTableSelectionWithJoin<TEndType>>,
            CommonTableSource<TEndType>,
            CommonPivotClause<TEndType>,
            CommonUnpivotClause<TEndType>,
            CommonTableSelectionWithJoin<TEndType>>
    {
    }
}

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSourceInJoin<T1, T2> : ISource<ITableSourceInJoin<T1>>, ICommonTableSource
    {
        public ITableSourceInJoin<T1> Source { get => throw new global::System.NotImplementedException(); set => throw new global::System.NotImplementedException(); }

        public ICommonDerivedTableWithAlias DerivedTable(Expression<Func<object>>[][] values)
        {
            throw new NotImplementedException();
        }

        public T GetSource<T>()
        {
            throw new global::System.NotImplementedException();
        }

        public ICommonSubqueryWithAlias Subquery(QueryExpression query)
        {
            throw new NotImplementedException();
        }

        public IQueryOperand<IEndSubquery<ICommonSubqueryWithAlias>> Subquery()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAlias Table(TableName tableName)
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAlias View(ViewName viewName)
        {
            throw new NotImplementedException();
        }
    }
}