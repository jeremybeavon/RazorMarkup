using RazorMarkup.Powershell.Modules.Utility;

namespace RazorMarkup.Powershell
{
    public static class UtilityModule
    {
        public static IAddTypeFromSourceParameters AddType(this PowershellCommand command)
        {
            return null;
        }

        public static IAddTypeFromSourceParameters AddType(this PowershellCommand command, string typeDefinition)
        {
            return null;
            //return new AddTypeCommand
        }
    }
}
