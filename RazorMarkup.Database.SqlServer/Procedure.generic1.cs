namespace RazorMarkup.Database.SqlServer
{
    public sealed class Procedure<TOutput>
    {
        public Procedure(ProcedureName name)
        {
            Name = name;
        }

        public Procedure(string name)
            : this(new ProcedureName(name))
        {
        }

        public ProcedureName Name { get; private set; }

        public TOutput Output => throw new NotInExpressionException();
    }
}
