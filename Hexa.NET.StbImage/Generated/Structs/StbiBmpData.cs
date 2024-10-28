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
	[NativeName(NativeNameType.StructOrClass, "stbi__bmp_data")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct StbiBmpData
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "bpp")]
		[NativeName(NativeNameType.Type, "int")]
		public int Bpp;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "offset")]
		[NativeName(NativeNameType.Type, "int")]
		public int Offset;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "hsz")]
		[NativeName(NativeNameType.Type, "int")]
		public int Hsz;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "mr")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Mr;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "mg")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Mg;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "mb")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Mb;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ma")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Ma;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "all_a")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint AllA;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "extra_read")]
		[NativeName(NativeNameType.Type, "int")]
		public int ExtraRead;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StbiBmpData(int bpp = default, int offset = default, int hsz = default, uint mr = default, uint mg = default, uint mb = default, uint ma = default, uint allA = default, int extraRead = default)
		{
			Bpp = bpp;
			Offset = offset;
			Hsz = hsz;
			Mr = mr;
			Mg = mg;
			Mb = mb;
			Ma = ma;
			AllA = allA;
			ExtraRead = extraRead;
		}


	}

}