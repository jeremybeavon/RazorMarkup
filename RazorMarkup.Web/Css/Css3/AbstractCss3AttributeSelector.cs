using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Web.Css.Css2;

namespace RazorMarkup.Web.Css.Css3
{
    public abstract class AbstractCss3AttributeSelector<TSelector> : AbstractAttributeSelector<TSelector>
        where TSelector : AbstractCss3AttributeSelector<TSelector>
    {
        public TSelector StartsWith(string attributeName, string value)
        {
            return Append("[{0}^={1}]", attributeName, value);
        }

        public TSelector EndsWith(string attributeName, string value)
        {
            return Append("[{0}$={1}]", attributeName, value);
        }

        public TSelector Contains(string attributeName, string value)
        {
            return Append("[{0}*={1}]", attributeName, value);
        }
    }
}
