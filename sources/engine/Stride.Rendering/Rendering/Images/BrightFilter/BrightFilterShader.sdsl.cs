﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

namespace Stride.Rendering.Images
{
    internal static partial class BrightFilterShaderKeys
    {
        public static readonly ValueParameterKey<Color3> ColorModulator = ParameterKeys.NewValue<Color3>();
        public static readonly ValueParameterKey<float> BrightPassSteepness = ParameterKeys.NewValue<float>(2.0f);
        public static readonly ValueParameterKey<float> ThresholdOffset = ParameterKeys.NewValue<float>(0.2f);
    }
}
