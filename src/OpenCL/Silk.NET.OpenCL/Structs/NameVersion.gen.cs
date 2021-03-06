// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    public unsafe struct NameVersion
    {
        public NameVersion
        (
            uint version = default
        )
        {
           Version = version;
        }

/// <summary></summary>
        public uint Version;
        /// <summary></summary>
       public fixed char Name[64];
    }
}
