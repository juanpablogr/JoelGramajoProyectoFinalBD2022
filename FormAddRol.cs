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
    public partial class FormAddRol : Form
    {
        Copilot copilot = new Copilot();

        public FormAddRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    throw new Exception();
                }

                copilot.ExecuteCommand("Insert Into Rol values (" +
                    "" + comboBox1.SelectedIndex + ", " +
                    "'" + textBox4.Text + "', " +
                    "'" + textBox5.Text + "' " + 
                    ")");

                copilot.ShowInfo(this, "Datos guardados con éxito!");
                this.Dispose();
            }
            catch (Exception ex)
            {
                copilot.ShowErr(this, ex.Message);
                copilot.ShowErr(this, "Error, recuerde completar los campos necesarios con los datos correspondientes y no agregar datos duplicados!");
            }
        }
    }
}
