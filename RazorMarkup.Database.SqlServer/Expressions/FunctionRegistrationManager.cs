using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    public sealed class FunctionRegistrationManager : IFunctionRegistrationManager
    {
        public static readonly FunctionRegistrationManager Instance = new FunctionRegistrationManager();

        private readonly IDictionary<MethodInfo, Func<AbstractStatementBuilder>> functionBuilders;
        private readonly IDictionary<string, IList<MethodInfo>> functionMethods;

        private FunctionRegistrationManager()
        {
            functionBuilders = new Dictionary<MethodInfo, Func<AbstractStatementBuilder>>();
            functionMethods = new Dictionary<string, IList<MethodInfo>>();
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(IFunctionRegistrations).Assembly));
            new CompositionContainer(catalog).ComposeParts(this);
            foreach (IFunctionRegistrations functionRegistrations in Registrations)
            {
                functionRegistrations.RegisterFunctions(this);
            }
        }

        [ImportMany]
        public IEnumerable<IFunctionRegistrations> Registrations { get; set; }

        public void Register(FunctionRegistration functionRegistration)
        {
            IList<MethodInfo> methods;
            if (!functionMethods.TryGetValue(functionRegistration.FunctionName, out methods))
            {
                methods = new List<MethodInfo>();
                functionMethods.Add(functionRegistration.FunctionName, methods);
            }

            foreach (MethodInfo method in functionRegistration.Methods)
            {
                functionBuilders.Add(method, functionRegistration.FunctionBuilder);
                methods.Add(method);
            }
        }

        public AbstractStatementBuilder GetFunctionBuilder(MethodInfo method)
        {
            MethodInfo searchMethod = method.IsGenericMethod ? method.GetGenericMethodDefinition() : method;
            Func<AbstractStatementBuilder> functionBuilder;
            if (!functionBuilders.TryGetValue(method, out functionBuilder))
            {
                throw new ArgumentException(method.Name + "was not found.", "method");
            }

            return functionBuilder();
        }

        public MethodInfo GetMethod(string functionName, int parameterCount)
        {
            IList<MethodInfo> methods;
            if (!functionMethods.TryGetValue(functionName, out methods))
            {
                throw new ArgumentException(functionName + " was not found.", "functionName");
            }

            return methods.First(method => IsMatch(method, parameterCount));
        }

        private static bool IsMatch(MethodInfo method, int parameterCount)
        {
            ParameterInfo[] parameters = method.GetParameters();
            if (parameters.Length != parameterCount)
            {
                return false;
            }

            /*for (int index = 0; index < parameters.Length; index++)
            {
                if (parameters[index].ParameterType != parameterTypes[index])
                {
                    return false;
                }
            }*/

            return true;
        }
    }
}
