using System.Collections.Generic;
using System.Linq;
using Mono.Cecil;

namespace RazorMarkup.Powershell
{
    public static class CodeGenerator
    {
        public static void GenerateModule(string assemblyFile, string outputDirectory)
        {
            AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(assemblyFile);
            
        }

        private static IEnumerable<TypeDefinition> FindAllCmdlets(string assemblyFile)
        {
            return AssemblyDefinition.ReadAssembly(assemblyFile).MainModule.GetTypes()
                .Where(type => type.CustomAttributes.Any(attribute => attribute.AttributeType.Name == "CmdletAttribute"));
        }

        private static IReadOnlyCollection<string> FindAllParameterSets(TypeDefinition type)
        {
            return null;
        }

        private static IEnumerable<CustomAttribute> FindAllParameterAttributes(TypeDefinition type)
        {
            return type.Fields.SelectMany(field => FindAllParameterAttributes(field))
                .Concat(type.Properties.SelectMany(property => FindAllParameterAttributes(property)));
        }

        private static IEnumerable<CustomAttribute> FindAllParameterAttributes(FieldDefinition field)
        {
            return FindAllParameterAttributes(field.CustomAttributes);
        }

        private static IEnumerable<CustomAttribute> FindAllParameterAttributes(PropertyDefinition property)
        {
            return FindAllParameterAttributes(property.CustomAttributes);
        }

        private static IEnumerable<CustomAttribute> FindAllParameterAttributes(IEnumerable<CustomAttribute> attributes)
        {
            return attributes.Where(attribute => attribute.AttributeType.Name == "ParameterAttribute");
        }
    }
}
