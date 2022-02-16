using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebbedAudio.Core.Data
{
    class Scraper
    {
        static string GetSiteHtml(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        return content.ReadAsStringAsync().Result;
                    }
                }
            }
        }

        public static List<string> GetMediaElements(string url)
        {
            List<string> mediaElements = new List<string>();

            bool anotherSubSite = true;
            var doc = new HtmlDocument();
            doc.LoadHtml(GetSiteHtml(url));

            var mediaElemenNodes = doc.DocumentNode.CssSelect("audio.wp-audio-shortcode > a");

            foreach (var node in mediaElemenNodes)
            {
                mediaElements.Add(node.InnerHtml.CleanInnerText());
            }

            return mediaElements;
        }

        public static void DownloadMedia(List<string> files, string downloadFolder)
        {
            WebClient client = new WebClient();
            int i = 0;
            string downloadFile = "";

            foreach (var file in files)
            {
                downloadFile = $@"C:\Users\hugok\source\repos\WebbedAudio AIP (Application In Parts)\Downloads\track{i}.mp3";
                using (StreamWriter sw = new StreamWriter(downloadFile))
                {
                }
                client.DownloadFile(new Uri(file), downloadFile);
                i++;
            }
        }
    }
}
