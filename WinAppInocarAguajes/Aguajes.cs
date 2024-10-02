using DJCodes.WebScrapring;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Data;

namespace WinAppInocarAguajes
{
    public class Aguajes
    {
        public DataTable ObtenerTabla(string url)
        {
            HtmlDocument htmlDocument = new WebScrapring().ObtenerHtml(url);

            DataTable dt = new DataTable();

            // Crea las columnas de la tabla
            HtmlNode table = htmlDocument.DocumentNode.SelectSingleNode("//table[1]");
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