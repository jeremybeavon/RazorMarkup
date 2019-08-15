using System;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSampleWithSystemInJoin<TEndType> : CommonTableSampleInJoin<TEndType>,
        ICommonTableSampleWithSystem
    {
        private readonly ITableSampleWithSystemInJoin<TEndType> tableSampleWithSystem;

        public CommonTableSampleWithSystemInJoin(
            ITableSampleWithSystemInJoin<TEndType> tableSampleWithSystem,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(tableSampleWithSystem, endClosure)
        {
            this.tableSampleWithSystem = tableSampleWithSystem;
        }

        public ICommonTableSample System()
        {
            return new CommonTableSampleInJoin<TEndType>(tableSampleWithSystem.System(), EndClosure);
        }
    }
}
