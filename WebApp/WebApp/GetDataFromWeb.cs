using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace WebApp
{
    class GetDataFromWeb
    {
        private string urlToHtml;                                                               //url to html page where you want to take data from
        private string regexExpr;                                                               //regular expression using to select data from html file
        private string htmlInString;                                                            // value to keep html page in string 
        private string htmlInStringTmp;                                                         // the same string like above without '\n's
        private Match matchHtmlStr;                                                             // Match using with Regex to find values 
        private List<string>keys = new List<string>();                                          // List<string> to keep results

        public GetDataFromWeb(string urlToHtml,string regexExpr)                                // 2 arguments constructor, taking url and regex string, 
        {
            this.urlToHtml = urlToHtml;
            this.regexExpr = regexExpr;

            htmlInString = new WebClient().DownloadString(urlToHtml);                           // getting data from http and save it like a string
            htmlInStringTmp = htmlInString.Replace('\n', ' ');                                  // replacing '\n' on ' ' if necessary
            matchHtmlStr = Regex.Match(htmlInStringTmp, regexExpr, RegexOptions.IgnoreCase);    // matching html file using regex expr
            ifMatchSuccess(matchHtmlStr);                                                       // call function to check if matching success, next save results to List<string>keys
        }

        private void ifMatchSuccess(Match match)                                                // function taking 1 argument(Match)
        {                                                                   
            if(match.Success)                                                                   // if match success --> add all results to keys List.   
            {
                for (int i = 1; i <match.Groups.Count ; i++)
                {
                    keys.Add(match.Groups[i].Value);
                    
                }
            }
        }
        public List<string> getResults()                                                        // returning results.     
        {
            return keys;
        }
    }
}
