namespace RazorMarkup.Database.SqlServer.Create.Type
{
    public interface ICreateTypeFrom : ISqlString
    {
        ISqlString Null();

        ISqlString NotNull();
    }
}
