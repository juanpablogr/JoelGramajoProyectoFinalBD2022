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
    public partial class FormUsuarioMainForm : Form
    {
        public string nameUsu;

        public FormUsuarioMainForm()
        {
            InitializeComponent();
        }

        private void FormUsuarioMainForm_Load(object sender, EventArgs e)
        {
            label2.Text = nameUsu;
        }
    }
}
