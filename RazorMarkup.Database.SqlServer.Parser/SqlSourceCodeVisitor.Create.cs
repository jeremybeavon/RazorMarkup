using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Create.Aggregate;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(CreateAggregateStatement node)
        {
            ICreateAggregateAnd and = Sql.Create().Aggregate(new AggregateName(node.Name.BaseIdentifier.Value))
                .WithParameter(new ParameterName(node.Parameters[0].VariableName.Value), new TypeName(null));
            foreach (ProcedureParameter parameter in node.Parameters.Skip(1))
            {
                and = and.And(new ParameterName(parameter.VariableName.Value), new TypeName(null));
            }

            ICreateAggregateExternalName name = and.Returns(
                new ParameterName(node.ReturnType.Name.BaseIdentifier.Value),
                new TypeName(null));
            AssemblyName assemblyName = new AssemblyName(node.AssemblyName.Name.Value);
            Result = node.AssemblyName.ClassName == null ?
                name.ExternalName(assemblyName) :
                name.ExternalName(assemblyName, new ClassName(node.AssemblyName.ClassName.Value));
        }
    }
}
