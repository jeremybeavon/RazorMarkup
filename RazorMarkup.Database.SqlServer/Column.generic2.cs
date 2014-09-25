using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer
{
    public sealed class Column<TValue, TValues>
        where TValue : ISqlType
    {
        public Column(ColumnName name)
        {
            Name = name;
        }

        public Column(string name)
            : this(new ColumnName(name))
        {
        }

        public ColumnName Name { get; private set; }

        public TValue Value { get; set; }

        public TValues Values { get; set; }
    }
}
