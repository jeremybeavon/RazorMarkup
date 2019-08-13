﻿using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSampleInJoin<TJoinEndType> :
        ICommonTableSample<ITableSelectionWithRepeatableInJoin<TJoinEndType>>
    {
    }
}
