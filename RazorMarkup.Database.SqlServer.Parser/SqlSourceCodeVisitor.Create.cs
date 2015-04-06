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
            ICreateAggregateAnd and = Sql.Create().Aggregate(node.Name.ToAggregateName())
                .WithParameter(new ParameterName(node.Parameters[0].VariableName.Value), node.Parameters[0].DataType.ToTypeName());
            foreach (ProcedureParameter parameter in node.Parameters.Skip(1))
            {
                and = and.And(new ParameterName(parameter.VariableName.Value), parameter.DataType.ToTypeName());
            }

            ICreateAggregateExternalName name = and.Returns(node.ReturnType.ToTypeName());
            AssemblyName assemblyName = new AssemblyName(node.AssemblyName.Name.Value);
            Result = node.AssemblyName.ClassName == null ?
                name.ExternalName(assemblyName) :
                name.ExternalName(assemblyName, new ClassName(node.AssemblyName.ClassName.Value));
        }
    }
}
