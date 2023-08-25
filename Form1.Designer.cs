namespace examenTecnico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_usuario = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tb_id = new TextBox();
            tb_area = new TextBox();
            tb_nombre = new TextBox();
            tb_apellidoPat = new TextBox();
            tb_apellidoMat = new TextBox();
            tb_usuario = new TextBox();
            tb_edad = new TextBox();
            cb_tipoUsuario = new ComboBox();
            tb_direccion = new TextBox();
            label10 = new Label();
            btn_insertar = new Button();
            btn_eliminar = new Button();
            btn_actualizar = new Button();
            label11 = new Label();
            rb_activo = new RadioButton();
            gb_activo = new GroupBox();
            rb_inactivo = new RadioButton();
            cb_filtrar = new ComboBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_usuario).BeginInit();
            gb_activo.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_usuario
            // 
            dgv_usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuario.Location = new Point(393, 118);
            dgv_usuario.Name = "dgv_usuario";
            dgv_usuario.RowTemplate.Height = 25;
            dgv_usuario.Size = new Size(590, 296);
            dgv_usuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 30);
            label1.Name = "label1";
            label1.Size = new Size(267, 37);
            label1.TabIndex = 1;
            label1.Text = "Control de usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 87);
            label2.Name = "label2";
            label2.Size = new Size(22, 17);
            label2.TabIndex = 2;
            label2.Text = "id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(59, 125);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 3;
            label3.Text = "usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 162);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 4;
            label4.Text = "tipo usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(76, 202);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 5;
            label5.Text = "area:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 297);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 6;
            label6.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(4, 336);
            label7.Name = "label7";
            label7.Size = new Size(109, 17);
            label7.TabIndex = 7;
            label7.Text = "Apellido paterno:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1, 381);
            label8.Name = "label8";
            label8.Size = new Size(112, 17);
            label8.TabIndex = 9;
            label8.Text = "Apellido materno:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(72, 423);
            label9.Name = "label9";
            label9.Size = new Size(41, 17);
            label9.TabIndex = 8;
            label9.Text = "edad:";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(110, 86);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(100, 23);
            tb_id.TabIndex = 10;
            // 
            // tb_area
            // 
            tb_area.Location = new Point(110, 201);
            tb_area.Name = "tb_area";
            tb_area.Size = new Size(263, 23);
            tb_area.TabIndex = 12;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(110, 296);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(263, 23);
            tb_nombre.TabIndex = 13;
            tb_nombre.KeyPress += tb_nombre_KeyPress;
            // 
            // tb_apellidoPat
            // 
            tb_apellidoPat.Location = new Point(110, 335);
            tb_apellidoPat.Name = "tb_apellidoPat";
            tb_apellidoPat.Size = new Size(263, 23);
            tb_apellidoPat.TabIndex = 14;
            tb_apellidoPat.KeyPress += tb_apellidoPat_KeyPress;
            // 
            // tb_apellidoMat
            // 
            tb_apellidoMat.Location = new Point(110, 380);
            tb_apellidoMat.Name = "tb_apellidoMat";
            tb_apellidoMat.Size = new Size(263, 23);
            tb_apellidoMat.TabIndex = 15;
            tb_apellidoMat.KeyPress += tb_apellidoMat_KeyPress;
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(110, 124);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(263, 23);
            tb_usuario.TabIndex = 16;
            // 
            // tb_edad
            // 
            tb_edad.Location = new Point(110, 423);
            tb_edad.Name = "tb_edad";
            tb_edad.Size = new Size(263, 23);
            tb_edad.TabIndex = 17;
            tb_edad.TextChanged += tb_edad_TextChanged;
            tb_edad.KeyPress += tb_edad_KeyPress;
            // 
            // cb_tipoUsuario
            // 
            cb_tipoUsuario.FormattingEnabled = true;
            cb_tipoUsuario.Location = new Point(110, 162);
            cb_tipoUsuario.Name = "cb_tipoUsuario";
            cb_tipoUsuario.Size = new Size(263, 23);
            cb_tipoUsuario.TabIndex = 18;
            cb_tipoUsuario.SelectedIndexChanged += cb_tipoUsuario_SelectedIndexChanged;
            // 
            // tb_direccion
            // 
            tb_direccion.Location = new Point(110, 463);
            tb_direccion.Name = "tb_direccion";
            tb_direccion.Size = new Size(263, 23);
            tb_direccion.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(49, 464);
            label10.Name = "label10";
            label10.Size = new Size(64, 17);
            label10.TabIndex = 19;
            label10.Text = "dirección:";
            // 
            // btn_insertar
            // 
            btn_insertar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_insertar.Location = new Point(393, 420);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(193, 38);
            btn_insertar.TabIndex = 21;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = true;
            btn_insertar.Click += btn_insertar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_eliminar.Location = new Point(790, 420);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(193, 38);
            btn_eliminar.TabIndex = 22;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_actualizar.Location = new Point(591, 420);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(193, 38);
            btn_actualizar.TabIndex = 23;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(68, 252);
            label11.Name = "label11";
            label11.Size = new Size(45, 17);
            label11.TabIndex = 24;
            label11.Text = "activo:";
            // 
            // rb_activo
            // 
            rb_activo.AutoSize = true;
            rb_activo.Location = new Point(23, 22);
            rb_activo.Name = "rb_activo";
            rb_activo.Size = new Size(57, 19);
            rb_activo.TabIndex = 25;
            rb_activo.TabStop = true;
            rb_activo.Text = "activo";
            rb_activo.UseVisualStyleBackColor = true;
            // 
            // gb_activo
            // 
            gb_activo.Controls.Add(rb_inactivo);
            gb_activo.Controls.Add(rb_activo);
            gb_activo.Location = new Point(119, 230);
            gb_activo.Name = "gb_activo";
            gb_activo.Size = new Size(236, 60);
            gb_activo.TabIndex = 26;
            gb_activo.TabStop = false;
            // 
            // rb_inactivo
            // 
            rb_inactivo.AutoSize = true;
            rb_inactivo.Location = new Point(123, 22);
            rb_inactivo.Name = "rb_inactivo";
            rb_inactivo.Size = new Size(67, 19);
            rb_inactivo.TabIndex = 27;
            rb_inactivo.TabStop = true;
            rb_inactivo.Text = "inactivo";
            rb_inactivo.UseVisualStyleBackColor = true;
            // 
            // cb_filtrar
            // 
            cb_filtrar.FormattingEnabled = true;
            cb_filtrar.Location = new Point(862, 89);
            cb_filtrar.Name = "cb_filtrar";
            cb_filtrar.Size = new Size(121, 23);
            cb_filtrar.TabIndex = 27;
            cb_filtrar.SelectedIndexChanged += cb_filtrar_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(821, 94);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 28;
            label12.Text = "filtrar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 561);
            Controls.Add(label12);
            Controls.Add(cb_filtrar);
            Controls.Add(gb_activo);
            Controls.Add(label11);
            Controls.Add(btn_actualizar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_insertar);
            Controls.Add(tb_direccion);
            Controls.Add(label10);
            Controls.Add(cb_tipoUsuario);
            Controls.Add(tb_edad);
            Controls.Add(tb_usuario);
            Controls.Add(tb_apellidoMat);
            Controls.Add(tb_apellidoPat);
            Controls.Add(tb_nombre);
            Controls.Add(tb_area);
            Controls.Add(tb_id);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_usuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_usuario).EndInit();
            gb_activo.ResumeLayout(false);
            gb_activo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_usuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tb_id;
        private TextBox tb_area;
        private TextBox tb_nombre;
        private TextBox tb_apellidoPat;
        private TextBox tb_apellidoMat;
        private TextBox tb_usuario;
        private TextBox tb_edad;
        private ComboBox cb_tipoUsuario;
        private TextBox tb_direccion;
        private Label label10;
        private Button btn_insertar;
        private Button btn_eliminar;
        private Button btn_actualizar;
        private Label label11;
        private RadioButton rb_activo;
        private GroupBox gb_activo;
        private RadioButton rb_inactivo;
        private ComboBox cb_filtrar;
        private Label label12;
    }
}