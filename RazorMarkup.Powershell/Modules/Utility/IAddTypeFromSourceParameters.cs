using System.CodeDom.Compiler;
using System.Linq.Expressions;

namespace RazorMarkup.Powershell.Modules.Utility
{
    public interface IAddTypeFromSourceParameters : IPowershellCommonParameters<IAddTypeFromSourceParameters>
    {
        IAddTypeFromSourceParameters CodeDomProvider(CodeDomProvider codeDomProvider);

        IAddTypeFromSourceParameters CodeDomProvider(Expression<CodeDomProvider> codeDomProvider);

        IAddTypeFromSourceParameters CompilerParameters(CompilerParameters compilerParameters);

        IAddTypeFromSourceParameters CompilerParameters(Expression<CodeDomProvider> compileParameters);

        IAddTypeFromSourceParameters ReferencedAssemblies(params string[] referencedAssemblies);

        IAddTypeFromSourceParameters ReferencedAssemblies(Expression<string[]> referencedAssemblies);

        IAddTypeFromSourceParameters OutputAssembly(string outputAssembly);

        IAddTypeFromSourceParameters OutputAssembly(Expression<string> outputAssembly);

        IAddTypeFromSourceParameters OutputType(OutputAssemblyType outputType);

        IAddTypeFromSourceParameters OutputType(Expression<OutputAssemblyType> outputType);

        IAddTypeFromSourceParameters PassThru();

        IAddTypeFromSourceParameters PassThru(bool passThru);

        IAddTypeFromSourceParameters PassThru(Expression<bool> passThru);

        IAddTypeFromSourceParameters IgnoreWarnings();

        IAddTypeFromSourceParameters IgnoreWarnings(bool ignoreWarnings);

        IAddTypeFromSourceParameters IgnoreWarnings(Expression<bool> ignoreWarnings);
    }
}
