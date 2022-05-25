using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoelGramajoProyectoFinalBD2022
{
    internal class Copilot
    {
        public Copilot()
        {

        }

        public DataTable ExecuteCommand(string command)
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
    }
}
