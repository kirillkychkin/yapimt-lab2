using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    static class StringMethods
    {
        public static string Concat(string firstString, string secondString)
        {
            string concatenatedResult = firstString + secondString;
            return concatenatedResult;
        }

        public static int Compul(string firstString, string secondString)
        {
            int index = 0;
            char firstChar;
            char secondChar;

            while (index < firstString.Length && index < secondString.Length)
            {
                firstChar = char.ToUpper(firstString[index]);
                secondChar = char.ToUpper(secondString[index]);

                if (firstChar != secondChar)
                {
                    return firstChar - secondChar;
                }

                index++;
            }

            return firstString.Length - secondString.Length;
        }

        public static void Copies(string sourceText, ref string destinationText, int numberOfCopies)
        {
            for (int copyIndex = 0; copyIndex < numberOfCopies; ++copyIndex)
            {
                destinationText += sourceText;
            }
        }

        public static void Delete(ref string text, int startIndex, int length)
        {
            string resultText = "";

            for (int i = 0; i < text.Length; ++i)
            {
                if (i < startIndex || i > startIndex + length - 1)
                {
                    resultText += text[i];
                }
            }

            text = resultText;
        }

        public static int Findwords(string text, string word)
        {
            if (word.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i <= text.Length - word.Length; ++i)
            {
                bool matchFound = true;

                for (int j = 0; j < word.Length; ++j)
                {
                    if (text[i + j] != word[j])
                    {
                        matchFound = false;
                        break;
                    }
                }

                if (matchFound)
                {
                    return i;
                }
            }

            return -1;
        }

        public static void Overlay(ref string baseText, string overlayText, int position)
        {
            if (position < 0)
            {
                return;
            }

            char[] resultText = new char[Math.Max(overlayText.Length + position + 1, baseText.Length)];

            for (int i = 0; i < baseText.Length; ++i)
            {
                resultText[i] = baseText[i];
            }

            for (int i = baseText.Length; i < position; ++i)
            {
                resultText[i] = ' ';
            }

            for (int i = 0; i < overlayText.Length; ++i)
            {
                resultText[i + position] = overlayText[i];
            }

            baseText = new string(resultText);
        }


        public static void Reverse(ref string text)
        {
            string reversedText = "";

            for (int i = text.Length - 1; i >= 0; --i)
            {
                reversedText += text[i];
            }

            text = reversedText;
        }


        public static void StrSet(ref string text, int startIndex, int length, char replacementChar)
        {
            if (startIndex < 0 || length < 0 || startIndex + length > text.Length)
            {
                return;
            }

            char[] textArray = text.ToCharArray();

            for (int i = startIndex; i < startIndex + length; ++i)
            {
                textArray[i] = replacementChar;
            }

            text = new string(textArray);
        }
        public static string Word(string input)
        {
            char[] chars = input.ToCharArray();

            int startIndex = 0;

            while (startIndex < chars.Length && char.IsWhiteSpace(chars[startIndex]))
            {
                startIndex++;
            }

            int endIndex = startIndex;

            while (endIndex < chars.Length && !char.IsWhiteSpace(chars[endIndex]))
            {
                endIndex++;
            }

            if (startIndex < endIndex)
            {
                return new string(chars, startIndex, endIndex - startIndex);
            }

            return string.Empty;
        }

        public static int Words(string inputText)
        {
            int wordCount = 0;
            bool isInsideWord = false;

            for (int currentIndex = 0; currentIndex < inputText.Length; ++currentIndex)
            {
                char currentChar = inputText[currentIndex];

                if (currentChar != ' ' && currentChar != '\n' && currentChar != '\r' && currentChar != '\t')
                {
                    if (!isInsideWord)
                    {
                        wordCount++;
                        isInsideWord = true;
                    }
                }
                else
                {
                    isInsideWord = false;
                }
            }

            return wordCount;
        }

    }
}
