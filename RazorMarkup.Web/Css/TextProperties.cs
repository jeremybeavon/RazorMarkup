/*
 * using (Css.Select(select => select.Class("test").HasChildren()
 * {
 *      @Css.Property().Text().Color("#00ff00");
 * }
 * 
 * using (Css.SelectMultiple(
 *      select => select.Element("div").HasParent(select.Element("span").HasParent(select.Element("p")))
 *      select => select.Id("id")))
 * {
 * }
 * 
 * (new 
 * 
 * Css.Begin(() => Class("test")
 * 
 * Css.BeginPropertyGroup(Class("test").Then(Id("id").WithAttribute("at")).Then(Element.All), 
 * 
 * new PropertyGroup(Class("text
 */

namespace RazorMarkup.Web.Css
{
    internal sealed class TextProperties : AbstractProperties, ITextProperties
    {
        public string Color(CssColor color)
        {
            return Property("color", color.ToHtmlString());
        }
    }
}
