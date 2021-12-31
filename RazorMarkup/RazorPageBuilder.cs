using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorMarkup
{
    public static class RazorPageBuilder
    {
        public static IRazorPage ToRazorPage(string fileName, params ISourceCode[] sourceCode)
        {
            StringBuilder textBuilder = new();
            foreach (string usingReference in GetUsingReferences(sourceCode))
            {
                textBuilder.AppendFormat("@using {0}", usingReference).AppendLine();
            }

            foreach (ISourceCode code in sourceCode)
            {
                textBuilder.AppendLine(code.Text);
            }

            return new RazorPage(fileName, textBuilder.ToString());
        }

        private static IEnumerable<string> GetUsingReferences(IEnumerable<ISourceCode> sourceCode)
        {
            return sourceCode.SelectMany(code => code.Namespaces).Distinct().OrderBy(reference => reference);
        }
    }
}
