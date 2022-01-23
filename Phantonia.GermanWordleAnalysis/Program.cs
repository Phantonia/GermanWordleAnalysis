// this is not gonna be optimized, if that would even be possible

using System.Diagnostics;

const int NumberOfLetters = 7;
const double VowelPrioritizer = 1.0D;

const string DictionaryPath = @"..\..\..\..\german.txt";

string[] words = File.ReadAllLines(DictionaryPath);

Dictionary<char, int> frequencies = new();

for (char c = 'a'; c <= 'z'; c++)
{
    frequencies[c] = 0;
}

foreach (string word in words)
{
    foreach (char c in word.ToLower())
    {
        if (char.IsLetter(c))
        {
            frequencies[c]++;
        }
    }
}

long totalLetterCount = 0;

foreach (int frequency in frequencies.Values)
{
    totalLetterCount += frequency;
}

Dictionary<char, double> relativeFrequencies = new();

for (char c = 'a'; c <= 'z'; c++)
{
    relativeFrequencies[c] = (double)frequencies[c] / totalLetterCount;
}

bool EachLetterIsUnique(string word)
{
    Debug.Assert(word == word.ToLower());
    return word.All(c => char.IsLetter(c)) && word.Distinct().Count() == word.Length;
}

double GetRank(string word)
{
    Debug.Assert(word == word.ToLower());

    double sum = 0.0D;

    foreach (char c in word)
    {
        double multiplier = 1.0D;

        if (c is 'a' or 'e' or 'i' or 'o' or 'u')
        {
            // just a quick guess: testing vowels is slightly more important
            // than consonants
            multiplier = VowelPrioritizer;
        }

        sum += relativeFrequencies[c] * multiplier;
    }

    return sum;
}

var query = words.Select(w => w.ToLower()).Where(w => w.Length == NumberOfLetters && EachLetterIsUnique(w)).OrderByDescending(w => GetRank(w));

HashSet<char> usedCharacters = new();

int count = 0;

foreach (string word in query)
{
    if (usedCharacters.Intersect(word).Count() == 0) // the word contains a fresh set of characters
    {
        count++;

        Console.WriteLine($"[{count}]: {word}");
        usedCharacters.UnionWith(word);
    }
}

{ }