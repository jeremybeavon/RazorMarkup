namespace RazorMarkup.Database.SqlServer.Create.AsymmetricKey
{
    public interface ICreateAsymmetricKeyStatementWithFrom : ICreateAsymmetricKeyStatementWithOptions
    {
        //object FromFile(Text pathToStringNameFile);

        //object FromExecutableFile(Text pathToExecutableFile);

        object FromAssembly(AssemblyName assemblyName);

        //object FromProvider(ProviderName providerName);

    }
}
