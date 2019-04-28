namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ITableSelectionWithAliasInJoin<TJoinEndType> : ITableSelectionWithTableSampleInJoin<TJoinEndType>
    {
        ITableSelectionWithTableSampleInJoin<TJoinEndType> WithAlias(TableAlias tableAlias);
    }
}
