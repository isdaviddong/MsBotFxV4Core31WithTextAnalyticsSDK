using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalytics.Bots
{
    public class TextAnalytics
    {
        public static LanguageResult DetectLanguage(string Text)
        {
            var cogsKey = "____________14a91bb83292_________";
            var cogsBaseUrl = "https://___________.cognitiveservices.azure.com/";
            var credentials = new ApiKeyServiceClientCredentials(cogsKey);
            TextAnalyticsClient client = new TextAnalyticsClient(credentials)
            {
                Endpoint = cogsBaseUrl
            };

            var result = client.DetectLanguage(Text, "us");
            return result;
        }

        public static SentimentResult GetSentiment(string Text)
        {
            var cogsKey = "____________14a91bb83292_________";
            var cogsBaseUrl = "https://__________.cognitiveservices.azure.com/";
            var credentials = new ApiKeyServiceClientCredentials(cogsKey);
            TextAnalyticsClient client = new TextAnalyticsClient(credentials)
            {
                Endpoint = cogsBaseUrl
            };

            var result = client.Sentiment(Text, "en");
            return result;
        }
    }
}
