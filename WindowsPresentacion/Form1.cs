using LibCaso3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.Nombre = "Juan";
            medico.Apellido = "Perez";
            medico.Matricula = "AE321G";

            MessageBox.Show(medico.ToString());

            Paciente paciente = new Paciente();

            paciente.Nombre = "Julian";
            paciente.Apellido = "Rosales";
            paciente.dni = "13415512";

            MessageBox.Show(paciente.ToString());
        }
    }
}
