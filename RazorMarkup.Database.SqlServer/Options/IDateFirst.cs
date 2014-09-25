using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Options
{
    public interface IDateFirst : IHideObjectMethods
    {
        ISqlString ToMonday();

        ISqlString ToTuesday();

        ISqlString ToWednesday();

        ISqlString ToThursday();

        ISqlString ToFriday();

        ISqlString ToSaturday();

        ISqlString ToSunday();
    }
}
