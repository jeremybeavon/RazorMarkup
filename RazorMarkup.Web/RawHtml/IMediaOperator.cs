using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IMediaOperator : IFluentHtmlString
    {
        /// <summary>
        /// Specifies an AND operator
        /// </summary>
        IMedia And();

        /// <summary>
        /// Specifies an OR operator
        /// </summary>
        IMedia Or();
    }
}
