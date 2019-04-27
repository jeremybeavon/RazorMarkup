namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    public abstract class AbstractTableReferenceBuilder : AbstractStatementBuilder
    {
        protected AbstractTableReferenceBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
        }

        public bool IncludeComma { get; set; }
    }
}
