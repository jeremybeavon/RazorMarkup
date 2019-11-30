using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSampleWithSystem :
        ICommonTableSampleWithSystem<ICommonTableSelectionWithRepeatable, ICommonTableSample>,
        ICommonTableSample
    {
    }
}
