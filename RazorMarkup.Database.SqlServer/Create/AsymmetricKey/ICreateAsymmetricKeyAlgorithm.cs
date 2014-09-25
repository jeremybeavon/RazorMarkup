namespace RazorMarkup.Database.SqlServer.Create.AsymmetricKey
{
    public interface ICreateAsymmetricKeyAlgorithm
    {
        ICreateAsymmetricKeySecondaryOptions Rsa512();

        ICreateAsymmetricKeySecondaryOptions Rsa1024();

        ICreateAsymmetricKeySecondaryOptions Rsa2048();

    }
}
