using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    public sealed class FunctionBuilder : AbstractStatementBuilder
    {
        public FunctionBuilder(string functionName, params int[] parameterIndexSortOrder)
            : base(null)
        {
            FunctionName = functionName;
            Arguments = new List<AbstractStatementTextBuilder>();
            ParameterIndexSortOrder = parameterIndexSortOrder;
        }

        public string FunctionName { get; private set; }

        public IList<AbstractStatementTextBuilder> Arguments { get; private set; }

        public IList<int> ParameterIndexSortOrder { get; private set; }

        private int FirstArgumentIndex
        {
            get { return ParameterIndexSortOrder.Count == 0 ? 0 : ParameterIndexSortOrder[0]; }
        }

        private IEnumerable<AbstractStatementTextBuilder> OrderedArguments
        {
            get
            {
                return ParameterIndexSortOrder.Count == 0 ?
                    Arguments.Skip(1) :
                    ParameterIndexSortOrder.Skip(1).Select(index => Arguments[index]);
            }
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(FunctionName);
            sqlBuilder.Append("(");
            if (Arguments.Count > 0)
            {
                Arguments[FirstArgumentIndex].ToSqlString(sqlBuilder);
                foreach (AbstractStatementTextBuilder argument in Arguments.Skip(1))
                {
                    sqlBuilder.Append(", ");
                    argument.ToSqlString(sqlBuilder);
                }
            }

            sqlBuilder.Append(")");
        }
    }
}
