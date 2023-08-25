namespace examenTecnico
{
    partial class inicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicioSesion));
            tb_usuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_entrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(228, 169);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(196, 23);
            tb_usuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 26);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 2;
            label1.Text = "inicio de sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(176, 172);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 3;
            label2.Text = "usuario:";
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.Green;
            btn_entrar.Cursor = Cursors.Hand;
            btn_entrar.FlatAppearance.BorderSize = 0;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entrar.ForeColor = Color.White;
            btn_entrar.Location = new Point(176, 209);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(248, 31);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(264, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // inicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 306);
            Controls.Add(pictureBox1);
            Controls.Add(btn_entrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_usuario);
            Name = "inicioSesion";
            Text = "inicioSesion";
            Load += inicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_usuario;
        private Label label1;
        private Label label2;
        private Button btn_entrar;
        private PictureBox pictureBox1;
    }
}