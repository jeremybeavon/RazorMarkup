namespace RazorMarkup.Database.SqlServer.Create.XmlIndex
{
    public interface ICreateXmlIndexOption : IHideObjectMethods
    {
        ICreateXmlIndexOptionOnOff PadIndex();

        ICreateXmlIndexOptionAnd FillFactor(int fillFactor);

        ICreateXmlIndexOptionOnOff SortInTempDb();

        ICreateXmlIndexOptionOff IgnoreDupKey();

        ICreateXmlIndexOptionOnOff DropExisting();

        ICreateXmlIndexOptionOff Online();

        ICreateXmlIndexOptionOnOff AllowRowLocks();

        ICreateXmlIndexOptionOnOff AllowPageLocks();

        ICreateXmlIndexOptionAnd MaxDop(int maximumDegreeOfParallelism);
    }
}
