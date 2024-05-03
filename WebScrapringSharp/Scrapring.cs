using HtmlAgilityPack;
using System.Data;
using System.Net;
using System.Net.Http;

namespace WebScrapringSharp
{
    public class Scrapring
    {
        private string ObtenerHtml(string url)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                HttpClient client = new HttpClient();
                return client.GetStringAsync(url).Result;
            }
            catch
            {

            }
            return "";
        }

        public DataTable ObtenerTabla(string url)
        {
            string html = new Scrapring().ObtenerHtml(url);

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            List<string> wikiLink = new List<string>();

            DataTable dt = new DataTable();

            // Crea las columnas de la tabla
            HtmlNode table = htmlDoc.DocumentNode.SelectSingleNode("//table[1]");
            if (table != null)
            {
                var thead = table.SelectNodes("//thead//tr//th");
                foreach (HtmlNode header in thead)
                {
                    dt.Columns.Add(header.InnerText);
                }

                // Crea las filas
                var filas = table.SelectNodes("//tbody//tr");
                if (filas != null)
                {
                    foreach (var row in filas)
                    {
                        List<string> arrayData = new List<string>();
                        foreach (HtmlNode n in row.ChildNodes)
                        {
                            if (n.HasChildNodes)
                            {
                                var value = n.InnerHtml.Replace("<br><strong>", ", ");

                                value = value.Replace("</strong>", "");

                                arrayData.Add(value); //n.InnerHtml
                            }
                        }

                        dt.Rows.Add(arrayData.ToArray());
                    }
                }
            }

            return dt;
        }

    }
}