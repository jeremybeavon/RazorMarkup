namespace RazorMarkup.Web.KnockoutJs
{
    public sealed class Optional<T>
    {
        public Optional(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }
    }
}
