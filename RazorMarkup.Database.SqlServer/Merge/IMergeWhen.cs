using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhen : IHideObjectMethods
    {
        IMergeWhenMatchedAnd WhenMatched();

        IMergeWhenNotMatchedByTargetAnd WhenNotMatched();

        IMergeWhenNotMatchedByTargetAnd WhenNotMatchedByTarget();

        IMergeWhenNotMatchedBySourceAnd WhenNotMatchedBySource();
    }
}
