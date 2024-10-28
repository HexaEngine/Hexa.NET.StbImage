// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.StbImage
{
	/// <summary>
	/// stbir_pixel_layout specifies:<br/>
	/// number of channels<br/>
	/// order of channels<br/>
	/// whether color is premultiplied by alpha<br/>
	/// for back compatibility, you can cast the old channel count to an stbir_pixel_layout<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "stbir_pixel_layout")]
	[Flags]
	public enum StbirPixelLayout : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_1CHANNEL")]
		[NativeName(NativeNameType.Value, "1")]
		Stbir1Channel = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_2CHANNEL")]
		[NativeName(NativeNameType.Value, "2")]
		Stbir2Channel = unchecked(2),

		/// <summary>
		/// 3-chan, with order specified (for channel flipping)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_RGB")]
		[NativeName(NativeNameType.Value, "3")]
		Rgb = unchecked(3),

		/// <summary>
		/// 3-chan, with order specified (for channel flipping)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_BGR")]
		[NativeName(NativeNameType.Value, "0")]
		Bgr = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_4CHANNEL")]
		[NativeName(NativeNameType.Value, "5")]
		Stbir4Channel = unchecked(5),

		/// <summary>
		/// alpha formats, where alpha is NOT premultiplied into color channels<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_RGBA")]
		[NativeName(NativeNameType.Value, "4")]
		Rgba = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_BGRA")]
		[NativeName(NativeNameType.Value, "6")]
		Bgra = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_ARGB")]
		[NativeName(NativeNameType.Value, "7")]
		Argb = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_ABGR")]
		[NativeName(NativeNameType.Value, "8")]
		Abgr = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_RA")]
		[NativeName(NativeNameType.Value, "9")]
		Ra = unchecked(9),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_AR")]
		[NativeName(NativeNameType.Value, "10")]
		Ar = unchecked(10),

		/// <summary>
		/// alpha formats, where alpha is premultiplied into color channels<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_RGBA_PM")]
		[NativeName(NativeNameType.Value, "11")]
		RgbaPm = unchecked(11),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_BGRA_PM")]
		[NativeName(NativeNameType.Value, "12")]
		BgraPm = unchecked(12),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_ARGB_PM")]
		[NativeName(NativeNameType.Value, "13")]
		ArgbPm = unchecked(13),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_ABGR_PM")]
		[NativeName(NativeNameType.Value, "14")]
		AbgrPm = unchecked(14),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_RA_PM")]
		[NativeName(NativeNameType.Value, "15")]
		RaPm = unchecked(15),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_AR_PM")]
		[NativeName(NativeNameType.Value, "16")]
		ArPm = unchecked(16),

		/// <summary>
		/// alpha formats, where NO alpha weighting is applied at all!<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_RGBA_NO_AW")]
		[NativeName(NativeNameType.Value, "11")]
		RgbaNoAw = unchecked(11),

		/// <summary>
		/// these are just synonyms for the _PM flags (which also do<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_BGRA_NO_AW")]
		[NativeName(NativeNameType.Value, "12")]
		BgraNoAw = unchecked(12),

		/// <summary>
		/// no alpha weighting). These names just make it more clear<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_ARGB_NO_AW")]
		[NativeName(NativeNameType.Value, "13")]
		ArgbNoAw = unchecked(13),

		/// <summary>
		/// for some folks).<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_ABGR_NO_AW")]
		[NativeName(NativeNameType.Value, "14")]
		AbgrNoAw = unchecked(14),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_RA_NO_AW")]
		[NativeName(NativeNameType.Value, "15")]
		RaNoAw = unchecked(15),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBIR_AR_NO_AW")]
		[NativeName(NativeNameType.Value, "16")]
		ArNoAw = unchecked(16),
	}
}