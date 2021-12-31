using RazorEngineCore;
using System;
using System.Collections.Generic;
using System.Web;

namespace RazorMarkup
{
    public abstract class AbstractRazorPageRenderer : IRazorPageRenderer
    {
        protected abstract IEnumerable<Type> ReferencedTypes { get; }

        public string Render(IRazorPage razorPage)
        {
            RazorEngine razorEngine = new();
            string text = razorEngine.Compile(razorPage.Text, ConfigureRazorEngine).Run();
            return HttpUtility.HtmlDecode(text);
        }

        private void ConfigureRazorEngine(IRazorEngineCompilationOptionsBuilder options)
        {
            foreach (Type referencedType in ReferencedTypes)
            {
                options.AddAssemblyReference(referencedType);
            }
        }
    }
}
