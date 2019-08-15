using System.Collections.Generic;
using System.Text;

namespace RazorMarkup.Web.Css
{
    public abstract class AbstractCssSelector
    {
        protected AbstractCssSelector()
        {
            ClassNames = new List<CssClass>();
        }

        public string ElementName { get; set; }

        public string Id { get; set; }

        public IList<CssClass> ClassNames { get; set; }

        public bool OnActiveElement { get; set; }

        public bool OnlySelectUnvisitedLinks { get; set; }

        public bool OnlySelectVisitedLinks { get; set; }

        public bool OnHover { get; set; }

        public bool OnlySelectFirstLine { get; set; }

        public bool OnlySelectFirstLetter { get; set; }

        public sealed override string ToString()
        {
            StringBuilder textBuilder = new StringBuilder();
            Write(textBuilder);
            return textBuilder.ToString();
        }

        internal virtual void Write(StringBuilder textBuilder)
        {
            WriteElementName(textBuilder);
            WriteId(textBuilder);
            WriteClassNames(textBuilder);
            WriteActive(textBuilder);
            WriteUnvisitedLink(textBuilder);
            WriteVisitedLink(textBuilder);
            WriteHover(textBuilder);
            WriteMatchOnlyFirstLine(textBuilder);
            WriteMatchOnlyFirstLetter(textBuilder);
        }

        private void WriteElementName(StringBuilder textBuilder)
        {
            if (!string.IsNullOrEmpty(ElementName))
            {
                textBuilder.Append(ElementName);
            }
        }

        private void WriteId(StringBuilder textBuilder)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                textBuilder.Append("#" + Id);
            }
        }

        private void WriteClassNames(StringBuilder textBuilder)
        {
            if (ClassNames != null && ClassNames.Count != 0)
            {
                textBuilder.Append(string.Join(".", ClassNames));
            }
        }

        private void WriteActive(StringBuilder textBuilder)
        {
            if (OnActiveElement)
            {
                textBuilder.Append(":active");
            }
        }

        private void WriteUnvisitedLink(StringBuilder textBuilder)
        {
            if (OnlySelectUnvisitedLinks)
            {
                textBuilder.Append(":link");
            }
        }

        private void WriteVisitedLink(StringBuilder textBuilder)
        {
            if (OnlySelectVisitedLinks)
            {
                textBuilder.Append(":visited");
            }
        }

        private void WriteHover(StringBuilder textBuilder)
        {
            if (OnHover)
            {
                textBuilder.Append(":hover");
            }
        }

        private void WriteMatchOnlyFirstLine(StringBuilder textBuilder)
        {
            if (OnlySelectFirstLine)
            {
                textBuilder.Append("::first-line");
            }
        }

        private void WriteMatchOnlyFirstLetter(StringBuilder textBuilder)
        {
            if (OnlySelectFirstLine)
            {
                textBuilder.Append("::first-letter");
            }
        }
    }
}
