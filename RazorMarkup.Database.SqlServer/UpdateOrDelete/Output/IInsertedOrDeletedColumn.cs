namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface IInsertedOrDeletedColumn : IHideObjectMethods
    {
        IInsertedOrDeletedColumnName Deleted();

        IInsertedOrDeletedColumnName Inserted();
    }
}
