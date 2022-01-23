using System.Collections.Immutable;

namespace Phantonia.GermanWordleAnalysis;

internal readonly record struct AnalysisResult(int NumberOfLetters, double VowelPriority, ImmutableArray<string> IdealWords);
