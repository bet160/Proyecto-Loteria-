
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
        void EnviarMensajeChat(string nombreUsuario, string mensaje, List<string>nombresUSuario);

        [OperationContract(IsOneWay = true)]
        void ModificarCuentaUsuario(CuentaSet cuenta);

        [OperationContract(IsOneWay = true)]
        void RegistrarPuntajeMáximo(string nombreUsuario, int puntajeMaximo);

        [OperationContract(IsOneWay = true)]
        void SolicitarPuntajes();

        [OperationContract(IsOneWay = true)]
        void EnviarInivitacion(string nombreUsuario,string tematica,List<string>invitados);

        [OperationContract(IsOneWay = true)]
        void ConfirmacionInvitacion(bool opcion, string nombreUsuario);

        [OperationContract(IsOneWay = true)]
        void FinalizarPartida(string nombreUsuario,List<string>nombresUsuario);
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
        void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica);

        [OperationContract(IsOneWay = true)]
        void RecibirConfirmacion(bool opcion);

        [OperationContract(IsOneWay = true)]
        void RecibirOrdenTarjetas(List<int>orden);

        [OperationContract(IsOneWay = true)]
        void RecibirFinPartida(string nombreUsuario);

        [OperationContract(IsOneWay = true)]
        void ComenzarPartida(List<int> orden, List<string> nombresUsuario);


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
