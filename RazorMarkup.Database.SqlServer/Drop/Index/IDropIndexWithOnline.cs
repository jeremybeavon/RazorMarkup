namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    public interface IDropIndexWithOnline : IHideObjectMethods
    {
        IDropIndexWithAnd On();

        IDropIndexWithAnd Off();
    }
}
