namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    public interface IDropIndexWithAnd : IDropIndexAnd
    {
        IDropIndexWithOptions And();
    }
}
