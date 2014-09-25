using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Drop;
using RazorMarkup.Database.SqlServer.Options;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public sealed class Sql : ISql
    {
        public static ISqlString Begin()
        {
            return new SqlString("BEGIN", () => Begin());
        }

        public static ISqlString BeginCatch()
        {
            return new SqlString("BEGIN CATCH", () => BeginCatch());
        }

        public static ISqlString BeginTry()
        {
            return new SqlString("BEGIN TRY", () => BeginTry());
        }

        public static ISqlString Break()
        {
            return new SqlString("BREAK", () => Break());
        }

        public static ISqlString Continue()
        {
            return new SqlString("CONTINUE", () => Continue());
        }

        public static IDropStatements Drop()
        {
            return new DropStatements();
        }

        public static ISqlString Else()
        {
            return new SqlString("ELSE", () => Else());
        }

        public static ISqlString End()
        {
            return new SqlString("END", () => End());
        }

        public static ISqlString EndCatch()
        {
            return new SqlString("END CATCH", () => EndCatch());
        }

        public static ISqlString EndTry()
        {
            return new SqlString("END TRY", () => EndTry());
        }

        public static ISqlString Goto(LabelName labelName)
        {
            return new SqlString("GOTO " + labelName.ToSqlString(), () => Goto(labelName), labelName);
        }

        public static ISqlString If(Expression<Func<bool>> expression)
        {
            throw new NotImplementedException();
        }

        public static ISqlString Label(LabelName labelName)
        {
            return new SqlString(labelName.ToSqlString() + ":", () => Label(labelName), labelName);
        }

        public static ISqlString Print(Expression<Func<Text>> expression)
        {
            throw new NotImplementedException();
        }

        public static IQueryStatements Query()
        {
            return new QueryStatements();
        }

        public static ISqlString Return()
        {
            return new SqlString("RETURN", () => Return());
        }

        public static ISetStatements Set()
        {
            return new SetStatements();
        }

        public static ISqlString While(Expression<Func<bool>> expression)
        {
            throw new NotImplementedException();
        }

        ISqlString ISql.Begin()
        {
            return Begin();
        }

        ISqlString ISql.BeginCatch()
        {
            return BeginCatch();
        }

        ISqlString ISql.BeginTry()
        {
            return BeginTry();
        }

        ISqlString ISql.Break()
        {
            return Break();
        }

        ISqlString ISql.Continue()
        {
            return Continue();
        }

        ISqlString ISql.Else()
        {
            return Else();
        }

        ISqlString ISql.End()
        {
            return End();
        }

        ISqlString ISql.EndCatch()
        {
            return EndCatch();
        }

        ISqlString ISql.EndTry()
        {
            return EndTry();
        }

        ISqlString ISql.Goto(LabelName labelName)
        {
            return Goto(labelName);
        }

        ISqlString ISql.If(Expression<Func<bool>> expression)
        {
            return If(expression);
        }

        ISqlString ISql.Label(LabelName labelName)
        {
            return Label(labelName);
        }

        ISqlString ISql.Print(Expression<Func<Text>> expression)
        {
            return Print(expression);
        }

        IQueryStatements ISql.Query()
        {
            return Query();
        }

        ISqlString ISql.Return()
        {
            return Return();
        }

        ISqlString ISql.While(Expression<Func<bool>> expression)
        {
            return While(expression);
        }
    }
}
