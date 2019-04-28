using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.SetClause
{
    internal sealed class SetClauseBuilder : AbstractStatementBuilder
    {
        public SetClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
        }

        public List<SetColumnOrVariableBuilder> SetClauses { get; } = new List<SetColumnOrVariableBuilder>();

        public SetColumnOrVariableBuilder CurrentSetClause => SetClauses.Last();

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            SetClauses[0].ToSqlString(sqlBuilder);
            using (sqlBuilder.IncrementIndent())
            {
                foreach (SetColumnOrVariableBuilder setClause in SetClauses.Skip(1))
                {
                    sqlBuilder.Append(",");
                    sqlBuilder.AppendIndent();
                    setClause.ToSqlString(sqlBuilder);
                }
            }
        }
    }
}
