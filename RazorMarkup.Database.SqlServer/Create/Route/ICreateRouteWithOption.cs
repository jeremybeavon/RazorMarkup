namespace RazorMarkup.Database.SqlServer.Create.Route
{
    public interface ICreateRouteWithOption : IHideObjectMethods
    {
        ICreateRouteWithAnd ServiceName(string serviceName);

        ICreateRouteWithAnd BrokerInstance(string brokerInstance);

        ICreateRouteWithAnd Lifetime(string routeLifetime);

        ICreateRouteWithAnd Address(string nextHopAddress);

        ICreateRouteWithAnd MirrorAddress(string nextHopMirrorAddress);
    }
}
