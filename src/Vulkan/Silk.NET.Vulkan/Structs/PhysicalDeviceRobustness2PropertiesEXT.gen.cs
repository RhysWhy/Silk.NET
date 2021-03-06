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

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceRobustness2PropertiesEXT
    {
        public PhysicalDeviceRobustness2PropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceRobustness2PropertiesExt,
            void* pNext = default,
            ulong robustStorageBufferAccessSizeAlignment = default,
            ulong robustUniformBufferAccessSizeAlignment = default
        )
        {
           SType = sType;
           PNext = pNext;
           RobustStorageBufferAccessSizeAlignment = robustStorageBufferAccessSizeAlignment;
           RobustUniformBufferAccessSizeAlignment = robustUniformBufferAccessSizeAlignment;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ulong RobustStorageBufferAccessSizeAlignment;
/// <summary></summary>
        public ulong RobustUniformBufferAccessSizeAlignment;
    }
}
