using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.Css.Css2
{
    public abstract class AbstractAttributeSelector<TSelector>
        where TSelector : AbstractAttributeSelector<TSelector>
    {
        private readonly StringBuilder attributeMatchBuilder;

        protected AbstractAttributeSelector()
        {
            attributeMatchBuilder = new StringBuilder();
        }

        private TSelector Selector
        {
            get { return (TSelector)(object)this; }
        }

        public TSelector MatchName(string attributeName)
        {
            return Append("[{0}]", attributeName);
        }

        public TSelector MatchValue(string attributeName, string value)
        {
            return Append("[{0}={1}]", attributeName, value);
        }

        public TSelector ContainsWord(string attributeName, string value)
        {
            return Append("[{0}~={1}]", attributeName, value);
        }

        public TSelector StartsWithWord(string attributeName, string value)
        {
            return Append("[{0}|={1}]", attributeName, value);
        }
        
        internal void Write(StringBuilder textBuilder)
        {
            textBuilder.Append(attributeMatchBuilder.ToString());
        }

        internal TSelector Append(string format, params string[] arguments)
        {
            attributeMatchBuilder.AppendFormat(format, arguments);
            return Selector;
        }
    }
}
