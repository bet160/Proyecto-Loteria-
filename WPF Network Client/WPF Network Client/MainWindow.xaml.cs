using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceModel;
using System.Threading;

namespace WPF_Network_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    [CallbackBehavior(UseSynchronizationContext =false)]
    public partial class MainWindow : Window, CalculatorService.ICalculatorServiceCallback
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Response(string mensaje)
        {
            this.Dispatcher.BeginInvoke(new ThreadStart(()=>TextBlockResponse.Text = mensaje.ToString()+"\n"));
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            InstanceContext instanceContext = new InstanceContext(this);
            CalculatorService.CalculatorServiceClient client = new CalculatorService.CalculatorServiceClient(instanceContext);
            CalculatorService.CuentaSet cuenta = new CalculatorService.CuentaSet();
            cuenta.nombreUsuario = "nombre";
            cuenta.contraseña = "contraseña";
            cuenta.correo = "correo";
            client.GuardarCuentaUsuario(cuenta);
        }
    }
}
