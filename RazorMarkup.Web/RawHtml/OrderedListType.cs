using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class OrderedListType : HtmlString
    {
        public static readonly OrderedListType Numbers = new OrderedListType("1");

        public static readonly OrderedListType AlphabeticalLowercase = new OrderedListType("a");

        public static readonly OrderedListType AlphabeticalUppercase = new OrderedListType("A");

        public static readonly OrderedListType RomanNumbersLowercase = new OrderedListType("i");

        public static readonly OrderedListType RomanNumbersUppercase = new OrderedListType("I");

        public OrderedListType(string html)
            : base(html)
        {
        }
    }
}
