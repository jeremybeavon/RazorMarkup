using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class TextElements : ITextElements
    {
        public IHtmlElement BeginAbbreviation()
        {
            return new HtmlElement("abbr");
        }

        public IHtmlString EndAbbreviation()
        {
            return new HtmlString("</abbr>");
        }

        public IHtmlElement BeginAddressOfAuthorOrOwner()
        {
            return new HtmlElement("address");
        }

        public IHtmlString EndAddressOfAuthorOrOwner()
        {
            return new HtmlString("</address>");
        }

        public IHtmlElement BeginBoldText()
        {
            return new HtmlElement("b");
        }

        public IHtmlString EndBoldText()
        {
            return new HtmlString("</b>");
        }

        public IHtmlElement BeginCite()
        {
            return new HtmlElement("cite");
        }

        public IHtmlString EndCite()
        {
            return new HtmlString("</cite>");
        }

        public IHtmlElement BeginCode()
        {
            return new HtmlElement("code");
        }

        public IHtmlString EndCode()
        {
            return new HtmlString("</code>");
        }

        public IHtmlElement BeginDefinitionText()
        {
            return new HtmlElement("dfn");
        }

        public IHtmlString EndDefinitionText()
        {
            return new HtmlString("</dfn>");
        }

        public IDeletedTextElement BeginDeletedText()
        {
            return new DeletedTextElement();
        }

        public IHtmlString EndDeletedText()
        {
            return new HtmlString("</del>");
        }

        public IHtmlElement BeginEmphasizedText()
        {
            return new HtmlElement("em");
        }

        public IHtmlString EndEmphasizedText()
        {
            return new HtmlString("</em>");
        }

        public IHtmlElement BeginHeader1()
        {
            return new HtmlElement("h1");
        }

        public IHtmlString EndHeader1()
        {
            return new HtmlString("</h1>");
        }

        public IHtmlElement BeginHeader2()
        {
            return new HtmlElement("h2");
        }

        public IHtmlString EndHeader2()
        {
            return new HtmlString("</h2>");
        }

        public IHtmlElement BeginHeader3()
        {
            return new HtmlElement("h3");
        }

        public IHtmlString EndHeader3()
        {
            return new HtmlString("</h3>");
        }

        public IHtmlElement BeginHeader4()
        {
            return new HtmlElement("h4");
        }

        public IHtmlString EndHeader4()
        {
            return new HtmlString("</h4>");
        }

        public IHtmlElement BeginHeader5()
        {
            return new HtmlElement("h5");
        }

        public IHtmlString EndHeader5()
        {
            return new HtmlString("</h5>");
        }

        public IHtmlElement BeginHeader6()
        {
            return new HtmlElement("h6");
        }

        public IHtmlString EndHeader6()
        {
            return new HtmlString("</h6>");
        }

        public IHtmlElement BeginItalicsText()
        {
            return new HtmlElement("i");
        }

        public IHtmlString EndItalicsText()
        {
            return new HtmlString("</i>");
        }

        public IInsertedTextElement BeginInsertedText()
        {
            return new InsertedTextElement();
        }

        public IHtmlString EndInsertedText()
        {
            return new HtmlString("</ins>");
        }

        public IHtmlElement BeginKeyboardText()
        {
            return new HtmlElement("kbd");
        }

        public IHtmlString EndKeyboardText()
        {
            return new HtmlString("</kbd>");
        }

        public ILabelElement BeginLabel()
        {
            return new LabelElement();
        }

        public IHtmlString EndLabel()
        {
            return new HtmlString("</label>");
        }

        public IHtmlElement LineBreak()
        {
            return new HtmlElement("br", true);
        }

        public IHtmlElement BeginParagraph()
        {
            return new HtmlElement("p");
        }

        public IHtmlString EndParagraph()
        {
            return new HtmlString("</p>");
        }

        public IHtmlElement BeginPreFormattedText()
        {
            return new HtmlElement("pre");
        }

        public IHtmlString EndPreFormattedText()
        {
            return new HtmlString("</pre>");
        }

        public IQuoteElement Quote()
        {
            return new QuoteElement();
        }

        public IHtmlElement BeginStrikethruText()
        {
            return new HtmlElement("s");
        }

        public IHtmlString EndStrikethruText()
        {
            return new HtmlString("</s>");
        }

        public IHtmlElement BeginSampleOutputText()
        {
            return new HtmlElement("samp");
        }

        public IHtmlString EndSampleOutputText()
        {
            return new HtmlString("</samp>");
        }

        public IHtmlElement BeginSmallText()
        {
            return new HtmlElement("small");
        }

        public IHtmlString EndSmallText()
        {
            return new HtmlString("</small>");
        }

        public IHtmlElement BeginImportantText()
        {
            return new HtmlElement("strong");
        }

        public IHtmlString EndImportantText()
        {
            return new HtmlString("</strong>");
        }

        public IHtmlElement BeginSubscriptText()
        {
            return new HtmlElement("sub");
        }

        public IHtmlString EndSubscriptText()
        {
            return new HtmlString("</sub>");
        }

        public IHtmlElement BeginSuperscriptText()
        {
            return new HtmlElement("sup");
        }

        public IHtmlString EndSuperscriptText()
        {
            return new HtmlString("</sup>");
        }

        public IHtmlElement BeginUnderlineText()
        {
            return new HtmlElement("u");
        }

        public IHtmlString EndUnderlineText()
        {
            return new HtmlString("</u>");
        }

        public IHtmlElement BeginVariableText()
        {
            return new HtmlElement("var");
        }

        public IHtmlString EndVariableText()
        {
            return new HtmlString("</var>");
        }
    }
}
