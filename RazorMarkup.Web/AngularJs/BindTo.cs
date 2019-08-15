using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace RazorMarkup.Web.AngularJs
{
    internal sealed class BindTo<TModel> : AbstractFluentHtmlString, IBindTo<TModel>
    {
        private readonly StringBuilder textBuilder;
        private readonly HtmlHelper<TModel> htmlHelper;

        public BindTo(HtmlHelper<TModel> htmlHelper)
        {
            textBuilder = new StringBuilder();
            this.htmlHelper = htmlHelper;
        }

        public void AddAttribute(string name, string value)
        {
            textBuilder.AppendFormat(AttributeHelper.GetAttribute(name, value));
        }

        public void AddAttribute(string name, LambdaExpression bindingExpression)
        {
            AddAttribute(name, HttpUtility.HtmlAttributeEncode(bindingExpression.ToHtmlString()));
        }

        public override string ToHtmlString()
        {
            return textBuilder.ToString();
        }

        public IAppBinding<TModel> App(string appName)
        {
            AddAttribute(AngularJsAttributes.App, appName);
            return new AppBinding<TModel>(this);
        }

        public IAppBinding<TModel> App(Type appType)
        {
            return App(appType.Name);
        }

        public IBindTo<TModel> Controller(string controllerName)
        {
            AddAttribute(AngularJsAttributes.Controller, controllerName);
            return this;
        }

        public TResult Foreach<TResult>(
            Expression<Func<TModel, IEnumerable<TResult>>> bindingExpression,
            string variableName)
        {
            GenerateForeach(variableName, bindingExpression);
            return default(TResult);
        }

        public TResult Foreach<TResult>(Expression<Func<IEnumerable<TResult>>> bindingExpression, string variableName)
        {
            GenerateForeach(variableName, bindingExpression);
            return default(TResult);
        }

        public IAnchorBinding<TModel> Anchor()
        {
            return new AnchorBinding<TModel>(this);
        }

        public IFormBinding<TModel> Form()
        {
            return new FormBinding<TModel>(this);
        }

        public IInputBinding<TModel> Input()
        {
            return new InputBinding<TModel>(this);
        }

        public IBindTo<TModel> Text<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Text, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Text<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Text, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Html<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Html, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Html<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Html, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Blur(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Blur, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Blur(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Blur, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Class<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Class, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Class<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Class, bindingExpression);
            return this;
        }

        public IBindTo<TModel> ClassEven<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.ClassEven, bindingExpression);
            return this;
        }

        public IBindTo<TModel> ClassEven<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.ClassEven, bindingExpression);
            return this;
        }

        public IBindTo<TModel> ClassOdd<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.ClassOdd, bindingExpression);
            return this;
        }

        public IBindTo<TModel> ClassOdd<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.ClassOdd, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Click(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Click, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Click(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Click, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Cloak()
        {
            AddAttribute(AngularJsAttributes.Cloak, string.Empty);
            return this;
        }

        public IBindTo<TModel> Copy(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Copy, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Copy(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Copy, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Cut(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Cut, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Cut(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Cut, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Disabled<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Disabled, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Disabled<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Disabled, bindingExpression);
            return this;
        }

        public IBindTo<TModel> DoubleClick(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.DoubleClick, bindingExpression);
            return this;
        }

        public IBindTo<TModel> DoubleClick(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.DoubleClick, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Focus(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Focus, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Focus(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Focus, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Hide<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Hide, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Hide<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Hide, bindingExpression);
            return this;
        }

        public IBindTo<TModel> If<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.If, bindingExpression);
            return this;
        }

        public IBindTo<TModel> If<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.If, bindingExpression);
            return this;
        }

        public IBindTo<TModel> KeyDown(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.KeyDown, bindingExpression);
            return this;
        }

        public IBindTo<TModel> KeyDown(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.KeyDown, bindingExpression);
            return this;
        }

        public IBindTo<TModel> KeyPress(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.KeyPress, bindingExpression);
            return this;
        }

        public IBindTo<TModel> KeyPress(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.KeyPress, bindingExpression);
            return this;
        }

        public IBindTo<TModel> KeyUp(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.KeyUp, bindingExpression);
            return this;
        }

        public IBindTo<TModel> KeyUp(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.KeyUp, bindingExpression);
            return this;
        }

        public IBindTo<TModel> ListSeparator(string separator)
        {
            separator = string.Concat(separator.Select(character => string.Concat("&#", (int)character)));
            AddAttribute(AngularJsAttributes.ListSeparator, separator);
            return this;
        }

        public IBindTo<TModel> MouseDown(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseDown, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseDown(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseDown, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseEnter(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseEnter, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseEnter(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseEnter, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseLeave(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseLeave, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseLeave(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseLeave, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseMove(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseMove, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseMove(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseMove, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseOver(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseOver, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseOver(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseOver, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseUp(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseUp, bindingExpression);
            return this;
        }

        public IBindTo<TModel> MouseUp(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.MouseUp, bindingExpression);
            return this;
        }

        public IBindTo<TModel> NonBindable()
        {
            AddAttribute(AngularJsAttributes.NonBindable, string.Empty);
            return this;
        }

        public IBindTo<TModel> Paste(Expression<Action<TModel>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Paste, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Paste(Expression<Action> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Paste, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Show<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Show, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Show<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Show, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Style<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Show, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Style<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Show, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Switch<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Switch, bindingExpression);
            return this;
        }

        public IBindTo<TModel> Switch<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.Switch, bindingExpression);
            return this;
        }

        public IBindTo<TModel> SwitchCase<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.SwitchCase, bindingExpression);
            return this;
        }

        public IBindTo<TModel> SwitchCase<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            AddAttribute(AngularJsAttributes.SwitchCase, bindingExpression);
            return this;
        }

        public IBindTo<TModel> SwitchDefaultCase()
        {
            AddAttribute(AngularJsAttributes.SwitchDefaultCase, string.Empty);
            return this;
        }

        private void GenerateForeach(string variableName, LambdaExpression bindingExpression)
        {
            string value = string.Format("{0} in {1}", variableName, bindingExpression.ToHtmlString());
            htmlHelper.ViewContext.Writer.Write(AttributeHelper.GetAttribute(AngularJsAttributes.Foreach, value));
        }
    }
}
