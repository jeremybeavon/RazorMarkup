using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.Credential
{
    public interface ICreateCredentialForCryptographicProvider : ISqlString
    {
        ISqlString ForCryptographicProvider(CryptographicProviderName cryptographicProviderName);
    }
}
