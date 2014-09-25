using System;

namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropProcedureStatement : SqlBuilder, IDropProcedureStatement
    {
        public DropProcedureStatement(ProcedureName functionName)
            : base(functionName.ToSqlString())
        {
        }

        public DropProcedureStatement(SchemaName schemaName, ProcedureName functionName)
            : base(string.Format("{0}.{1}", schemaName.ToSqlString(), functionName.ToSqlString()))
        {
        }

        private DropProcedureStatement(string name)
            : base(string.Format("DROP PROCEDURE {0}", name))
        {
        }

        public IDropProcedureStatement And(ProcedureName functionName)
        {
            Append(", ");
            Append(functionName.ToSqlString());
            return this;
        }

        public IDropProcedureStatement And(SchemaName schemaName, ProcedureName functionName)
        {
            Append(", ");
            Append(schemaName.ToSqlString());
            Append(".");
            Append(functionName.ToSqlString());
            return this;
        }
    }
}
