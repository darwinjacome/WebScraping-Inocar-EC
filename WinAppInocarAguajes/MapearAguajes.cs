using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppInocarAguajes
{
    public class MapearAguajes
    {
        /*public List<tblCalendarioAguaje> CargarCalendarioAguaje(DataTable dtDiasAguaje, int año)
        {
            List<DiaAguaje> diasAguajeTemp = new List<DiaAguaje>();

            foreach (DataRow row in dtDiasAguaje.Rows)
            {
                string mes = "";
                switch (Convert.ToString(row[0]))
                {
                    case "ENERO":
                        mes = "01";
                        break;

                    case "FEBRERO":
                        mes = "02";
                        break;

                    case "MARZO":
                        mes = "03";
                        break;

                    case "ABRIL":
                        mes = "04";
                        break;

                    case "MAYO":
                        mes = "05";
                        break;

                    case "JUNIO":
                        mes = "06";
                        break;

                    case "JULIO":
                        mes = "07";
                        break;

                    case "AGOSTO":
                        mes = "08";
                        break;

                    case "SEPTIEMBRE":
                        mes = "09";
                        break;

                    case "OCTUBRE":
                        mes = "10";
                        break;

                    case "NOVIEMBRE":
                        mes = "11";
                        break;

                    case "DICIEMBRE":
                        mes = "12";
                        break;
                }

                if (!string.IsNullOrEmpty(mes))
                {
                    //var diaLunaLlena = Convert.ToString(row[3]);
                    ////var diaCuartoMenguante = Convert.ToString(row[4]);
                    //var diaLunaNueva = Convert.ToString(row[5]);
                    //var diaCuartoCreciente = Convert.ToString(row[2]);

                    var strDias = Convert.ToString(row[6]).Replace("<br>", ",").Replace("<strong>", ",").Replace("</strong>", ",");
                    foreach (var dia in strDias.Split(','))
                    {
                        if (!string.IsNullOrEmpty(dia))
                        {
                            var aguaje = Convert.ToDateTime($"{año}-{mes}-{dia}");
                            diasAguajeTemp.Add(new DiaAguaje(aguaje));
                        }
                    }
                }
            }

            // Se realiza ordenamiento de las fechas de aguaje
            List<DiaAguaje> diasAguaje = diasAguajeTemp.OrderBy(x => x.dfeAguaje).ToList();
            for (int i = 0; i < diasAguaje.Count(); i++)
            {
                if (i == 0)
                {
                    diasAguaje[i].guid = Guid.NewGuid().ToString();
                }
                else
                {
                    var diaAnterior = diasAguaje.FindAll(x => x.dfeAguaje == diasAguaje[i].dfeAguaje.AddDays(-1)).FirstOrDefault();

                    diasAguaje[i].guid = diaAnterior != null ? diaAnterior.guid : Guid.NewGuid().ToString();
                }
            }

            List<tblCalendarioAguaje> calendario = diasAguaje.GroupBy(x => x.guid).Select((g, i) => new tblCalendarioAguaje { nqnAguaje = i + 1, dfeDesde = g.Min(p => p.dfeAguaje), dfeHasta = g.Max(p => p.dfeAguaje) }).ToList();

            return calendario;
        }*/
    }
}
