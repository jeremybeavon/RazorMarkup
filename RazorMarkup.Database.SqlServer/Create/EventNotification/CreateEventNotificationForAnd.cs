using System;

namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    internal sealed class CreateEventNotificationForAnd : CreateEventNotificationToService,
        ICreateEventNotificationForAnd
    {
        public CreateEventNotificationForAnd(CreateEventNotificationStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateEventNotificationForAnd And(EventGroupName eventGroup)
        {
            Statement.EventTypesAndGroups.Add(eventGroup.ToSqlString());
            Statement.Append((ICreateEventNotificationForAnd input) => input.And(eventGroup), eventGroup);
            return this;
        }

        public ICreateEventNotificationForAnd And(EventTypeName eventType)
        {
            Statement.EventTypesAndGroups.Add(eventType.ToSqlString());
            Statement.Append((ICreateEventNotificationForAnd input) => input.And(eventType), eventType);
            return this;
        }
    }
}
