﻿using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class UnpivotClauseAlias :
        CommonUnpivotClauseAlias<
            ITableSourceInJoinWithTableSelection,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableSelectionWithJoin,
            IUnpivotClauseAlias>,
        IUnpivotClauseAlias
    {
        public UnpivotClauseAlias(FromClauseBuilder statement)
            : base(
                statement,
                TableSelectionWithJoin.CreateTableSourceInJoin,
                TableSource.Create,
                PivotClause.Create,
                UnpivotClause.Create,
                TableSelectionWithJoin.Create)
        {
        }

        public static IUnpivotClauseAlias Create(FromClauseBuilder statement)
        {
            return new UnpivotClauseAlias(statement);
        }

        public IMergeWhen On(Expression<Func<bool>> searchCondition)
        {
            return new EndFromClause(Statement).On(searchCondition);
        }
    }
}
