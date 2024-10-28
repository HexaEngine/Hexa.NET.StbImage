// See https://aka.ms/new-console-template for more information
using CppAst;
using HexaGen;
using HexaGen.Patching;


CsCodeGeneratorConfig generatorSettings = CsCodeGeneratorConfig.Load("generator.json");
CppParserOptions options = new()
{
    ParseMacros = true,
    ParseComments = true,
    ParseSystemIncludes = true,
    ParseAsCpp = true,
    AutoSquashTypedef = true,
};
options.AdditionalArguments.Add("-Wno-narrowing");
CsCodeGenerator generator = new(generatorSettings);
generator.LogToConsole();
generator.PatchEngine.RegisterPrePatch(new NamingPatch(["Stbir","Stbi" ], NamingPatchOptions.None));
generator.Generate(options, "include/main.h", "../../../../Hexa.NET.StbImage/Generated");