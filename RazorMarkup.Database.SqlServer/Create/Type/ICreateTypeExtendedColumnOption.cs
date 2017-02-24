namespace RazorMarkup.Database.SqlServer.Create.Type
{
    public interface ICreateTypeExtendedColumnOption : ICreateTypeColumnOption
    {
        ICreateTypeColumnOption Max();

        ICreateTypeColumnOption Content(XmlSchemaCollectionName xmlSchemaCollectionName);

        ICreateTypeColumnOption Document(XmlSchemaCollectionName xmlSchemaCollectionName);
    }
}
