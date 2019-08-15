using System;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class DeletedTextElement : AbstractHtmlElement<IDeletedTextElement>, IDeletedTextElement
    {
        public DeletedTextElement()
            : base("del", false)
        {
        }

        public IDeletedTextElement WithCite(string url)
        {
            return AddAttribute("cite", url);
        }

        public IDeletedTextElement WithDateTime(DateTime deleteDate)
        {
            return AddAttribute("datetime", deleteDate.ToString("yyyy-MM-ddThh:mm:ss"));
        }
    }
}
