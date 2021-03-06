﻿using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ISubqueryWithAliasInJoin<TJoinEndType> :
        ICommonSubqueryWithAlias<ITableSelectionWithJoinInJoin<TJoinEndType>>
    {
    }
}
