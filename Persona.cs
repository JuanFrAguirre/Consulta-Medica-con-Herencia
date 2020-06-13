using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConKaty
{
    internal abstract class Persona
    {
        //propiedades
        public string Nombre { get; set; }

        public int DNI { get; set; }
        public long NumTelefono { get; set; }
        public int Sexo { get; set; }

        //constructores
        public Persona()
        {
            Nombre = "";
            NumTelefono = DNI = Sexo = 0;
        }

        public Persona(string nombre, int dni, long numTelefono, int sexo)
        {
            Nombre = nombre;
            DNI = dni;
            NumTelefono = numTelefono;
            Sexo = sexo;
        }

        //metodos
        public string MostrarSexo()
        {
            switch (Sexo)
            {
                case 1: return "Masculino";
                case 2: return "Femenino";
                default: return "Otro";
            }
        }

        public string MostrarDatosPersona()
        {
            return
                $"Nombre: {Nombre}\n" +
                $"DNI: {DNI}\n" +
                $"Telefono: {NumTelefono}\n" +
                $"Sexo: {MostrarSexo()}";
        }
    }
}