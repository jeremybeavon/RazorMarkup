using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public interface ISql : IHideObjectMethods
    {
        IQueryStatements Query();

        ISqlString If(Expression<Func<bool>> expression);

        ISqlString Else();

        ISqlString Break();

        ISqlString Continue();

        ISqlString Begin();

        ISqlString End();

        ISqlString Label(LabelName labelName);

        ISqlString Goto(LabelName labelName);

        ISqlString Return();

        ISqlString BeginTry();

        ISqlString EndTry();

        ISqlString BeginCatch();

        ISqlString EndCatch();

        ISqlString While(Expression<Func<bool>> expression);

        ISqlString Print(Expression<Func<Text>> expression);

        //ISqlString Return(Expression<Func<Integer>> expression);
    }
}
/* 
 * TODOs:
 * Select column expression
 * data type precision and conversion
 * CONCAT
 * STUFF
 * Catalog Views\Data Collector Views
 * Catalog Views\Database Mail Views
 * 
 * Sql.Query().Select().AllColumns().From().Subquery().Select().AllColumns().From().Table(new TableName("table1")).End().Subquery()
 * 
 * Sql.Query().Select().AllColumns().From().Table(...).WithAlias().InnerJoin().Table(...).WithAlias().On(() => 
 */
