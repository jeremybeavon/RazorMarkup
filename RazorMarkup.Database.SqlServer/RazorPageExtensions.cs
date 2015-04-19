namespace RazorMarkup.Database.SqlServer
{
    public static class RazorPageExtensions
    {
        public static string Render(this IRazorPage razorPage)
        {
            return new RazorPageRenderer().Render(razorPage);
        }
    }
}
