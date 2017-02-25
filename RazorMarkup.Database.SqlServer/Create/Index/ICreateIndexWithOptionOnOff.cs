namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexWithOptionOnOff : IHideObjectMethods
    {
        ICreateIndexWithAnd On();

        ICreateIndexWithAnd Off();
    }
}
