using System;
using System.Linq.Expressions;

namespace RazorMarkup
{
    public abstract class AbstractExpressionVisitor : ExpressionVisitor
    {
        protected override Expression VisitBinary(BinaryExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            throw new NotSupportedException();
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitDebugInfo(DebugInfoExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitDefault(DefaultExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitDynamic(DynamicExpression node)
        {
            throw new NotSupportedException();
        }

        protected override ElementInit VisitElementInit(ElementInit node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitExtension(Expression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitGoto(GotoExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitIndex(IndexExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitLabel(LabelExpression node)
        {
            throw new NotSupportedException();
        }

        protected override LabelTarget VisitLabelTarget(LabelTarget node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitListInit(ListInitExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitLoop(LoopExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            throw new NotSupportedException();
        }

        protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
            throw new NotSupportedException();
        }

        protected override MemberBinding VisitMemberBinding(MemberBinding node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            throw new NotSupportedException();
        }

        protected override MemberListBinding VisitMemberListBinding(MemberListBinding node)
        {
            throw new NotSupportedException();
        }

        protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitNew(NewExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitSwitch(SwitchExpression node)
        {
            throw new NotSupportedException();
        }

        protected override SwitchCase VisitSwitchCase(SwitchCase node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitTry(TryExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            throw new NotSupportedException();
        }
    }
}
