using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;

namespace YahooQAScraper
{
    class Program
    {

        private string purl;

        //Hpプロパティ//
        public string seturl
        {
            set　//値をhpに代入する
            {
                this.purl = value;
            }
            get　//値を返す
            {
                return this.purl;
            }
        }



        public async Task Start()
        {
            // Yahoo知恵袋のURL
            string url = purl;

            // AngleSharpの設定
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);

            // URLを読み込んでドキュメントを取得
            var document = await context.OpenAsync(url);

            // 質問を取得
            var question = GetQuestion(document);
            Console.WriteLine("質問: " + question);

            // 回答を取得
            var answers = GetAnswers(document);
            Console.WriteLine("回答:");
            foreach (var answer in answers)
            {
                Console.WriteLine(answer);
            }
        }

        // 質問を取得するメソッド
        static string GetQuestion(IDocument document)
        {
            var questionElement = document.QuerySelector(".abBase .ab-ttl h1 span");
            return questionElement?.TextContent?.Trim();
        }

        // 回答を取得するメソッド
        static List<string> GetAnswers(IDocument document)
        {
            var answerElements = document.QuerySelectorAll(".abBase .ab-ansList .ab-ansName span");
            var answers = new List<string>();
            foreach (var answerElement in answerElements)
            {
                answers.Add(answerElement?.TextContent?.Trim());
            }
            return answers;
        }
    }
}