namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface ISecondaryInsertedOrDeletedColumn
    {
        ISecondaryInsertedOrDeletedColumnName Deleted();

        ISecondaryInsertedOrDeletedColumnName Inserted();
    }
}
