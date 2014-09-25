namespace RazorMarkup.Database.SqlServer.Create.AsymmetricKey
{
    public interface ICreateAsymmetricKeyStatementWithOptions
    {
        ICreateAsymmetricKeyAlgorithm WithAlgorithm();

        //ICreateAsymmetricKeySecondaryOptions WithProviderKeyName(Text keyNameInProvider);


    }
}
