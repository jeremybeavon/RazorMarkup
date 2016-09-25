﻿using RazorMarkup.Database.SqlServer.Create.Aggregate;
using RazorMarkup.Database.SqlServer.Create.Assembly;

namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateStatements
    {
        ICreateAggregateStatement Aggregate(AggregateName aggregateName);

        ICreateApplicationRoleStatement ApplicationRole(ApplicationRoleName applicationRoleName);

        ICreateAssemblyStatementWithAuthorization Assembly(AssemblyName assemblyName);
    }
}
