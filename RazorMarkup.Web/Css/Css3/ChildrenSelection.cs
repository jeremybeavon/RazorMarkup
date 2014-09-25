using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.Css.Css3
{
    public sealed class ChildrenSelection : AbstractCssSelection
    {
        public ChildrenSelection()
            : base(SelectionText.Children)
        {
        }
    }
}
