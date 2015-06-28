using System;
using System.Collections.Generic;
namespace RazorMarkup.Database.SqlServer
{
    public sealed class RazorPageRenderer : AbstractRazorPageRenderer
    {
        protected override IEnumerable<Type> ReferencedTypes
        {
            get
            {
                yield return typeof(Sql);
                yield return typeof(ISqlString);
                yield return typeof(IHideObjectMethods);
            }
        }
    }
}
