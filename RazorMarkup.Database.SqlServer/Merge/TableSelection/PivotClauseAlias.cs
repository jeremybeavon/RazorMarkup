﻿using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;
using System.Linq.Expressions;
using System;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class PivotClauseAlias :
        CommonPivotClauseAlias<
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableSelectionWithJoin,
            IPivotClauseAlias>,
        IPivotClauseAlias
    {
        public PivotClauseAlias(FromClauseBuilder statement)
            : base(
                statement,
                TableSelectionWithJoin.CreateTableSourceInJoin,
                TableSource.Create,
                PivotClause.Create,
                UnpivotClause.Create,
                TableSelectionWithJoin.Create)
        {
        }

        public static IPivotClauseAlias Create(FromClauseBuilder statement)
        {
            return new PivotClauseAlias(statement);
        }

        public IMergeWhen On(Expression<Func<bool>> searchCondition)
        {
            return new EndFromClause(Statement).On(searchCondition);
        }
    }
}
