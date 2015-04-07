using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Drop.Signature
{
    internal sealed class DropSignatureStatement : AbstractStatement<DropSignatureStatementBuilder>, IDropSignatureStatement
    {
        public DropSignatureStatement(ProcedureName procedureName)
            : this(procedureName.ToSqlString())
        {
            Statement.Initialize(() => Sql.Drop().Signature(procedureName), procedureName);
        }

        public DropSignatureStatement(FunctionName functionName)
            : this(functionName.ToSqlString())
        {
            Statement.Initialize(() => Sql.Drop().Signature(functionName), functionName);
        }

        public DropSignatureStatement(AssemblyName assemblyName)
            : this(assemblyName.ToSqlString())
        {
            Statement.Initialize(() => Sql.Drop().Signature(assemblyName), assemblyName);
        }

        public DropSignatureStatement(TriggerName triggerName)
            : this(triggerName.ToSqlString())
        {
            Statement.Initialize(() => Sql.Drop().Signature(triggerName), triggerName);
        }

        private DropSignatureStatement(string name)
            : base(new DropSignatureStatementBuilder(name))
        {
        }

        public IDropSignatureCryptoType By()
        {
            Statement.Append((IDropSignatureStatement input) => input.By());
            return new DropSignatureCryptoType(Statement);
        }
    }
}
