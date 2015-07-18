using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using HtmlAgilityPack;
using System.Timers;

namespace WebApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("{0}     {1}     {2}     {3}      {4}       {5}    {6}   {7}","USD","EUR","CHF","GBP","WIG","WIG20","mWIG40","sWIG80");
             
           string expr_exchange_rates = "USD.+<td.+>([0-9],[0-9]+)</td>.+EUR.+EUR.+<td.+>([0-9],[0-9]+)</td>.+CHF.+CHF.+<td.+>([0-9],[0-9]+)</td>.+GBP.+GBP.+<td.+>([0-9],[0-9]+)</td>";
           string expr_indexes = "WIG.+<td.+>([0-9]+.[0-9]+)</td>.+WIG20.+WIG20.+<td.+>([0-9]+.[0-9]+)</td>.+mWIG40.+mWIG40.+<td.+>([0-9]+.[0-9]+)</td>.+sWIG80.+sWIG80.+<td.+>([0-9]+.[0-9]+)</td>";
           
           string url_exchange_rates = "http://cw.money.pl/kursy_nbp_gf.html";
           string url_indexes = "http://cw.money.pl/indeksy_gpw_gf.html";

           GetDataFromWeb exchange_rates = new GetDataFromWeb(url_exchange_rates,expr_exchange_rates);
           GetDataFromWeb indexes = new GetDataFromWeb(url_indexes, expr_indexes);

           //const double interval = 1000;
           //Timer checkForTime = new Timer(interval);
           //checkForTime.Elapsed += new ElapsedEventHandler(checkForTime_Elapsed);
           //checkForTime.Enabled = true;
           List<string> res_e_r = exchange_rates.getResults();
           List<string> res_i = indexes.getResults();

           Console.Write("{0}  {1}  {2}  {3} | ", res_e_r[0], res_e_r[1], res_e_r[2], res_e_r[3]);
           Console.Write("{0}  {1}  {2}  {3}", res_i[0], res_i[1], res_i[2], res_i[3]);

            Console.ReadLine();
                
        }
        static void checkForTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            update();
        }
        static void update()
        {
            
        }
    }
}
