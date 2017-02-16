namespace RazorMarkup.Database.SqlServer.Create.PartitionFunction
{
    public interface ICreatePartitionFunctionStatement : IHideObjectMethods
    {
        ICreatePartitionFunctionAsRangeLeftRight AsRange();
    }
}
