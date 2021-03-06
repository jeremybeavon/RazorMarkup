﻿using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonSubqueryWithAlias<TTableSelectionWithJoin> :
        AbstractStatement<FromClauseBuilder>,
        ICommonSubqueryWithAlias<TTableSelectionWithJoin>
    {
        private readonly Func<FromClauseBuilder, TTableSelectionWithJoin> tableSelectionWithJoinBuilder;

        protected CommonSubqueryWithAlias(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TTableSelectionWithJoin> tableSelectionWithJoinBuilder)
            : base(statement)
        {
            this.tableSelectionWithJoinBuilder = tableSelectionWithJoinBuilder;
        }

        public TTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            SubqueryBuilder subqueryBuilder = Statement.CurrentSubquery;
            subqueryBuilder.TableAlias = tableAlias.ToSqlString();
            foreach (ColumnAlias alias in columnAlias)
            {
                subqueryBuilder.ColumnAlias.Add(alias.ToSqlString());
            }

            ISqlString columnAliasString = new SqlStringArray(typeof(ColumnAlias), columnAlias);
            Statement.Append(
                (ICommonSubqueryWithAlias<TTableSelectionWithJoin> input) => input.As(null),
                tableAlias,
                columnAliasString);
            return tableSelectionWithJoinBuilder(Statement);
        }
    }
}
