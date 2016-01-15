using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.CommandLine.Git
{
    public interface IGit : IHideObjectMethods
    {
        IGitPullOptions Pull();
    }
}
