using System;

namespace ManagedBass
{
    public static class DynamicCodeHelper
    {
        public static bool Supported
        {
            // Check is dynamic code supported by trying to create dynamic code
            get
            {
                try
                {
                    var assemblyName = new System.Reflection.AssemblyName("DynamicAssembly");
                    var assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, System.Reflection.Emit.AssemblyBuilderAccess.Run);
                    var moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}