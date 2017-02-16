using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create
{
    internal sealed class CreateCryptographicalProviderStatement : SqlBuilder, ICreateCryptographicProviderStatement
    {
        public CreateCryptographicalProviderStatement(CryptographicProviderName name)
            : base(string.Format("CREATE CRYPTOGRAPHIC PROVIDER {0}", name), () => Sql.Create().CryptographicProvider(null), name)
        {
        }

        public ISqlString FromFile(string pathOfDll)
        {
            Append("FROM FILE = '");
            Append(pathOfDll);
            Append("'");
            Append((ICreateCryptographicProviderStatement input) => input.FromFile(null), new RawStatementBuilder(pathOfDll));
            return this;
        }
    }
}
