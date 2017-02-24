using SystemType = System.Type;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    internal sealed class CreateAggregateStatement : AbstractStatement<CreateAggregateStatementBuilder>,
        ICreateAggregateStatement
    {
        public CreateAggregateStatement(AggregateName name)
            : base(new CreateAggregateStatementBuilder(name))
        {
            Statement.Initialize(() => Sql.Create().Aggregate(null), name);
        }

        public ICreateAggregateAnd WithParameter(ParameterName parameterName, TypeName typeName)
        {
            Statement.Parameters.Add(new CreateAggregateParameterBuilder(parameterName, typeName.ToSqlString()));
            Statement.Append(
                (ICreateAggregateStatement input) => input.WithParameter(parameterName, typeName), parameterName, typeName);
            return new CreateAggregateAnd(Statement);
        }

        public ICreateAggregateAnd WithParameter(ParameterName parameterName, SystemType parameterType)
        {
            ISqlString parameterTypeSql = parameterType.ToSqlString();
            Statement.Parameters.Add(new CreateAggregateParameterBuilder(parameterName, parameterTypeSql.ToSqlString()));
            Statement.Append(
                (ICreateAggregateStatement input) => input.WithParameter(parameterName, parameterType),
                parameterName,
                parameterTypeSql);
            return new CreateAggregateAnd(Statement);
        }
    }
}
