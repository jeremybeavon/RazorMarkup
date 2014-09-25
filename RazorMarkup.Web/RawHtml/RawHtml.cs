using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class RawHtml : IRawHtml
    {
        public IBlockElements Block()
        {
            return new BlockElements();
        }

        public IEmbeddedObjectElements EmbeddedObject()
        {
            return new EmbeddedObjectElements();
        }

        public IHeadElements Head()
        {
            return new HeadElements();
        }

        public IInputHiddenElement HiddenField()
        {
            return new InputHiddenElement();
        }

        public IImageElement Image()
        {
            return new ImageElement();
        }

        public IImageMapElements ImageMap()
        {
            return new ImageMapElements();
        }

        public ILinkElements Link()
        {
            return new LinkElements();
        }

        public IListElements List()
        {
            return new ListElements();
        }

        public IMetadataElement Metadata()
        {
            return new MetadataElement();
        }

        public ITableElements Table()
        {
            return new TableElements();
        }

        public ITextElements Text()
        {
            return new TextElements();
        }

        public IUserInputElements UserInput()
        {
            return new UserInputElements();
        }

        public IHtmlString Comment(string comment)
        {
            return new HtmlString(string.Format("<!-- {0} -->", comment));
        }

        public IHtmlString DocType(DocType docType)
        {
            return new HtmlString(string.Format("<!DOCTYPE {0}>", docType.ToHtmlString()));
        }

        public IHtmlElement BeginBody()
        {
            return new HtmlElement("body");
        }

        public IHtmlString EndBody()
        {
            return new HtmlString("</body>");
        }

        public IHtmlElement BeginHead()
        {
            return new HtmlElement("head");
        }

        public IHtmlString EndHead()
        {
            return new HtmlString("</head>");
        }

        public IHtmlElement HorizontalBreak()
        {
            return new HtmlElement("hr", true);
        }

        public IHtmlDocumentElement BeginHtml()
        {
            return new HtmlDocumentElement();
        }

        public IHtmlString EndHtml()
        {
            return new HtmlString("</html>");
        }

        public IInlineFrameElement BeginInlineFrame()
        {
            return new InlineFrameElement();
        }

        public IHtmlString EndInlineFrame()
        {
            return new HtmlString("</iframe>");
        }

        public IHtmlElement BeginNoScript()
        {
            return new HtmlElement("noscript");
        }

        public IHtmlString EndNoScript()
        {
            return new HtmlString("noscript");
        }

        public IScriptElement BeginScript()
        {
            return new ScriptElement();
        }

        public IScriptElement BeginScript(string type)
        {
            return new ScriptElement(type);
        }

        public IHtmlString EndScript()
        {
            return new HtmlString("</script>");
        }

        public IHtmlElement BeginTitle()
        {
            return new HtmlElement("title");
        }

        public IHtmlString EndTitle()
        {
            return new HtmlString("</title>");
        }
    }
}
