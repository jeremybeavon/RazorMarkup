﻿using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonDerivedTableWithAlias : ICommonDerivedTableWithAlias<ICommonTableSelectionWithJoin>
    {
    }
}
