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
    public partial class FormEditarRol : Form
    {
        Copilot copilot = new Copilot();
        DataTable table;

        public FormEditarRol()
        {
            InitializeComponent();
        }

        private void FormEditarRol_Load(object sender, EventArgs e)
        {
            try
            {
                int idx = int.Parse(Interaction.InputBox("Ingrese un ID válido:", "Editar", ""));
                table = copilot.ExecuteCommand("Select * From Rol Where IdRol=" + idx);

                textBox4.Text = table.Rows[0].Field<string>("NombreRol");
                textBox5.Text = table.Rows[0].Field<string>("DescRol");
            }
            catch
            {
                copilot.ShowErr(this, "Por favor, ingrese un id válido!");
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                copilot.ExecuteCommand("Update Rol Set " +
                    "NombreRol='" + textBox4.Text + "', " +
                    "DescRol='" + textBox5.Text + "' " +
                    "Where IdRol=" + table.Rows[0].Field<int>("IdRol"));
            }
            catch
            {
                copilot.ShowErr(this, "Datos inválidos!");
            }
        }
    }
}
