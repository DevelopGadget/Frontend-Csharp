namespace Client_Web_Api
{
    partial class View
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.TabControl tPestañas;
            System.Windows.Forms.TabPage tbRegistrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            System.Windows.Forms.TabPage tbModificar;
            System.Windows.Forms.TabPage tbEliminar;
            System.Windows.Forms.TabPage tbBuscar;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableRegistro = new System.Windows.Forms.DataGridView();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEstadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbEscudoReg = new System.Windows.Forms.PictureBox();
            this.pbEstadioReg = new System.Windows.Forms.PictureBox();
            this.tboxuEstadioReg = new System.Windows.Forms.TextBox();
            this.tboxuEscudo = new System.Windows.Forms.TextBox();
            this.tboxsEstadioReg = new System.Windows.Forms.TextBox();
            this.tboxsNombreReg = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.tableMod = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbEscudoMod = new System.Windows.Forms.PictureBox();
            this.pbEstadioMod = new System.Windows.Forms.PictureBox();
            this.tboxuEstadioMod = new System.Windows.Forms.TextBox();
            this.tboxuEscudoMod = new System.Windows.Forms.TextBox();
            this.tboxsEstadioMod = new System.Windows.Forms.TextBox();
            this.tboxsNombreMod = new System.Windows.Forms.TextBox();
            this.btnBuscarMod = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tPestañas = new System.Windows.Forms.TabControl();
            tbRegistrar = new System.Windows.Forms.TabPage();
            tbModificar = new System.Windows.Forms.TabPage();
            tbEliminar = new System.Windows.Forms.TabPage();
            tbBuscar = new System.Windows.Forms.TabPage();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            tPestañas.SuspendLayout();
            tbRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadioReg)).BeginInit();
            tbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadioMod)).BeginInit();
            this.SuspendLayout();
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
            // tPestañas
            // 
            tPestañas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            tPestañas.Controls.Add(tbRegistrar);
            tPestañas.Controls.Add(tbModificar);
            tPestañas.Controls.Add(tbEliminar);
            tPestañas.Controls.Add(tbBuscar);
            tPestañas.ImageList = this.imageList1;
            tPestañas.ItemSize = new System.Drawing.Size(60, 50);
            tPestañas.Location = new System.Drawing.Point(0, 0);
            tPestañas.Name = "tPestañas";
            tPestañas.SelectedIndex = 0;
            tPestañas.Size = new System.Drawing.Size(785, 479);
            tPestañas.TabIndex = 0;
            // 
            // tbRegistrar
            // 
            tbRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbRegistrar.Controls.Add(this.btnRegistrar);
            tbRegistrar.Controls.Add(this.tableRegistro);
            tbRegistrar.Controls.Add(label6);
            tbRegistrar.Controls.Add(label5);
            tbRegistrar.Controls.Add(this.pbEscudoReg);
            tbRegistrar.Controls.Add(this.pbEstadioReg);
            tbRegistrar.Controls.Add(this.tboxuEstadioReg);
            tbRegistrar.Controls.Add(label4);
            tbRegistrar.Controls.Add(this.tboxuEscudo);
            tbRegistrar.Controls.Add(label3);
            tbRegistrar.Controls.Add(this.tboxsEstadioReg);
            tbRegistrar.Controls.Add(label2);
            tbRegistrar.Controls.Add(this.tboxsNombreReg);
            tbRegistrar.Controls.Add(label1);
            tbRegistrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            tbRegistrar.ImageIndex = 0;
            tbRegistrar.Location = new System.Drawing.Point(4, 54);
            tbRegistrar.Name = "tbRegistrar";
            tbRegistrar.Padding = new System.Windows.Forms.Padding(3);
            tbRegistrar.Size = new System.Drawing.Size(777, 421);
            tbRegistrar.TabIndex = 0;
            tbRegistrar.Text = "Registrar";
            tbRegistrar.UseVisualStyleBackColor = true;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "find.png");
            this.imageList1.Images.SetKeyName(3, "update.png");
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
            // pbEscudoReg
            // 
            this.pbEscudoReg.Location = new System.Drawing.Point(576, 257);
            this.pbEscudoReg.Name = "pbEscudoReg";
            this.pbEscudoReg.Size = new System.Drawing.Size(191, 149);
            this.pbEscudoReg.TabIndex = 9;
            this.pbEscudoReg.TabStop = false;
            // 
            // pbEstadioReg
            // 
            this.pbEstadioReg.Location = new System.Drawing.Point(358, 257);
            this.pbEstadioReg.Name = "pbEstadioReg";
            this.pbEstadioReg.Size = new System.Drawing.Size(191, 149);
            this.pbEstadioReg.TabIndex = 8;
            this.pbEstadioReg.TabStop = false;
            // 
            // tboxuEstadioReg
            // 
            this.tboxuEstadioReg.Location = new System.Drawing.Point(199, 151);
            this.tboxuEstadioReg.Name = "tboxuEstadioReg";
            this.tboxuEstadioReg.Size = new System.Drawing.Size(145, 26);
            this.tboxuEstadioReg.TabIndex = 7;
            // 
            // tboxuEscudo
            // 
            this.tboxuEscudo.Location = new System.Drawing.Point(404, 151);
            this.tboxuEscudo.Name = "tboxuEscudo";
            this.tboxuEscudo.Size = new System.Drawing.Size(145, 26);
            this.tboxuEscudo.TabIndex = 5;
            // 
            // tboxsEstadioReg
            // 
            this.tboxsEstadioReg.Location = new System.Drawing.Point(404, 60);
            this.tboxsEstadioReg.Name = "tboxsEstadioReg";
            this.tboxsEstadioReg.Size = new System.Drawing.Size(145, 26);
            this.tboxsEstadioReg.TabIndex = 3;
            // 
            // tboxsNombreReg
            // 
            this.tboxsNombreReg.Location = new System.Drawing.Point(199, 60);
            this.tboxsNombreReg.Name = "tboxsNombreReg";
            this.tboxsNombreReg.Size = new System.Drawing.Size(145, 26);
            this.tboxsNombreReg.TabIndex = 1;
            // 
            // tbModificar
            // 
            tbModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbModificar.Controls.Add(this.btnBuscarMod);
            tbModificar.Controls.Add(this.btnMod);
            tbModificar.Controls.Add(this.tableMod);
            tbModificar.Controls.Add(label7);
            tbModificar.Controls.Add(label8);
            tbModificar.Controls.Add(this.pbEscudoMod);
            tbModificar.Controls.Add(this.pbEstadioMod);
            tbModificar.Controls.Add(this.tboxuEstadioMod);
            tbModificar.Controls.Add(label9);
            tbModificar.Controls.Add(this.tboxuEscudoMod);
            tbModificar.Controls.Add(label10);
            tbModificar.Controls.Add(this.tboxsEstadioMod);
            tbModificar.Controls.Add(label11);
            tbModificar.Controls.Add(this.tboxsNombreMod);
            tbModificar.Controls.Add(label12);
            tbModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            tbModificar.ImageIndex = 3;
            tbModificar.Location = new System.Drawing.Point(4, 54);
            tbModificar.Name = "tbModificar";
            tbModificar.Padding = new System.Windows.Forms.Padding(3);
            tbModificar.Size = new System.Drawing.Size(777, 421);
            tbModificar.TabIndex = 1;
            tbModificar.Text = "Modificar";
            tbModificar.UseVisualStyleBackColor = true;
            // 
            // tbEliminar
            // 
            tbEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            tbEliminar.ImageIndex = 1;
            tbEliminar.Location = new System.Drawing.Point(4, 54);
            tbEliminar.Name = "tbEliminar";
            tbEliminar.Padding = new System.Windows.Forms.Padding(3);
            tbEliminar.Size = new System.Drawing.Size(777, 421);
            tbEliminar.TabIndex = 2;
            tbEliminar.Text = "Eliminar";
            tbEliminar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            tbBuscar.ImageIndex = 2;
            tbBuscar.Location = new System.Drawing.Point(4, 54);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Padding = new System.Windows.Forms.Padding(3);
            tbBuscar.Size = new System.Drawing.Size(777, 421);
            tbBuscar.TabIndex = 3;
            tbBuscar.Text = "Buscar";
            tbBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Arial", 12F);
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.ImageIndex = 3;
            this.btnMod.ImageList = this.imageList1;
            this.btnMod.Location = new System.Drawing.Point(604, 134);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(117, 45);
            this.btnMod.TabIndex = 27;
            this.btnMod.Text = "Modificar";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // tableMod
            // 
            this.tableMod.AllowUserToAddRows = false;
            this.tableMod.AllowUserToDeleteRows = false;
            this.tableMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tableMod.Location = new System.Drawing.Point(7, 249);
            this.tableMod.Name = "tableMod";
            this.tableMod.ReadOnly = true;
            this.tableMod.Size = new System.Drawing.Size(344, 150);
            this.tableMod.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Estadio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial", 12F);
            label7.Location = new System.Drawing.Point(618, 217);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 18);
            label7.TabIndex = 25;
            label7.Text = "Foto del escudo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial", 12F);
            label8.Location = new System.Drawing.Point(347, 217);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(217, 18);
            label8.TabIndex = 24;
            label8.Text = "Foto del estadio donde reside";
            // 
            // pbEscudoMod
            // 
            this.pbEscudoMod.Location = new System.Drawing.Point(577, 250);
            this.pbEscudoMod.Name = "pbEscudoMod";
            this.pbEscudoMod.Size = new System.Drawing.Size(191, 149);
            this.pbEscudoMod.TabIndex = 23;
            this.pbEscudoMod.TabStop = false;
            // 
            // pbEstadioMod
            // 
            this.pbEstadioMod.Location = new System.Drawing.Point(359, 250);
            this.pbEstadioMod.Name = "pbEstadioMod";
            this.pbEstadioMod.Size = new System.Drawing.Size(191, 149);
            this.pbEstadioMod.TabIndex = 22;
            this.pbEstadioMod.TabStop = false;
            // 
            // tboxuEstadioMod
            // 
            this.tboxuEstadioMod.Location = new System.Drawing.Point(200, 144);
            this.tboxuEstadioMod.Name = "tboxuEstadioMod";
            this.tboxuEstadioMod.Size = new System.Drawing.Size(145, 26);
            this.tboxuEstadioMod.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Arial", 12F);
            label9.Location = new System.Drawing.Point(188, 110);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(171, 18);
            label9.TabIndex = 20;
            label9.Text = "Url con foto del estadio:";
            // 
            // tboxuEscudoMod
            // 
            this.tboxuEscudoMod.Location = new System.Drawing.Point(405, 144);
            this.tboxuEscudoMod.Name = "tboxuEscudoMod";
            this.tboxuEscudoMod.Size = new System.Drawing.Size(145, 26);
            this.tboxuEscudoMod.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Arial", 12F);
            label10.Location = new System.Drawing.Point(394, 110);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(170, 18);
            label10.TabIndex = 18;
            label10.Text = "Url con foto del escudo:";
            // 
            // tboxsEstadioMod
            // 
            this.tboxsEstadioMod.Location = new System.Drawing.Point(405, 53);
            this.tboxsEstadioMod.Name = "tboxsEstadioMod";
            this.tboxsEstadioMod.Size = new System.Drawing.Size(145, 26);
            this.tboxsEstadioMod.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Arial", 12F);
            label11.Location = new System.Drawing.Point(356, 20);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(245, 18);
            label11.TabIndex = 16;
            label11.Text = "Nombre del estadio donde reside:";
            // 
            // tboxsNombreMod
            // 
            this.tboxsNombreMod.Location = new System.Drawing.Point(200, 53);
            this.tboxsNombreMod.Name = "tboxsNombreMod";
            this.tboxsNombreMod.Size = new System.Drawing.Size(145, 26);
            this.tboxsNombreMod.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Arial", 12F);
            label12.Location = new System.Drawing.Point(235, 20);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(68, 18);
            label12.TabIndex = 14;
            label12.Text = "Nombre:";
            // 
            // btnBuscarMod
            // 
            this.btnBuscarMod.Font = new System.Drawing.Font("Arial", 12F);
            this.btnBuscarMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarMod.ImageIndex = 2;
            this.btnBuscarMod.ImageList = this.imageList1;
            this.btnBuscarMod.Location = new System.Drawing.Point(27, 190);
            this.btnBuscarMod.Name = "btnBuscarMod";
            this.btnBuscarMod.Size = new System.Drawing.Size(117, 45);
            this.btnBuscarMod.TabIndex = 28;
            this.btnBuscarMod.Text = "Buscar";
            this.btnBuscarMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarMod.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(tPestañas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 520);
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Teams";
            this.Load += new System.EventHandler(this.Form1_Load);
            tPestañas.ResumeLayout(false);
            tbRegistrar.ResumeLayout(false);
            tbRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadioReg)).EndInit();
            tbModificar.ResumeLayout(false);
            tbModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadioMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnBuscarMod;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.DataGridView tableMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.PictureBox pbEscudoMod;
        private System.Windows.Forms.PictureBox pbEstadioMod;
        private System.Windows.Forms.TextBox tboxuEstadioMod;
        private System.Windows.Forms.TextBox tboxuEscudoMod;
        private System.Windows.Forms.TextBox tboxsEstadioMod;
        private System.Windows.Forms.TextBox tboxsNombreMod;
    }
}

