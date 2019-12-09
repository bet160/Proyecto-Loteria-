using AccesoBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;

namespace ServidorLoteria
{
    
    [ServiceBehavior(ConcurrencyMode= ConcurrencyMode.Single,InstanceContextMode = InstanceContextMode.Single)]
    public class ServicioCuentaUsuario : IServicioCuentaUsuario
    {
        readonly Dictionary<ICalculatorServiceCallback, string> usuariosConectados  = new Dictionary<ICalculatorServiceCallback, string>();
        private ICalculatorServiceCallback callbackChannel;

        public ServicioCuentaUsuario()
        {

        }

        public ServicioCuentaUsuario(ICalculatorServiceCallback callbackCreator)
        {
            this.callbackChannel = callbackCreator ?? throw new ArgumentNullException("callbackCreator");
        }

        public void GuardarCuentaUsuario(CuentaSet cuenta)
        {
            try
            {
                Console.WriteLine("BDloteriaEntities");
                BDLoteriaEntities db = new BDLoteriaEntities();
                Console.WriteLine("BDloteriaEntities2");
                var c = (from per in db.CuentaSet where per.nombreUsuario == cuenta.nombreUsuario select per).First();
                Console.WriteLine("Consulta");

                if (c != null)
                {

                    OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("El usuario ya ha sido registrado");
                }
            }
            catch (InvalidOperationException)
            {
                BDLoteriaEntities db = new BDLoteriaEntities();
                db.CuentaSet.Add(cuenta);
                db.SaveChanges();
                Console.WriteLine(cuenta.nombreUsuario + ": Se ha registrado");
                db.Dispose();
            }
        }

        public void IniciarSesion(string nombreUsuario, string contraseña)
        {
            try
            {
                BDLoteriaEntities db = new BDLoteriaEntities();
                //db.CuentaSet.Where(d => d.nombreUsuario == nombreUsuario && d.contraseña == contraseña).First();
                var cuenta = (from per in db.CuentaSet where per.nombreUsuario == nombreUsuario && per.contraseña == contraseña select per).First();
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().DevuelveCuenta(cuenta);
                var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();
                usuariosConectados[connection] = nombreUsuario;
                /*var connection = callbackChannel;
                    _users[connection] = nombreUsuario;
                Func<ICalculatorServiceCallback> channel = () => callbackChannel;
                callbackChannel.DevuelveCuenta(cuenta);*/
                Console.WriteLine(cuenta.nombreUsuario + ": Ha iniciado sesión");
                Console.WriteLine("Puntaje: " + cuenta.puntajeMaximo);
                db.Dispose();
            }
            catch (InvalidOperationException)
            {
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("El usuario o contraseña son erroneos");
            }

        }

        public void ModificarCuentaUsuario(CuentaSet cuenta)
        {
            try
            {
                BDLoteriaEntities po = new BDLoteriaEntities();
                var c = (from per in po.CuentaSet where per.nombreUsuario == cuenta.nombreUsuario select per).First();
                c.correo = cuenta.correo;
                c.contraseña = cuenta.contraseña;
                po.SaveChanges();
                Console.WriteLine("Se ha modificado");
                po.Dispose();
            }
            catch (InvalidOperationException)
            {
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("Alguno de los datos introducidos no son correctos");
            }
        }

        public void RegistrarPuntajeMáximo(string nombreUsuario, int puntajeMaximo)
        {
            try
            {
                BDLoteriaEntities po = new BDLoteriaEntities();
                var c = (from per in po.CuentaSet where per.nombreUsuario == nombreUsuario select per).First();
                if (c.puntajeMaximo == null)
                {
                    c.puntajeMaximo = puntajeMaximo;
                    po.SaveChanges();
                    Console.WriteLine("Se ha registrado nuevo puntaje");
                }
                else
                {
                    if (c.puntajeMaximo < puntajeMaximo)
                    {
                        c.puntajeMaximo = puntajeMaximo;
                        po.SaveChanges();
                        Console.WriteLine("Se ha registrado nuevo puntaje");
                    }
                    else
                    {
                        Console.WriteLine("El puntaje anterior era mas alto");
                    }
                }
                po.Dispose();
            }
            catch (InvalidOperationException)
            {
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("Ocurrio un error al intentar registrar un nuevo puntaje máximo");
            }
        }

