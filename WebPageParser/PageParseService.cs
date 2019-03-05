using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace WebPageParser
{
    class PageParseService
    {
        string ParsePage(HtmlDocument doc)
        {
            var root = doc.DocumentNode;
            var sb = new StringBuilder();
            foreach (var node in root.DescendantNodesAndSelf())
            {
                if (!node.HasChildNodes)
                {
                    string text = node.InnerText;
                    if (!string.IsNullOrEmpty(text))
                        sb.AppendLine(text.Trim());
                }
            }

            return sb.ToString();
        }

        HtmlDocument GetHtmlDocumentFromUrl(string url)
        {
            var web = new HtmlWeb();
            return web.Load(url);
        }

        List<string> GetAllUrlFromPage()
        {
            throw new NotImplementedException();
        }

        -
    }
}