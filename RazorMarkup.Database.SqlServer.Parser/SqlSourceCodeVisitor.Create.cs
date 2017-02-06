using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Create.Aggregate;
using RazorMarkup.Database.SqlServer.Create.Assembly;
using RazorMarkup.Database.SqlServer.Types;

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

        public override void ExplicitVisit(CreateAssemblyStatement node)
        {
            ICreateAssemblyStatementWithAuthorization authorization = Sql.Create().Assembly(new AssemblyName(node.Name.Value));
            ICreateAssemblyStatement statement = node.Owner == null ? authorization : authorization.Authorization(node.Owner.Value);
            ICreateAssemblyAnd and = statement.From(node.Parameters[0].ToExpression<SqlVarbinary>());
            foreach (ScalarExpression parameter in node.Parameters.Skip(1))
            {
                and = and.And(parameter.ToExpression<SqlVarbinary>());
            }

            if (node.Options == null && node.Options.Count == 0)
            {
                Result = and;
            }
            else if (node.Options.Count > 1 || node.Options[1].OptionKind != AssemblyOptionKind.PermissionSet)
            {
                throw new NotSupportedException();
            }
            else
            {
                switch (((PermissionSetAssemblyOption)node.Options[1]).PermissionSetOption)
                {
                    case PermissionSetOption.Safe:
                        Result = and.WithPermissionSet().Safe();
                        break;
                    case PermissionSetOption.ExternalAccess:
                        Result = and.WithPermissionSet().ExternalAccess();
                        break;
                    case PermissionSetOption.Unsafe:
                        Result = and.WithPermissionSet().Unsafe();
                        break;
                }
            }
        }

        public override void ExplicitVisit(CreateMasterKeyStatement node)
        {
            Result = Sql.Create().MasterKey().EncryptionByPassword(node.Password.Value);
        }
    }
}
