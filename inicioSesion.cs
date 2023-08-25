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

namespace examenTecnico
{
    public partial class inicioSesion : Form
    {
        public inicioSesion()
        {
            InitializeComponent();
        }


        public int inicio(string usuario)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                try
                {
                    int res = 0;
                    SqlCommand cmd = new SqlCommand("sp_login", cn);
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                    res = Convert.ToInt32(cmd.ExecuteScalar());
                    return res;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al iniciar sesion");
                    return -1;
                }
            }
        }

        private void inicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario = tb_usuario.Text;
            if (inicio(usuario) == 1)
            {
                Form1 forma = new Form1(1);
                this.Hide();
                forma.ShowDialog();
            }
            if (inicio(usuario) == 0)
            {
                Form1 forma = new Form1(0);
                this.Hide();
                forma.ShowDialog();
            }
        }
    }
}
