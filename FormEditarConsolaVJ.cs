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
    public partial class FormEditarConsolaVJ : Form
    {
        Copilot copilot = new Copilot();
        DataTable table;

        public FormEditarConsolaVJ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                copilot.ExecuteCommand("Update ConsolaVJ Set " +
                    "NombreCom='" + textBox1.Text + "', " +
                    "Marca='" + textBox2.Text + "', " +
                    "TamPulgadas='" + textBox3.Text + "', " +
                    "AnioFab=" + textBox4.Text + ", " +
                    "DescGeneral='" + textBox5.Text + "', " +
                    "CaractTecnicas='" + textBox6.Text + "' " +
                    "Where IdConsola=" + table.Rows[0].Field<int>("IdConsola"));
            }
            catch
            {
                copilot.ShowErr(this, "Datos inválidos!");
            }
        }

        private void FormEditarConsolaVJ_Load(object sender, EventArgs e)
        {
            try
            {
                int idx = int.Parse(Interaction.InputBox("Ingrese un ID de consola:", "Editar", ""));
                table = copilot.ExecuteCommand("Select * From ConsolaVJ Where IdConsola=" + idx);

                textBox1.Text = table.Rows[0].Field<string>("NombreCom");
                textBox2.Text = table.Rows[0].Field<string>("Marca");
                textBox3.Text = table.Rows[0].Field<string>("TamPulgadas");
                textBox4.Text = table.Rows[0].Field<string>("AnioFab");
                textBox5.Text = table.Rows[0].Field<string>("DescGeneral");
                textBox6.Text = table.Rows[0].Field<string>("CaractTecnicas");
            }
            catch
            {
                copilot.ShowErr(this, "Por favor, ingrese un id válido!");
                this.Dispose();
            }
        }
    }
}
