using System;
using System.Collections.Generic;
using System.Web;
using Westwind.RazorHosting;

namespace RazorMarkup.Common
{
    public abstract class AbstractRazorPageRenderer : IRazorPageRenderer
    {
        protected abstract IEnumerable<Type> ReferencedTypes { get; }

        public string Render(IRazorPage razorPage)
        {
            RazorEngine razorEngine = new RazorEngine();
            razorEngine.Configuration.CompileToMemory = true;
            foreach (Type referencedType in ReferencedTypes)
            {
                razorEngine.AddAssemblyFromType(referencedType);
            }

            string text = razorEngine.RenderTemplate(razorPage.Text);
            if (!string.IsNullOrWhiteSpace(razorEngine.ErrorMessage))
            {
                throw new CompilationException(razorEngine.ErrorMessage);
            }
           
            return HttpUtility.HtmlDecode(text);
        }
    }
}
