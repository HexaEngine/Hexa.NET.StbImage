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
	[NativeName(NativeNameType.StructOrClass, "stbir__scale_info")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct StbirScaleInfo
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "input_full_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int InputFullSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "output_sub_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int OutputSubSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "scale")]
		[NativeName(NativeNameType.Type, "float")]
		public float Scale;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "inv_scale")]
		[NativeName(NativeNameType.Type, "float")]
		public float InvScale;

		/// <summary>
		/// starting shift in output pixel space (in pixels)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pixel_shift")]
		[NativeName(NativeNameType.Type, "float")]
		public float PixelShift;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "scale_is_rational")]
		[NativeName(NativeNameType.Type, "int")]
		public int ScaleIsRational;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "scale_numerator")]
		[NativeName(NativeNameType.Type, "stbir_uint32")]
		public uint ScaleNumerator;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "scale_denominator")]
		[NativeName(NativeNameType.Type, "stbir_uint32")]
		public uint ScaleDenominator;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StbirScaleInfo(int inputFullSize = default, int outputSubSize = default, float scale = default, float invScale = default, float pixelShift = default, int scaleIsRational = default, uint scaleNumerator = default, uint scaleDenominator = default)
		{
			InputFullSize = inputFullSize;
			OutputSubSize = outputSubSize;
			Scale = scale;
			InvScale = invScale;
			PixelShift = pixelShift;
			ScaleIsRational = scaleIsRational;
			ScaleNumerator = scaleNumerator;
			ScaleDenominator = scaleDenominator;
		}


	}

}
