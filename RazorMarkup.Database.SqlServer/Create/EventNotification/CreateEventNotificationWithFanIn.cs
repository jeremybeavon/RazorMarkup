namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    internal sealed class CreateEventNotificationWithFanIn : CreateEventNotificationFor,
        ICreateEventNotificationWithFanIn
    {
        public CreateEventNotificationWithFanIn(CreateEventNotificationStatementBuilder statement)
            : base(statement)
        {
        }
        
        public ICreateEventNotificationFor WithFanIn()
        {
            Statement.WithFanIn = true;
            Statement.Append((ICreateEventNotificationWithFanIn input) => input.WithFanIn());
            return this;
        }
    }
}
