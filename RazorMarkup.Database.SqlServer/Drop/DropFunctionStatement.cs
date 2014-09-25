using System;

namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropFunctionStatement : SqlBuilder, IDropFunctionStatement
    {
        public DropFunctionStatement(FunctionName functionName)
            : base(functionName.ToSqlString())
        {
        }

        public DropFunctionStatement(SchemaName schemaName, FunctionName functionName)
            : base(string.Format("{0}.{1}", schemaName.ToSqlString(), functionName.ToSqlString()))
        {
        }

        private DropFunctionStatement(string name)
            : base(string.Format("DROP FUNCTION {0}", name))
        {
        }

        public IDropFunctionStatement And(FunctionName functionName)
        {
            Append(", ");
            Append(functionName.ToSqlString());
            return this;
        }

        public IDropFunctionStatement And(SchemaName schemaName, FunctionName functionName)
        {
            Append(", ");
            Append(schemaName.ToSqlString());
            Append(".");
            Append(functionName.ToSqlString());
            return this;
        }
    }
}
