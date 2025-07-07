using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilerias
{
    public class Utilerias
    {
        public string NombreUtileria { get; set; }
        public int NumerOperacion { get; set; }

        public Utilerias()
        {
            NombreUtileria = "Utileria de Prueba";
            NumerOperacion = 1;
        }

        public string DevolverNombreUtileria(string nombre)
        {
            return nombre;
        }

        public decimal DevolverResultadoOperacion(decimal num1, decimal num2)
        {
            return num1 + num2; // Suma
        }

    }

}
