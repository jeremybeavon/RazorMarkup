namespace RazorMarkup.Powershell
{
    public interface IPowershellString : IHideObjectMethods
    {
        string ToPowershellString();
    }
}
