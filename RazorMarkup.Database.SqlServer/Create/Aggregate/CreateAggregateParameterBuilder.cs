namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    internal sealed class CreateAggregateParameterBuilder : AbstractStatementTextBuilder
    {
        public CreateAggregateParameterBuilder(ParameterName name, string type)
        {
            Name = name;
            Type = type;
        }

        public ParameterName Name { get; private set; }

        public string Type { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(Name.ToSqlString());
            sqlBuilder.Append(" ");
            sqlBuilder.Append(Type);
        }
    }
}
