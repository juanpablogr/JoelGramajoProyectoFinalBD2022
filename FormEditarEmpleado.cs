using Microsoft.VisualBasic;
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
    public partial class FormEditarEmpleado : Form
    {
        Copilot copilot = new Copilot();
        DataTable table;

        public FormEditarEmpleado()
        {
            InitializeComponent();
        }

        private void FormEditarEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                string idx = Interaction.InputBox("Ingrese un nombre de usuario válido:", "Editar", "");
                table = copilot.ExecuteCommand("Select * From Empleado Where NameUsu like '" + idx + "'");

                textBox1.Text = table.Rows[0].Field<string>("NameUsu");
                textBox2.Text = table.Rows[0].Field<string>("PasswordUsu");
            }
            catch
            {
                copilot.ShowErr(this, "Por favor, ingrese un nombre válido!");
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                copilot.ExecuteCommand("Update Empleado Set " +
                    "NameUsu='" + textBox1.Text + "', " +
                    "PasswordUsu='" + textBox2.Text + "' " +
                    "Where NameUsu like '" + table.Rows[0].Field<string>("NameUsu") + "'");
            }
            catch
            {
                copilot.ShowErr(this, "Datos inválidos!");
            }
        }
    }
}
