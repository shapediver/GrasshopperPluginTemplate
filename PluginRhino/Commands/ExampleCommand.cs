using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using System;
using System.Collections.Generic;

namespace PluginTemplate.PluginRhino
{
    public class ExampleCommand : Command
    {
        public ExampleCommand()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static ExampleCommand Instance { get; private set; }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName => "PluginTemplateExampleCommand";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            /// The following code shows a possibility to differentiate between versions of RhinoCommon and .NET at compile time.

            /// The RHINOCOMMON_* constants are defined in "CommonReferencesRhino.csproj"
#if RHINOCOMMON_EQUAL_7
            RhinoApp.WriteLine("RHINOCOMMON_EQUAL_7 is defined.");
#endif

#if RHINOCOMMON_EQUAL_8
            RhinoApp.WriteLine("RHINOCOMMON_EQUAL_8 is defined.");
#endif

#if RHINOCOMMON_GREATER_EQUAL_7
            RhinoApp.WriteLine("RHINOCOMMON_GREATER_EQUAL_7 is defined.");
#endif

#if RHINOCOMMON_GREATER_EQUAL_8
            RhinoApp.WriteLine("RHINOCOMMON_GREATER_EQUAL_8 is defined.");
#endif

            /// see https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives
#if NETFRAMEWORK
            RhinoApp.WriteLine("NETFRAMEWORK is defined.");
#endif

#if NET7_0_OR_GREATER
            RhinoApp.WriteLine("NET7_0_OR_GREATER is defined.");
#endif

            return Result.Success;
        }
    }
}
