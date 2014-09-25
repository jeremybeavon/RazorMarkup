using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.Css.Css3
{
    public abstract class AbstractCssSelection : AbstractCss3Selector<CssSelector, AttributeSelector>
    {
        private readonly string operatorText;

        protected AbstractCssSelection(string operatorText)
        {
            this.operatorText = operatorText;
        }

        public AbstractCssSelection Selection { get; set; }

        internal override void Write(StringBuilder textBuilder)
        {
            textBuilder.Append(operatorText);
            base.Write(textBuilder);
            if (Selection != null)
            {
                Selection.Write(textBuilder);
            }
        }
    }
}
