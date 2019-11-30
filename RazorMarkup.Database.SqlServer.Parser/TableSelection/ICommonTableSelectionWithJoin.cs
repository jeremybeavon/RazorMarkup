using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithJoin :
        ICommonTableSelectionWithJoin<ICommonTableSource, ICommonTableSource, ICommonPivotClause, ICommonUnpivotClause>
    {
        ICommonTableSelectionWithJoin On(Expression<Func<bool>> expression);
    } 
}
