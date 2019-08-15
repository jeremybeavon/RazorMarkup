using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IRawHtml : IHideObjectMethods
    {
        IBlockElements Block();

        IEmbeddedObjectElements EmbeddedObject();

        IHeadElements Head();

        IInputHiddenElement HiddenField();

        IImageElement Image();

        IImageMapElements ImageMap();

        IListElements List();

        ILinkElements Link();

        IMetadataElement Metadata();

        ITableElements Table();

        ITextElements Text();

        IUserInputElements UserInput();

        IHtmlString Comment(string comment);

        IHtmlString DocType(DocType docType);

        IHtmlElement BeginBody();

        IHtmlString EndBody();

        IHtmlElement BeginHead();

        IHtmlString EndHead();

        IHtmlElement HorizontalBreak();
        
        IHtmlDocumentElement BeginHtml();

        IHtmlString EndHtml();

        IInlineFrameElement BeginInlineFrame();

        IHtmlString EndInlineFrame();

        IHtmlElement BeginNoScript();

        IHtmlString EndNoScript();

        IScriptElement BeginScript();

        IScriptElement BeginScript(string type);

        IHtmlString EndScript();

        IHtmlElement BeginTitle();

        IHtmlString EndTitle();
    }
}

/*
 * TODOs
 * bdi
 * 
 * Soon:
 * 
 * img.ismap
 */