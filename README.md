You know the game Wordle which is basically *the* thing in the internet lately? The following words have been proposed to be ideal to start guessing with as they cover a lot of common letters:

* SIREN (or RISEN, they have the same effect)
* OCTAL
* DUMPY

According to how many matches you have with SIREN you might consider also gussing OCTAL and even DUMPY.

I wanted to know these words for a German version of Wordle, and especially also different numbers of letters. Here are my results:

Assume vowels are as important as consonants:

| 4 letters | 5 letters | 6 letters | 7 letters | 8 letters | 9 letters | 10 letters |
|-----------|-----------|-----------|-----------|-----------|-----------|------------|
| RENS      | ERNST     | INSERT    | ANREIST   | INSELART  | RHEINTALS | HALTERINGS |
| THAI      | GHALI     | LOCHAU    | LOGBUCH   |           |           |            |
| KLUG      | DUMPF     |           |           |           |           |            |
| ODBC      |           |           |           |           |           |            |

This is just a quick and dirty project and I have not simulated this (maybe I will in the future) but just from my guess I would think, that vowels are more important than consonants, and my quick guess would be that they are 25% more important.
The analyser has a parameter called `VowelPriority`. The results above are all generated with a vowel priority of 1.0, so that vowels are not prioritized at all. How about we do prioritze them by said 25% with a vowel priority of 1.25?

Here are the results:

| 4 letters | 5 letters | 6 letters | 7 letters | 8 letters | 9 letters | 10 letters |
|-----------|-----------|-----------|-----------|-----------|-----------|------------|
| RENS      | NIERS     | IRENAS    | ANREIST   | ASTURIEN  | REINHAUST | UNGLASIERT |
| THAI      | LAUGT     | FLUCHT    | LOGBUCH   |           |           |            |
| KLUG      |           |           |           |           |           |            |
| FDGB      |           |           |           |           |           |            |