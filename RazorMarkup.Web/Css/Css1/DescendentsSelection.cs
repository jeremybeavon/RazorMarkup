using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.Css.Css1
{
    public sealed class DescendentsSelection : AbstractCssSelector
    {
        public DescendentsSelection Selection { get; set; }

        internal override void Write(StringBuilder textBuilder)
        {
            textBuilder.Append(SelectionText.Descendents);
            base.Write(textBuilder);
            if (Selection != null)
            {
                Selection.Write(textBuilder);
            }
        }
    }
}
