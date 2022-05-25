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
    public partial class FormAddEmpleado : Form
    {
        Copilot copilot = new Copilot();

        public FormAddEmpleado()
        {
            InitializeComponent();
        }

        private void FormAddEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                copilot.ExecuteCommand("Insert Into Empleado values (" +
                    "'" + textBox1.Text + "', " +
                    "'" + textBox2.Text + "' " +
                    ")");

                copilot.ShowInfo(this, "Datos guardados con éxito!");
                this.Dispose();
            }
            catch (Exception ex)
            {
                copilot.ShowErr(this, ex.Message);
                copilot.ShowErr(this, "Error, recuerde completar los campos necesarios con los datos correspondientes!");
            }
        }
    }
}
