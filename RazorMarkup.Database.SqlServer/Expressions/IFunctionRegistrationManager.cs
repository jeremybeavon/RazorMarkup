using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    public interface IFunctionRegistrationManager
    {
        void Register(FunctionRegistration functionRegistration);
    }
}
