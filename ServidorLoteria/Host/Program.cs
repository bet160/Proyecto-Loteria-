using System;
using System.ServiceModel;

namespace Host
{
    public static class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ServidorLoteria.ServicioCuentaUsuario)))
            {
                host.Open();
                Console.WriteLine("El servidor está arriba");
                Console.ReadLine();
            }
        }

    }
}
