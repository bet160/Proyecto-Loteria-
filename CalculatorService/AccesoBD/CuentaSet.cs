//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class CuentaSet
    {
        public int Id { get; set; }
        public string nombreUsuario { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string puntajeMaximo { get; set; }
        public Nullable<byte> fotoPerfil { get; set; }
    }
}