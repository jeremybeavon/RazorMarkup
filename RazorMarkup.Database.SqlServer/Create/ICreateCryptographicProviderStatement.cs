using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateCryptographicProviderStatement : IHideObjectMethods
    {
        ISqlString FromFile(string pathOfDll);
    }
}
