using System.Linq.Expressions;

namespace RazorMarkup.Powershell
{
    public interface IPowershellCommonParameters<TParameters> : IHideObjectMethods
    {
        TParameters Debug();

        TParameters Debug(bool debug);

        TParameters Debug(Expression<bool> debug);

        TParameters ErrorAction(ActionPreference errorAction);

        TParameters ErrorAction(Expression<ActionPreference> errorAction);

        TParameters ErrorVariable(string errorVariable);

        TParameters ErrorVariable(Expression<string> errorVariable);

        TParameters OutVariable(string outVariable);

        TParameters OutVariable(Expression<string> outVariable);

        TParameters OutBuffer(int outBuffer);

        TParameters OutBuffer(Expression<int> outBuffer);

        TParameters Verbose();

        TParameters Verbose(bool verbose);

        TParameters Verbose(Expression<bool> verbose);

        TParameters WarningAction(ActionPreference warningAction);

        TParameters WarningAction(Expression<ActionPreference> warningAction);

        TParameters WarningVariable(string warningVariable);

        TParameters WarningVariable(Expression<string> warningVariable);
    }
}
