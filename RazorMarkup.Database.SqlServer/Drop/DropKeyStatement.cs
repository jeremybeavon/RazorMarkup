using System;

namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropKeyStatement : SqlBuilder, IDropKeyStatement
    {
        public DropKeyStatement(AsymmetricKeyName asymmetricKeyName)
            : base(string.Format("DROP ASYMMETRIC KEY {0}", asymmetricKeyName.ToSqlString()))
        {
        }

        public DropKeyStatement(SymmetricKeyName symmetricKeyName)
            : base(string.Format("DROP SYMMETRIC KEY {0}", symmetricKeyName.ToSqlString()))
        {
        }

        public ISqlString RemoveProviderKey()
        {
            Append(" REMOVE PROVIDER KEY");
            return this;
        }
    }
}
