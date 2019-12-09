using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WCF_User_Client.Model
{
    class Tabla
    {
        private int idTabla;
        private List<Image> cartasDeTabla;

        public int IdTabla { get => idTabla; set => idTabla = value; }
        public List<Image> CartasDeTabla { get => cartasDeTabla; set => cartasDeTabla = value; }
    }
}
