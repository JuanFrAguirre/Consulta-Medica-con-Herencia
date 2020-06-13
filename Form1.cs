using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConKaty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            //variable para sacar el sexo de los rdo btn del medico
            int sexo = 0;
            if (rdoMascMed.Checked) sexo = 1;
            if (rdoFemMed.Checked) sexo = 2;
            if (rdoOtroMed.Checked) sexo = 3;

            //instanciar la clase Medico
            Medico Favaloro = new Medico(txtNombreMed.Text, int.Parse(txtDNIMed.Text), long.Parse(txtTelefonoMed.Text), sexo, cboEspecialidad.SelectedIndex + 1, double.Parse(txtCostoConsulta.Text));

            MessageBox.Show(Favaloro.MostrarDatosMedico(), "Registro de Medico Exitoso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            //variable para sacar el sexo de los rdo btn del medico
            int sexo = 0;
            if (rdoMascPac.Checked) sexo = 1;
            if (rdoFemPac.Checked) sexo = 2;
            if (rdoOtroPac.Checked) sexo = 3;

            //instanciar la clase Medico
            Paciente Katy = new Paciente(txtNombrePac.Text, int.Parse(txtDNIPac.Text), long.Parse(txtTelefonoPac.Text), sexo, cboObraSocial.SelectedIndex + 1, int.Parse(txtHistoriaClinica.Text));

            MessageBox.Show(Katy.MostrarDatosPaciente(), "Alta de Paciente Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}