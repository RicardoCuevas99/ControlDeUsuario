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
    public partial class frm_actualizar : Form
    {
        int idUsuario;
        public frm_actualizar(int id)
        {
            InitializeComponent();
            idUsuario = id;

        }

        private void frm_actualizar_Load(object sender, EventArgs e)
        {
            cargarDatosUsuario();
        }

        public DataTable BuscarUsuario(int idUsuario)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {

                string consulta = "select *from Usuario where idUsuario=@idUsuario";
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
        }

        public void cargarDatosUsuario()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-33G778R;Initial Catalog=ABC;Integrated Security=True"))
            {
                DataTable Usuario = new DataTable();
                Usuario = BuscarUsuario(idUsuario);


                tb_id.Text = Usuario.Rows[0]["idUsuario"].ToString();
                tb_usuario.Text = Usuario.Rows[0]["usuario"].ToString();
                cb_tipoUsuario.Text = Usuario.Rows[0]["tipoUsuario"].ToString();
                rb_activo.Text = Usuario.Rows[0]["activo"].ToString();
                rb_inactivo.Text = Usuario.Rows[0]["activo"].ToString();
                tb_nombre.Text = Usuario.Rows[0]["nombre"].ToString();
                tb_apellidoPat.Text = Usuario.Rows[0]["apellidoPaterno"].ToString();
                tb_apellidoMat.Text = Usuario.Rows[0]["apellidoMaterno"].ToString();
                tb_edad.Text = Usuario.Rows[0]["edad"].ToString();
                tb_direccion.Text = Usuario.Rows[0]["dirección"].ToString();

            }

        }

        public void llenarComboTipoUsuario()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                string consulta = "select *from tiposUsuario";
                SqlCommand cmd = new SqlCommand(consulta, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["nombreTipoUsuario"] = "Seleccionar";
                dt.Rows.InsertAt(fila, 0);
                cb_tipoUsuario.DisplayMember = "nombreTipoUsuario";
                cb_tipoUsuario.ValueMember = "idTipoUsuario";
                cb_tipoUsuario.DataSource = dt;
            }
        }
        public int verificarActivos()
        {
            if (rb_activo.Checked)
            {
                return 1;
            }
            else if (rb_inactivo.Checked)
            {
                return 0;
            }
            else { return -1; }
        }

        public void actualizarUsuario(int idUsuario, string pUsuario, int pTipoUsuario, string pNombre, string pApellidoPaterno, string pApellidoMaterno, int pEdad, string pDirección)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_actualizarUsuario", cn);
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = pUsuario;
                    cmd.Parameters.Add("@tipoUsuario", SqlDbType.Int).Value = pTipoUsuario;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = pNombre;
                    cmd.Parameters.Add("@apellidoPaterno", SqlDbType.VarChar).Value = pApellidoPaterno;
                    cmd.Parameters.Add("@apellidoMaterno", SqlDbType.VarChar).Value = pApellidoMaterno;
                    cmd.Parameters.Add("@edad", SqlDbType.Int).Value = pEdad;
                    cmd.Parameters.Add("@dirección", SqlDbType.VarChar).Value = pDirección;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("usuario se ha actualizado con Exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar el registro");
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string Usuario = tb_usuario.Text;
            int TipoUsuario = Convert.ToInt32(cb_tipoUsuario.SelectedValue);
            string Nombre = tb_nombre.Text;
            string ApellidoPaterno = tb_apellidoPat.Text;
            string ApellidoMaterno = tb_apellidoMat.Text;
            int Edad = Convert.ToInt32(tb_edad.Text);
            string Direccion = tb_direccion.Text;
            actualizarUsuario(idUsuario, Usuario, TipoUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, Edad, Direccion);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.ShowDialog();

        }

        private void tb_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suprime el carácter ingresado si no es una letra o una tecla de control
            }
        }

        private void tb_apellidoPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suprime el carácter ingresado si no es una letra o una tecla de control
            }
        }

        private void tb_apellidoMat_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
    {
        e.Handled = true; // Suprime el carácter ingresado si no es una letra o una tecla de control
    }
        }
    }
}
