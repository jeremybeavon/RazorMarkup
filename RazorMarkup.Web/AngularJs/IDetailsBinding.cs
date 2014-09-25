using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.AngularJs
{
    public interface IDetailsBinding<TModel> : IFluentHtmlString
    {
        IDetailsBinding<TModel> Open<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IDetailsBinding<TModel> Open<TResult>(Expression<Func<TResult>> bindingExpression);
    }
}
