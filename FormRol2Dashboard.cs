using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoelGramajoProyectoFinalBD2022
{
    public partial class FormRol2Dashboard : Form
    {
        public FormRol2Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddConsolaVJ form1 = new FormAddConsolaVJ();
            form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAddPremio formAddPremio = new FormAddPremio();
            formAddPremio.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAddConsolaVJ formAddConsolaVJ = new FormAddConsolaVJ();
            formAddConsolaVJ.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAddGeneroVJ formAddGeneroVJ = new FormAddGeneroVJ();
            formAddGeneroVJ.ShowDialog();   
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormAddRol formAddRol = new FormAddRol();
            formAddRol.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormAddEmpleado formAddEmpleado = new FormAddEmpleado();
            formAddEmpleado.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormConsultarPremios formConsultarPremios = new FormConsultarPremios();
            formConsultarPremios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsultaConsolasVJ formConsultaConsolasVJ = new FormConsultaConsolasVJ();
            formConsultaConsolasVJ.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormConsultasGenerosVJ formConsultasGenerosVJ = new FormConsultasGenerosVJ();
            formConsultasGenerosVJ.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormConsultarRoles formConsultarRoles = new FormConsultarRoles();
            formConsultarRoles.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormConsultarEmpleados formConsultarEmpleados = new FormConsultarEmpleados();
            formConsultarEmpleados.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormEditPremio formEditPremio = new FormEditPremio();
            formEditPremio.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormEditarConsolaVJ formEditarConsolaVJ = new FormEditarConsolaVJ();
            formEditarConsolaVJ.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormEditarGeneroVJ formEditarGeneroVJ = new FormEditarGeneroVJ();
            formEditarGeneroVJ.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormEditarRol formEditarRol = new FormEditarRol();
            formEditarRol.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FormEditarEmpleado formEditarEmpleado = new FormEditarEmpleado();
            formEditarEmpleado.ShowDialog();
        }
    }
}
