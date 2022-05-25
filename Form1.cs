using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoelGramajoProyectoFinalBD2022
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        DataTable ExecuteCommand(string command)
        {
            DataTable outputData = new DataTable();

            using (SqlConnection conex = new SqlConnection("Server=LAPTOP-GH0QKC17; Database=proyectoFinalBD; User Id=sa; Password=database;"))
            {
                // --- conexion con sql server ---
                conex.Open();
                SqlCommand comando = new SqlCommand(command, conex);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(outputData);
                // --- FIN  ---
            }

            return outputData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable usuariosClientes = ExecuteCommand("Select * From Participante");
            dataGridView1.DataSource = usuariosClientes;

        }
    }
}
