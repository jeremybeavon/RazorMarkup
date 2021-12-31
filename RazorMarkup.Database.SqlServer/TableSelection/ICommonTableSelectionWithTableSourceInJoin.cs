using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithTableSourceInJoin<TTableSourceInJoin> :
        IHideObjectMethods
    {
        TTableSourceInJoin InnerJoin();

        TTableSourceInJoin InnerLoopJoin();

        TTableSourceInJoin InnerHashJoin();

        TTableSourceInJoin InnerMergeJoin();

        TTableSourceInJoin InnerRemoteJoin();

        TTableSourceInJoin LeftJoin();

        TTableSourceInJoin LeftLoopJoin();

        TTableSourceInJoin LeftHashJoin();

        TTableSourceInJoin LeftMergeJoin();

        TTableSourceInJoin LeftRemoteJoin();

        TTableSourceInJoin RightJoin();

        TTableSourceInJoin RightLoopJoin();

        TTableSourceInJoin RightHashJoin();

        TTableSourceInJoin RightMergeJoin();

        TTableSourceInJoin RightRemoteJoin();

        TTableSourceInJoin FullJoin();

        TTableSourceInJoin FullLoopJoin();

        TTableSourceInJoin FullHashJoin();

        TTableSourceInJoin FullMergeJoin();

        TTableSourceInJoin FullRemoteJoin();
    }
}
