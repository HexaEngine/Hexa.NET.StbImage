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
	[NativeName(NativeNameType.StructOrClass, "stbir__FP16")]
	[StructLayout(LayoutKind.Explicit)]
	public partial struct StbirFP16
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "u")]
		[NativeName(NativeNameType.Type, "unsigned short")]
		[FieldOffset(0)]
		public ushort U;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StbirFP16(ushort u = default)
		{
			U = u;
		}


	}

}
