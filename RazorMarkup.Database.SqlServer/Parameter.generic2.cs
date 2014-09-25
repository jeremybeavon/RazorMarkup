namespace RazorMarkup.Database.SqlServer
{
    public sealed class Parameter<TValue, TValues>
    {
        public Parameter(ParameterName name)
        {
            Name = name;
        }

        public Parameter(string name)
            : this(new ParameterName(name))
        {
        }

        public ParameterName Name { get; private set; }

        public TValue Value { get; set; }

        public TValues Values { get; set; }
    }
}
