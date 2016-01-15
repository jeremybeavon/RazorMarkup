using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.CommandLine.Git
{
    public interface IGitPullOptions : IHideObjectMethods
    {
        IGitPullOptions Quiet();

        IGitPullOptions Verbose();

        IGitPullOptions RecurseSubmodules();

        IGitPullOptions RecurseSubmodules(RecurseSubmodulesOption option);

        IGitPullOptions Commit();

        IGitPullOptions NoCommit();


    }
}
