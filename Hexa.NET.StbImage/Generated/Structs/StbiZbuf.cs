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
	/// zlib-from-memory implementation for PNG reading<br/>
	/// because PNG allows splitting the zlib stream arbitrarily,<br/>
	/// and it's annoying structurally to have PNG call ZLIB call PNG,<br/>
	/// we require PNG read all the IDATs and combine them into a single<br/>
	/// memory buffer<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "stbi__zbuf")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct StbiZbuf
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "zbuffer")]
		[NativeName(NativeNameType.Type, "stbi_uc*")]
		public unsafe byte* Zbuffer;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "zbuffer_end")]
		[NativeName(NativeNameType.Type, "stbi_uc*")]
		public unsafe byte* ZbufferEnd;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "num_bits")]
		[NativeName(NativeNameType.Type, "int")]
		public int NumBits;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "hit_zeof_once")]
		[NativeName(NativeNameType.Type, "int")]
		public int HitZeofOnce;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "code_buffer")]
		[NativeName(NativeNameType.Type, "stbi__uint32")]
		public uint CodeBuffer;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "zout")]
		[NativeName(NativeNameType.Type, "char*")]
		public unsafe byte* Zout;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "zout_start")]
		[NativeName(NativeNameType.Type, "char*")]
		public unsafe byte* ZoutStart;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "zout_end")]
		[NativeName(NativeNameType.Type, "char*")]
		public unsafe byte* ZoutEnd;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "z_expandable")]
		[NativeName(NativeNameType.Type, "int")]
		public int ZExpandable;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "z_length")]
		[NativeName(NativeNameType.Type, "stbi__zhuffman")]
		public StbiZhuffman ZLength;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "z_distance")]
		[NativeName(NativeNameType.Type, "stbi__zhuffman")]
		public StbiZhuffman ZDistance;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StbiZbuf(byte* zbuffer = default, byte* zbufferEnd = default, int numBits = default, int hitZeofOnce = default, uint codeBuffer = default, byte* zout = default, byte* zoutStart = default, byte* zoutEnd = default, int zExpandable = default, StbiZhuffman zLength = default, StbiZhuffman zDistance = default)
		{
			Zbuffer = zbuffer;
			ZbufferEnd = zbufferEnd;
			NumBits = numBits;
			HitZeofOnce = hitZeofOnce;
			CodeBuffer = codeBuffer;
			Zout = zout;
			ZoutStart = zoutStart;
			ZoutEnd = zoutEnd;
			ZExpandable = zExpandable;
			ZLength = zLength;
			ZDistance = zDistance;
		}


	}

}
