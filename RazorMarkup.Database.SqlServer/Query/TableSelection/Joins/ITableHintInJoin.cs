﻿using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableHintInJoin<TJoinEndType> :
        ICommonTableHint<ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>>
    {
    }
}
