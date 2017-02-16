namespace RazorMarkup.Database.SqlServer.Create.PartitionFunction
{
    public interface ICreatePartitionFunctionAsRangeLeftRight : ICreatePartitionFunctionForValues
    {
        ICreatePartitionFunctionForValues Left();

        ICreatePartitionFunctionForValues Right();
    }
}
