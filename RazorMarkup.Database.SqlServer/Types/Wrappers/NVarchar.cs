namespace RazorMarkup.Database.SqlServer.Types.Wrappers
{
    public sealed class NVarchar
    {
        public static implicit operator NVarchar(string text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator NVarchar(SqlChar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator NVarchar(SqlNChar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator NVarchar(SqlVarchar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator NVarchar(SqlVarcharMax text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator NVarchar(SqlNVarchar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator NVarchar(SqlNVarcharMax text)
        {
            throw new NotInExpressionException();
        }
    }
}
