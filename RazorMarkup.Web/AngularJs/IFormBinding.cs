using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.AngularJs
{
    public interface IFormBinding<TModel> : IFluentHtmlString
    {
        IFormBinding<TModel> Submit(Expression<Action<TModel>> bindingExpression);

        IFormBinding<TModel> Submit(Expression<Action> bindingExpression);
    }
}
