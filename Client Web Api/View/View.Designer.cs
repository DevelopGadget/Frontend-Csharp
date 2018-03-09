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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            System.Windows.Forms.Label label25;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.tboxsBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tboxsId = new System.Windows.Forms.TextBox();
            this.cbSelec = new System.Windows.Forms.CheckBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.TabaDatos = new System.Windows.Forms.DataGridView();
            this.sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEstadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbEscudo = new System.Windows.Forms.PictureBox();
            this.pbEstadio = new System.Windows.Forms.PictureBox();
            this.tboxuEstadio = new System.Windows.Forms.TextBox();
            this.tboxuEscudo = new System.Windows.Forms.TextBox();
            this.tboxsEstadio = new System.Windows.Forms.TextBox();
            this.tboxsNombre = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.prbBarra = new System.Windows.Forms.ProgressBar();
            label25 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.Pestañas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadio)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "find.png");
            this.imageList1.Images.SetKeyName(3, "update.png");
            this.imageList1.Images.SetKeyName(4, "Cancel.png");
            this.imageList1.Images.SetKeyName(5, "select.png");
            this.imageList1.Images.SetKeyName(6, "Upg.png");
            this.imageList1.Images.SetKeyName(7, "if_02_Soccer_300768.png");
            this.imageList1.Images.SetKeyName(8, "if_football_310332.png");
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tabPage1);
            this.Pestañas.Controls.Add(this.tabPage2);
            this.Pestañas.ImageList = this.imageList1;
            this.Pestañas.ItemSize = new System.Drawing.Size(50, 30);
            this.Pestañas.Location = new System.Drawing.Point(-1, 0);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(827, 503);
            this.Pestañas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnElim);
            this.tabPage1.Controls.Add(this.btnMod);
            this.tabPage1.Controls.Add(this.tboxsBuscar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(label25);
            this.tabPage1.Controls.Add(this.tboxsId);
            this.tabPage1.Controls.Add(this.cbSelec);
            this.tabPage1.Controls.Add(this.btnReg);
            this.tabPage1.Controls.Add(this.TabaDatos);
            this.tabPage1.Controls.Add(label6);
            this.tabPage1.Controls.Add(label5);
            this.tabPage1.Controls.Add(this.pbEscudo);
            this.tabPage1.Controls.Add(this.pbEstadio);
            this.tabPage1.Controls.Add(this.tboxuEstadio);
            this.tabPage1.Controls.Add(label4);
            this.tabPage1.Controls.Add(this.tboxuEscudo);
            this.tabPage1.Controls.Add(label3);
            this.tabPage1.Controls.Add(this.tboxsEstadio);
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(this.tboxsNombre);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(this.btnCargar);
            this.tabPage1.Controls.Add(this.prbBarra);
            this.tabPage1.ImageIndex = 7;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Equipos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 8;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jugadores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(184, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 23);
            this.textBox1.TabIndex = 100;
            this.textBox1.Text = "Cargando Datos Por Favor Espere...";
            this.textBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageIndex = 4;
            this.btnCancelar.ImageList = this.imageList1;
            this.btnCancelar.Location = new System.Drawing.Point(19, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 45);
            this.btnCancelar.TabIndex = 99;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnElim
            // 
            this.btnElim.Enabled = false;
            this.btnElim.Font = new System.Drawing.Font("Arial", 12F);
            this.btnElim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElim.ImageIndex = 1;
            this.btnElim.ImageList = this.imageList1;
            this.btnElim.Location = new System.Drawing.Point(633, 40);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(117, 45);
            this.btnElim.TabIndex = 98;
            this.btnElim.Text = "Eliminar";
            this.btnElim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElim.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Enabled = false;
            this.btnMod.Font = new System.Drawing.Font("Arial", 12F);
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.ImageIndex = 3;
            this.btnMod.ImageList = this.imageList1;
            this.btnMod.Location = new System.Drawing.Point(633, 92);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(117, 45);
            this.btnMod.TabIndex = 97;
            this.btnMod.Text = "Modificar";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // tboxsBuscar
            // 
            this.tboxsBuscar.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxsBuscar.Location = new System.Drawing.Point(142, 200);
            this.tboxsBuscar.Name = "tboxsBuscar";
            this.tboxsBuscar.Size = new System.Drawing.Size(145, 23);
            this.tboxsBuscar.TabIndex = 95;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.ImageIndex = 2;
            this.btnBuscar.ImageList = this.imageList1;
            this.btnBuscar.Location = new System.Drawing.Point(19, 188);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 45);
            this.btnBuscar.TabIndex = 96;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Arial", 12F);
            label25.Location = new System.Drawing.Point(36, 29);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(121, 18);
            label25.TabIndex = 94;
            label25.Text = "Id seleccionado:";
            // 
            // tboxsId
            // 
            this.tboxsId.Enabled = false;
            this.tboxsId.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxsId.Location = new System.Drawing.Point(25, 63);
            this.tboxsId.Name = "tboxsId";
            this.tboxsId.Size = new System.Drawing.Size(145, 23);
            this.tboxsId.TabIndex = 93;
            // 
            // cbSelec
            // 
            this.cbSelec.AutoSize = true;
            this.cbSelec.Enabled = false;
            this.cbSelec.Font = new System.Drawing.Font("Arial", 12F);
            this.cbSelec.Location = new System.Drawing.Point(154, 230);
            this.cbSelec.Name = "cbSelec";
            this.cbSelec.Size = new System.Drawing.Size(123, 22);
            this.cbSelec.TabIndex = 92;
            this.cbSelec.Text = "Seleccionado";
            this.cbSelec.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Enabled = false;
            this.btnReg.Font = new System.Drawing.Font("Arial", 12F);
            this.btnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReg.ImageIndex = 0;
            this.btnReg.ImageList = this.imageList1;
            this.btnReg.Location = new System.Drawing.Point(633, 143);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(117, 45);
            this.btnReg.TabIndex = 85;
            this.btnReg.Text = "Registrar";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // TabaDatos
            // 
            this.TabaDatos.AllowUserToAddRows = false;
            this.TabaDatos.AllowUserToDeleteRows = false;
            this.TabaDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TabaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sId,
            this.sNombre,
            this.sEstadio});
            this.TabaDatos.Location = new System.Drawing.Point(15, 258);
            this.TabaDatos.MultiSelect = false;
            this.TabaDatos.Name = "TabaDatos";
            this.TabaDatos.ReadOnly = true;
            this.TabaDatos.RowHeadersVisible = false;
            this.TabaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabaDatos.Size = new System.Drawing.Size(362, 150);
            this.TabaDatos.TabIndex = 91;
            // 
            // sId
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            this.sId.DefaultCellStyle = dataGridViewCellStyle2;
            this.sId.HeaderText = "Id";
            this.sId.Name = "sId";
            this.sId.ReadOnly = true;
            this.sId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sId.Width = 80;
            // 
            // sNombre
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            this.sNombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.sNombre.HeaderText = "Nombre";
            this.sNombre.Name = "sNombre";
            this.sNombre.ReadOnly = true;
            this.sNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sNombre.Width = 140;
            // 
            // sEstadio
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10F);
            this.sEstadio.DefaultCellStyle = dataGridViewCellStyle4;
            this.sEstadio.HeaderText = "Estadio";
            this.sEstadio.Name = "sEstadio";
            this.sEstadio.ReadOnly = true;
            this.sEstadio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sEstadio.Width = 140;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 12F);
            label6.Location = new System.Drawing.Point(640, 226);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 18);
            label6.TabIndex = 90;
            label6.Text = "Foto del escudo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 12F);
            label5.Location = new System.Drawing.Point(376, 226);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(217, 18);
            label5.TabIndex = 89;
            label5.Text = "Foto del estadio donde reside";
            // 
            // pbEscudo
            // 
            this.pbEscudo.Image = ((System.Drawing.Image)(resources.GetObject("pbEscudo.Image")));
            this.pbEscudo.InitialImage = null;
            this.pbEscudo.Location = new System.Drawing.Point(606, 259);
            this.pbEscudo.Name = "pbEscudo";
            this.pbEscudo.Size = new System.Drawing.Size(191, 149);
            this.pbEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEscudo.TabIndex = 88;
            this.pbEscudo.TabStop = false;
            // 
            // pbEstadio
            // 
            this.pbEstadio.Image = ((System.Drawing.Image)(resources.GetObject("pbEstadio.Image")));
            this.pbEstadio.InitialImage = null;
            this.pbEstadio.Location = new System.Drawing.Point(388, 259);
            this.pbEstadio.Name = "pbEstadio";
            this.pbEstadio.Size = new System.Drawing.Size(191, 149);
            this.pbEstadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstadio.TabIndex = 87;
            this.pbEstadio.TabStop = false;
            // 
            // tboxuEstadio
            // 
            this.tboxuEstadio.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxuEstadio.Location = new System.Drawing.Point(208, 153);
            this.tboxuEstadio.Name = "tboxuEstadio";
            this.tboxuEstadio.Size = new System.Drawing.Size(145, 23);
            this.tboxuEstadio.TabIndex = 82;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 12F);
            label4.Location = new System.Drawing.Point(196, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(171, 18);
            label4.TabIndex = 86;
            label4.Text = "Url con foto del estadio:";
            // 
            // tboxuEscudo
            // 
            this.tboxuEscudo.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxuEscudo.Location = new System.Drawing.Point(413, 153);
            this.tboxuEscudo.Name = "tboxuEscudo";
            this.tboxuEscudo.Size = new System.Drawing.Size(145, 23);
            this.tboxuEscudo.TabIndex = 83;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 12F);
            label3.Location = new System.Drawing.Point(402, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(170, 18);
            label3.TabIndex = 84;
            label3.Text = "Url con foto del escudo:";
            // 
            // tboxsEstadio
            // 
            this.tboxsEstadio.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxsEstadio.Location = new System.Drawing.Point(413, 62);
            this.tboxsEstadio.Name = "tboxsEstadio";
            this.tboxsEstadio.Size = new System.Drawing.Size(145, 23);
            this.tboxsEstadio.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F);
            label2.Location = new System.Drawing.Point(364, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(245, 18);
            label2.TabIndex = 81;
            label2.Text = "Nombre del estadio donde reside:";
            // 
            // tboxsNombre
            // 
            this.tboxsNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxsNombre.Location = new System.Drawing.Point(208, 62);
            this.tboxsNombre.Name = "tboxsNombre";
            this.tboxsNombre.Size = new System.Drawing.Size(145, 23);
            this.tboxsNombre.TabIndex = 79;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F);
            label1.Location = new System.Drawing.Point(243, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 18);
            label1.TabIndex = 78;
            label1.Text = "Nombre:";
            // 
            // btnCargar
            // 
            this.btnCargar.Enabled = false;
            this.btnCargar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.ImageIndex = 6;
            this.btnCargar.ImageList = this.imageList1;
            this.btnCargar.Location = new System.Drawing.Point(633, 428);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(153, 35);
            this.btnCargar.TabIndex = 77;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // prbBarra
            // 
            this.prbBarra.Location = new System.Drawing.Point(18, 433);
            this.prbBarra.Name = "prbBarra";
            this.prbBarra.Size = new System.Drawing.Size(591, 25);
            this.prbBarra.Step = 3;
            this.prbBarra.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbBarra.TabIndex = 76;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 501);
            this.Controls.Add(this.Pestañas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 540);
            this.MinimumSize = new System.Drawing.Size(840, 540);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Teams";
            this.Load += new System.EventHandler(this.View_Load);
            this.Pestañas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl Pestañas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox tboxsBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tboxsId;
        private System.Windows.Forms.CheckBox cbSelec;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridView TabaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEstadio;
        private System.Windows.Forms.PictureBox pbEscudo;
        private System.Windows.Forms.PictureBox pbEstadio;
        private System.Windows.Forms.TextBox tboxuEstadio;
        private System.Windows.Forms.TextBox tboxuEscudo;
        private System.Windows.Forms.TextBox tboxsEstadio;
        private System.Windows.Forms.TextBox tboxsNombre;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ProgressBar prbBarra;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

