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
        readonly Dictionary<ICalculatorServiceCallback, string> _users  = new Dictionary<ICalculatorServiceCallback, string>();

        public void GuardarCuentaUsuario(CuentaSet cuenta)
        {
            try
            {
                Console.WriteLine("BDloteriaEntities1");
                BDLoteriaEntities db = new BDLoteriaEntities();
                Console.WriteLine("BDloteriaEntities");
                var c = (from per in db.CuentaSet where per.nombreUsuario == cuenta.nombreUsuario select per).First();
                Console.WriteLine("Consulta");
                if (c != null)
                {
                    OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("El usuario ya ha sido registrado");
                }
                else
                {
                    db.CuentaSet.Add(cuenta);
                    db.SaveChanges();
                    Console.WriteLine(cuenta.nombreUsuario + ": Se ha conectado");
                    db.Dispose();
                }
            }
            catch (InvalidOperationException)
            {
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("El usuario o contraseña son erroneos");
            }
        }

        public void IniciarSesion(string nombreUsuario, string contraseña)
        {
            try
            {
                BDLoteriaEntities db = new BDLoteriaEntities();
                db.CuentaSet.Where(d => d.nombreUsuario == nombreUsuario && d.contraseña == contraseña).First();
                var cuenta = (from per in db.CuentaSet where per.nombreUsuario == nombreUsuario && per.contraseña == contraseña select per).First();
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().DevuelveCuenta(cuenta);
                var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();
                _users[connection] = nombreUsuario;
                Console.WriteLine(nombreUsuario + ": Ha iniciado sesión");
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
                c.fotoPerfil = cuenta.fotoPerfil;
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

        public void EnviarMensajeChat(string nombreUsuario, string mensaje, List<string> nombresUSuario)
        {
            string mensaje1 = "[" + nombreUsuario + "]" + mensaje;
            Thread.Sleep(50);
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

            foreach (var other in _users)
            {
                foreach(var nombre1 in nombresUSuario)
                {
                    if (other.Value.Equals(nombre1))
                    {
                        if (other.Key == connection)
                            continue;
                        other.Key.MensajeChat(mensaje1);
                    }
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
            _users[connection] = nombreUsuario;
            Console.WriteLine(nombreUsuario+" Acaba de cerrar sesión");
        }

        public void EnviarInivitacion(string nombreUsuario, string tematica, List<string> invitados)
        {
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

            foreach (var other in _users)
            {
                foreach (var nombre1 in nombresUsuario)
                {
                    if (other.Value.Equals(nombre1))
                    {
                        if (other.Key == connection)
                            continue;
                        other.Key.RecibirInvitacion("Quiere jugar contigo",nombreUsuario,tematica);
                    }
                }
            }
        }

        public void ConfirmacionInvitacion(bool opcion, string nombreUsuario)
        {
        
  
        }

        public void ComenzarPartida(List<int> orden, List<string> nombresUsuario)
        {
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

            foreach (var other in _users)
            {
                foreach (var nombre1 in nombresUsuario)
                {
                    if (other.Value.Equals(nombre1))
                    {
                        if (other.Key == connection)
                            continue;
                        other.Key.RecibirOrdenTarjetas(orden);
                    }
                }
            }
        }

        public void FinalizarPartida(string nombreUsuario, List<string> nombresUsuario)
        {
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

            foreach (var other in _users)
            {
                foreach (var nombre1 in nombresUsuario)
                {
                    if (other.Value.Equals(nombre1))
                    {
                        if (other.Key == connection)
                            continue;
                        other.Key.RecibirFinPartida(nombreUsuario);
                    }
                }
            }

        }
    }
}