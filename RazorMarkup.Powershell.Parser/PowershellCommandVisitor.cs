using System;
using System.Management.Automation.Language;

namespace RazorMarkup.Powershell.Parser
{
    public sealed class PowershellCommandVisitor : AstVisitor
    {
        public override AstVisitAction VisitArrayExpression(ArrayExpressionAst arrayExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitAttribute(AttributeAst attributeAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitBlockStatement(BlockStatementAst blockStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitBreakStatement(BreakStatementAst breakStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitCatchClause(CatchClauseAst catchClauseAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitCommand(CommandAst commandAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitCommandExpression(CommandExpressionAst commandExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitCommandParameter(CommandParameterAst commandParameterAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitConstantExpression(ConstantExpressionAst constantExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitContinueStatement(ContinueStatementAst continueStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitConvertExpression(ConvertExpressionAst convertExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitDataStatement(DataStatementAst dataStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitErrorExpression(ErrorExpressionAst errorExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitErrorStatement(ErrorStatementAst errorStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitExitStatement(ExitStatementAst exitStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitFileRedirection(FileRedirectionAst redirectionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitForEachStatement(ForEachStatementAst forEachStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitForStatement(ForStatementAst forStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitHashtable(HashtableAst hashtableAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitIfStatement(IfStatementAst ifStmtAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitIndexExpression(IndexExpressionAst indexExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitInvokeMemberExpression(InvokeMemberExpressionAst methodCallAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitMemberExpression(MemberExpressionAst memberExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitMergingRedirection(MergingRedirectionAst redirectionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitNamedBlock(NamedBlockAst namedBlockAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitParamBlock(ParamBlockAst paramBlockAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitParameter(ParameterAst parameterAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitParenExpression(ParenExpressionAst parenExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitPipeline(PipelineAst pipelineAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitReturnStatement(ReturnStatementAst returnStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitScriptBlock(ScriptBlockAst scriptBlockAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitStatementBlock(StatementBlockAst statementBlockAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitSubExpression(SubExpressionAst subExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitSwitchStatement(SwitchStatementAst switchStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitThrowStatement(ThrowStatementAst throwStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitTrap(TrapStatementAst trapStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitTryStatement(TryStatementAst tryStatementAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitTypeConstraint(TypeConstraintAst typeConstraintAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitTypeExpression(TypeExpressionAst typeExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitUsingExpression(UsingExpressionAst usingExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitVariableExpression(VariableExpressionAst variableExpressionAst)
        {
            throw new NotSupportedException();
        }

        public override AstVisitAction VisitWhileStatement(WhileStatementAst whileStatementAst)
        {
            throw new NotSupportedException();
        }
    }
}
