namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateMessageTypeValidationOption : IHideObjectMethods
    {
        ISqlString None();

        ISqlString Empty();

        ISqlString WellFormedXml();

        ISqlString ValidXmlWithSchemaCollection(XmlSchemaCollectionName schemaCollectionName);
    }
}
