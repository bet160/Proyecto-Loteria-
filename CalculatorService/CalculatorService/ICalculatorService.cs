
using AccesoBD;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract(CallbackContract =typeof(ICalculatorServiceCallback))]
    public interface ICalculatorService
    {
        [OperationContract(IsOneWay=true)]
        void GuardarCuentaUsuario(CuentaSet cuenta);
        [OperationContract(IsOneWay = true)]
        void SendOperation(string nombreUsuario, string mensaje);
        [OperationContract(IsOneWay = true)]
        void Join(string username);
    }

    public interface ICalculatorServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void Response(string mensaje);
    }

    [DataContract]
    public class CuentaUsuario
    {
        String nombreUsuario;
        String correo;
        string contraseña;
        String puntaje;
        Byte[] fotoPerfil;

        [DataMember]
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        [DataMember]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [DataMember]
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        [DataMember]
        public string Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }

        [DataMember]
        public Byte[] FotoPerfil
        {
            get { return fotoPerfil; }
            set { fotoPerfil = value; }
        }
        [DataMember]
        public ObservableCollection<Message> UserMessage { get; set; }
    }
}
