namespace RazorMarkup.Database.SqlServer
{
    public sealed class LabelName : SqlString
    {
        public LabelName(string labelName)
            : base(labelName.TrimEnd(':'))
        {
        }
    }
}
