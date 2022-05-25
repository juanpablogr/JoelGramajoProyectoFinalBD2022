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
    public partial class FormRol1Dashboard : Form
    {
        public FormRol1Dashboard()
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
            FormAddPremio form1 = new FormAddPremio();
            form1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAddGeneroVJ form2 = new FormAddGeneroVJ();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormConsultarPremios form3 = new FormConsultarPremios();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsultaConsolasVJ form4 = new FormConsultaConsolasVJ();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormConsultasGenerosVJ form5 = new FormConsultasGenerosVJ();
            form5.ShowDialog();
        }
    }
}
