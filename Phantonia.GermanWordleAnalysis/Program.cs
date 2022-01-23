// this is not gonna be optimized, if that would even be possible

using Phantonia.GermanWordleAnalysis;

const double VowelPriority = 1.0D;

const string DictionaryPath = @"..\..\..\..\german.txt";

string[] words = File.ReadAllLines(DictionaryPath);

void OutputResults(AnalysisResult result)
{
    Console.WriteLine($"For {result.NumberOfLetters} letters and vowel priority {result.VowelPriority} " +
                      $"the following words are ideal:");

    foreach (string word in result.IdealWords)
    {
        Console.WriteLine($"- {word.ToUpper()}");
    }

    Console.WriteLine();
}

for (int i = 4; i <= 10; i++)
{
    OutputResults(Analyser.Analyse(words, numberOfLetters: i, vowelPriority: 1.0D));
    OutputResults(Analyser.Analyse(words, numberOfLetters: i, vowelPriority: 1.25D));
}