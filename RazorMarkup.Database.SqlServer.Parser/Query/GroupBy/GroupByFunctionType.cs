using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal enum GroupByFunctionType
    {
        Cube,
        Group,
        GroupingSet,
        Rollup
    }
}
