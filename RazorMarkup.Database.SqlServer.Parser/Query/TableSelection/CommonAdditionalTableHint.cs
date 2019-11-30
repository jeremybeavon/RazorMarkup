using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.TableSelection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonAdditionalTableHint<TEndType> : ICommonAdditionalTableHint
    {
        private readonly IAdditionalTableHint<TEndType> additionalTableHint;

        public CommonAdditionalTableHint(IAdditionalTableHint<TEndType> additionalTableHint)
        {
            this.additionalTableHint = additionalTableHint;
        }

        public ICommonTableHint And()
        {
            throw new NotImplementedException();
        }

        public ICommonDerivedTableWithAlias DerivedTable(Expression<Func<object>>[][] values)
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceScan()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues)
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceSeek()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint HoldLock()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint Index(params string[] indexValues)
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint NoExpand()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint NoLock()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint NoWait()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint PageLock()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadCommitted()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadCommittedLock()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadPast()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadUncommitted()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint RepeatableRead()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint RowLock()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint Serializable()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint Snapshot()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells)
        {
            throw new NotImplementedException();
        }

        public IQueryOperand<IEndSubquery<ICommonSubqueryWithAlias>> Subquery()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAlias Table(TableName tableName)
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint TabLock()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint TabLockX()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint UpdateLock()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAlias View(ViewName viewName)
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithAdditionalTableHint XLock()
        {
            throw new NotImplementedException();
        }
    }
}
