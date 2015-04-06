using System;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    internal class CreateAggregateReturns : AbstractStatement<CreateAggregateStatementBuilder>, ICreateAggregateReturns
    {
        public CreateAggregateReturns(CreateAggregateStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAggregateExternalName Returns(TypeName typeName)
        {
            Statement.ReturnType = typeName.ToSqlString();
            Statement.Append((ICreateAggregateReturns input) => input.Returns(typeName), typeName);
            return new CreateAggregateExternalName(Statement);
        }

        public ICreateAggregateExternalName Returns(Type parameterType)
        {
            ISqlString parameterTypeSql = parameterType.ToSqlString();
            Statement.ReturnType = parameterTypeSql.ToSqlString();
            Statement.Append((ICreateAggregateReturns input) => input.Returns(parameterType), parameterTypeSql);
            return new CreateAggregateExternalName(Statement);
        }
    }
}
