﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PicoPlaca.Web.ModPicoPlacaServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ModPicoPlacaServices.IPicoPlacaServices")]
    public interface IPicoPlacaServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicoPlacaServices/ConsultarHorarios", ReplyAction="http://tempuri.org/IPicoPlacaServices/ConsultarHorariosResponse")]
        string ConsultarHorarios(PicoPlaca.DistributedServices.Contracts.DataContract.PicoPlacaDatos datos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicoPlacaServices/ConsultarHorarios", ReplyAction="http://tempuri.org/IPicoPlacaServices/ConsultarHorariosResponse")]
        System.Threading.Tasks.Task<string> ConsultarHorariosAsync(PicoPlaca.DistributedServices.Contracts.DataContract.PicoPlacaDatos datos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPicoPlacaServicesChannel : PicoPlaca.Web.ModPicoPlacaServices.IPicoPlacaServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PicoPlacaServicesClient : System.ServiceModel.ClientBase<PicoPlaca.Web.ModPicoPlacaServices.IPicoPlacaServices>, PicoPlaca.Web.ModPicoPlacaServices.IPicoPlacaServices {
        
        public PicoPlacaServicesClient() {
        }
        
        public PicoPlacaServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PicoPlacaServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PicoPlacaServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PicoPlacaServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ConsultarHorarios(PicoPlaca.DistributedServices.Contracts.DataContract.PicoPlacaDatos datos) {
            return base.Channel.ConsultarHorarios(datos);
        }
        
        public System.Threading.Tasks.Task<string> ConsultarHorariosAsync(PicoPlaca.DistributedServices.Contracts.DataContract.PicoPlacaDatos datos) {
            return base.Channel.ConsultarHorariosAsync(datos);
        }
    }
}
