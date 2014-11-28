using System;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    internal class CreateAggregateReturns : AbstractStatement<CreateAggregateStatementBuilder>, ICreateAggregateReturns
    {
        public CreateAggregateReturns(CreateAggregateStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAggregateExternalName Returns(ParameterName parameterName, TypeName typeName)
        {
            Statement.Append((ICreateAggregateReturns input) => input.Returns(parameterName, typeName), parameterName, typeName);
            Statement.Parameters.Add(new CreateAggregateParameterBuilder(parameterName, typeName.ToSqlString()));
            return new CreateAggregateExternalName(Statement);
        }

        public ICreateAggregateExternalName Returns(ParameterName parameterName, Type parameterType)
        {
            ISqlString parameterTypeSql = parameterType.ToSqlString();
            Statement.Append(
                (ICreateAggregateReturns input) => input.Returns(parameterName, parameterType),
                parameterName,
                parameterTypeSql);
            Statement.Parameters.Add(new CreateAggregateParameterBuilder(parameterName, parameterTypeSql.ToSqlString()));
            return new CreateAggregateExternalName(Statement);
        }
    }
}
