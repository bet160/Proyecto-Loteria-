using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_User_Client.Model;

namespace ClienteLoteria.Model
{
    class Usuario
    {
        string nombreUsuario;
        string correo;
        string contraseña;
        long? puntaje;
        Byte? fotoPerfil;
        Tabla tabla; 

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public long? Puntaje { get => puntaje; set => puntaje = value; }
        public byte? FotoPerfil { get => fotoPerfil; set => fotoPerfil = value; }
        public Tabla Tabla { get => tabla; set => tabla = value; }
    }
}

