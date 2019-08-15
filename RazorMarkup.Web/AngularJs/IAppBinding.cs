namespace RazorMarkup.Web.AngularJs
{
    public interface IAppBinding<TModel> : IFluentHtmlString
    {
        IBindTo<TModel> WithStrictDependencyInjection();

        IBindTo<TModel> AlsoBindTo();
    }
}
