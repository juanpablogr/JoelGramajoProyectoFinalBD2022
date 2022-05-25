using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace JoelGramajoProyectoFinalBD2022
{
    public partial class FormEditPremio : Form
    {
        Copilot copilot = new Copilot();
        DataTable table;

        public FormEditPremio()
        {
            InitializeComponent();
        }

        private void FormEditPremio_Load(object sender, EventArgs e)
        {
            try
            {
                int idPremio = int.Parse(Interaction.InputBox("Ingrese un ID de premio:", "Editar premio", ""));
                table = copilot.ExecuteCommand("Select * From Premio Where IdPremio=" + idPremio);

                textBox1.Text = table.Rows[0].Field<string>("NombrePremio");
                textBox2.Text = table.Rows[0].Field<string>("DescPremio");
            }
            catch
            {
                copilot.ShowErr(this, "Por favor, ingrese un id de premio válido!");
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                copilot.ExecuteCommand("Update Premio Set " +
                    "NombrePremio='" + textBox1.Text + "', " +
                    "DescPremio='" + textBox2.Text + "' " +
                    "Where IdPremio=" + table.Rows[0].Field<int>("IdPremio"));
            }
            catch 
            {
                copilot.ShowErr(this, "Datos inválidos!");
            }
        }
    }
}
