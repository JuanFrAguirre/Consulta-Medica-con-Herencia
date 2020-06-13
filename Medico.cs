using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConKaty
{
    internal class Medico : Persona
    {
        //propiedades
        public int Especialidad { get; set; }

        public double CostoConsulta { get; set; }

        //constructores
        public Medico() : base()
        {
            CostoConsulta = Especialidad = 0;
        }

        public Medico(string nombre, int dni, long numTelefono, int sexo, int especialidad, double costoConsulta) : base(nombre, dni, numTelefono, sexo)
        {
            Especialidad = especialidad;
            CostoConsulta = costoConsulta;
        }

        //metodos
        public string MostrarEspecialidad()
        {
            switch (Especialidad)
            {
                case 1: return "Cardiologia";
                case 2: return "Pediatria";
                case 3: return "Odontologia";
                case 4: return "Ginecologia";
                case 5: return "Traumatologia";
                default: return "No se ha seleccionado especialidad";
            }
        }

        public string MostrarDatosMedico()
        {
            return
                $"{MostrarDatosPersona()}\n" +
                $"Especialidad: {MostrarEspecialidad()}\n" +
                $"Costo de la consulta: ${CostoConsulta}";
        }
    }
}