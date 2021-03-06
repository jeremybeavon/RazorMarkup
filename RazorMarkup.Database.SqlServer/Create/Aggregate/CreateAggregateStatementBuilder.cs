﻿using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    internal sealed class CreateAggregateStatementBuilder : AbstractStatementBuilder
    {
        public CreateAggregateStatementBuilder(AggregateName name)
            : base(new ExpressionBuilder())
        {
            Name = name;
            Parameters = new List<CreateAggregateParameterBuilder>();
        }

        public AggregateName Name { get; private set; }

        public IList<CreateAggregateParameterBuilder> Parameters { get; private set; }

        public string ReturnType { get; set; }

        public string ExternalName { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("CREATE AGGREGATE ");
            sqlBuilder.Append(Name.ToSqlString());
            sqlBuilder.AppendIndent().Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                sqlBuilder.AppendIndent();
                Parameters[0].ToSqlString(sqlBuilder);
                foreach (CreateAggregateParameterBuilder parameter in Parameters.Skip(1))
                {
                    sqlBuilder.Append(",");
                    sqlBuilder.AppendIndent();
                    parameter.ToSqlString(sqlBuilder);
                }
            }

            sqlBuilder.AppendIndent().Append(")");
            sqlBuilder.AppendIndent().Append("RETURNS ").Append(ReturnType);
            sqlBuilder.AppendIndent().Append("EXTERNAL NAME ").Append(ExternalName);
        }
    }
}
