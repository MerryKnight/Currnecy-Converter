using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace WindowsFormsApp1
{
    public class prog
    {
     
        
        public async Task<float> GetHtmlAsync(string url)
        {
            

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var curvalue = htmlDocument.DocumentNode.Descendants("div")
                  .Where(node => node.GetAttributeValue("class", "")
                  .Equals("currency-table__large-text")).ToList();

            var cellText = curvalue[0].InnerHtml.Replace(",",".");
            
            return Convert.ToSingle(cellText);

        }
  
    }
    }



  