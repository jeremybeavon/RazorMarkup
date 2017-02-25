namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexWithStopList : IHideObjectMethods
    {
        ICreateFullTextIndexWithAnd Off();

        ICreateFullTextIndexWithAnd System();
    }
}
