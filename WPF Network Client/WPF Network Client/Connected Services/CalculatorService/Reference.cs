﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_Network_Client.CalculatorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CuentaSet", Namespace="http://schemas.datacontract.org/2004/07/AccesoBD")]
    [System.SerializableAttribute()]
    public partial class CuentaSet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string correoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<byte> fotoPerfilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string puntajeMaximoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contraseña {
            get {
                return this.contraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.contraseñaField, value) != true)) {
                    this.contraseñaField = value;
                    this.RaisePropertyChanged("contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                if ((object.ReferenceEquals(this.correoField, value) != true)) {
                    this.correoField = value;
                    this.RaisePropertyChanged("correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> fotoPerfil {
            get {
                return this.fotoPerfilField;
            }
            set {
                if ((this.fotoPerfilField.Equals(value) != true)) {
                    this.fotoPerfilField = value;
                    this.RaisePropertyChanged("fotoPerfil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreUsuario {
            get {
                return this.nombreUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreUsuarioField, value) != true)) {
                    this.nombreUsuarioField = value;
                    this.RaisePropertyChanged("nombreUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string puntajeMaximo {
            get {
                return this.puntajeMaximoField;
            }
            set {
                if ((object.ReferenceEquals(this.puntajeMaximoField, value) != true)) {
                    this.puntajeMaximoField = value;
                    this.RaisePropertyChanged("puntajeMaximo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorService.ICalculatorService", CallbackContract=typeof(WPF_Network_Client.CalculatorService.ICalculatorServiceCallback))]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/GuardarCuentaUsuario")]
        void GuardarCuentaUsuario(WPF_Network_Client.CalculatorService.CuentaSet cuenta);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/GuardarCuentaUsuario")]
        System.Threading.Tasks.Task GuardarCuentaUsuarioAsync(WPF_Network_Client.CalculatorService.CuentaSet cuenta);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/SendOperation")]
        void SendOperation(string nombreUsuario, string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/SendOperation")]
        System.Threading.Tasks.Task SendOperationAsync(string nombreUsuario, string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/Join")]
        void Join(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/Join")]
        System.Threading.Tasks.Task JoinAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/Response")]
        void Response(string mensaje);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : WPF_Network_Client.CalculatorService.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.DuplexClientBase<WPF_Network_Client.CalculatorService.ICalculatorService>, WPF_Network_Client.CalculatorService.ICalculatorService {
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void GuardarCuentaUsuario(WPF_Network_Client.CalculatorService.CuentaSet cuenta) {
            base.Channel.GuardarCuentaUsuario(cuenta);
        }
        
        public System.Threading.Tasks.Task GuardarCuentaUsuarioAsync(WPF_Network_Client.CalculatorService.CuentaSet cuenta) {
            return base.Channel.GuardarCuentaUsuarioAsync(cuenta);
        }
        
        public void SendOperation(string nombreUsuario, string mensaje) {
            base.Channel.SendOperation(nombreUsuario, mensaje);
        }
        
        public System.Threading.Tasks.Task SendOperationAsync(string nombreUsuario, string mensaje) {
            return base.Channel.SendOperationAsync(nombreUsuario, mensaje);
        }
        
        public void Join(string username) {
            base.Channel.Join(username);
        }
        
        public System.Threading.Tasks.Task JoinAsync(string username) {
            return base.Channel.JoinAsync(username);
        }
    }
}