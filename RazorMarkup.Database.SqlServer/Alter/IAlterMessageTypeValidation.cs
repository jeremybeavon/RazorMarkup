using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Alter
{
    public interface IAlterMessageTypeValidation : IHideObjectMethods
    {
        ISqlString None();

        ISqlString Empty();

        ISqlString WellFormedXml();

        ISqlString ValidXmlWithSchemaCollection(XmlSchemaCollectionName schemaCollectionName);
    }
}
