using System;
using Xunit;

namespace StringSizeProject.Tests
{
    public class SolutionTests
    {
        [Fact(DisplayName = "SolveWords should return 4 lines for the sentence \"do not step on the broken glass\"")]
        public void SolveWords()
        {
            var maxLineSize = 10;
            var sentence = "do not step on the broken glass";

            var lines = Solution.SolveWords(sentence, maxLineSize);

            Assert.Equal(4, lines.Count);
            Assert.Equal("do not", lines[0]);
            Assert.Equal("step on", lines[1]);
            Assert.Equal("the broken", lines[2]);
            Assert.Equal("glass", lines[3]);
        }

        [Fact(DisplayName = "SolveWords should return 7 lines for the sentence \"breaking is a new song and it's better than an old song\"")]
        public void SolveWords2()
        {
            var maxLineSize = 10;
            var sentence = "breaking is a new song and it's better than an old song";

            var lines = Solution.SolveWords(sentence, maxLineSize);

            Assert.Equal(7, lines.Count);
            Assert.Equal("breaking", lines[0]);
            Assert.Equal("is a new", lines[1]);
            Assert.Equal("song and", lines[2]);
            Assert.Equal("it's", lines[3]);
            Assert.Equal("better", lines[4]);
            Assert.Equal("than an", lines[5]);
            Assert.Equal("old song", lines[6]);
        }

        [Fact(DisplayName = "GetLine should return \"do not\"")]
        public void GetLine()
        {
            var maxLineSize = 10;
            var sentence = "do not step on the broken glass";

            var line = Solution.GetLine(ref sentence, maxLineSize);

            Assert.Equal("do not", line);
        }

        [Fact(DisplayName = "GetLine should pass with a single word less than the max line length")]
        public void GetLineWithSingeWord()
        {
            var maxLineSize = 10;
            var sentence = "hello";

            var line = Solution.GetLine(ref sentence, maxLineSize);

            Assert.Equal("hello", line);
        }

        [Fact(DisplayName = "GetLine should fail with a single word longer than the max line length")]
        public void GetLineShouldFailWithSingleWordLongerThanMax()
        {
            var maxLineSize = 1;
            var sentence = "hello";

            Assert.Throws<Exception>(() => Solution.GetLine(ref sentence, maxLineSize));
        }

        [Fact(DisplayName = "SolveWords should fail if any word exists longer than the max line length")]
        public void SolveWordsShouldFailIfAWordExistsLongerThanMax()
        {
            var maxLineSize = 3;
            var sentence = "for my failure test";

            Assert.Throws<Exception>(() => Solution.SolveWords(sentence, maxLineSize));
        }

        [Fact(DisplayName = "AlternateGetLine should return \"do not\"")]
        public void AlternateGetLine()
        {
            var maxLineSize = 10;
            var sentence = "do not step on the broken glass";

            var line = Solution.AlternateGetLine(ref sentence, maxLineSize);

            Assert.Equal("do not", line);
        }

        [Fact(DisplayName = "AlternateGetLine should pass with a single word less than the max line length")]
        public void AlternateGetLineWithSingeWord()
        {
            var maxLineSize = 10;
            var sentence = "hello";

            var line = Solution.AlternateGetLine(ref sentence, maxLineSize);

            Assert.Equal("hello", line);
        }

        [Fact(DisplayName = "AlternateGetLine should fail with a single word longer than the max line length")]
        public void AlternateGetLineShouldFailWithSingleWordLongerThanMax()
        {
            var maxLineSize = 1;
            var sentence = "hello";

            Assert.Throws<Exception>(() => Solution.AlternateGetLine(ref sentence, maxLineSize));
        }
    }
}
