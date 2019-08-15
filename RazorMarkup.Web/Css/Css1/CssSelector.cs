using System.Text;

namespace RazorMarkup.Web.Css.Css1
{
    public sealed class CssSelector : AbstractCssSelector
    {
        public DescendentsSelection Selection { get; set; }

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
