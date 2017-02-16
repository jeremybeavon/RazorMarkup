namespace RazorMarkup.Database.SqlServer.Create.XmlIndex
{
    public interface ICreateXmlIndexUsingXmlIndex : ICreateXmlIndexWith
    {
        ICreateXmlIndexFor UsingXmlIndex(IndexName xmlIndexName);
    }
}
