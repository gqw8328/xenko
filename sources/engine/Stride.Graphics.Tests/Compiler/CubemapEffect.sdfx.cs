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

namespace Test
{
    internal static partial class ShaderMixins
    {
        internal partial class CubemapDisplayEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "ShaderBase");
                context.Mixin(mixin, "TransformationWAndVP");
                context.Mixin(mixin, "AlbedoFlatShading");

                {
                    var __mixinToCompose__ = "ComputeColorTextureCubeBasic";
                    var __subMixin = new ShaderMixinSource();
                    context.PushComposition(mixin, "albedoDiffuse", __subMixin);
                    context.Mixin(__subMixin, __mixinToCompose__, TexturingKeys.TextureCube0);
                    context.PopComposition();
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("CubemapDisplayEffect", new CubemapDisplayEffect());
            }
        }
    }
    internal static partial class ShaderMixins
    {
        internal partial class CubemapEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "ShaderBase");
                context.Mixin(mixin, "TransformationWAndVP");
                context.Mixin(mixin, "AlbedoFlatShading");
                if (context.GetParam(MaterialParameters.AlbedoDiffuse) != null)

                    {
                        var __mixinToCompose__ = context.GetParam(MaterialParameters.AlbedoDiffuse);
                        var __subMixin = new ShaderMixinSource();
                        context.PushComposition(mixin, "albedoDiffuse", __subMixin);
                        context.Mixin(__subMixin, __mixinToCompose__);
                        context.PopComposition();
                    }
                else

                    {
                        var __mixinToCompose__ = "ComputeColorTextureCubeReflect";
                        var __subMixin = new ShaderMixinSource();
                        context.PushComposition(mixin, "albedoDiffuse", __subMixin);
                        context.Mixin(__subMixin, __mixinToCompose__, TexturingKeys.TextureCube0);
                        context.PopComposition();
                    }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("CubemapEffect", new CubemapEffect());
            }
        }
    }
    internal static partial class ShaderMixins
    {
        internal partial class CubemapGeomEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "ShaderBase");
                context.Mixin(mixin, "TransformationWAndVP");
                mixin.AddMacro("MAX_VERTEX_COUNT", 9);
                context.Mixin(mixin, "CameraCube");
                context.Mixin(mixin, "AlbedoFlatShading");
                if (context.GetParam(MaterialParameters.AlbedoDiffuse) != null)

                    {
                        var __mixinToCompose__ = context.GetParam(MaterialParameters.AlbedoDiffuse);
                        var __subMixin = new ShaderMixinSource();
                        context.PushComposition(mixin, "albedoDiffuse", __subMixin);
                        context.Mixin(__subMixin, __mixinToCompose__);
                        context.PopComposition();
                    }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("CubemapGeomEffect", new CubemapGeomEffect());
            }
        }
    }
    internal static partial class ShaderMixins
    {
        internal partial class CubemapIBLEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "StrideBaseShader");
                if (context.ChildEffectName == "StrideGBufferShaderPass")
                {
                    context.Mixin(mixin, "StrideGBufferShaderPass");
                    return;
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("CubemapIBLEffect", new CubemapIBLEffect());
            }
        }
    }
}
