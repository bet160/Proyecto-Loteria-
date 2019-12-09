using WCF_User_Client.Model;

namespace ClienteLoteria.Model
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public long? Puntaje { get; set; }
        public byte? FotoPerfil { get; set; }
        public Tabla Tabla { get; set; }
    }
}

