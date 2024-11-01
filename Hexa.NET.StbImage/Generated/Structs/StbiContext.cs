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
	/// stbi__context structure is our basic context used by all images, so it<br/>
	/// contains all the IO context, plus some basic image information<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "stbi__context")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct StbiContext
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "img_x")]
		[NativeName(NativeNameType.Type, "stbi__uint32")]
		public uint ImgX;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "img_y")]
		[NativeName(NativeNameType.Type, "stbi__uint32")]
		public uint ImgY;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "img_n")]
		[NativeName(NativeNameType.Type, "int")]
		public int ImgN;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "img_out_n")]
		[NativeName(NativeNameType.Type, "int")]
		public int ImgOutN;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "io")]
		[NativeName(NativeNameType.Type, "stbi_io_callbacks")]
		public StbiIoCallbacks Io;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "io_user_data")]
		[NativeName(NativeNameType.Type, "void*")]
		public unsafe void* IoUserData;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "read_from_callbacks")]
		[NativeName(NativeNameType.Type, "int")]
		public int ReadFromCallbacks;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "buflen")]
		[NativeName(NativeNameType.Type, "int")]
		public int Buflen;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "buffer_start")]
		[NativeName(NativeNameType.Type, "stbi_uc[128]")]
		public byte BufferStart_0;
		public byte BufferStart_1;
		public byte BufferStart_2;
		public byte BufferStart_3;
		public byte BufferStart_4;
		public byte BufferStart_5;
		public byte BufferStart_6;
		public byte BufferStart_7;
		public byte BufferStart_8;
		public byte BufferStart_9;
		public byte BufferStart_10;
		public byte BufferStart_11;
		public byte BufferStart_12;
		public byte BufferStart_13;
		public byte BufferStart_14;
		public byte BufferStart_15;
		public byte BufferStart_16;
		public byte BufferStart_17;
		public byte BufferStart_18;
		public byte BufferStart_19;
		public byte BufferStart_20;
		public byte BufferStart_21;
		public byte BufferStart_22;
		public byte BufferStart_23;
		public byte BufferStart_24;
		public byte BufferStart_25;
		public byte BufferStart_26;
		public byte BufferStart_27;
		public byte BufferStart_28;
		public byte BufferStart_29;
		public byte BufferStart_30;
		public byte BufferStart_31;
		public byte BufferStart_32;
		public byte BufferStart_33;
		public byte BufferStart_34;
		public byte BufferStart_35;
		public byte BufferStart_36;
		public byte BufferStart_37;
		public byte BufferStart_38;
		public byte BufferStart_39;
		public byte BufferStart_40;
		public byte BufferStart_41;
		public byte BufferStart_42;
		public byte BufferStart_43;
		public byte BufferStart_44;
		public byte BufferStart_45;
		public byte BufferStart_46;
		public byte BufferStart_47;
		public byte BufferStart_48;
		public byte BufferStart_49;
		public byte BufferStart_50;
		public byte BufferStart_51;
		public byte BufferStart_52;
		public byte BufferStart_53;
		public byte BufferStart_54;
		public byte BufferStart_55;
		public byte BufferStart_56;
		public byte BufferStart_57;
		public byte BufferStart_58;
		public byte BufferStart_59;
		public byte BufferStart_60;
		public byte BufferStart_61;
		public byte BufferStart_62;
		public byte BufferStart_63;
		public byte BufferStart_64;
		public byte BufferStart_65;
		public byte BufferStart_66;
		public byte BufferStart_67;
		public byte BufferStart_68;
		public byte BufferStart_69;
		public byte BufferStart_70;
		public byte BufferStart_71;
		public byte BufferStart_72;
		public byte BufferStart_73;
		public byte BufferStart_74;
		public byte BufferStart_75;
		public byte BufferStart_76;
		public byte BufferStart_77;
		public byte BufferStart_78;
		public byte BufferStart_79;
		public byte BufferStart_80;
		public byte BufferStart_81;
		public byte BufferStart_82;
		public byte BufferStart_83;
		public byte BufferStart_84;
		public byte BufferStart_85;
		public byte BufferStart_86;
		public byte BufferStart_87;
		public byte BufferStart_88;
		public byte BufferStart_89;
		public byte BufferStart_90;
		public byte BufferStart_91;
		public byte BufferStart_92;
		public byte BufferStart_93;
		public byte BufferStart_94;
		public byte BufferStart_95;
		public byte BufferStart_96;
		public byte BufferStart_97;
		public byte BufferStart_98;
		public byte BufferStart_99;
		public byte BufferStart_100;
		public byte BufferStart_101;
		public byte BufferStart_102;
		public byte BufferStart_103;
		public byte BufferStart_104;
		public byte BufferStart_105;
		public byte BufferStart_106;
		public byte BufferStart_107;
		public byte BufferStart_108;
		public byte BufferStart_109;
		public byte BufferStart_110;
		public byte BufferStart_111;
		public byte BufferStart_112;
		public byte BufferStart_113;
		public byte BufferStart_114;
		public byte BufferStart_115;
		public byte BufferStart_116;
		public byte BufferStart_117;
		public byte BufferStart_118;
		public byte BufferStart_119;
		public byte BufferStart_120;
		public byte BufferStart_121;
		public byte BufferStart_122;
		public byte BufferStart_123;
		public byte BufferStart_124;
		public byte BufferStart_125;
		public byte BufferStart_126;
		public byte BufferStart_127;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "callback_already_read")]
		[NativeName(NativeNameType.Type, "int")]
		public int CallbackAlreadyRead;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "img_buffer")]
		[NativeName(NativeNameType.Type, "stbi_uc*")]
		public unsafe byte* ImgBuffer;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "img_buffer_end")]
		[NativeName(NativeNameType.Type, "stbi_uc*")]
		public unsafe byte* ImgBufferEnd;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "img_buffer_original")]
		[NativeName(NativeNameType.Type, "stbi_uc*")]
		public unsafe byte* ImgBufferOriginal;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "img_buffer_original_end")]
		[NativeName(NativeNameType.Type, "stbi_uc*")]
		public unsafe byte* ImgBufferOriginalEnd;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StbiContext(uint imgX = default, uint imgY = default, int imgN = default, int imgOutN = default, StbiIoCallbacks io = default, void* ioUserData = default, int readFromCallbacks = default, int buflen = default, byte* bufferStart = default, int callbackAlreadyRead = default, byte* imgBuffer = default, byte* imgBufferEnd = default, byte* imgBufferOriginal = default, byte* imgBufferOriginalEnd = default)
		{
			ImgX = imgX;
			ImgY = imgY;
			ImgN = imgN;
			ImgOutN = imgOutN;
			Io = io;
			IoUserData = ioUserData;
			ReadFromCallbacks = readFromCallbacks;
			Buflen = buflen;
			if (bufferStart != default(byte*))
			{
				BufferStart_0 = bufferStart[0];
				BufferStart_1 = bufferStart[1];
				BufferStart_2 = bufferStart[2];
				BufferStart_3 = bufferStart[3];
				BufferStart_4 = bufferStart[4];
				BufferStart_5 = bufferStart[5];
				BufferStart_6 = bufferStart[6];
				BufferStart_7 = bufferStart[7];
				BufferStart_8 = bufferStart[8];
				BufferStart_9 = bufferStart[9];
				BufferStart_10 = bufferStart[10];
				BufferStart_11 = bufferStart[11];
				BufferStart_12 = bufferStart[12];
				BufferStart_13 = bufferStart[13];
				BufferStart_14 = bufferStart[14];
				BufferStart_15 = bufferStart[15];
				BufferStart_16 = bufferStart[16];
				BufferStart_17 = bufferStart[17];
				BufferStart_18 = bufferStart[18];
				BufferStart_19 = bufferStart[19];
				BufferStart_20 = bufferStart[20];
				BufferStart_21 = bufferStart[21];
				BufferStart_22 = bufferStart[22];
				BufferStart_23 = bufferStart[23];
				BufferStart_24 = bufferStart[24];
				BufferStart_25 = bufferStart[25];
				BufferStart_26 = bufferStart[26];
				BufferStart_27 = bufferStart[27];
				BufferStart_28 = bufferStart[28];
				BufferStart_29 = bufferStart[29];
				BufferStart_30 = bufferStart[30];
				BufferStart_31 = bufferStart[31];
				BufferStart_32 = bufferStart[32];
				BufferStart_33 = bufferStart[33];
				BufferStart_34 = bufferStart[34];
				BufferStart_35 = bufferStart[35];
				BufferStart_36 = bufferStart[36];
				BufferStart_37 = bufferStart[37];
				BufferStart_38 = bufferStart[38];
				BufferStart_39 = bufferStart[39];
				BufferStart_40 = bufferStart[40];
				BufferStart_41 = bufferStart[41];
				BufferStart_42 = bufferStart[42];
				BufferStart_43 = bufferStart[43];
				BufferStart_44 = bufferStart[44];
				BufferStart_45 = bufferStart[45];
				BufferStart_46 = bufferStart[46];
				BufferStart_47 = bufferStart[47];
				BufferStart_48 = bufferStart[48];
				BufferStart_49 = bufferStart[49];
				BufferStart_50 = bufferStart[50];
				BufferStart_51 = bufferStart[51];
				BufferStart_52 = bufferStart[52];
				BufferStart_53 = bufferStart[53];
				BufferStart_54 = bufferStart[54];
				BufferStart_55 = bufferStart[55];
				BufferStart_56 = bufferStart[56];
				BufferStart_57 = bufferStart[57];
				BufferStart_58 = bufferStart[58];
				BufferStart_59 = bufferStart[59];
				BufferStart_60 = bufferStart[60];
				BufferStart_61 = bufferStart[61];
				BufferStart_62 = bufferStart[62];
				BufferStart_63 = bufferStart[63];
				BufferStart_64 = bufferStart[64];
				BufferStart_65 = bufferStart[65];
				BufferStart_66 = bufferStart[66];
				BufferStart_67 = bufferStart[67];
				BufferStart_68 = bufferStart[68];
				BufferStart_69 = bufferStart[69];
				BufferStart_70 = bufferStart[70];
				BufferStart_71 = bufferStart[71];
				BufferStart_72 = bufferStart[72];
				BufferStart_73 = bufferStart[73];
				BufferStart_74 = bufferStart[74];
				BufferStart_75 = bufferStart[75];
				BufferStart_76 = bufferStart[76];
				BufferStart_77 = bufferStart[77];
				BufferStart_78 = bufferStart[78];
				BufferStart_79 = bufferStart[79];
				BufferStart_80 = bufferStart[80];
				BufferStart_81 = bufferStart[81];
				BufferStart_82 = bufferStart[82];
				BufferStart_83 = bufferStart[83];
				BufferStart_84 = bufferStart[84];
				BufferStart_85 = bufferStart[85];
				BufferStart_86 = bufferStart[86];
				BufferStart_87 = bufferStart[87];
				BufferStart_88 = bufferStart[88];
				BufferStart_89 = bufferStart[89];
				BufferStart_90 = bufferStart[90];
				BufferStart_91 = bufferStart[91];
				BufferStart_92 = bufferStart[92];
				BufferStart_93 = bufferStart[93];
				BufferStart_94 = bufferStart[94];
				BufferStart_95 = bufferStart[95];
				BufferStart_96 = bufferStart[96];
				BufferStart_97 = bufferStart[97];
				BufferStart_98 = bufferStart[98];
				BufferStart_99 = bufferStart[99];
				BufferStart_100 = bufferStart[100];
				BufferStart_101 = bufferStart[101];
				BufferStart_102 = bufferStart[102];
				BufferStart_103 = bufferStart[103];
				BufferStart_104 = bufferStart[104];
				BufferStart_105 = bufferStart[105];
				BufferStart_106 = bufferStart[106];
				BufferStart_107 = bufferStart[107];
				BufferStart_108 = bufferStart[108];
				BufferStart_109 = bufferStart[109];
				BufferStart_110 = bufferStart[110];
				BufferStart_111 = bufferStart[111];
				BufferStart_112 = bufferStart[112];
				BufferStart_113 = bufferStart[113];
				BufferStart_114 = bufferStart[114];
				BufferStart_115 = bufferStart[115];
				BufferStart_116 = bufferStart[116];
				BufferStart_117 = bufferStart[117];
				BufferStart_118 = bufferStart[118];
				BufferStart_119 = bufferStart[119];
				BufferStart_120 = bufferStart[120];
				BufferStart_121 = bufferStart[121];
				BufferStart_122 = bufferStart[122];
				BufferStart_123 = bufferStart[123];
				BufferStart_124 = bufferStart[124];
				BufferStart_125 = bufferStart[125];
				BufferStart_126 = bufferStart[126];
				BufferStart_127 = bufferStart[127];
			}
			CallbackAlreadyRead = callbackAlreadyRead;
			ImgBuffer = imgBuffer;
			ImgBufferEnd = imgBufferEnd;
			ImgBufferOriginal = imgBufferOriginal;
			ImgBufferOriginalEnd = imgBufferOriginalEnd;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StbiContext(uint imgX = default, uint imgY = default, int imgN = default, int imgOutN = default, StbiIoCallbacks io = default, void* ioUserData = default, int readFromCallbacks = default, int buflen = default, Span<byte> bufferStart = default, int callbackAlreadyRead = default, byte* imgBuffer = default, byte* imgBufferEnd = default, byte* imgBufferOriginal = default, byte* imgBufferOriginalEnd = default)
		{
			ImgX = imgX;
			ImgY = imgY;
			ImgN = imgN;
			ImgOutN = imgOutN;
			Io = io;
			IoUserData = ioUserData;
			ReadFromCallbacks = readFromCallbacks;
			Buflen = buflen;
			if (bufferStart != default(Span<byte>))
			{
				BufferStart_0 = bufferStart[0];
				BufferStart_1 = bufferStart[1];
				BufferStart_2 = bufferStart[2];
				BufferStart_3 = bufferStart[3];
				BufferStart_4 = bufferStart[4];
				BufferStart_5 = bufferStart[5];
				BufferStart_6 = bufferStart[6];
				BufferStart_7 = bufferStart[7];
				BufferStart_8 = bufferStart[8];
				BufferStart_9 = bufferStart[9];
				BufferStart_10 = bufferStart[10];
				BufferStart_11 = bufferStart[11];
				BufferStart_12 = bufferStart[12];
				BufferStart_13 = bufferStart[13];
				BufferStart_14 = bufferStart[14];
				BufferStart_15 = bufferStart[15];
				BufferStart_16 = bufferStart[16];
				BufferStart_17 = bufferStart[17];
				BufferStart_18 = bufferStart[18];
				BufferStart_19 = bufferStart[19];
				BufferStart_20 = bufferStart[20];
				BufferStart_21 = bufferStart[21];
				BufferStart_22 = bufferStart[22];
				BufferStart_23 = bufferStart[23];
				BufferStart_24 = bufferStart[24];
				BufferStart_25 = bufferStart[25];
				BufferStart_26 = bufferStart[26];
				BufferStart_27 = bufferStart[27];
				BufferStart_28 = bufferStart[28];
				BufferStart_29 = bufferStart[29];
				BufferStart_30 = bufferStart[30];
				BufferStart_31 = bufferStart[31];
				BufferStart_32 = bufferStart[32];
				BufferStart_33 = bufferStart[33];
				BufferStart_34 = bufferStart[34];
				BufferStart_35 = bufferStart[35];
				BufferStart_36 = bufferStart[36];
				BufferStart_37 = bufferStart[37];
				BufferStart_38 = bufferStart[38];
				BufferStart_39 = bufferStart[39];
				BufferStart_40 = bufferStart[40];
				BufferStart_41 = bufferStart[41];
				BufferStart_42 = bufferStart[42];
				BufferStart_43 = bufferStart[43];
				BufferStart_44 = bufferStart[44];
				BufferStart_45 = bufferStart[45];
				BufferStart_46 = bufferStart[46];
				BufferStart_47 = bufferStart[47];
				BufferStart_48 = bufferStart[48];
				BufferStart_49 = bufferStart[49];
				BufferStart_50 = bufferStart[50];
				BufferStart_51 = bufferStart[51];
				BufferStart_52 = bufferStart[52];
				BufferStart_53 = bufferStart[53];
				BufferStart_54 = bufferStart[54];
				BufferStart_55 = bufferStart[55];
				BufferStart_56 = bufferStart[56];
				BufferStart_57 = bufferStart[57];
				BufferStart_58 = bufferStart[58];
				BufferStart_59 = bufferStart[59];
				BufferStart_60 = bufferStart[60];
				BufferStart_61 = bufferStart[61];
				BufferStart_62 = bufferStart[62];
				BufferStart_63 = bufferStart[63];
				BufferStart_64 = bufferStart[64];
				BufferStart_65 = bufferStart[65];
				BufferStart_66 = bufferStart[66];
				BufferStart_67 = bufferStart[67];
				BufferStart_68 = bufferStart[68];
				BufferStart_69 = bufferStart[69];
				BufferStart_70 = bufferStart[70];
				BufferStart_71 = bufferStart[71];
				BufferStart_72 = bufferStart[72];
				BufferStart_73 = bufferStart[73];
				BufferStart_74 = bufferStart[74];
				BufferStart_75 = bufferStart[75];
				BufferStart_76 = bufferStart[76];
				BufferStart_77 = bufferStart[77];
				BufferStart_78 = bufferStart[78];
				BufferStart_79 = bufferStart[79];
				BufferStart_80 = bufferStart[80];
				BufferStart_81 = bufferStart[81];
				BufferStart_82 = bufferStart[82];
				BufferStart_83 = bufferStart[83];
				BufferStart_84 = bufferStart[84];
				BufferStart_85 = bufferStart[85];
				BufferStart_86 = bufferStart[86];
				BufferStart_87 = bufferStart[87];
				BufferStart_88 = bufferStart[88];
				BufferStart_89 = bufferStart[89];
				BufferStart_90 = bufferStart[90];
				BufferStart_91 = bufferStart[91];
				BufferStart_92 = bufferStart[92];
				BufferStart_93 = bufferStart[93];
				BufferStart_94 = bufferStart[94];
				BufferStart_95 = bufferStart[95];
				BufferStart_96 = bufferStart[96];
				BufferStart_97 = bufferStart[97];
				BufferStart_98 = bufferStart[98];
				BufferStart_99 = bufferStart[99];
				BufferStart_100 = bufferStart[100];
				BufferStart_101 = bufferStart[101];
				BufferStart_102 = bufferStart[102];
				BufferStart_103 = bufferStart[103];
				BufferStart_104 = bufferStart[104];
				BufferStart_105 = bufferStart[105];
				BufferStart_106 = bufferStart[106];
				BufferStart_107 = bufferStart[107];
				BufferStart_108 = bufferStart[108];
				BufferStart_109 = bufferStart[109];
				BufferStart_110 = bufferStart[110];
				BufferStart_111 = bufferStart[111];
				BufferStart_112 = bufferStart[112];
				BufferStart_113 = bufferStart[113];
				BufferStart_114 = bufferStart[114];
				BufferStart_115 = bufferStart[115];
				BufferStart_116 = bufferStart[116];
				BufferStart_117 = bufferStart[117];
				BufferStart_118 = bufferStart[118];
				BufferStart_119 = bufferStart[119];
				BufferStart_120 = bufferStart[120];
				BufferStart_121 = bufferStart[121];
				BufferStart_122 = bufferStart[122];
				BufferStart_123 = bufferStart[123];
				BufferStart_124 = bufferStart[124];
				BufferStart_125 = bufferStart[125];
				BufferStart_126 = bufferStart[126];
				BufferStart_127 = bufferStart[127];
			}
			CallbackAlreadyRead = callbackAlreadyRead;
			ImgBuffer = imgBuffer;
			ImgBufferEnd = imgBufferEnd;
			ImgBufferOriginal = imgBufferOriginal;
			ImgBufferOriginalEnd = imgBufferOriginalEnd;
		}


	}

}
