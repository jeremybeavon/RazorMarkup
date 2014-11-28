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
            Statement.Append((ICreateAggregateExternalName input) => input.ExternalName(assemblyName), assemblyName);
            Statement.ExternalName = assemblyName.ToSqlString();
            return this;
        }

        public ISqlString ExternalName(AssemblyName assemblyName, ClassName className)
        {
            Statement.Append(
                (ICreateAggregateExternalName input) => input.ExternalName(assemblyName, className),
                assemblyName,
                className);
            Statement.ExternalName = string.Format("{0}::{1}", assemblyName.ToSqlString(), className.ToSqlString());
            return this;
        }
    }
}
