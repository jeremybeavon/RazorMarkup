using RazorMarkup.Database.SqlServer.Types;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    internal class CreateAssemblyStatement : AbstractStatement<CreateAssemblyStatementBuilder>, ICreateAssemblyStatement
    {
        public CreateAssemblyStatement(CreateAssemblyStatementBuilder statement) : base(statement)
        {
        }

        public ICreateAssemblyAnd From(string location)
        {
            Statement.Assemblies.Add(location);
            Statement.Append((ICreateAssemblyStatement input) => input.From(location), new RawStatementBuilder(location));
            return new CreateAssemblyAnd(Statement);
        }

        public ICreateAssemblyAnd From(Expression<Func<SqlVarbinary>> assemblyBits)
        {
            Statement.Assemblies.Add(assemblyBits);
            Statement.Append((ICreateAssemblyStatement input) => input.From(assemblyBits), assemblyBits);
            return new CreateAssemblyAnd(Statement);
        }
    }
}
