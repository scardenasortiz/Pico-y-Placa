using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using PicoPlaca.DistributedServices.Contracts.DataContract;


namespace PicoPlaca.DistributedServices.Contracts
{
    [ServiceContract]
    public interface IPicoPlacaServices
    {
        [OperationContract]
        string ConsultarHorarios(PicoPlacaDatos datos);
    }
}
