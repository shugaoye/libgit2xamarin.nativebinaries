using System;
using System.Diagnostics;

namespace LibGit2Sharp.Core
{
    public static class NativeDllName
    {
        public const string Name = LibGit2XamarinWrapper.DllName;
    }

    public class LibGit2XamarinUnitTest : IDisposable
    {
        readonly LibGit2XamarinSafeHandle handle;

        public LibGit2XamarinUnitTest()
        {
            // handle = LibGit2XamarinWrapper.CreateMyMathFuncs();
            handle = null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (handle != null && !handle.IsInvalid)
                handle.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public static int git_libgit2_features()
        {
            Debug.Print("LibGit2Xamarin DllName={0}\n", LibGit2XamarinWrapper.GetDllName());
            return LibGit2XamarinWrapper.git_libgit2_features();
        }

    }
}
