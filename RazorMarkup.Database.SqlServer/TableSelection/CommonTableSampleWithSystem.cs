using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSampleWithSystem<
        TTableSample,
        TTableSelectionWithRepeatable,
        TCommonTableSampleWithSystem> :
        CommonTableSample<TTableSelectionWithRepeatable>,
        ICommonTableSampleWithSystem<TTableSelectionWithRepeatable, TTableSample>
        where TCommonTableSampleWithSystem : ICommonTableSampleWithSystem<TTableSelectionWithRepeatable, TTableSample>
    {
        private readonly Func<FromClauseBuilder, TTableSample> tableSampleBuilder;

        protected CommonTableSampleWithSystem(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TTableSelectionWithRepeatable> tableSelectionWithRepeatableBuilder,
            Func<FromClauseBuilder, TTableSample> tableSampleBuilder)
            : base(statement, tableSelectionWithRepeatableBuilder)
        {
            this.tableSampleBuilder = tableSampleBuilder;
        }

        public TTableSample System()
        {
            Statement.CurrentTable.IsTableSampleSystem = true;
            Statement.Append((TCommonTableSampleWithSystem input) => input.System());
            return tableSampleBuilder(Statement);
        }
    }
}
