namespace Client_Web_Api
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.tPestañas = new System.Windows.Forms.TabControl();
            this.tbRegistrar = new System.Windows.Forms.TabPage();
            this.tbModificar = new System.Windows.Forms.TabPage();
            this.tbEliminar = new System.Windows.Forms.TabPage();
            this.tbBuscar = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tboxsNombreReg = new System.Windows.Forms.TextBox();
            this.tboxsEstadioReg = new System.Windows.Forms.TextBox();
            this.tboxuEscudo = new System.Windows.Forms.TextBox();
            this.tboxuEstadioReg = new System.Windows.Forms.TextBox();
            this.pbEstadioReg = new System.Windows.Forms.PictureBox();
            this.pbEscudoReg = new System.Windows.Forms.PictureBox();
            this.tableRegistro = new System.Windows.Forms.DataGridView();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEstadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.tPestañas.SuspendLayout();
            this.tbRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadioReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // tPestañas
            // 
            this.tPestañas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tPestañas.Controls.Add(this.tbRegistrar);
            this.tPestañas.Controls.Add(this.tbModificar);
            this.tPestañas.Controls.Add(this.tbEliminar);
            this.tPestañas.Controls.Add(this.tbBuscar);
            this.tPestañas.ImageList = this.imageList1;
            this.tPestañas.ItemSize = new System.Drawing.Size(60, 50);
            this.tPestañas.Location = new System.Drawing.Point(0, 0);
            this.tPestañas.Name = "tPestañas";
            this.tPestañas.SelectedIndex = 0;
            this.tPestañas.Size = new System.Drawing.Size(785, 479);
            this.tPestañas.TabIndex = 0;
            // 
            // tbRegistrar
            // 
            this.tbRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegistrar.Controls.Add(this.btnRegistrar);
            this.tbRegistrar.Controls.Add(this.tableRegistro);
            this.tbRegistrar.Controls.Add(label6);
            this.tbRegistrar.Controls.Add(label5);
            this.tbRegistrar.Controls.Add(this.pbEscudoReg);
            this.tbRegistrar.Controls.Add(this.pbEstadioReg);
            this.tbRegistrar.Controls.Add(this.tboxuEstadioReg);
            this.tbRegistrar.Controls.Add(label4);
            this.tbRegistrar.Controls.Add(this.tboxuEscudo);
            this.tbRegistrar.Controls.Add(label3);
            this.tbRegistrar.Controls.Add(this.tboxsEstadioReg);
            this.tbRegistrar.Controls.Add(label2);
            this.tbRegistrar.Controls.Add(this.tboxsNombreReg);
            this.tbRegistrar.Controls.Add(label1);
            this.tbRegistrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbRegistrar.ImageIndex = 0;
            this.tbRegistrar.Location = new System.Drawing.Point(4, 54);
            this.tbRegistrar.Name = "tbRegistrar";
            this.tbRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistrar.Size = new System.Drawing.Size(777, 421);
            this.tbRegistrar.TabIndex = 0;
            this.tbRegistrar.Text = "Registrar";
            this.tbRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbModificar
            // 
            this.tbModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbModificar.ImageIndex = 3;
            this.tbModificar.Location = new System.Drawing.Point(4, 54);
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbModificar.Size = new System.Drawing.Size(777, 512);
            this.tbModificar.TabIndex = 1;
            this.tbModificar.Text = "Modificar";
            this.tbModificar.UseVisualStyleBackColor = true;
            // 
            // tbEliminar
            // 
            this.tbEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbEliminar.ImageIndex = 1;
            this.tbEliminar.Location = new System.Drawing.Point(4, 54);
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbEliminar.Size = new System.Drawing.Size(777, 512);
            this.tbEliminar.TabIndex = 2;
            this.tbEliminar.Text = "Eliminar";
            this.tbEliminar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscar.ImageIndex = 2;
            this.tbBuscar.Location = new System.Drawing.Point(4, 54);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbBuscar.Size = new System.Drawing.Size(777, 512);
            this.tbBuscar.TabIndex = 3;
            this.tbBuscar.Text = "Buscar";
            this.tbBuscar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "find.png");
            this.imageList1.Images.SetKeyName(3, "update.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F);
            label1.Location = new System.Drawing.Point(234, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 18);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // tboxsNombreReg
            // 
            this.tboxsNombreReg.Location = new System.Drawing.Point(199, 60);
            this.tboxsNombreReg.Name = "tboxsNombreReg";
            this.tboxsNombreReg.Size = new System.Drawing.Size(145, 26);
            this.tboxsNombreReg.TabIndex = 1;
            // 
            // tboxsEstadioReg
            // 
            this.tboxsEstadioReg.Location = new System.Drawing.Point(404, 60);
            this.tboxsEstadioReg.Name = "tboxsEstadioReg";
            this.tboxsEstadioReg.Size = new System.Drawing.Size(145, 26);
            this.tboxsEstadioReg.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F);
            label2.Location = new System.Drawing.Point(355, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(245, 18);
            label2.TabIndex = 2;
            label2.Text = "Nombre del estadio donde reside:";
            // 
            // tboxuEscudo
            // 
            this.tboxuEscudo.Location = new System.Drawing.Point(404, 151);
            this.tboxuEscudo.Name = "tboxuEscudo";
            this.tboxuEscudo.Size = new System.Drawing.Size(145, 26);
            this.tboxuEscudo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 12F);
            label3.Location = new System.Drawing.Point(393, 117);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(170, 18);
            label3.TabIndex = 4;
            label3.Text = "Url con foto del escudo:";
            // 
            // tboxuEstadioReg
            // 
            this.tboxuEstadioReg.Location = new System.Drawing.Point(199, 151);
            this.tboxuEstadioReg.Name = "tboxuEstadioReg";
            this.tboxuEstadioReg.Size = new System.Drawing.Size(145, 26);
            this.tboxuEstadioReg.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 12F);
            label4.Location = new System.Drawing.Point(187, 117);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(171, 18);
            label4.TabIndex = 6;
            label4.Text = "Url con foto del estadio:";
            // 
            // pbEstadioReg
            // 
            this.pbEstadioReg.Location = new System.Drawing.Point(358, 257);
            this.pbEstadioReg.Name = "pbEstadioReg";
            this.pbEstadioReg.Size = new System.Drawing.Size(191, 149);
            this.pbEstadioReg.TabIndex = 8;
            this.pbEstadioReg.TabStop = false;
            // 
            // pbEscudoReg
            // 
            this.pbEscudoReg.Location = new System.Drawing.Point(576, 257);
            this.pbEscudoReg.Name = "pbEscudoReg";
            this.pbEscudoReg.Size = new System.Drawing.Size(191, 149);
            this.pbEscudoReg.TabIndex = 9;
            this.pbEscudoReg.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 12F);
            label5.Location = new System.Drawing.Point(346, 224);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(217, 18);
            label5.TabIndex = 10;
            label5.Text = "Foto del estadio donde reside";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 12F);
            label6.Location = new System.Drawing.Point(617, 224);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 18);
            label6.TabIndex = 11;
            label6.Text = "Foto del escudo";
            // 
            // tableRegistro
            // 
            this.tableRegistro.AllowUserToAddRows = false;
            this.tableRegistro.AllowUserToDeleteRows = false;
            this.tableRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNombre,
            this.sEstadio});
            this.tableRegistro.Location = new System.Drawing.Point(6, 256);
            this.tableRegistro.Name = "tableRegistro";
            this.tableRegistro.ReadOnly = true;
            this.tableRegistro.Size = new System.Drawing.Size(344, 150);
            this.tableRegistro.TabIndex = 12;
            // 
            // sNombre
            // 
            this.sNombre.HeaderText = "Nombre";
            this.sNombre.Name = "sNombre";
            this.sNombre.ReadOnly = true;
            this.sNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sNombre.Width = 150;
            // 
            // sEstadio
            // 
            this.sEstadio.HeaderText = "Estadio";
            this.sEstadio.Name = "sEstadio";
            this.sEstadio.ReadOnly = true;
            this.sEstadio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sEstadio.Width = 150;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.ImageIndex = 0;
            this.btnRegistrar.ImageList = this.imageList1;
            this.btnRegistrar.Location = new System.Drawing.Point(603, 141);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 45);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.tPestañas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Teams";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tPestañas.ResumeLayout(false);
            this.tbRegistrar.ResumeLayout(false);
            this.tbRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadioReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tPestañas;
        private System.Windows.Forms.TabPage tbRegistrar;
        private System.Windows.Forms.TabPage tbModificar;
        private System.Windows.Forms.TabPage tbEliminar;
        private System.Windows.Forms.TabPage tbBuscar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tboxsNombreReg;
        private System.Windows.Forms.TextBox tboxsEstadioReg;
        private System.Windows.Forms.TextBox tboxuEstadioReg;
        private System.Windows.Forms.TextBox tboxuEscudo;
        private System.Windows.Forms.PictureBox pbEscudoReg;
        private System.Windows.Forms.PictureBox pbEstadioReg;
        private System.Windows.Forms.DataGridView tableRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEstadio;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

