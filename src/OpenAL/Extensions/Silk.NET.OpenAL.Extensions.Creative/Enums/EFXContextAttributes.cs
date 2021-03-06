// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Defines new context attributes.
    /// </summary>
    public enum EFXContextAttributes
    {
        /// <summary>
        /// Default: 2
        /// This Context property can be passed to OpenAL during Context creation (alcCreateContext) to
        /// request a maximum number of Auxiliary Sends desired on each Source. It is not guaranteed that the desired
        /// number of sends will be available, so an application should query this property after creating the context
        /// using alcGetIntergerv.
        /// </summary>
        MaxAuxiliarySends = 0x20003
    }
}