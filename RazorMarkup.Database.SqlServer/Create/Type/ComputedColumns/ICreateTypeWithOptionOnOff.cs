namespace RazorMarkup.Database.SqlServer.Create.Type.ComputedColumns
{
    public interface ICreateTypeWithOptionOnOff : IHideObjectMethods
    {
        ICreateTypeAnd On();

        ICreateTypeAnd Off();
    }
}
