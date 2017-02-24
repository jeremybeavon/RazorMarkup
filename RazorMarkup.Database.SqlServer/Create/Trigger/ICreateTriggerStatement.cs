using RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView.Table;
using RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView.View;

namespace RazorMarkup.Database.SqlServer.Create.Trigger
{
    public interface ICreateTriggerStatement : IHideObjectMethods
    {
        ICreateTriggerTableWith On(TableName tableName);

        ICreateTriggerViewWith On(ViewName viewName);
    }
}
