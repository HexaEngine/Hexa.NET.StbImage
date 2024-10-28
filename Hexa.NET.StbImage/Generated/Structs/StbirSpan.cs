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
	[NativeName(NativeNameType.StructOrClass, "stbir__span")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct StbirSpan
	{
		/// <summary>
		/// First pixel of decode buffer to write to<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "n0")]
		[NativeName(NativeNameType.Type, "int")]
		public int N0;

		/// <summary>
		/// Last pixel of decode that will be written to<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "n1")]
		[NativeName(NativeNameType.Type, "int")]
		public int N1;

		/// <summary>
		/// Pixel offset into input_scanline<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pixel_offset_for_input")]
		[NativeName(NativeNameType.Type, "int")]
		public int PixelOffsetForInput;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StbirSpan(int n0 = default, int n1 = default, int pixelOffsetForInput = default)
		{
			N0 = n0;
			N1 = n1;
			PixelOffsetForInput = pixelOffsetForInput;
		}


	}

}