using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace examenTecnico
{
    public partial class Form1 : Form
    {
        private int rolUsuario;

        public Form1()
        {
            InitializeComponent();
            llenarComboFiltrar();
            tb_id.Enabled = false;
            rb_activo.Checked = true;

        }
        public Form1(int rol)
        {
            InitializeComponent();
            //gb_activo.Enabled = false;
            rolUsuario = rol;

            if (rolUsuario == 1)
            {
                // Habilitar funcionalidades de administrador
                llenarComboFiltrar();
                tb_id.Enabled = false;
                rb_activo.Checked = true;
            }
            else if (rolUsuario == 0)
            {
                // Habilitar funcionalidades de usuario general
                btn_actualizar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_insertar.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_usuario.DataSource = mostrarDatos();
            llenarComboTipoUsuario();

        }


        public DataTable mostrarDatos()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("sp_consultaUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable filtrarNombre()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                string consulta = "select *from Usuario order by nombre asc";
                SqlCommand cmd = new SqlCommand(consulta, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable FiltrarActivos()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                string consulta = "select *from Usuario order by area asc";
                SqlCommand cmd = new SqlCommand(consulta, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable FiltrarArea()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                string consulta = "select *from Usuario order by activo asc";
                SqlCommand cmd = new SqlCommand(consulta, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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

        public void llenarComboFiltrar()
        {
            cb_filtrar.Items.Add("Seleccione");
            cb_filtrar.Items.Add("Nombre");
            cb_filtrar.Items.Add("Area");
            cb_filtrar.Items.Add("Activos");

            cb_filtrar.SelectedIndex = 0;
        }

        private void cb_filtrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_filtrar.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Nombre":
                    dgv_usuario.DataSource = filtrarNombre();
                    break;
                case "Area":
                    dgv_usuario.DataSource = FiltrarArea();
                    break;
                case "Activos":
                    dgv_usuario.DataSource = FiltrarActivos();
                    break;
                default:
                    break;
            }
        }

        public void insertarUsuario(string pUsuario, int pTipoUsuario, string pArea, int pActivo, string pNombre, string pApellidoPaterno, string pApellidoMaterno, int pEdad, string pDirección)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_altaUsuario", cn);
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = pUsuario;
                    cmd.Parameters.Add("@tipoUsuario", SqlDbType.Int).Value = pTipoUsuario;
                    cmd.Parameters.Add("@area", SqlDbType.VarChar).Value = pArea;
                    cmd.Parameters.Add("@activo", SqlDbType.Int).Value = pActivo;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = pNombre;
                    cmd.Parameters.Add("@apellidoPaterno", SqlDbType.VarChar).Value = pApellidoPaterno;
                    cmd.Parameters.Add("@apellidoMaterno", SqlDbType.VarChar).Value = pApellidoMaterno;
                    cmd.Parameters.Add("@edad", SqlDbType.Int).Value = pEdad;
                    cmd.Parameters.Add("@dirección", SqlDbType.VarChar).Value = pDirección;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("usuario Ingresado con Exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar el registro");
                }
            }
        }

        public void eliminarUsuario(int idUsuario)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_bajaUsuario", cn);
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("el usuario no existe");
                }

            }
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


        private void btn_insertar_Click(object sender, EventArgs e)
        {
            string Usuario = tb_usuario.Text;
            int TipoUsuario = Convert.ToInt32(cb_tipoUsuario.SelectedValue);
            string Area = tb_area.Text;
            int Activo = verificarActivos();
            string Nombre = tb_nombre.Text;
            string ApellidoPaterno = tb_apellidoPat.Text;
            string ApellidoMaterno = tb_apellidoMat.Text;
            int Edad = Convert.ToInt32(tb_edad.Text);
            string Direccion = tb_direccion.Text;

            if (verificarusuario(Usuario) == 0)
            {
                insertarUsuario(Usuario, TipoUsuario, Area, Activo, Nombre, ApellidoPaterno, ApellidoMaterno, Edad, Direccion);
                dgv_usuario.DataSource = mostrarDatos();
                vaciarCampos();
            }
            else
            {
                MessageBox.Show("el usuario " + Usuario + " ya existe");
            }
        }

        private void cb_tipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void actualizarUsuario(int idUsuario, string pUsuario, int pTipoUsuario, int activo, string pNombre, string pApellidoPaterno, string pApellidoMaterno, int pEdad, string pDirección)
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgv_usuario.CurrentRow.Cells[0].Value);
            DialogResult resul = MessageBox.Show("Esta seguro que quiere borrar el registro", "", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                eliminarUsuario(ID);
                dgv_usuario.DataSource = mostrarDatos();
            }
            else
            {

            }
        }

        public void vaciarCampos()
        {
            tb_usuario.Text = "";
            tb_area.Text = "";
            cb_tipoUsuario.SelectedIndex = 0;
            tb_nombre.Text = "";
            tb_apellidoPat.Text = ""; ;
            tb_apellidoMat.Text = "";
            tb_edad.Text = "";
            tb_direccion.Text = "";
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgv_usuario.CurrentRow.Cells[0].Value);
            frm_actualizar form = new frm_actualizar(ID);
            this.Hide();
            form.ShowDialog();
        }

        public int verificarusuario(string usuario)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=ricardoCuevas\\SQLEXPRESS;Initial Catalog=ControlUsuario;Integrated Security=True"))
            {
                int res = 0;
                SqlCommand cmd = new SqlCommand("sp_existeUsuario", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                res = Convert.ToInt32(cmd.ExecuteScalar());
                return res;
            }
        }

        private void tb_edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suprime el carácter ingresado si no es un número o una tecla de control
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