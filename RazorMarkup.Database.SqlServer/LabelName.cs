using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer
{
    public sealed class LabelName : SqlString
    {
        public LabelName(string labelName)
            : base(labelName)
        {
        }
    }
}
