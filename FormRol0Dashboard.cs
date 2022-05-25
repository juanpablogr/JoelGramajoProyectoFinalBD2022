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
    public partial class FormRol0Dashboard : Form
    {
        public FormRol0Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConsultarPremios form1 = new FormConsultarPremios();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsultaConsolasVJ form2 = new FormConsultaConsolasVJ();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormConsultasGenerosVJ form3 = new FormConsultasGenerosVJ();
            form3.ShowDialog();
        }
    }
}
