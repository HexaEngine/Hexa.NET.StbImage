// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.StbImage
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "stbi__pngchunk")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct StbiPngchunk
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "length")]
		[NativeName(NativeNameType.Type, "stbi__uint32")]
		public uint Length;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "stbi__uint32")]
		public uint Type;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StbiPngchunk(uint length = default, uint type = default)
		{
			Length = length;
			Type = type;
		}


	}

}
