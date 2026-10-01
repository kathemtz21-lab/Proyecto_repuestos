namespace Repuestos_Elena
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            this.txtContraseña = new Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIniciar = new Krypton.Toolkit.KryptonButton();
            this.btnIniciarCliente = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Poppins", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "LogIn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtUsuario.CueHint.CueHintText = "Tu usuario aquí ...";
            this.txtUsuario.CueHint.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(105, 257);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(281, 42);
            this.txtUsuario.StateActive.Content.Font = new System.Drawing.Font("Poppins", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsuario.StateCommon.Border.Rounding = 20F;
            this.txtUsuario.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtUsuario.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -3, -3, -3);
            this.txtUsuario.TabIndex = 11;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtContraseña.CueHint.CueHintText = "Tu contraseña ...";
            this.txtContraseña.CueHint.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(105, 339);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(281, 42);
            this.txtContraseña.StateActive.Content.Font = new System.Drawing.Font("Poppins", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtContraseña.StateCommon.Border.Rounding = 20F;
            this.txtContraseña.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtContraseña.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -3, -3, -3);
            this.txtContraseña.TabIndex = 12;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 104);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tu herramienta central para organizar el stock, \r\nmonitorear el flujo de ventas y" +
    " tomar decisiones \r\nestratégicas que mantengan tu empresa siempre \r\nen marcha.\r\n" +
    "";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(132, 414);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.OverrideDefault.Back.Color1 = System.Drawing.Color.Blue;
            this.btnIniciar.OverrideDefault.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.btnIniciar.OverrideDefault.Back.ColorAngle = 360F;
            this.btnIniciar.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIniciar.OverrideDefault.Border.Rounding = 30F;
            this.btnIniciar.Size = new System.Drawing.Size(211, 52);
            this.btnIniciar.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.btnIniciar.StateCommon.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.btnIniciar.StateCommon.Back.ColorAngle = 360F;
            this.btnIniciar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIniciar.StateCommon.Border.Rounding = 30F;
            this.btnIniciar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-20, -40, -20, -20);
            this.btnIniciar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnIniciar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.StatePressed.Back.Color1 = System.Drawing.Color.Blue;
            this.btnIniciar.StatePressed.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.btnIniciar.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.btnIniciar.StateTracking.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.btnIniciar.StateTracking.Back.ColorAngle = 360F;
            this.btnIniciar.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIniciar.StateTracking.Border.Rounding = 30F;
            this.btnIniciar.TabIndex = 18;
            this.btnIniciar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnIniciar.Values.Text = "Iniciar sesión";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnIniciarCliente
            // 
            this.btnIniciarCliente.Location = new System.Drawing.Point(130, 478);
            this.btnIniciarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarCliente.Name = "btnIniciarCliente";
            this.btnIniciarCliente.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnIniciarCliente.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnIniciarCliente.OverrideDefault.Back.ColorAngle = 360F;
            this.btnIniciarCliente.OverrideDefault.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.btnIniciarCliente.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIniciarCliente.OverrideDefault.Border.Rounding = 30F;
            this.btnIniciarCliente.Size = new System.Drawing.Size(214, 46);
            this.btnIniciarCliente.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnIniciarCliente.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnIniciarCliente.StateCommon.Back.ColorAngle = 360F;
            this.btnIniciarCliente.StateCommon.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.btnIniciarCliente.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIniciarCliente.StateCommon.Border.Rounding = 30F;
            this.btnIniciarCliente.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-20);
            this.btnIniciarCliente.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MediumBlue;
            this.btnIniciarCliente.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarCliente.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnIniciarCliente.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnIniciarCliente.StatePressed.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.btnIniciarCliente.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIniciarCliente.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnIniciarCliente.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnIniciarCliente.StateTracking.Back.ColorAngle = 360F;
            this.btnIniciarCliente.StateTracking.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.btnIniciarCliente.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIniciarCliente.StateTracking.Border.Rounding = 30F;
            this.btnIniciarCliente.TabIndex = 25;
            this.btnIniciarCliente.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnIniciarCliente.Values.Text = "Iniciar como cliente";
            this.btnIniciarCliente.Click += new System.EventHandler(this.btnIniciarCliente_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 578);
            this.Controls.Add(this.btnIniciarCliente);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox txtUsuario;
        private Krypton.Toolkit.KryptonTextBox txtContraseña;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonButton btnIniciar;
        private Krypton.Toolkit.KryptonButton btnIniciarCliente;
    }
}