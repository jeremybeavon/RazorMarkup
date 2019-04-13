using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            
        }
    }
}
