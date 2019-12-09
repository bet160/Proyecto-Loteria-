using AccesoBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;


namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    [ServiceBehavior(ConcurrencyMode= ConcurrencyMode.Single,InstanceContextMode = InstanceContextMode.Single)]
    public class CalculatorService : ICalculatorService
    {
        Dictionary<ICalculatorServiceCallback, string> _users = new Dictionary<ICalculatorServiceCallback, string>();

        public void GuardarCuentaUsuario(CuentaSet cuenta)
        {
            
                var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();
                _users[connection] = cuenta.nombreUsuario;
                BDLoteriaEntities db = new BDLoteriaEntities();
                Console.WriteLine("BdLoteriaEntities");
                db.CuentaSet.Add(cuenta);
                Console.WriteLine("AgregaCuenta");
                db.SaveChanges();
                Console.WriteLine(cuenta.nombreUsuario + ": Se ha conectado");

            
        }

        public void Join(string username)
        {
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();
            _users[connection] = username;
            Console.WriteLine(username + ": Se ha conectado");
        }

        public void SendOperation(string nombreUsuario, string mensaje)
        {
            string mensaje1 = "[" + nombreUsuario + "]" + mensaje;
        Thread.Sleep(50);
            var connection = OperationContext.Current.GetCallbackChannel<ICalculatorServiceCallback>();

            foreach (var other in _users.Keys)
            {
                if (other == connection)
                    continue;
                other.Response(mensaje1);
            }

        }
    }
}
