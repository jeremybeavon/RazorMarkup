namespace RazorMarkup.Database.SqlServer.Drop.Signature
{
    internal sealed class DropSignatureCryptoType : AbstractStatement<DropSignatureStatementBuilder>, IDropSignatureCryptoType
    {
        public DropSignatureCryptoType(DropSignatureStatementBuilder statement)
            : base(statement)
        {
        }

        public IDropSignatureAnd Certificate(CertificateName certificateName)
        {
            Statement.Append(string.Format("CERTIFICATE {0}", certificateName.ToSqlString()));
            Statement.Append((IDropSignatureCryptoType input) => input.Certificate(null), certificateName);
            return new DropSignatureAnd(Statement);
        }

        public IDropSignatureAnd AysmmetricKey(AsymmetricKeyName asymmetricKeyName)
        {
            Statement.Append(string.Format("ASYMMETRIC KEY {0}", asymmetricKeyName.ToSqlString()));
            Statement.Append((IDropSignatureCryptoType input) => input.AysmmetricKey(null), asymmetricKeyName);
            return new DropSignatureAnd(Statement);
        }
    }
}
