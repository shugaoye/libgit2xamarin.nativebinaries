using System;
using Microsoft.Win32.SafeHandles;

namespace LibGit2Sharp.Core
{
    internal class LibGit2XamarinSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public LibGit2XamarinSafeHandle() : base(true) { }

        public IntPtr Ptr => this.handle;

        protected override bool ReleaseHandle()
        {
            // LibGit2XamarinWrapper.DisposeMyMathFuncs(handle);
            return true;
        }
    }
}
