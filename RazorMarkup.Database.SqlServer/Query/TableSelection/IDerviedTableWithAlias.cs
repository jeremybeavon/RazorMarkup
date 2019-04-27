﻿namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IDerviedTableWithAlias<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithJoin<TEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
