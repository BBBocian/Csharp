using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolInfoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
	/*
            string webAdd = "http://moto.money.pl/ceny-paliw/wroclaw,pb95.html";
            string exprON = ".+gaz_box.+>([0-9].[0-9]+)</span>.+[0-9]";
            GetDataFromWeb ON = new GetDataFromWeb(webAdd, exprON);

            List<string> resultsON = ON.getResults(); 

            foreach(string x in resultsON)
                Console.WriteLine(x);
	*/

	    HtmlWeb webGet = new HtmlWeb();
            HtmlDocument document = webGet.Load(@"C:\Users\Bocian\Documents\Visual Studio 2013\Projects\Xpath first proj\bookshop.html");
            HtmlNodeCollection metaTags = document.DocumentNode.SelectNodes("/html/body/div/div/div/div/div/ul/li/span");

            Console.WriteLine("{0}    {1}","ON",metaTags[0].InnerHtml);
            Console.WriteLine("{0}  {1}", "PB95", metaTags[1].InnerHtml);
            Console.WriteLine("{0}  {1}", "PB98", metaTags[2].InnerHtml);
            Console.WriteLine("{0}   {1}", "LPG", metaTags[3].InnerHtml);


            Console.ReadLine();
        }
    }
}
