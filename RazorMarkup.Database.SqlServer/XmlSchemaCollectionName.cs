using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer
{
    public class XmlSchemaCollectionName : SqlString
    {
        public XmlSchemaCollectionName(string xmlSchemaCollectionName)
            : base(xmlSchemaCollectionName)
        {
        }
    }
}
