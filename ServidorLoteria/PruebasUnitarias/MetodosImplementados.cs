using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServidorLoteria;
using AccesoBD;

namespace PruebasUnitarias
{
    internal class MetodosImplementados : ICalculatorServiceCallback
    {
        private CuentaSet cuentaUsuario;

        internal MetodosImplementados()
        {
            cuentaUsuario = null;
        }

        internal CuentaSet Response
        {
            get { return cuentaUsuario; }
        }

        public void DevuelveCuenta(CuentaSet cuenta)
        {
            this.cuentaUsuario = cuenta;
        }

        public void DevuelvePuntajes(List<PuntajeUsuario> puntajes)
        {
            throw new NotImplementedException();
        }

        public void MensajeChat(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void RecibirConfirmacion(bool opcion, string tematica)
        {
            throw new NotImplementedException();
        }

        public void RecibirFinPartida(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
        {
            throw new NotImplementedException();
        }

        public void Respuesta(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
