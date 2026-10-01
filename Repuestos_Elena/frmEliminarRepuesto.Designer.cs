namespace Repuestos_Elena
{
    partial class frmEliminarRepuesto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarRepuesto));
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.dgvResultados = new Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new Krypton.Toolkit.KryptonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.btnBuscar = new Krypton.Toolkit.KryptonButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(22, 24);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.dgvResultados);
            this.kryptonGroup1.Panel.Controls.Add(this.label1);
            this.kryptonGroup1.Panel.Controls.Add(this.pictureBox24);
            this.kryptonGroup1.Panel.Controls.Add(this.txtCodigo);
            this.kryptonGroup1.Panel.Controls.Add(this.label11);
            this.kryptonGroup1.Panel.Controls.Add(this.btnCancelar);
            this.kryptonGroup1.Panel.Controls.Add(this.btnBuscar);
            this.kryptonGroup1.Panel.Controls.Add(this.label8);
            this.kryptonGroup1.Size = new System.Drawing.Size(714, 506);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 29;
            // 
            // dgvResultados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombre,
            this.marca,
            this.fabricante,
            this.origen,
            this.stock});
            this.dgvResultados.Location = new System.Drawing.Point(25, 236);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.RowTemplate.Height = 45;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(660, 156);
            this.dgvResultados.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvResultados.StateCommon.Background.Draw = Krypton.Toolkit.InheritBool.True;
            this.dgvResultados.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvResultados.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvResultados.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvResultados.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvResultados.StateCommon.DataCell.Border.Rounding = 8F;
            this.dgvResultados.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResultados.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(3);
            this.dgvResultados.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dgvResultados.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dgvResultados.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.dgvResultados.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.Black;
            this.dgvResultados.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResultados.StateCommon.HeaderColumn.Content.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.dgvResultados.StateCommon.HeaderColumn.Content.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvResultados.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvResultados.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvResultados.TabIndex = 81;
            // 
            // ID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "Cod. / SKU";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 89;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre de repuesto";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 191;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 93;
            // 
            // fabricante
            // 
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.MinimumWidth = 6;
            this.fabricante.Name = "fabricante";
            this.fabricante.ReadOnly = true;
            this.fabricante.Width = 128;
            // 
            // origen
            // 
            this.origen.HeaderText = "Origen";
            this.origen.MinimumWidth = 6;
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            this.origen.Width = 95;
            // 
            // stock
            // 
            this.stock.HeaderText = "Unidades disponibles";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "Coincidencias encontradas:";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.White;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(369, 137);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(32, 32);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 79;
            this.pictureBox24.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.CueHint.CueHintText = "Código aquí ...";
            this.txtCodigo.CueHint.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(52, 137);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(221, 36);
            this.txtCodigo.StateActive.Content.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCodigo.StateCommon.Border.Rounding = 20F;
            this.txtCodigo.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtCodigo.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -3, -3, -3);
            this.txtCodigo.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 31);
            this.label11.TabIndex = 77;
            this.label11.Text = "Código / SKU";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(522, 427);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnCancelar.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnCancelar.OverrideDefault.Back.ColorAngle = 360F;
            this.btnCancelar.OverrideDefault.Border.Color1 = System.Drawing.Color.SeaGreen;
            this.btnCancelar.OverrideDefault.Border.Color2 = System.Drawing.Color.SeaGreen;
            this.btnCancelar.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelar.OverrideDefault.Border.Rounding = 30F;
            this.btnCancelar.Size = new System.Drawing.Size(152, 46);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Back.ColorAngle = 360F;
            this.btnCancelar.StateCommon.Border.Color1 = System.Drawing.Color.SeaGreen;
            this.btnCancelar.StateCommon.Border.Color2 = System.Drawing.Color.SeaGreen;
            this.btnCancelar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelar.StateCommon.Border.Rounding = 30F;
            this.btnCancelar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-20);
            this.btnCancelar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Green;
            this.btnCancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnCancelar.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnCancelar.StatePressed.Border.Color1 = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelar.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnCancelar.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnCancelar.StateTracking.Back.ColorAngle = 360F;
            this.btnCancelar.StateTracking.Border.Color1 = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelar.StateTracking.Border.Rounding = 30F;
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(420, 128);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OverrideDefault.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.btnBuscar.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.OverrideDefault.Back.ColorAngle = 360F;
            this.btnBuscar.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuscar.OverrideDefault.Border.Rounding = 30F;
            this.btnBuscar.Size = new System.Drawing.Size(174, 49);
            this.btnBuscar.StateCommon.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.btnBuscar.StateCommon.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.StateCommon.Back.ColorAngle = 360F;
            this.btnBuscar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuscar.StateCommon.Border.Rounding = 30F;
            this.btnBuscar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-20, -65, -20, -20);
            this.btnBuscar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBuscar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnBuscar.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnBuscar.StatePressed.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.btnBuscar.StatePressed.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.StateTracking.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.btnBuscar.StateTracking.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.StateTracking.Back.ColorAngle = 360F;
            this.btnBuscar.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuscar.StateTracking.Border.Rounding = 30F;
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBuscar.Values.Text = "Buscar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(403, 39);
            this.label8.TabIndex = 28;
            this.label8.Text = "Eliminar el registro de un repuesto";
            // 
            // frmEliminarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 546);
            this.Controls.Add(this.kryptonGroup1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarRepuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Repuesto";
            this.Load += new System.EventHandler(this.frmEliminarRepuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private System.Windows.Forms.Label label8;
        private Krypton.Toolkit.KryptonTextBox txtCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonDataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}