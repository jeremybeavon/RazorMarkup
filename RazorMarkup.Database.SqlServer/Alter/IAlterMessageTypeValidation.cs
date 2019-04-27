namespace RazorMarkup.Database.SqlServer.Alter
{
    public interface IAlterMessageTypeValidation : IHideObjectMethods
    {
        ISqlString None();

        ISqlString Empty();

        ISqlString WellFormedXml();

        ISqlString ValidXmlWithSchemaCollection(XmlSchemaCollectionName schemaCollectionName);
    }
}
