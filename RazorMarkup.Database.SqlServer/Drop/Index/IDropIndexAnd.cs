namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    public interface IDropIndexAnd : ISqlString, IHideObjectMethods
    {
        IDropIndexStatement And(IndexName indexName);
    }
}
