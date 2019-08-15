namespace RazorMarkup.Web.AngularJs
{
    public interface IInputBinding<TModel> : IFluentHtmlString
    {
        IInputCheckboxBinding<TModel> Checkbox();
    }
}
