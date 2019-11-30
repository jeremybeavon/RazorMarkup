using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSampleWithSystem<TEndType> : CommonTableSample<TEndType>,
        ICommonTableSampleWithSystem
    {
        private readonly ITableSampleWithSystem<TEndType> tableSampleWithSystem;

        public CommonTableSampleWithSystem(ITableSampleWithSystem<TEndType> tableSampleWithSystem)
            : base(tableSampleWithSystem)
        {
            this.tableSampleWithSystem = tableSampleWithSystem;
        }

        public ICommonTableSample System()
        {
            return new CommonTableSample<TEndType>(tableSampleWithSystem.System());
        }
    }
}
