using RazorMarkup.Database.SqlServer.Types;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    internal class CreateAssemblyAnd : CreateAssemblyWithPermissionSet, ICreateAssemblyAnd
    {
        public CreateAssemblyAnd(CreateAssemblyStatementBuilder statement) : base(statement)
        {
        }

        public ICreateAssemblyAnd And(string location)
        {
            Statement.Assemblies.Add(location);
            Statement.Append((ICreateAssemblyAnd input) => input.And(location), new RawStatementBuilder(location));
            return this;
        }

        public ICreateAssemblyAnd And(Expression<Func<SqlVarbinary>> assemblyBits)
        {
            Statement.Assemblies.Add(assemblyBits);
            Statement.Append((ICreateAssemblyAnd input) => input.And(assemblyBits), assemblyBits);
            return this;
        }
    }
}
