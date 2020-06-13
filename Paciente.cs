using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConKaty
{
    internal class Paciente : Persona
    {
        //propiedades
        public int ObraSocial { get; set; }

        public int HistoriaClinica { get; set; }

        //constructores
        public Paciente() : base()
        {
            ObraSocial = HistoriaClinica = 0;
        }

        public Paciente(string nombre, int dni, long numTelefono, int sexo, int obraSocial, int historiaClinica) : base(nombre, dni, numTelefono, sexo)
        {
            ObraSocial = obraSocial;
            HistoriaClinica = historiaClinica;
        }

        //metodos
        public string MostrarObraSocial()
        {
            switch (ObraSocial)
            {
                case 1: return "PAMI";
                case 2: return "Nobis";
                case 3: return "Swiss Medical";
                case 4: return "Medife";
                case 5: return "OSDE";
                default: return "No ha seleccionado una obra social";
            }
        }

        public string MostrarDatosPaciente()
        {
            return
                $"{MostrarDatosPersona()}\n" +
                $"Obra Social: {MostrarObraSocial()}\n" +
                $"Historia Clinica: {HistoriaClinica}";
        }
    }
}