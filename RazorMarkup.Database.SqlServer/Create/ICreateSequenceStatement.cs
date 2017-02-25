namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateSequenceStatement : ISqlString
    {
        ICreateSequenceStatement As(TypeName typeName);

        ICreateSequenceStatement StartsWith(int startsWith);

        ICreateSequenceStatement IncrementBy(int increment);

        ICreateSequenceStatement MinValue(int minValue);

        ICreateSequenceStatement NoMinValue();

        ICreateSequenceStatement MaxValue(int maxValue);

        ICreateSequenceStatement NoMaxValue();

        ICreateSequenceStatement Cycle();

        ICreateSequenceStatement NoCycle();

        ICreateSequenceStatement Cache();

        ICreateSequenceStatement Cache(int cache);

        ICreateSequenceStatement NoCache();
    }
}
