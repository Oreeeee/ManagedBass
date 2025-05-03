using System;

namespace ManagedBass
{
    public static class IntPtrBackport
    {
        public static IntPtr Add(IntPtr ptr, int offset)
        {
            return new IntPtr(ptr.ToInt64() + offset);
        }
        
        public static IntPtr Subtract(IntPtr ptr, int offset)
        {
            return new IntPtr(ptr.ToInt64() - offset);
        }
    }
}