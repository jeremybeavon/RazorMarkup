using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IMetadataElement : IHtmlElement<IMetadataElement>
    {
        IMetadataElement WithContent(string content);

        IMetadataElement WithName(HttpMetadataName name);

        IMetadataElement WithName(MetadataName name);
    }
}
