namespace RazorMarkup.CommandLine.Git
{
    public interface IGit : IHideObjectMethods
    {
        IGitPullOptions Pull();
    }
}
