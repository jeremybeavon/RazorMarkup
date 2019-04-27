namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropFunctionStatement : SqlBuilder, IDropFunctionStatement
    {
        public DropFunctionStatement(FunctionName functionName)
            : base(string.Format("DROP FUNCTION {0}", functionName.ToSqlString()))
        {
            Initialize(() => Sql.Drop().Function(null), functionName);
        }

        public IDropFunctionStatement And(FunctionName functionName)
        {
            Append(", ");
            Append(functionName.ToSqlString());
            Append((IDropFunctionStatement input) => input.And(null), functionName);
            return this;
        }
    }
}
