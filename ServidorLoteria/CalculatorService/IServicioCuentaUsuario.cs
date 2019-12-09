
using AccesoBD;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServidorLoteria
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(ICalculatorServiceCallback))]
    public interface IServicioCuentaUsuario
    {
        [OperationContract(IsOneWay = true)]
        void IniciarSesion(string nombreUsuario, string contraseña);
        [OperationContract(IsOneWay = true)]
        void CerrarSesion(string nombreUsuario);
        [OperationContract(IsOneWay = true)]
        void GuardarCuentaUsuario(CuentaSet cuenta);
        [OperationContract(IsOneWay = true)]
        void EnviarMensajeChat(string nombreUsuario, string mensaje, string nombreRemitente);
        [OperationContract(IsOneWay = true)]
        void ModificarCuentaUsuario(CuentaSet cuenta);
        [OperationContract(IsOneWay = true)]
        void RegistrarPuntajeMáximo(string nombreUsuario, int puntajeMaximo);
        [OperationContract(IsOneWay = true)]
        void SolicitarPuntajes();
        [OperationContract(IsOneWay = true)]
        void EnviarInivitacion(string mensaje, string nombreUsuario,string tematica, string nombreRemitente);
        [OperationContract(IsOneWay = true)]
        void ConfirmacionInvitacion(bool opcion, string nombreUsuario, string tematica,string emisor);
        [OperationContract(IsOneWay = true)]
        void FinalizarPartida(string nombreUsuario,string nombreRemitente);
        [OperationContract(IsOneWay = true)]
        void ActualizarUsuario(string nombreUsuario, string contraseña);
    }

    [ServiceContract]
    public interface ICalculatorServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void MensajeChat(string mensaje);
        [OperationContract(IsOneWay = true)]
        void Respuesta(string mensaje);

        [OperationContract(IsOneWay = true)]
        void DevuelveCuenta(CuentaSet cuenta);

        [OperationContract(IsOneWay = true)]
        void DevuelvePuntajes(List<PuntajeUsuario> puntajes);
        [OperationContract(IsOneWay = true)]
        void RecibirInvitacion(string nombreUsuario, string mensaje, string tematica);
        [OperationContract(IsOneWay = true)]
        void RecibirConfirmacion(bool opcion, string tematica,string nombreUsuario);
        [OperationContract(IsOneWay = true)]
        void RecibirFinPartida(string mensaje);

    }

    [DataContract]
    public class PuntajeUsuario
    {
        [DataMember]
        string nombreUsuario;
        [DataMember]
        private long? puntajeMaximo;
        public PuntajeUsuario(string nombreUsuario, long? puntajeMaximo)
        {
            this.nombreUsuario = nombreUsuario;
            this.puntajeMaximo = puntajeMaximo;
        }
    }
}
