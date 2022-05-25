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
    public partial class FormEditarGeneroVJ : Form
    {
        Copilot copilot = new Copilot();
        DataTable table;

        public FormEditarGeneroVJ()
        {
            InitializeComponent();
        }

        private void FormEditarGeneroVJ_Load(object sender, EventArgs e)
        {
            try
            {
                int idx = int.Parse(Interaction.InputBox("Ingrese un ID válido:", "Editar", ""));
                table = copilot.ExecuteCommand("Select * From GeneroVJ Where IdGeneroVJ=" + idx);

                textBox4.Text = table.Rows[0].Field<string>("NombreGenero");
                textBox5.Text = table.Rows[0].Field<string>("DescripcionGen");
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
                copilot.ExecuteCommand("Update GeneroVJ Set " +
                    "NombreGenero='" + textBox4.Text + "', " +
                    "DescripcionGen='" + textBox5.Text + "' " +
                    "Where IdGeneroVJ=" + table.Rows[0].Field<int>("IdGeneroVJ"));
            }
            catch
            {
                copilot.ShowErr(this, "Datos inválidos!");
            }
        }
    }
    }
}
