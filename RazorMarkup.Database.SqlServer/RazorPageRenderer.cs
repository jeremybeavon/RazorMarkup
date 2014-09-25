using System;
using System.Collections.Generic;
using RazorMarkup.Common;

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
            }
        }
    }
}
