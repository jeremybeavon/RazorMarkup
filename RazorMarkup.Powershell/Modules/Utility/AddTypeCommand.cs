using System;
using System.CodeDom.Compiler;
using System.Linq.Expressions;

namespace RazorMarkup.Powershell.Modules.Utility
{
    internal sealed class AddTypeCommand : AbstractPowershellCommand,
        IAddTypeFromSourceParameters
    {
        public AddTypeCommand()
            : base("Add-Type")
        {
        }

        public AddTypeCommand(string typeDefinition)
            : this()
        {
            AddImplicitParameter(typeDefinition);
        }

        public AddTypeCommand(Expression<string> typeDefinition)
            : this()
        {
            AddImplicitParameter(typeDefinition);
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.CodeDomProvider(CodeDomProvider codeDomProvider)
        {
            AddParameter(codeDomProvider);
            return this;
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.CodeDomProvider(
            Expression<CodeDomProvider> codeDomProvider)
        {
            AddParameter(codeDomProvider);
            return this;
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.CompilerParameters(CompilerParameters compilerParameters)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.CompilerParameters(Expression<CodeDomProvider> compileParameters)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.Debug()
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.Debug(bool debug)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.Debug(Expression<bool> debug)
        {
            throw new NotImplementedException();
        }
        
        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.ErrorAction(ActionPreference errorAction)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.ErrorAction(Expression<ActionPreference> errorAction)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.ErrorVariable(string errorVariable)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.ErrorVariable(Expression<string> errorVariable)
        {
            throw new NotImplementedException();
        }
        
        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.IgnoreWarnings()
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.IgnoreWarnings(bool ignoreWarnings)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.IgnoreWarnings(Expression<bool> ignoreWarnings)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.OutBuffer(int outBuffer)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.OutBuffer(Expression<int> outBuffer)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.OutputAssembly(string outputAssembly)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.OutputAssembly(Expression<string> outputAssembly)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.OutputType(OutputAssemblyType outputType)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.OutputType(Expression<OutputAssemblyType> outputType)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.OutVariable(string outVariable)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.OutVariable(Expression<string> outVariable)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.PassThru()
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.PassThru(bool passThru)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.PassThru(Expression<bool> passThru)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.ReferencedAssemblies(params string[] referencedAssemblies)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IAddTypeFromSourceParameters.ReferencedAssemblies(Expression<string[]> referencedAssemblies)
        {
            throw new NotImplementedException();
        }
        
        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.Verbose()
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.Verbose(bool verbose)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.Verbose(Expression<bool> verbose)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.WarningAction(ActionPreference warningAction)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.WarningAction(Expression<ActionPreference> warningAction)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.WarningVariable(string warningVariable)
        {
            throw new NotImplementedException();
        }

        IAddTypeFromSourceParameters IPowershellCommonParameters<IAddTypeFromSourceParameters>.WarningVariable(Expression<string> warningVariable)
        {
            throw new NotImplementedException();
        }
    }
}
