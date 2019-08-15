using System.Text;

namespace RazorMarkup.Web.Css.Css2
{
    public sealed class CssSelector : AbstractCss2Selector<AttributeSelector>
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
