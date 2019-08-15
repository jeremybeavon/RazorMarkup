using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class MergeStatementBuilder : AbstractStatementBuilder
    {
        public MergeStatementBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
        }

        public WithClauseBuilder WithClause { get; set; }

        public ExpressionBuilder<Integer> Top { get; set; }

        public bool IsPercent { get; set; }

        public bool HasInto { get; set; }

        public string TableName { get; set; }

        public List<string> MergeHints { get; } = new List<string>();

        public bool TableAliasHasAsKeyword { get; set; }

        public string TableAlias { get; set; }

        public FromClauseBuilder UsingClause { get; set; }

        public ExpressionBuilder<bool> SearchCondition { get; set; }

        public List<AbstractWhenClauseBuilder> WhenClauses { get; } = new List<AbstractWhenClauseBuilder>();

        public WhenMatchedClauseBuilder LastMatchedClause => (WhenMatchedClauseBuilder)WhenClauses.Last();

        public WhenNotMatchedClauseBuilder LastNotMatchedClause => (WhenNotMatchedClauseBuilder)WhenClauses.Last();

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            WithClause?.ToSqlString(sqlBuilder);
            sqlBuilder.Append("MERGE ");
            if (Top != null)
            {
                sqlBuilder.Append(" TOP (");
                Top.ToSqlString(sqlBuilder);
                sqlBuilder.Append(") ");
                if (IsPercent)
                {
                    sqlBuilder.Append("PERCENT ");
                }
            }

            if (HasInto)
            {
                sqlBuilder.Append("INTO ");
            }

            sqlBuilder.Append(TableName);
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("USING ");
            UsingClause.ToSqlString(sqlBuilder);
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("ON ");
            SearchCondition.ToSqlString(sqlBuilder);
            foreach (AbstractWhenClauseBuilder whenClause in WhenClauses)
            {
                whenClause.ToSqlString(sqlBuilder);
            }
        }
    }
}
