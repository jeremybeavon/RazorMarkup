using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
