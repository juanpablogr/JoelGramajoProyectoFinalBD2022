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
    public partial class FormConsultasGenerosVJ : Form
    {
        Copilot copilot = new Copilot();

        public FormConsultasGenerosVJ()
        {
            InitializeComponent();
        }

        private void FormConsultasGenerosVJ_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = copilot.ExecuteCommand("Select * From GeneroVJ");
        }
    }
}
