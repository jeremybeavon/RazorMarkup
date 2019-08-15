namespace RazorMarkup.Web.AngularJs
{
    internal sealed class AppBinding<TModel> : AbstractFluentHtmlString, IAppBinding<TModel>
    {
        private readonly BindTo<TModel> binding;

        public AppBinding(BindTo<TModel> binding)
        {
            this.binding = binding;
        }

        public IBindTo<TModel> WithStrictDependencyInjection()
        {
            binding.AddAttribute(AngularJsAttributes.StrictDependencyInjection, string.Empty);
            return binding;
        }

        public IBindTo<TModel> AlsoBindTo()
        {
            return binding;
        }

        public override string ToHtmlString()
        {
            return binding.ToHtmlString();
        }
    }
}
