// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_draw_texture")]
    public abstract unsafe partial class NVDrawTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_draw_texture";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="x0">
        /// To be added.
        /// </param>
        /// <param name="y0">
        /// To be added.
        /// </param>
        /// <param name="x1">
        /// To be added.
        /// </param>
        /// <param name="y1">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="s0">
        /// To be added.
        /// </param>
        /// <param name="t0">
        /// To be added.
        /// </param>
        /// <param name="s1">
        /// To be added.
        /// </param>
        /// <param name="t1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawTextureNV")]
        public abstract void DrawTexture([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] float x0, [Flow(FlowDirection.In)] float y0, [Flow(FlowDirection.In)] float x1, [Flow(FlowDirection.In)] float y1, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float s0, [Flow(FlowDirection.In)] float t0, [Flow(FlowDirection.In)] float s1, [Flow(FlowDirection.In)] float t1);

        public NVDrawTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

