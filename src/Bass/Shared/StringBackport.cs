namespace ManagedBass
{
    public static class StringBackport
    {
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrEmpty(str) || str.Trim().Length == 0;
        }
    }
}