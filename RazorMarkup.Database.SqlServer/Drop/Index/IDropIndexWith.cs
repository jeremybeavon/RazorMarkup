namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    public interface IDropIndexWith : IDropIndexAnd
    {
        IDropIndexWithOptions With();
    }
}
