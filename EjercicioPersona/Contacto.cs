using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EjercicioPersona
{
    public class Contacto : Persona
    {
        public int Tel { get; set; }  
        public string Email { get; set; }
        public string RFC { get; set; }

       /* public void Datos(string Nombre, string ApPaterno, string ApMaterno, String Fecha_Nac, int Tel, string Email)
        {
           this.Nombre = Nombre;
           this.ApPaterno = ApPaterno;
           this.ApMaterno  = ApMaterno;
           this.Fecha_Nac = Fecha_Nac;
           this.Tel = Tel;
           this.Email = Email;
        }*/

        
        public string Extraccion(string ApPaterno, string ApMaterno, string Nombre, string Fecha_Nac)
        {
            this.Nombre = Nombre.Substring(0,1);
            this.ApPaterno= ApPaterno.Substring(0, 2);
            this.ApMaterno= ApMaterno.Substring(0, 1);
            this.Fecha_Nac= Fecha_Nac.Substring(0, 6);
            this.RFC += this.ApPaterno;
            this.RFC += this.ApMaterno;
            this.RFC += this.Nombre;
            this.RFC += this.Fecha_Nac;

            return this.RFC;
        }
       
    }
}
