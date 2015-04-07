namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropSequenceStatement : ISqlString, IHideObjectMethods
    {
        IDropSequenceStatement And(SequenceName sequenceName);
    }
}
