
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
        void EnviarMensajeChat(string nombreUsuario, string mensaje);
        [OperationContract(IsOneWay = true)]
        void ModificarCuentaUsuario(CuentaSet cuenta);
        [OperationContract(IsOneWay = true)]
        void RegistrarPuntajeMáximo(string nombreUsuario, int puntajeMaximo);
        [OperationContract(IsOneWay = true)]
        void SolicitarPuntajes();
    }

    [ServiceContract]
    public interface ICalculatorServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void Respuesta(string mensaje);

        [OperationContract(IsOneWay = true)]
        void DevuelveCuenta(CuentaSet cuenta);

        [OperationContract(IsOneWay = true)]
        void DevuelvePuntajes(List<PuntajeUsuario> puntajes);

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
