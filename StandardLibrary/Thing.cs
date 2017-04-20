using System;

namespace StandardLibrary
{
    public class Thing
    {
        public static string Method()
        {
            return nameof(StandardLibrary);
        }

        public static System.Reflection.Assembly GetExecutingAssembly()
        {
            return System.Reflection.Assembly.GetExecutingAssembly
        }
    }
}
