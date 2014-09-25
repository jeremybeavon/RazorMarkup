namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithAliasInJoin<TJoinEndType>
    {
        ITableSelectionWithTableSampleInJoin<TJoinEndType> WithAlias(TableAlias tableAlias);
    }
}
