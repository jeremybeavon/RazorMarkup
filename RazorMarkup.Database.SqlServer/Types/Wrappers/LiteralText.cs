namespace RazorMarkup.Database.SqlServer.Types.Wrappers
{
    public sealed class LiteralText
    {
        public static implicit operator LiteralText(string text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator LiteralText(VariableName variableName)
        {
            throw new NotInExpressionException();
        }
    }
}
