namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    internal class CreateEventNotificationFor : AbstractStatement<CreateEventNotificationStatementBuilder>,
        ICreateEventNotificationFor
    {
        public CreateEventNotificationFor(CreateEventNotificationStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateEventNotificationForAnd For(EventGroupName eventGroup)
        {
            Statement.EventTypesAndGroups.Add(eventGroup.ToString());
            Statement.Append((ICreateEventNotificationFor input) => input.For(eventGroup), eventGroup);
            return new CreateEventNotificationForAnd(Statement);
        }

        public ICreateEventNotificationForAnd For(EventTypeName eventType)
        {
            Statement.EventTypesAndGroups.Add(eventType.ToString());
            Statement.Append((ICreateEventNotificationFor input) => input.For(eventType), eventType);
            return new CreateEventNotificationForAnd(Statement);
        }
    }
}
