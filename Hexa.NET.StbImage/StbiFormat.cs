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
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "")]
	[Flags]
	public enum StbiFormat : int
	{
		/// <summary>
		/// only used for desired_channels<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBI_default")]
		[NativeName(NativeNameType.Value, "0")]
		StbiDefault = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBI_grey")]
		[NativeName(NativeNameType.Value, "1")]
		StbiGrey = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBI_grey_alpha")]
		[NativeName(NativeNameType.Value, "2")]
		StbiGreyAlpha = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBI_rgb")]
		[NativeName(NativeNameType.Value, "3")]
		StbiRgb = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "STBI_rgb_alpha")]
		[NativeName(NativeNameType.Value, "4")]
		StbiRgbAlpha = unchecked(4),
	}
}
