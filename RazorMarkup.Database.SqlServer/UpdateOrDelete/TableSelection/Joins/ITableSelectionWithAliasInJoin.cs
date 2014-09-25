namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    public interface ITableSelectionWithAliasInJoin<TJoinEndType>
    {
        ITableSelectionWithTableSampleInJoin<TJoinEndType> WithAlias(TableAlias tableAlias);
    }
}
