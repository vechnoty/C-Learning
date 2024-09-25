using TextAnalysis;

namespace TestProject1
   
{

    public class Tests
    {
        [Test]
       
        public void ContinuePhrase_DoNothing_WhenWordsCountIsZero()
        {
            var mostFrequentNextWords = new Dictionary<string, string>
        {
            {"x", "y"}
        };

            var actual =
                TextGeneratorTask.ContinuePhrase(mostFrequentNextWords, "x", 0);
            Assert.AreEqual("x", actual);
        }

        [Test]

        public void ReturnResult_WithLexicographicallyFirstBigram_IfBigramsHaveSameFrequency(
            [Values("x y. x z.", "x z. x y.", "x y. x yy.", "x yy. x y")]
        string text)
        {
            var parsedText = SentencesParserTask.ParseSentences(text);
            var expected = new Dictionary<string, string>
        {
            {"x", "y"}
        };

            var actual = FrequencyAnalysisTask.GetMostFrequentNextWords(parsedText);

            Assert.AreEqual(expected, actual, text);
        }

        [Test]
        public void IgnoreSentencesWithSingleWord([Values("x. ax. y. z")] string text)
        {
            var parsedText = SentencesParserTask.ParseSentences(text);
            var expected = new Dictionary<string, string>();

            var actual = FrequencyAnalysisTask.GetMostFrequentNextWords(parsedText);

            Assert.AreEqual(expected, actual, text);
        }

        [Test]

        public void ReturnPairForEveryBigram([Values("x y. y z.", "y z. x y.")] string text)
        {
            var parsedText = SentencesParserTask.ParseSentences(text);
            var expected = new Dictionary<string, string>
        {
            {"x", "y"},
            {"y", "z"}
        };

            var actual = FrequencyAnalysisTask.GetMostFrequentNextWords(parsedText);

            Assert.AreEqual(expected, actual, text);
        }

        [Test]

        public void ReturnResult_WithMostFrequentBigrams([Values("x y. x z. x y.", "x z. x y. x y", "x y. x y.", "x y")]
        string text)
        {
            var parsedText = SentencesParserTask.ParseSentences(text);
            var expected = new Dictionary<string, string>
        {
            {"x", "y"}
        };

            var actual = FrequencyAnalysisTask.GetMostFrequentNextWords(parsedText);

            Assert.AreEqual(expected, actual, text);
        }

            [Test]
        
        public void ReturnEmptyDictionary_OnEmptyText()
        {
            var text = "";
            var parsedText = SentencesParserTask.ParseSentences(text);
            var expected = new Dictionary<string, string>();

            var actual = FrequencyAnalysisTask.GetMostFrequentNextWords(parsedText);

            Assert.AreEqual(expected, actual, text);
        }
        [Test]
       
        public void ReturnCorrectResult_OnTextWithOneSentenceWithMultipleWords()
        {
            var text = "x y z";
            var parsedText = SentencesParserTask.ParseSentences(text);
            var expected = new Dictionary<string, string>
        {
            {"x", "y"},
            {"y", "z"},
            {"x y", "z"}
        };

            var actual = FrequencyAnalysisTask.GetMostFrequentNextWords(parsedText);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test1()
        {
            var text = "a.b c..d";
            string result = "abcd";
            var res2 = SentencesParserTask.ParseSentences(text);
            var list = new List<string>();
           
            foreach (var sentence in res2)
            {
                list.Add(string.Concat(sentence));
            }
            string str = string.Concat(list);
            Assert.AreEqual(result,str);
        }


        [Test]
        public void Test2()
        {
            var text = "a.b!c?d:e;f(g)h;i";
            var expected = new List<List<string>>
        {
            new() {"a"},
            new() {"b"},
            new() {"c"},
            new() {"d"},
            new() {"e"},
            new() {"f"},
            new() {"g"},
            new() {"h"},
            new() {"i"}
        };

            var actual = SentencesParserTask.ParseSentences(text);
            Assert.AreEqual(expected, actual,text);
        }
    }
}