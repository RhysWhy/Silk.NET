// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_conservative_raster_pre_snap_triangles")]
    public abstract unsafe partial class NVConservativeRasterPreSnapTriangles : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conservative_raster_pre_snap_triangles";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glConservativeRasterParameteriNV")]
        public abstract void ConservativeRasterParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int param);

        public NVConservativeRasterPreSnapTriangles(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

