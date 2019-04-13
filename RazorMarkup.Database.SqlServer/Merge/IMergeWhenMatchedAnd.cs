using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhenMatchedAnd : IMergeWhenMatched
    {
        IMergeWhenMatched And(Expression<Func<bool>> condition);
    }
}
