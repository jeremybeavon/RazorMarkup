namespace RazorMarkup.Database.SqlServer.Create.XmlIndex
{
    public interface ICreateXmlIndexOptionOnOff : IHideObjectMethods
    {
        ICreateXmlIndexOptionAnd On();

        ICreateXmlIndexOptionAnd Off();
    }
}
