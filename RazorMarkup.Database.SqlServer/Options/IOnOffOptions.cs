namespace RazorMarkup.Database.SqlServer.Options
{
    public interface IOnOffOptions : IHideObjectMethods
    {
        ISqlString On();

        ISqlString Off();
    }
}
