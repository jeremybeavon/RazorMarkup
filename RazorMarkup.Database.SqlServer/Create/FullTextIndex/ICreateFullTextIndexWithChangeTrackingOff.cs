namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexWithChangeTrackingOff : ICreateFullTextIndexWithAnd
    {
        ICreateFullTextIndexWithAnd NoPopulation();
    }
}
