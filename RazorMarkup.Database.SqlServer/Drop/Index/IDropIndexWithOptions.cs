using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    public interface IDropIndexWithOptions : IHideObjectMethods
    {
        IDropIndexWithAnd MaxDegreeOfParallelism(Expression<Func<Integer>> maxDegreeOfParallelism);

        IDropIndexWithOnline Online();

        IDropIndexWithAnd MoveTo(PartitionSchemeName partitionSchemeName, ColumnName columnName);

        IDropIndexWithAnd MoveTo(FileGroupName fileGroupName);

        IDropIndexWithAnd MoveToDefault();

        IDropIndexWithAnd FilestreamOn(PartitionSchemeName partitionSchemeName);

        IDropIndexWithAnd FilestreamOn(FileGroupName fileGroupName);

        IDropIndexWithAnd FilestreamOnDefault();
    }
}
