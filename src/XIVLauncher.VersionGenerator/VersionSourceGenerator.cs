﻿namespace VersionGenerator;

using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

[Generator]
public class VersionSourceGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.AssemblyVersion", out var version))
            context.AddSource("AppUtil.VersionInfo.g.cs", SourceText.From($@"
// <auto-generated />
namespace XIVLauncher.Core;

public static partial class AppUtil
{{
    public partial class VersionInfo
    {{
        public VersionInfo()
        {{
            Version = (""{context.Compilation.AssemblyName}"", new Version(""{version}""));
        }}
    }}
}}", Encoding.UTF8, SourceHashAlgorithm.Sha256));
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        // No initialization required for this one
    }
}