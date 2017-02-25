namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexWithChangeTracking : IHideObjectMethods
    {
        ICreateFullTextIndexWithAnd Manual();

        ICreateFullTextIndexWithAnd Auto();

        ICreateFullTextIndexWithChangeTrackingOff Off();
    }
}
