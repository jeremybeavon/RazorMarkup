﻿using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal sealed class GroupFunctionQueryBuilder : AbstractStatementBuilder
    {
        public GroupFunctionQueryBuilder(ExpressionBuilder expressionBuilder, string functionName)
            : base(expressionBuilder)
        {
            FunctionName = functionName;
            Groupings = new List<AbstractStatementBuilder>();
        }

        public string FunctionName { get; private set; }

        public IList<AbstractStatementBuilder> Groupings { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(FunctionName).AppendIndent().Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                sqlBuilder.AppendIndent();
                Groupings[0].ToSqlString(sqlBuilder);
                foreach (AbstractStatementBuilder grouping in Groupings.Skip(1))
                {
                    sqlBuilder.Append(",");
                    sqlBuilder.AppendIndent();
                    grouping.ToSqlString(sqlBuilder);
                }
            }

            sqlBuilder.AppendIndent().Append(")");
        }
    }
}
