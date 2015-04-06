using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    internal class CreateAggregateExternalName : AbstractStatement<CreateAggregateStatementBuilder>,
        ICreateAggregateExternalName
    {
        public CreateAggregateExternalName(CreateAggregateStatementBuilder statement)
            : base(statement)
        {
        }

        public ISqlString ExternalName(AssemblyName assemblyName)
        {
            Statement.ExternalName = assemblyName.ToSqlString();
            Statement.Append((ICreateAggregateExternalName input) => input.ExternalName(assemblyName), assemblyName);
            return this;
        }

        public ISqlString ExternalName(AssemblyName assemblyName, ClassName className)
        {
            Statement.ExternalName = string.Format("{0}.{1}", assemblyName.ToSqlString(), className.ToSqlString());
            Statement.Append((ICreateAggregateExternalName input) => input.ExternalName(null, null), assemblyName, className);
            return this;
        }
    }
}
