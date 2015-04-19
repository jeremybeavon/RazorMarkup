namespace RazorMarkup
{
    public static class SourceCodeExtensions
    {
        public static IRazorPage ToRazorPage(this ISourceCode sourceCode, string fileName)
        {
            return RazorPageBuilder.ToRazorPage(fileName, sourceCode);
        }
    }
}
