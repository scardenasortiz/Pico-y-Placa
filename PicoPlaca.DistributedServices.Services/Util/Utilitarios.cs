using PicoPlaca.DistributedServices.Contracts.DataContract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlaca.DistributedServices.Services.Util
{
    public static class Utilitarios
    {
        public static void ObtenerDia(PicoPlacaDatos datos)
        {
            try
            {
                DateTime f = Convert.ToDateTime(datos.Fecha);
                datos.Dia = f.ToString("dddd", new CultureInfo("es-ES"));
            }
            catch (Exception ex)
            {
                datos.Dia = string.Empty;
            }
        }

        public static void ObtenerTipoHorario(PicoPlacaDatos datos)
        {
            try
            {
                if (datos.Tiempo.Hours < 12)
                    datos.TipoHora = Variables.TipoHoraM;
                else
                    datos.TipoHora = Variables.TipoHoraT;
            }
            catch (Exception ex)
            {
                datos.TipoHora = string.Empty;
            }
        }

        public static void ObtenerUltimoDigito(PicoPlacaDatos datos)
        {
            try
            {
                datos.Digito = datos.Placa.Substring(datos.Placa.Length - 1);
            }
            catch (Exception ex)
            {
                datos.Digito = string.Empty;
            }
        }
    }
}
