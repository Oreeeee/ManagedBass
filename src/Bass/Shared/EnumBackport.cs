using System;

namespace ManagedBass
{
    public static class EnumBackport
    {
        public static bool HasFlag<T>(this T value, T flag) where T : struct, Enum
        {
            long valueLong = Convert.ToInt64(value);
            long flagLong = Convert.ToInt64(flag);
            return (valueLong & flagLong) == flagLong;
        }
    }
}
