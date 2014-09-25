using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.Css.Css2
{
    public abstract class AbstractCss2Selector<TAttributeSelector> : AbstractCssSelector
        where TAttributeSelector : AbstractAttributeSelector<TAttributeSelector>
    {
        public bool SelectAllElements { get; set; }

        public TAttributeSelector AttributeSelectors { get; set; }

        public InsertContentOption? InsertContent { get; set; }

        public bool OnlySelectFirstChild { get; set; }

        public bool OnFocus { get; set; }

        public LanguageCode Language { get; set; }

        internal override void Write(StringBuilder textBuilder)
        {
            base.Write(textBuilder);
            WriteSelectAllElements(textBuilder);
            WriteAttributeSelectors(textBuilder);
            WriteInsertContext(textBuilder);
            WriteFirstChild(textBuilder);
            WriteFocus(textBuilder);
            WriteLanguage(textBuilder);
        }

        private void WriteSelectAllElements(StringBuilder textBuilder)
        {
            if (SelectAllElements)
            {
                textBuilder.Append("*");
            }
        }

        private void WriteAttributeSelectors(StringBuilder textBuilder)
        {
            if (AttributeSelectors != null)
            {
                AttributeSelectors.Write(textBuilder);
            }
        }

        private void WriteInsertContext(StringBuilder textBuilder)
        {
            if (InsertContent != null)
            {
                if (InsertContent.Value == InsertContentOption.After)
                {
                    textBuilder.Append("::after");
                }
                else
                {
                    textBuilder.Append("::before");
                }
            }
        }

        private void WriteFirstChild(StringBuilder textBuilder)
        {
            if (OnlySelectFirstChild)
            {
                textBuilder.Append(":first-child");
            }
        }

        private void WriteFocus(StringBuilder textBuilder)
        {
            if (OnFocus)
            {
                textBuilder.Append(":focus");
            }
        }

        private void WriteLanguage(StringBuilder textBuilder)
        {
            if (Language != null)
            {
                textBuilder.AppendFormat(":lang({0})", Language.ToHtmlString());
            }
        }
    }
}
