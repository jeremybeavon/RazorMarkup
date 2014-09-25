namespace RazorMarkup.Database.SqlServer.Options
{
    public interface IFipsFlagger : IHideObjectMethods
    {
        ISqlString ToEntry();

        ISqlString ToFull();

        ISqlString ToIntermediate();

        ISqlString ToOff();
    }
}
