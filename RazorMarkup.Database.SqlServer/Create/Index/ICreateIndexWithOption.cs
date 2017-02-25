namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexWithOption : IHideObjectMethods
    {
        ICreateIndexWithOptionOnOff PadIndex();

        ICreateIndexWithAnd FillFactor(int fillFactor);

        ICreateIndexWithOptionOnOff SortInTempDb();

        ICreateIndexWithOptionOnOff IgnoreDupKey();

        ICreateIndexWithOptionOnOff StatisticsNoRecompute();

        ICreateIndexWithOptionOnOff DropExisting();

        ICreateIndexWithOptionOnOff Online();

        ICreateIndexWithOptionOnOff AllowRowLocks();

        ICreateIndexWithOptionOnOff AllowPageLocks();

        ICreateIndexWithAnd MaxDop(int maximumDegreeOfParallelism);

        ICreateIndexWithDataCompression DataCompression();
    }
}
