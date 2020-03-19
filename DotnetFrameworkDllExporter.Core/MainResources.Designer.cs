using System.Reflection;
using System.Resources;

namespace DotnetFrameworkDllExporter.Core 
{
    public static class MainResources
    {
        public static string AssemblyDtd
        {
            get
            {
                var rm = new ResourceManager("DotNetFrameworkDllExporterCore.MainResources", Assembly.GetExecutingAssembly());
                return rm.GetString("AssemblyDtd");
            }
        }
    }     
}
