namespace RazorMarkup.Database.SqlServer.Alter
{
    internal sealed class AlterMessageTypeStatement : SqlBuilder, IAlterMessageTypeStatement, IAlterMessageTypeValidation
    {
        public AlterMessageTypeStatement(MessageTypeName messageTypeName)
            : base(string.Format("DROP MESSAGE TYPE {0}", messageTypeName.ToSqlString()))
        {
            Initialize(() => Sql.Alter().MessageType(null), messageTypeName);
        }

        public ISqlString Empty()
        {
            Append("EMPTY");
            Append((IAlterMessageTypeValidation input) => input.Empty());
            return this;
        }

        public ISqlString None()
        {
            Append("NONE");
            Append((IAlterMessageTypeValidation input) => input.None());
            return this;
        }

        public IAlterMessageTypeValidation Validation()
        {
            Append("VALIDATION = ");
            Append((IAlterMessageTypeStatement input) => input.Validation());
            return this;
        }

        public ISqlString ValidXmlWithSchemaCollection(XmlSchemaCollectionName schemaCollectionName)
        {
            Append("VALID_XML WITH SCHEMA COLLECTION ");
            Append(schemaCollectionName.ToSqlString());
            Append((IAlterMessageTypeValidation input) => input.ValidXmlWithSchemaCollection(null), schemaCollectionName);
            return this;
        }

        public ISqlString WellFormedXml()
        {
            Append("WELL_FORMED_XML");
            Append((IAlterMessageTypeValidation input) => input.WellFormedXml());
            return this;
        }
    }
}
