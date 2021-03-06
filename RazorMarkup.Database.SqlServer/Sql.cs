﻿using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Alter;
using RazorMarkup.Database.SqlServer.Backup;
using RazorMarkup.Database.SqlServer.Create;
using RazorMarkup.Database.SqlServer.Drop;
using RazorMarkup.Database.SqlServer.Merge;
using RazorMarkup.Database.SqlServer.Options;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class Sql
    {
        public static IAlterStatements Alter()
        {
            return new AlterStatements();
        }

        public static IBackupStatements Backup()
        {
            return new BackupStatements();
        }

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

        public static ICreateStatements Create()
        {
            return new CreateStatements();
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
            ExpressionBuilder<bool> expressionBuilder = expression.ToExpressionBuilder();
            return new SqlString("IF " + expressionBuilder.ToSqlString(), () => While(null), expressionBuilder);
        }

        public static ISqlString Label(LabelName labelName)
        {
            return new SqlString(labelName.ToSqlString() + ":", () => Label(null), labelName);
        }

        public static IMergeStatement Merge()
        {
            return new MergeStatement();
        }

        public static ISqlString Print(Expression<Func<Text>> expression)
        {
            ExpressionBuilder<Text> expressionBuilder = expression.ToExpressionBuilder();
            return new SqlString("PRINT " + expressionBuilder.ToSqlString(), () => Print(null), expressionBuilder);
        }

        public static IQueryStatements Query()
        {
            return new QueryStatements();
        }

        public static ISqlString Return()
        {
            return new SqlString("RETURN", () => Return());
        }

        public static ISqlString Return(Expression<Func<object>> expression)
        {
            ExpressionBuilder<object> expressionBuilder = expression.ToExpressionBuilder();
            return new SqlString("RETURN " + expressionBuilder.ToSqlString(), () => Return(null), expressionBuilder);
        }

        public static ISetStatements Set()
        {
            return new SetStatements();
        }

        public static ISqlString While(Expression<Func<bool>> expression)
        {
            ExpressionBuilder<bool> expressionBuilder = expression.ToExpressionBuilder();
            return new SqlString("WHILE " + expressionBuilder.ToSqlString(), () => While(null), expressionBuilder);
        }
    }
}
