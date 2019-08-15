using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface ITextElements : IHideObjectMethods
    {
        IHtmlElement BeginAbbreviation();

        IHtmlString EndAbbreviation();

        IHtmlElement BeginAddressOfAuthorOrOwner();

        IHtmlString EndAddressOfAuthorOrOwner();

        IHtmlElement BeginBoldText();

        IHtmlString EndBoldText();

        IHtmlElement BeginCite();

        IHtmlString EndCite();

        IHtmlElement BeginCode();

        IHtmlString EndCode();

        IHtmlElement BeginDefinitionText();

        IHtmlString EndDefinitionText();

        IDeletedTextElement BeginDeletedText();

        IHtmlString EndDeletedText();

        IHtmlElement BeginEmphasizedText();

        IHtmlString EndEmphasizedText();

        IHtmlElement BeginHeader1();

        IHtmlString EndHeader1();

        IHtmlElement BeginHeader2();

        IHtmlString EndHeader2();

        IHtmlElement BeginHeader3();

        IHtmlString EndHeader3();

        IHtmlElement BeginHeader4();

        IHtmlString EndHeader4();

        IHtmlElement BeginHeader5();

        IHtmlString EndHeader5();

        IHtmlElement BeginHeader6();

        IHtmlString EndHeader6();

        IHtmlElement BeginItalicsText();

        IHtmlString EndItalicsText();

        IInsertedTextElement BeginInsertedText();

        IHtmlString EndInsertedText();

        IHtmlElement BeginKeyboardText();

        IHtmlString EndKeyboardText();

        ILabelElement BeginLabel();

        IHtmlString EndLabel();

        IHtmlElement LineBreak();

        IHtmlElement BeginParagraph();

        IHtmlString EndParagraph();

        IHtmlElement BeginPreFormattedText();

        IHtmlString EndPreFormattedText();

        IQuoteElement Quote();

        IHtmlElement BeginStrikethruText();

        IHtmlString EndStrikethruText();

        IHtmlElement BeginSampleOutputText();

        IHtmlString EndSampleOutputText();

        IHtmlElement BeginSmallText();

        IHtmlString EndSmallText();

        IHtmlElement BeginImportantText();

        IHtmlString EndImportantText();

        IHtmlElement BeginSubscriptText();

        IHtmlString EndSubscriptText();

        IHtmlElement BeginSuperscriptText();

        IHtmlString EndSuperscriptText();

        IHtmlElement BeginUnderlineText();

        IHtmlString EndUnderlineText();

        IHtmlElement BeginVariableText();

        IHtmlString EndVariableText();
    }
}
