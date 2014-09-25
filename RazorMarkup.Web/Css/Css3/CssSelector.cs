using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.Css.Css3
{
    public sealed class CssSelector : AbstractCss3Selector<CssSelector, AttributeSelector>
    {
        public AbstractCssSelection Selection { get; set; }

        internal override void Write(StringBuilder textBuilder)
        {
            base.Write(textBuilder);
            if (Selection != null)
            {
                Selection.Write(textBuilder);
            }
        }
    }
}
