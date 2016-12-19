using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;
using System.Text;
using System.Collections;
using System.Xml;

using PicoPlaca.DistributedServices.Contracts.DataContract;

using PicoPlaca.Web.ModPicoPlacaServices;

namespace PicoPlaca.Web
{
    public class ConsumoServicio
    {
        #region Variables
        PicoPlacaServicesClient pp = new PicoPlacaServicesClient();

        #endregion

        #region Pico y Placa
        public string ConsultarHorarios(PicoPlacaDatos datos) 
        {
            return pp.ConsultarHorarios(datos);            
        }

        #endregion

    }
}