using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaEmail
{
    public class EnvioDeCorreo
    {
        private bool correoEnviado = false;

        public bool EnviarCorreo(string correoDestinatario, string CodigoDeVerificacion)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.To.Add(correoDestinatario);
            mensaje.Subject = "LOTERIA: Código de verificación";
            mensaje.SubjectEncoding = Encoding.UTF8;
            mensaje.Body = "Código de verificación: " + CodigoDeVerificacion;
            mensaje.BodyEncoding = Encoding.UTF8;
            mensaje.From = new MailAddress("loteriafei@gmail.com");

            SmtpClient clienteCorreo = new SmtpClient();
            clienteCorreo.Credentials = new NetworkCredential("loteriafei@gmail.com", "LoteriaFei2019");
            clienteCorreo.Port = 587;
            clienteCorreo.EnableSsl = true;
            clienteCorreo.Host = "smtp.gmail.com";

            try
            {
                clienteCorreo.Send(mensaje);
                correoEnviado = true;
                return correoEnviado;
            }
            catch (Exception)
            {
                throw;
            }
        } 
    }
}
