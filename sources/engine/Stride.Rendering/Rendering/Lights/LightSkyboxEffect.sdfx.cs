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

using Stride.Rendering.Data;
namespace Stride.Rendering.Lights
{
    internal static partial class ShaderMixins
    {
        internal partial class LightSkyboxEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "LightSkyboxShader");
                if (context.GetParam(LightSkyboxShaderKeys.LightDiffuseColor) != null)
                {

                    {
                        var __mixinToCompose__ = context.GetParam(LightSkyboxShaderKeys.LightDiffuseColor);
                        var __subMixin = new ShaderMixinSource();
                        context.PushComposition(mixin, "lightDiffuseColor", __subMixin);
                        context.Mixin(__subMixin, __mixinToCompose__);
                        context.PopComposition();
                    }
                }
                if (context.GetParam(LightSkyboxShaderKeys.LightSpecularColor) != null)
                {

                    {
                        var __mixinToCompose__ = context.GetParam(LightSkyboxShaderKeys.LightSpecularColor);
                        var __subMixin = new ShaderMixinSource();
                        context.PushComposition(mixin, "lightSpecularColor", __subMixin);
                        context.Mixin(__subMixin, __mixinToCompose__);
                        context.PopComposition();
                    }
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("LightSkyboxEffect", new LightSkyboxEffect());
            }
        }
    }
}
