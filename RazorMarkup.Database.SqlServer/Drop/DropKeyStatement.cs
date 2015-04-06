using System;

namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropKeyStatement : SqlBuilder, IDropKeyStatement
    {
        public DropKeyStatement(AsymmetricKeyName asymmetricKeyName)
            : base(string.Format("DROP ASYMMETRIC KEY {0}", asymmetricKeyName.ToSqlString()))
        {
            Initialize(() => Sql.Drop().AsymmetricKey(null), asymmetricKeyName);
        }

        public DropKeyStatement(SymmetricKeyName symmetricKeyName)
            : base(string.Format("DROP SYMMETRIC KEY {0}", symmetricKeyName.ToSqlString()))
        {
            Initialize(() => Sql.Drop().SymmetricKey(null), symmetricKeyName);
        }

        public ISqlString RemoveProviderKey()
        {
            Append(" REMOVE PROVIDER KEY");
            Append((IDropKeyStatement input) => input.RemoveProviderKey());
            return this;
        }
    }
}
