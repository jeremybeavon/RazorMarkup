namespace RazorMarkup.Database.SqlServer.Drop.Signature
{
    internal sealed class DropSignatureAnd : AbstractStatement<DropSignatureStatementBuilder>, IDropSignatureAnd
    {
        public DropSignatureAnd(DropSignatureStatementBuilder statement)
            : base(statement)
        {
        }

        public IDropSignatureCryptoType And()
        {
            Statement.Append((IDropSignatureAnd input) => input.And());
            return new DropSignatureCryptoType(Statement);
        }
    }
}
