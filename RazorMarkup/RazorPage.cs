using System.IO;

namespace RazorMarkup
{
    internal sealed class RazorPage : IRazorPage
    {
        public RazorPage(string fileName, string text)
        {
            FileName = fileName;
            Text = text;
        }

        public string FileName { get; private set; }

        public string Text { get; private set; }

        public void ToFile(string directory)
        {
            File.WriteAllText(Path.Combine(directory, FileName), Text);
        }
    }
}
