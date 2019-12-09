using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_User_Client.Model
{
    class Puntajes
    {
        string nombreUsuario;
        long? puntaje;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }

        public long? Puntaje { get => puntaje; set => puntaje = value; }
    }
}
