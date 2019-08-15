using System.Text;

namespace RazorMarkup.Web.Css.Css2
{
    public abstract class AbstractCssSelection : AbstractCss2Selector<AttributeSelector>
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
