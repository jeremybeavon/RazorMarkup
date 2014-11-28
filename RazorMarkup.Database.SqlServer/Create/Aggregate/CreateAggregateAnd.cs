using System;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    internal class CreateAggregateAnd : CreateAggregateReturns, ICreateAggregateAnd
    {
        public CreateAggregateAnd(CreateAggregateStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAggregateAnd And(ParameterName parameterName, TypeName typeName)
        {
            Statement.Append((ICreateAggregateAnd input) => input.And(parameterName, typeName), parameterName, typeName);
            Statement.Parameters.Add(new CreateAggregateParameterBuilder(parameterName, typeName.ToSqlString()));
            return new CreateAggregateAnd(Statement);
        }

        public ICreateAggregateAnd And(ParameterName parameterName, Type parameterType)
        {
            ISqlString parameterTypeSql = parameterType.ToSqlString();
            Statement.Append(
                (ICreateAggregateAnd input) => input.And(parameterName, parameterType),
                parameterName,
                parameterTypeSql);
            Statement.Parameters.Add(new CreateAggregateParameterBuilder(parameterName, parameterTypeSql.ToSqlString()));
            return new CreateAggregateAnd(Statement);
        }
    }
}
