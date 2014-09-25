using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateApplicationRoleStatement : IHideObjectMethods
    {
        ICreateApplicationRoleDefaultSchema WithPassword(string password);
    }
}
