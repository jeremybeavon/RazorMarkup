using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.AngularJs
{
    public interface IAppBinding<TModel> : IFluentHtmlString
    {
        IBindTo<TModel> WithStrictDependencyInjection();

        IBindTo<TModel> AlsoBindTo();
    }
}
