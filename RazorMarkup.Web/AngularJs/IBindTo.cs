using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.AngularJs
{
    public interface IBindTo<TModel> : IFluentHtmlString
    {
        IAppBinding<TModel> App(string appName);

        IAppBinding<TModel> App(Type appType);

        IBindTo<TModel> Controller(string controllerName);

        IAnchorBinding<TModel> Anchor();

        IFormBinding<TModel> Form();

        IInputBinding<TModel> Input();

        TResult Foreach<TResult>(Expression<Func<TModel, IEnumerable<TResult>>> bindingExpression, string variableName);

        TResult Foreach<TResult>(Expression<Func<IEnumerable<TResult>>> bindingExpression, string variableName);

        IBindTo<TModel> Text<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> Text<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> Html<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> Html<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> Blur(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> Blur(Expression<Action> bindingExpression);

        IBindTo<TModel> Class<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> Class<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> ClassEven<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> ClassEven<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> ClassOdd<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> ClassOdd<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> Click(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> Click(Expression<Action> bindingExpression);

        IBindTo<TModel> Cloak();

        IBindTo<TModel> Copy(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> Copy(Expression<Action> bindingExpression);

        IBindTo<TModel> Cut(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> Cut(Expression<Action> bindingExpression);

        IBindTo<TModel> Disabled<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> Disabled<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> DoubleClick(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> DoubleClick(Expression<Action> bindingExpression);

        IBindTo<TModel> Focus(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> Focus(Expression<Action> bindingExpression);

        IBindTo<TModel> Hide<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> Hide<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> If<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> If<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> KeyDown(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> KeyDown(Expression<Action> bindingExpression);

        IBindTo<TModel> KeyPress(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> KeyPress(Expression<Action> bindingExpression);

        IBindTo<TModel> KeyUp(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> KeyUp(Expression<Action> bindingExpression);

        IBindTo<TModel> ListSeparator(string separator);

        IBindTo<TModel> MouseDown(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> MouseDown(Expression<Action> bindingExpression);

        IBindTo<TModel> MouseEnter(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> MouseEnter(Expression<Action> bindingExpression);

        IBindTo<TModel> MouseLeave(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> MouseLeave(Expression<Action> bindingExpression);

        IBindTo<TModel> MouseMove(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> MouseMove(Expression<Action> bindingExpression);

        IBindTo<TModel> MouseOver(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> MouseOver(Expression<Action> bindingExpression);

        IBindTo<TModel> MouseUp(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> MouseUp(Expression<Action> bindingExpression);

        IBindTo<TModel> NonBindable();

        IBindTo<TModel> Paste(Expression<Action<TModel>> bindingExpression);

        IBindTo<TModel> Paste(Expression<Action> bindingExpression);

        IBindTo<TModel> Show<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> Show<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> Style<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> Style<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> Switch<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> Switch<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> SwitchCase<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IBindTo<TModel> SwitchCase<TResult>(Expression<Func<TResult>> bindingExpression);

        IBindTo<TModel> SwitchDefaultCase();
    }
}
