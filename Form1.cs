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
        Copilot copilot = new Copilot();

        public FormLogin()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {


            DataTable usuariosClientes = copilot.ExecuteCommand("Select * From Participante");
            usuariosClientes = copilot.ExecuteCommand("Select NickName, Password From Participante Where NickName like '" + textBox1.Text + "' and Password like '" + textBox2.Text + "'");

            if (usuariosClientes.Rows.Count != 0)
            { // loguea cliente
                MessageBox.Show("Participante logueado con exito!");
                FormUsuarioMainForm form = new FormUsuarioMainForm();
                form.nameUsu = usuariosClientes.Rows[0].Field<string>("NickName");
                form.ShowDialog();

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            { // loguea otro tipo usuario
                DataTable table1 = copilot.ExecuteCommand("Select E.NameUsu, E.PasswordUsu, R.IdRol From Ejerce as R, Empleado as E Where R.NameUsu = E.NameUsu and E.NameUsu like '"+ textBox1.Text + "' and E.PasswordUsu like '" + textBox2.Text + "'");
                int idx = table1.Rows[0].Field<int>("IdRol");

                if (idx == 0)
                {
                    FormRol0Dashboard form = new FormRol0Dashboard();
                    form.label2.Text = table1.Rows[0].Field<string>("NameUsu");
                    form.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    if (idx == 1)
                    {
                        FormRol1Dashboard form1 = new FormRol1Dashboard();
                        form1.label2.Text = table1.Rows[0].Field<string>("NameUsu");
                        form1.ShowDialog();
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else
                    {
                        if (idx == 2)
                        {
                            FormRol2Dashboard form2 = new FormRol2Dashboard();
                            form2.label2.Text = table1.Rows[0].Field<string>("NameUsu");
                            form2.ShowDialog();
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        else
                        {
                            if (idx == 3)
                            {
                                FormRol3Dashboard form3 = new FormRol3Dashboard();
                                form3.label2.Text = table1.Rows[0].Field<string>("NameUsu");
                                form3.ShowDialog();
                                textBox1.Text = "";
                                textBox2.Text = "";
                            }
                            else
                            {
                                copilot.ShowErr(this, "Contraseña o usuario incorrectos!");
                            }
                        }
                    }
                }
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}