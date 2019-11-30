using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonAdditionalTableHint :
        IAdditionalCommonTableHint<
            ICommonTableSelectionWithAlias,
            ICommonSubqueryWithAlias,
            ICommonDerivedTableWithAlias,
            ICommonTableSelectionWithAdditionalTableHint>
    {
    }
}
