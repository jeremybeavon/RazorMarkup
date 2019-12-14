using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    public interface ISource
    {
        T GetSource<T>();
    }
}
