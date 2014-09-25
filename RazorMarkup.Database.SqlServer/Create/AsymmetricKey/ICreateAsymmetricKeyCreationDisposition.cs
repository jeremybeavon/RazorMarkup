namespace RazorMarkup.Database.SqlServer.Create.AsymmetricKey
{
    public interface ICreateAsymmetricKeyCreationDisposition
    {
        ICreateAsymmetricKeySecondaryOptions CreateNew();

        ICreateAsymmetricKeySecondaryOptions OpenExisting();
    }
}
