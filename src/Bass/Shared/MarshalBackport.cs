using System;
using System.Runtime.InteropServices;

namespace ManagedBass
{
    public static class MarshalBackport
    {
        public static T PtrToStructure<T>(IntPtr ptr)
        {
            return (T)Marshal.PtrToStructure(ptr, typeof(T));
        }

        public static int SizeOf<T>()
        {
            return Marshal.SizeOf(typeof(T));
        }
    }
}