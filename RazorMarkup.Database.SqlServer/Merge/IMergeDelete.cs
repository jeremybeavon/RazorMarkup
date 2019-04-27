namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeDelete : IHideObjectMethods
    {
        IMergeWhen Delete();
    }
}
