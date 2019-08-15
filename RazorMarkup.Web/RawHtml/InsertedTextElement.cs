using System;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InsertedTextElement : AbstractHtmlElement<IInsertedTextElement>, IInsertedTextElement
    {
        public InsertedTextElement()
            : base("ins", false)
        {
        }

        public IInsertedTextElement WithCite(string url)
        {
            return AddAttribute("cite", url);
        }

        public IInsertedTextElement WithDateTime(DateTime deleteDate)
        {
            return AddAttribute("datetime", deleteDate.ToString("yyyy-MM-ddThh:mm:ss"));
        }
    }
}
