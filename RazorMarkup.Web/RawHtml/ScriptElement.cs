namespace RazorMarkup.Web.RawHtml
{
    internal sealed class ScriptElement : AbstractHtmlElement<IScriptElement>, IScriptElement
    {
        public const string DefaultType = "text/javascript";

        public ScriptElement()
            : this(DefaultType)
        {
        }

        public ScriptElement(string type)
            : base("script", false)
        {
            if (type != null)
            {
                AddAttribute("type", type);
            }
        }

        public IScriptElement WithCharacterSet(string characterSet)
        {
            return AddAttribute("charset", characterSet);
        }

        public IScriptElement WithDefer()
        {
            return AddEmptyAttribute("defer");
        }

        public IScriptElement WithUrl(string url)
        {
            return AddAttribute("src", url);
        }
    }
}
