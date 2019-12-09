using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;

namespace WCF_User_Client
{
    /// <summary>
    /// Lógica de interacción para Verificacion.xaml
    /// </summary>
    /// 
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class EditarPerfil : Window, ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        

        public EditarPerfil()
        {
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                ServidorLoteria.ServicioCuentaUsuarioClient client = new ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
                ServidorLoteria.CuentaSet cuenta = new ServidorLoteria.CuentaSet();
                
            }
            catch (EndpointNotFoundException)
            {
                
            }
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            Principal ventana = new Principal();
            ventana.Show();
            this.Close();
        }

        private void CerrarVentana(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizarVentana(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void Respuesta(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void DevuelveCuenta(CuentaSet cuenta)
        {

        }

        public void DevuelvePuntajes(PuntajeUsuario[] puntajes)
        {
            throw new NotImplementedException();
        }
    }
}
