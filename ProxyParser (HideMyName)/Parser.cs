using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xNet;

namespace ProxyParser
{
    class Parser
    {
        public string HideMyNameDownloadAndParse(string url)
        {
            var output = "";
            var data = new HttpRequest
            {
                CharacterSet = Encoding.UTF8,
                KeepAlive = true,
                KeepAliveTimeout = 1000,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36 OPR/71.0.3770.323"
            };
            string response = data.Get(url).ToString();
            var matches = Regex.Matches(response, @"(\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}</td>)|(\d{2,5}</td>)");
            int matchesCount = matches.Count;
            for (int i = 0; i < matchesCount; i+=2)
                if (!Regex.Match(matches[i].Value, @"([A-Za-z-])").Success || matches[i].Value.Contains("<"))
                         output += matches[i].Value.Replace("</td>", "")+":" + matches[i+1].Value.Replace("</td>", "") + Environment.NewLine;
            if (response.Contains("It seems you are bot. If so, please use separate API interface. It is cheap and easy to use."))
                return "bot detected:"+url;
            return output;
        }
    }
}
