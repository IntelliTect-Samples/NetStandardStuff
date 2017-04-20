using System;

namespace StandardLibrary
{
    public class Thing
    {
        public static string Method1()
        {
            return nameof(StandardLibrary);
        }

        public static string Method2()
        {
            return ClassLibraryNetFramework.Thing.Method1();
        }



#if Fail

        public static System.Reflection.Assembly GetExecutingAssembly()
        {
            // Bogus IntelliSence because the incorrect project type is specified in the solution:
            //      Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}")
            // when adding a project created using dotnet new classlib --name StandardLibrary
            // Changing the project Guid to
            //      Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}")
            // resolves the issue.
            return System.Reflection.Assembly.GetExecutingAssembly();
        }
#endif // Fail
    }
}
