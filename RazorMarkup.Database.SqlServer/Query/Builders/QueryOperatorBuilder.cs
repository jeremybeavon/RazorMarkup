﻿namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class QueryOperatorBuilder : ClauseBuilder
    {
        public QueryOperatorBuilder(string @operator)
        {
            Operator = @operator;
        }

        public string Operator { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent().Append(Operator);
            base.ToSqlString(sqlBuilder);
        }
    }
}
