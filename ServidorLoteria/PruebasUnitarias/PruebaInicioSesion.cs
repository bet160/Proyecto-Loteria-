using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccesoBD;
using ServidorLoteria;
using System.Linq;
using System.ServiceModel;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaInicioSesion
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*string nombreEsperado = "Manuel";
            string correoEsperado = "betohdz-06@hotmail.com";
            string contraseñaEsperada = "12";*/
            CuentaSet cuentaEsperada = new CuentaSet()
            {
                nombreUsuario = "Manuel",
                correo = "betohdz-06@hotmail.com",
                contraseña = "12",
                puntajeMaximo = null,
                fotoPerfil = null
                
            };

            MetodosImplementados metodo = new MetodosImplementados();
            ServidorLoteria.ServicioCuentaUsuario servicio = new ServidorLoteria.ServicioCuentaUsuario(metodo);

            servicio.IniciarSesion("Manuel", "12");

            Assert.AreEqual<String>("Manuel",
                metodo.Response.nombreUsuario);
        }
    }
}
