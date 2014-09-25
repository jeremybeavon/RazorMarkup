using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IMediaResolution : IHideObjectMethods
    {
        /// <summary>
        /// Specifies the pixel density of the target display/paper.
        /// </summary>
        IMediaOperator AsDotsPerInch(int resolution);

        /// <summary>
        /// Specifies the pixel density of the target display/paper.
        /// </summary>
        IMediaOperator AsDotsPerCentimeter(int resolution);
    }
}
