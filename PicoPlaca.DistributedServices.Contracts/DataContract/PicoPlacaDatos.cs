using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlaca.DistributedServices.Contracts.DataContract
{
    [DataContract(Namespace = Service.Namespace)]
    public class PicoPlacaDatos : IExtensibleDataObject
    {
        #region Constants and Fields
        private const int Version1 = 1;
        #endregion

        #region Properties

        #region IExtensibleDataObject Members
        public virtual ExtensionDataObject ExtensionData { get; set; }
        #endregion

        [DataMember(IsRequired = true, Order = Version1)]
        public string Placa { get; set; }

        [DataMember(IsRequired = true, Order = Version1)]
        public string Fecha { get; set; }

        [DataMember(IsRequired = true, Order = Version1)]
        public TimeSpan Tiempo { get; set; }

        [DataMember(IsRequired = true, Order = Version1)]
        public string Codigo { get; set; }

        [DataMember(IsRequired = true, Order = Version1)]
        public string TipoHora { get; set; }

        [DataMember(IsRequired = true, Order = Version1)]
        public string Dia { get; set; }

        [DataMember(IsRequired = true, Order = Version1)]
        public string Digito { get; set; }

        #endregion
    }
}