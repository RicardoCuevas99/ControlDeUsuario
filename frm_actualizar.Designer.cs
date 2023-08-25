namespace examenTecnico
{
    partial class frm_actualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_activo = new GroupBox();
            rb_inactivo = new RadioButton();
            rb_activo = new RadioButton();
            label11 = new Label();
            tb_direccion = new TextBox();
            label10 = new Label();
            cb_tipoUsuario = new ComboBox();
            tb_edad = new TextBox();
            tb_usuario = new TextBox();
            tb_apellidoMat = new TextBox();
            tb_apellidoPat = new TextBox();
            tb_nombre = new TextBox();
            tb_id = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_salir = new Button();
            btn_Guardar = new Button();
            gb_activo.SuspendLayout();
            SuspendLayout();
            // 
            // gb_activo
            // 
            gb_activo.Controls.Add(rb_inactivo);
            gb_activo.Controls.Add(rb_activo);
            gb_activo.Location = new Point(128, 250);
            gb_activo.Name = "gb_activo";
            gb_activo.Size = new Size(236, 60);
            gb_activo.TabIndex = 46;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(77, 272);
            label11.Name = "label11";
            label11.Size = new Size(45, 17);
            label11.TabIndex = 45;
            label11.Text = "activo:";
            // 
            // tb_direccion
            // 
            tb_direccion.Location = new Point(551, 296);
            tb_direccion.Multiline = true;
            tb_direccion.Name = "tb_direccion";
            tb_direccion.Size = new Size(296, 23);
            tb_direccion.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(485, 297);
            label10.Name = "label10";
            label10.Size = new Size(64, 17);
            label10.TabIndex = 43;
            label10.Text = "dirección:";
            // 
            // cb_tipoUsuario
            // 
            cb_tipoUsuario.FormattingEnabled = true;
            cb_tipoUsuario.Location = new Point(128, 201);
            cb_tipoUsuario.Name = "cb_tipoUsuario";
            cb_tipoUsuario.Size = new Size(263, 23);
            cb_tipoUsuario.TabIndex = 42;
            // 
            // tb_edad
            // 
            tb_edad.Location = new Point(551, 250);
            tb_edad.Name = "tb_edad";
            tb_edad.Size = new Size(296, 23);
            tb_edad.TabIndex = 41;
            tb_edad.KeyPress += tb_edad_KeyPress;
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(128, 154);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(263, 23);
            tb_usuario.TabIndex = 40;
            // 
            // tb_apellidoMat
            // 
            tb_apellidoMat.Location = new Point(551, 200);
            tb_apellidoMat.Name = "tb_apellidoMat";
            tb_apellidoMat.Size = new Size(296, 23);
            tb_apellidoMat.TabIndex = 39;
            tb_apellidoMat.KeyPress += tb_apellidoMat_KeyPress;
            // 
            // tb_apellidoPat
            // 
            tb_apellidoPat.Location = new Point(551, 154);
            tb_apellidoPat.Name = "tb_apellidoPat";
            tb_apellidoPat.Size = new Size(296, 23);
            tb_apellidoPat.TabIndex = 38;
            tb_apellidoPat.KeyPress += tb_apellidoPat_KeyPress;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(551, 111);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(296, 23);
            tb_nombre.TabIndex = 37;
            tb_nombre.KeyPress += tb_nombre_KeyPress;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(128, 110);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(100, 23);
            tb_id.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(437, 201);
            label8.Name = "label8";
            label8.Size = new Size(112, 17);
            label8.TabIndex = 34;
            label8.Text = "Apellido materno:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(508, 250);
            label9.Name = "label9";
            label9.Size = new Size(41, 17);
            label9.TabIndex = 33;
            label9.Text = "edad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(440, 155);
            label7.Name = "label7";
            label7.Size = new Size(109, 17);
            label7.TabIndex = 32;
            label7.Text = "Apellido paterno:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(485, 112);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 31;
            label6.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 201);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 29;
            label4.Text = "tipo usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 155);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 28;
            label3.Text = "usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 111);
            label2.Name = "label2";
            label2.Size = new Size(22, 17);
            label2.TabIndex = 27;
            label2.Text = "id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(335, 23);
            label1.Name = "label1";
            label1.Size = new Size(201, 30);
            label1.TabIndex = 47;
            label1.Text = "Actualizar Usuarios";
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.Location = new Point(448, 376);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(136, 39);
            btn_salir.TabIndex = 49;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Guardar.Location = new Point(294, 376);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(136, 39);
            btn_Guardar.TabIndex = 50;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // frm_actualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 444);
            Controls.Add(btn_Guardar);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(gb_activo);
            Controls.Add(label11);
            Controls.Add(tb_direccion);
            Controls.Add(label10);
            Controls.Add(cb_tipoUsuario);
            Controls.Add(tb_edad);
            Controls.Add(tb_usuario);
            Controls.Add(tb_apellidoMat);
            Controls.Add(tb_apellidoPat);
            Controls.Add(tb_nombre);
            Controls.Add(tb_id);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frm_actualizar";
            Text = "frm_actualizar";
            Load += frm_actualizar_Load;
            gb_activo.ResumeLayout(false);
            gb_activo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_activo;
        private RadioButton rb_inactivo;
        private RadioButton rb_activo;
        private Label label11;
        private TextBox tb_direccion;
        private Label label10;
        private ComboBox cb_tipoUsuario;
        private TextBox tb_edad;
        private TextBox tb_usuario;
        private TextBox tb_apellidoMat;
        private TextBox tb_apellidoPat;
        private TextBox tb_nombre;
        private TextBox tb_id;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_salir;
        private Button btn_Guardar;
    }
}