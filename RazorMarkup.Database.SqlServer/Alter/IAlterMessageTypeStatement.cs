using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Alter
{
    public interface IAlterMessageTypeStatement : IHideObjectMethods
    {
        IAlterMessageTypeValidation Validation();
    }
}
