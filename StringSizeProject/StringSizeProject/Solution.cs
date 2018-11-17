using System;
using System.Collections.Generic;
using System.Text;

namespace StringSizeProject
{
    //Given a sentence and a maxLineSize break the sentence into a list of strings where
    //the word order is preserved and a line is a subset of the sentence less than the maxLineSize
    public class Solution
    {
        public static List<string> SolveWords(string sentence, int maxLineSize)
        {
            var lines = new List<string>();

            var subString = sentence;

            while (subString.Length > 0)
            {
                lines.Add(AlternateGetLine(ref subString, maxLineSize));
            }

            return lines;
        }

        public static string GetLine(ref string subSentence, int maxLineSize)
        {
            var line = string.Empty;

            if (subSentence.Length > maxLineSize && subSentence.IndexOf(' ') == -1)
            {
                throw new Exception($"Cannot add {subSentence} to line because it is longer than the max line size");
            }

            if (subSentence.IndexOf(' ') > maxLineSize)
            {
                throw new Exception("Cannot add a word to the line because it is longer than the max line size");
            }

            if (subSentence.Length <= maxLineSize)
            {
                line = subSentence;
                subSentence = "";
            }
            
            var i = 0;
            var lastIndex = -1;
            while ((i = subSentence.IndexOf(' ', i)) != -1 && i <= maxLineSize)
            {

                line = subSentence.Substring(0, i);
                lastIndex = i;

                i++;
            }

            subSentence = subSentence.Remove(0, lastIndex + 1);

            return line;
        }

        public static string AlternateGetLine(ref string subSentence, int maxLineSize)
        {
            var line = string.Empty;

            var firstSpaceIndex = subSentence.IndexOf(' ');

            if (subSentence.Length > maxLineSize && firstSpaceIndex == -1)
            {
                throw new Exception($"Cannot add {subSentence} to line because it is longer than the max line size");
            }

            if (firstSpaceIndex > maxLineSize)
            {
                throw new Exception("Cannot add a word to the line because it is longer than the max line size");
            }

            if (subSentence.Length <= maxLineSize)
            {
                line = subSentence;
                subSentence = "";
            }
            else
            {
                var index = subSentence.Substring(0, maxLineSize + 1).LastIndexOf(' ');

                line = subSentence.Substring(0, index);

                subSentence = subSentence.Remove(0, index).Trim();
            }
            
            return line;
        }
    }
}
