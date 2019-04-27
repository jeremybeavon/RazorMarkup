namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableSelectionWithAliasInJoin<TJoinEndType> : ITableSelectionWithTableSampleInJoin<TJoinEndType>
    {
        ITableSelectionWithTableSampleInJoin<TJoinEndType> WithAlias(TableAlias tableAlias);
    }
}
