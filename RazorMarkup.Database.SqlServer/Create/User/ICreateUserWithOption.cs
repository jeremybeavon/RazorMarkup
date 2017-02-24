namespace RazorMarkup.Database.SqlServer.Create.User
{
    public interface ICreateUserWithOption : IHideObjectMethods
    {
        ICreateUserWithAnd DefaultSchema(SchemaName schemaName);

        ICreateUserWithAnd DefaultLanguage(string language);

        ICreateUserWithDefaultLanguage DefaultLanguage();

        ICreateUserWithAnd Sid(string sid);
    }
}
