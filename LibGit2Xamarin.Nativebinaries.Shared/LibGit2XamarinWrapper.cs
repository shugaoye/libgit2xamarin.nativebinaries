using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    internal static class LibGit2XamarinWrapper
    {
#if __ANDROID__
        public const string DllName = "libgit2.so";
#elif __IOS__
        public const string DllName = "__Internal";
#else
        // public const string DllName = "git2.dll";
        public const string DllName = "__Internal";
#endif

        public static string GetDllName()
        {
            return DllName;
        }

        //[DllImport(DllName, EntryPoint = "CreateMyMathFuncsClass")]
        //internal static extern LibGit2XamarinSafeHandle CreateMyMathFuncs();

        //[DllImport(DllName, EntryPoint = "DisposeMyMathFuncsClass")]
        //internal static extern void DisposeMyMathFuncs(IntPtr ptr);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int git_libgit2_features();

    }
}
