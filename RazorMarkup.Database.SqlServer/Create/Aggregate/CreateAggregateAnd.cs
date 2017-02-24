using SystemType = System.Type;

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
            Statement.Parameters.Add(new CreateAggregateParameterBuilder(parameterName, typeName.ToSqlString()));
            Statement.Append((ICreateAggregateAnd input) => input.And(parameterName, typeName), parameterName, typeName);
            return new CreateAggregateAnd(Statement);
        }

        public ICreateAggregateAnd And(ParameterName parameterName, SystemType parameterType)
        {
            ISqlString parameterTypeSql = parameterType.ToSqlString();
            Statement.Parameters.Add(new CreateAggregateParameterBuilder(parameterName, parameterTypeSql.ToSqlString()));
            Statement.Append(
                (ICreateAggregateAnd input) => input.And(parameterName, parameterType),
                parameterName,
                parameterTypeSql);
            return new CreateAggregateAnd(Statement);
        }
    }
}
