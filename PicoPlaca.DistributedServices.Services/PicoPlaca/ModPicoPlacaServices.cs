using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PicoPlaca.DistributedServices.Contracts.DataContract;
using PicoPlaca.Data.EF;
using PicoPlaca.DistributedServices.Contracts;

namespace PicoPlaca.DistributedServices.Services.PicoPlaca
{ 
    public class ModPicoPlacaServices : IPicoPlacaServices
    {

        #region IPicoPlacaServices
        public string ConsultarHorarios(PicoPlacaDatos datos)
        {
            string mensaje = string.Empty;
            try
            {
                using(picoplacaEntities db = new picoplacaEntities())
                {
                    Util.Utilitarios.ObtenerDia(datos);
                    if (!string.IsNullOrEmpty(datos.Dia))
                    {
                        var query = (from diaspicoplaca in db.Dias
                                     where diaspicoplaca.Dia == datos.Dia
                                     select new
                                     {
                                         Codigo = diaspicoplaca.Codigo
                                     }).ToList();

                        foreach (var element in query)
                        {
                            datos.Codigo = element.Codigo;
                            if (ConsultaDigito(datos))
                                if(ConsultaHora(datos))
                                    mensaje = Variables.HorarioIncorrecto;
                                else
                                    mensaje = Variables.HorarioCorrecto;
                            else
                                mensaje = Variables.HorarioCorrecto;
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }

            return mensaje;
        }
        #endregion

        #region Metodos Privados
        private Boolean ConsultaDigito(PicoPlacaDatos datos)
        {
            try
            {
                using(picoplacaEntities db = new picoplacaEntities())
                {
                    Util.Utilitarios.ObtenerUltimoDigito(datos);
                    if (!string.IsNullOrEmpty(datos.Digito))
                    {
                        var queryDigito = (from num in db.Digito
                                           where num.CodigoDias == datos.Codigo && num.Digito1 == datos.Digito
                                           select num
                                           ).ToList().Count;

                        if (queryDigito > 0)
                            return true;
                    }
                }
                    
            }
            catch (Exception)
            {
                
            }

            return false;
        }

        private Boolean ConsultaHora(PicoPlacaDatos datos)
        {
            try
            {
                using (picoplacaEntities db = new picoplacaEntities())
                {
                    Util.Utilitarios.ObtenerTipoHorario(datos);

                    if (!string.IsNullOrEmpty(datos.TipoHora))
                    {
                        var queryDigito = (from hora in db.Horarios
                                           where hora.HoraInicio <= datos.Tiempo && hora.HoraFin >= datos.Tiempo && hora.TipoHora == datos.TipoHora
                                           select hora
                                           ).ToList().Count;

                        if (queryDigito > 0)
                            return true;
                    }
                }

            }
            catch (Exception)
            {

            }

            return false;
        }
        #endregion
    }
}