        public void EnviarMensajeChat(string nombreUsuario, string mensaje, string nombreRemitente)
        {
            string mensaje1 = "[" + nombreUsuario + "]" + mensaje;
            Thread.Sleep(50);
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

            foreach (var destinatario in usuariosConectados)
            {
                    if (destinatario.Value.Equals(nombreRemitente))
                    {
                        if (destinatario.Key == connection)
                            continue;
                        destinatario.Key.MensajeChat(mensaje1);
                    }
            }
        }

        public void SolicitarPuntajes()
        {
            try
            {
                List<PuntajeUsuario> puntajes = new List<PuntajeUsuario>();
                using (var ctx = new BDLoteriaEntities())
                {
                    var cuentas = from s in ctx.CuentaSet
                                  orderby s.puntajeMaximo descending
                                  select s;
                    foreach (var valor in cuentas)
                    {
                        if (valor.puntajeMaximo != null)
                        {
                            puntajes.Add(new PuntajeUsuario(valor.nombreUsuario, valor.puntajeMaximo));
                            Console.WriteLine(valor.nombreUsuario + "=" + valor.puntajeMaximo);
                        }
                    }
                }
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().DevuelvePuntajes(puntajes);
            }
            catch (InvalidOperationException)
            {
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("Ocurrio un error al intentar acceder a la base de datos intentelo más tarde");
            }
        }

        public void CerrarSesion(string nombreUsuario)
        {
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();
            usuariosConectados[connection] = nombreUsuario;
        }

        public void EnviarInivitacion(string mensaje, string nombreUsuario, string tematica, string nombreRemitente)
        {
            try
            {
                var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

                foreach (var invitado in usuariosConectados)
                {
                    if ((invitado.Value.Equals(nombreRemitente)) && (!invitado.Value.Equals(nombreUsuario)))
                    {
                        if (invitado.Key == connection)
                            continue;
                        invitado.Key.RecibirInvitacion(nombreUsuario, mensaje, tematica);
                    }

                }
            }
            catch (NullReferenceException)
            {
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("El usuario que usted invitó no está conectado");
            }

        }

        public void ConfirmacionInvitacion(bool opcion, string nombreUsuario, string tematica,string emisor)
        {
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

            foreach (var usuarioRemitente in usuariosConectados)
            {
                    if (usuarioRemitente.Value.Equals(emisor))
                    {
                        if (usuarioRemitente.Key == connection)
                            continue;
                            usuarioRemitente.Key.RecibirConfirmacion(opcion,tematica,nombreUsuario);
                    }
            }

        }

        public void FinalizarPartida(string nombreUsuario, string nombreRemitente)
        {
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

            foreach (var jugadorPerdedor in usuariosConectados)
            {
                if (jugadorPerdedor.Value.Equals(nombreRemitente))
                {
                    if (jugadorPerdedor.Key == connection)
                        continue;
                    jugadorPerdedor.Key.RecibirFinPartida("El usuario "+nombreUsuario+" ha ganado la partida");
                }
            }

        }

        public void ActualizarUsuario(string nombreUsuario, string contraseña)
        {
            try
            {
                BDLoteriaEntities db = new BDLoteriaEntities();
                db.CuentaSet.Where(d => d.nombreUsuario == nombreUsuario && d.contraseña == contraseña).First();
                var cuenta = (from per in db.CuentaSet where per.nombreUsuario == nombreUsuario && per.contraseña == contraseña select per).First();
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().DevuelveCuenta(cuenta);
                Console.WriteLine(nombreUsuario + ": Ha actualizado su cuenta");
                db.Dispose();
            }
            catch (InvalidOperationException)
            {
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("Error al registrar en la base de datos");
            }
        }
    }
}