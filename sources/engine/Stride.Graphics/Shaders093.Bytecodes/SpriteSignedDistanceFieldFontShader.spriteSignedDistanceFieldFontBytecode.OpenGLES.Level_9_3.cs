﻿#if STRIDE_GRAPHICS_API_OPENGLES
//------------------------------------------------------------------------------
// <auto-generated>
//     Stride Effect Compiler File Generated:
//     Effect [SpriteSignedDistanceFieldFontShader]
//
//     Command Line: C:\dev\stride\sources\engine\Stride.Graphics\Shaders093.Bytecodes\..\..\..\..\sources\assets\Stride.Core.Assets.CompilerApp\bin\Debug\net472\Stride.Core.Assets.CompilerApp.exe --platform=Windows --property:RuntimeIdentifier=win-opengles --output-path=C:\dev\stride\sources\engine\Stride.Graphics\Shaders093.Bytecodes\obj\app_data --build-path=C:\dev\stride\sources\engine\Stride.Graphics\Shaders093.Bytecodes\obj\build_app_data --package-file=Graphics.sdpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stride.Graphics 
{
    internal partial class SpriteSignedDistanceFieldFontShader
    {
        private static readonly byte[] spriteSignedDistanceFieldFontBytecode = new byte[] {
7, 192, 254, 239, 0, 0, 9, 0, 0, 0, 0, 0, 22, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 80, 111, 105, 110, 116, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 23, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 76, 105, 110, 101, 97, 114, 83, 97, 109, 112, 108, 101, 114, 21, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 
0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 29, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 76, 105, 110, 101, 97, 114, 66, 111, 114, 100, 101, 114, 83, 97, 109, 
112, 108, 101, 114, 21, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 44, 84, 101, 120, 116, 117, 
114, 105, 110, 103, 46, 76, 105, 110, 101, 97, 114, 67, 108, 97, 109, 112, 67, 111, 109, 112, 97, 114, 101, 76, 101, 115, 115, 69, 113, 117, 97, 108, 83, 97, 109, 112, 108, 101, 114, 148, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 4, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 28, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 65, 110, 105, 115, 111, 116, 114, 111, 112, 105, 99, 83, 97, 109, 112, 108, 101, 114, 85, 0, 0, 0, 3, 0, 
0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 34, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 65, 110, 105, 115, 111, 
116, 114, 111, 112, 105, 99, 82, 101, 112, 101, 97, 116, 83, 97, 109, 112, 108, 101, 114, 85, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 
255, 127, 255, 255, 255, 127, 127, 0, 0, 28, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 80, 111, 105, 110, 116, 82, 101, 112, 101, 97, 116, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 29, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 76, 105, 110, 101, 97, 114, 82, 101, 112, 101, 97, 116, 83, 97, 109, 112, 108, 101, 114, 21, 0, 0, 0, 1, 0, 
0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 23, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 82, 101, 112, 101, 97, 
116, 83, 97, 109, 112, 108, 101, 114, 21, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 3, 0, 0, 
0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 10, 0, 0, 0, 26, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 7, 80, 101, 114, 68, 114, 97, 119, 0, 7, 80, 101, 114, 68, 114, 97, 119, 1, 0, 
0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 0, 0, 7, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 
1, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 64, 0, 
0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 64, 0, 0, 0, 1, 1, 0, 26, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 46, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 
109, 0, 20, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 51, 0, 0, 0, 0, 64, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 8, 80, 79, 83, 73, 84, 73, 79, 78, 0, 0, 0, 0, 0, 8, 
84, 69, 88, 67, 79, 79, 82, 68, 0, 0, 0, 0, 0, 5, 67, 79, 76, 79, 82, 0, 0, 0, 0, 0, 6, 0, 0, 0, 35, 83, 112, 114, 105, 116, 101, 83, 105, 103, 110, 101, 100, 68, 105, 115, 116, 97, 110, 99, 101, 70, 105, 101, 108, 100, 70, 111, 110, 116, 83, 104, 97, 100, 101, 114, 
1, 182, 30, 36, 111, 246, 180, 175, 213, 1, 191, 88, 116, 137, 233, 235, 105, 10, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 1, 103, 177, 47, 3, 221, 157, 52, 231, 107, 111, 207, 181, 23, 175, 186, 140, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 1, 227, 114, 5, 111, 246, 192, 
110, 218, 184, 233, 136, 65, 74, 143, 117, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 145, 192, 234, 138, 174, 10, 69, 202, 0, 87, 138, 64, 132, 250, 54, 7, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 102, 5, 246, 130, 48, 38, 110, 255, 43, 200, 
180, 232, 16, 46, 222, 107, 23, 83, 105, 103, 110, 101, 100, 68, 105, 115, 116, 97, 110, 99, 101, 70, 105, 101, 108, 100, 70, 111, 110, 116, 1, 172, 15, 189, 95, 73, 121, 86, 178, 142, 238, 98, 20, 99, 98, 230, 42, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 3, 164, 170, 205, 96, 212, 
38, 9, 196, 208, 133, 38, 72, 208, 185, 170, 0, 85, 7, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 13, 10, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 13, 10, 112, 114, 101, 99, 105, 115, 
105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 105, 110, 116, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 
114, 67, 117, 98, 101, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 
109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 
111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 
112, 108, 101, 114, 67, 117, 98, 101, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 
108, 101, 114, 50, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 
13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 13, 10, 35, 100, 101, 102, 105, 110, 101, 32, 116, 101, 120, 101, 108, 70, 101, 116, 99, 104, 66, 117, 102, 102, 101, 114, 80, 108, 97, 
99, 101, 104, 111, 108, 100, 101, 114, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 
99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 
110, 95, 105, 100, 48, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 
10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 73, 78, 
80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 118, 
101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 59, 13, 10, 125, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 32, 117, 110, 105, 102, 111, 114, 109, 32, 80, 101, 114, 68, 114, 97, 119, 32, 123, 13, 10, 32, 32, 32, 32, 109, 97, 116, 52, 
32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 51, 59, 13, 10, 125, 59, 13, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 
76, 79, 82, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 76, 
79, 82, 48, 59, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 67, 111, 108, 
111, 114, 95, 105, 100, 55, 52, 32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 
10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 
97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 
115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 
108, 111, 114, 95, 105, 100, 55, 52, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 
48, 32, 61, 32, 40, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 32, 42, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 51, 41, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 
85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 
100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 
114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 59, 13, 10, 32, 32, 32, 32, 103, 
108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 
95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 59, 
13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 42, 32, 50, 46, 48, 32, 45, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 119, 59, 13, 10, 32, 32, 32, 32, 
103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 59, 13, 10, 125, 13, 10, 0, 5, 0, 0, 0, 1, 234, 231, 203, 197, 200, 208, 181, 126, 130, 235, 83, 226, 241, 23, 141, 48, 0, 29, 11, 0, 0, 35, 
118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 13, 10, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 105, 110, 116, 59, 13, 10, 
112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 
101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 112, 
114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 13, 
10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 13, 10, 112, 114, 101, 99, 105, 
115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 
110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 
32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 13, 10, 35, 100, 101, 102, 105, 110, 101, 32, 116, 101, 120, 101, 108, 70, 101, 116, 99, 104, 66, 117, 102, 102, 101, 114, 80, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114, 13, 10, 115, 116, 114, 117, 99, 116, 
32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 59, 13, 10, 
32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 
108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 73, 78, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 
110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 59, 13, 10, 125, 59, 13, 10, 117, 110, 105, 102, 111, 
114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 108, 111, 99, 97, 116, 105, 111, 110, 32, 61, 32, 48, 41, 32, 32, 
111, 117, 116, 32, 118, 101, 99, 52, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 
10, 105, 110, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 102, 108, 111, 97, 116, 32, 109, 101, 100, 105, 97, 110, 95, 105, 100, 51, 40, 102, 108, 111, 97, 116, 32, 114, 44, 32, 102, 108, 111, 97, 116, 32, 103, 44, 32, 102, 108, 111, 97, 116, 32, 98, 41, 13, 
10, 123, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 109, 97, 120, 40, 109, 105, 110, 40, 114, 44, 32, 103, 41, 44, 32, 109, 105, 110, 40, 109, 97, 120, 40, 114, 44, 32, 103, 41, 44, 32, 98, 41, 41, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 70, 111, 110, 116, 67, 
111, 108, 111, 114, 95, 105, 100, 52, 40, 118, 101, 99, 52, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 32, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 44, 32, 102, 108, 
111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 61, 32, 99, 108, 97, 109, 112, 40, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 
110, 101, 115, 115, 44, 32, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 48, 46, 50, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 115, 104, 97, 114, 112, 110, 101, 115, 115, 77, 97, 103, 110, 105, 116, 117, 100, 101, 32, 61, 32, 48, 46, 53, 59, 13, 10, 32, 32, 32, 32, 
102, 108, 111, 97, 116, 32, 97, 120, 105, 115, 68, 105, 115, 116, 97, 110, 99, 101, 32, 61, 32, 48, 46, 52, 32, 45, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 109, 101, 100, 105, 97, 110, 68, 105, 115, 
116, 97, 110, 99, 101, 32, 61, 32, 109, 101, 100, 105, 97, 110, 95, 105, 100, 51, 40, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 114, 44, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 103, 44, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 
98, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 115, 105, 103, 68, 105, 115, 116, 32, 61, 32, 109, 101, 100, 105, 97, 110, 68, 105, 115, 116, 97, 110, 99, 101, 32, 45, 32, 97, 120, 105, 115, 68, 105, 115, 116, 97, 110, 99, 101, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 
97, 116, 32, 116, 114, 97, 110, 115, 105, 116, 105, 111, 110, 32, 61, 32, 102, 119, 105, 100, 116, 104, 40, 115, 105, 103, 68, 105, 115, 116, 41, 32, 42, 32, 48, 46, 56, 53, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 111, 112, 97, 99, 105, 116, 121, 32, 61, 32, 115, 109, 111, 
111, 116, 104, 115, 116, 101, 112, 40, 45, 116, 114, 97, 110, 115, 105, 116, 105, 111, 110, 44, 32, 116, 114, 97, 110, 115, 105, 116, 105, 111, 110, 44, 32, 115, 105, 103, 68, 105, 115, 116, 41, 59, 13, 10, 32, 32, 32, 32, 111, 112, 97, 99, 105, 116, 121, 32, 42, 61, 32, 111, 112, 97, 99, 105, 
116, 121, 59, 13, 10, 32, 32, 32, 32, 105, 102, 32, 40, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 62, 32, 102, 108, 111, 97, 116, 40, 48, 41, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 102, 
97, 114, 68, 105, 115, 116, 97, 110, 99, 101, 32, 61, 32, 97, 120, 105, 115, 68, 105, 115, 116, 97, 110, 99, 101, 32, 43, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 42, 32, 102, 108, 111, 97, 116, 40, 50, 41, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 
32, 102, 108, 111, 97, 116, 32, 115, 105, 103, 68, 105, 115, 116, 66, 111, 114, 100, 101, 114, 32, 61, 32, 109, 101, 100, 105, 97, 110, 68, 105, 115, 116, 97, 110, 99, 101, 32, 45, 32, 102, 97, 114, 68, 105, 115, 116, 97, 110, 99, 101, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 
111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 76, 105, 110, 101, 32, 61, 32, 115, 104, 97, 114, 112, 110, 101, 115, 115, 77, 97, 103, 110, 105, 116, 117, 100, 101, 32, 42, 32, 115, 105, 103, 68, 105, 115, 116, 66, 111, 114, 100, 101, 114, 32, 47, 32, 102, 119, 105, 100, 116, 104, 40, 115, 105, 103, 
68, 105, 115, 116, 66, 111, 114, 100, 101, 114, 41, 32, 43, 32, 102, 97, 114, 68, 105, 115, 116, 97, 110, 99, 101, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 79, 112, 97, 99, 105, 116, 121, 32, 61, 32, 115, 109, 111, 111, 116, 104, 
115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 102, 108, 111, 97, 116, 40, 49, 41, 44, 32, 98, 111, 114, 100, 101, 114, 76, 105, 110, 101, 41, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 32, 61, 32, 109, 105, 120, 40, 98, 
111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 44, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 40, 98, 111, 114, 100, 101, 114, 79, 112, 97, 99, 105, 116, 121, 41, 41, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 115, 97, 109, 112, 108, 101, 100, 
67, 111, 108, 111, 114, 32, 61, 32, 109, 105, 120, 40, 118, 101, 99, 52, 40, 48, 44, 32, 48, 44, 32, 48, 44, 32, 48, 41, 44, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 40, 111, 112, 97, 99, 105, 116, 121, 41, 41, 59, 13, 10, 32, 32, 32, 32, 114, 101, 
116, 117, 114, 110, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 
41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 44, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 
67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 41, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 53, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 
32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 70, 111, 110, 116, 67, 111, 108, 111, 114, 95, 105, 100, 52, 40, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 115, 116, 114, 101, 97, 109, 115, 41, 44, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 
52, 44, 32, 118, 101, 99, 52, 40, 48, 44, 32, 48, 44, 32, 48, 44, 32, 49, 41, 44, 32, 48, 46, 41, 59, 13, 10, 125, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 80, 83, 95, 73, 78, 80, 85, 84, 32, 95, 48, 105, 110, 112, 
117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 32, 61, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 
111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 103, 108, 95, 
70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 
32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 67, 111, 
108, 111, 114, 95, 105, 100, 55, 52, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 53, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 
32, 32, 32, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 115, 116, 114, 101, 
97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 32, 32, 32, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 95, 48, 111, 117, 
116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 13, 10, 
        };
    }
}
#endif
