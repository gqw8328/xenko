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

namespace Stride.Rendering.Skyboxes
{
    public static partial class SkyboxShaderBaseKeys
    {
        public static readonly ValueParameterKey<float> Intensity = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<Matrix> ProjectionInverse = ParameterKeys.NewValue<Matrix>();
        public static readonly ValueParameterKey<Matrix> ViewInverse = ParameterKeys.NewValue<Matrix>();
        public static readonly ValueParameterKey<Matrix> SkyMatrix = ParameterKeys.NewValue<Matrix>();
    }
}
