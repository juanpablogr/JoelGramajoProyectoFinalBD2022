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
    public partial class FormConsultarRoles : Form
    {
        Copilot copilot = new Copilot();

        public FormConsultarRoles()
        {
            InitializeComponent();
        }

        private void FormConsultarRoles_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = copilot.ExecuteCommand("Select * From Rol");
        }
    }
}
