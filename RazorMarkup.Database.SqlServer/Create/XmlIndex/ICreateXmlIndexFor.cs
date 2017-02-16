namespace RazorMarkup.Database.SqlServer.Create.XmlIndex
{
    public interface ICreateXmlIndexFor : ICreateXmlIndexWith, ISqlString
    {
        ICreateXmlIndexWith ForValue();

        ICreateXmlIndexWith ForPath();

        ICreateXmlIndexWith ForProperty();
    }
}
