using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer
{
    public sealed class ColumnName : SqlString, ISqlType
    {
        public ColumnName(string columnName)
            : base(columnName)
        {
        }

        public static implicit operator byte(ColumnName columnName)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator short(ColumnName columnName)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator int(ColumnName columnName)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator long(ColumnName columnName)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator string(ColumnName columnName)
        {
            throw new NotInExpressionException();
        }
    }
}
