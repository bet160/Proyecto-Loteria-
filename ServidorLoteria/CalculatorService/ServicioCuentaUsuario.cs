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

        public void CerrarSesion(string nombreUsuario)
        {
            try
            { 
                foreach (var other in _users.Keys)
                {
                    if (other.Equals(nombreUsuario))
                        _users.Remove(other);
                }
                Console.WriteLine(nombreUsuario + ": Ha terminado su sesión");
            }
            catch (InvalidOperationException)
            {
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("Ocurrio un error al intentar cerrar sesión");
            }
        }

        public void GuardarCuentaUsuario(CuentaSet cuenta)
        {
            try
            {
                BDLoteriaEntities db = new BDLoteriaEntities();
                var c = (from per in db.CuentaSet where per.nombreUsuario == cuenta.nombreUsuario select per).First();
                c.correo = cuenta.correo;

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
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().Respuesta("El usuario o contrasela son erroneos");
            }
        }

        public void IniciarSesion(string nombreUsuario, string contraseña)
        {
            try
            {
                BDLoteriaEntities db = new BDLoteriaEntities();
                db.CuentaSet.Where(d => d.nombreUsuario == nombreUsuario && d.contraseña == contraseña).First();
                var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();
                _users[connection] = nombreUsuario;
                var cuenta = (from per in db.CuentaSet where per.nombreUsuario == nombreUsuario && per.contraseña == contraseña select per).First();
                OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>().DevuelveCuenta(cuenta);
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

        public void EnviarMensajeChat(string nombreUsuario, string mensaje)
        {
            string mensaje1 = "[" + nombreUsuario + "]" + mensaje;
            Thread.Sleep(50);
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

            foreach (var other in _users.Keys)
            {
                if (other == connection)
                    continue;
                other.Respuesta(mensaje1);
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
    }
}