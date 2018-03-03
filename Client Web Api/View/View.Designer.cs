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
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.prbBarra = new System.Windows.Forms.ProgressBar();
            this.tboxsBuscar = new System.Windows.Forms.TextBox();
            this.tboxsId = new System.Windows.Forms.TextBox();
            this.cbSelec = new System.Windows.Forms.CheckBox();
            this.TabaDatos = new System.Windows.Forms.DataGridView();
            this.sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEstadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tboxuEstadio = new System.Windows.Forms.TextBox();
            this.tboxuEscudo = new System.Windows.Forms.TextBox();
            this.tboxsEstadio = new System.Windows.Forms.TextBox();
            this.tboxsNombre = new System.Windows.Forms.TextBox();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.pbEscudo = new System.Windows.Forms.PictureBox();
            this.pbEstadio = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TabaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadio)).BeginInit();
            this.SuspendLayout();
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Arial", 12F);
            label25.Location = new System.Drawing.Point(31, 24);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(121, 18);
            label25.TabIndex = 68;
            label25.Text = "Id seleccionado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 12F);
            label6.Location = new System.Drawing.Point(604, 221);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 18);
            label6.TabIndex = 64;
            label6.Text = "Foto del escudo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 12F);
            label5.Location = new System.Drawing.Point(350, 221);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(217, 18);
            label5.TabIndex = 63;
            label5.Text = "Foto del estadio donde reside";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 12F);
            label4.Location = new System.Drawing.Point(191, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(171, 18);
            label4.TabIndex = 60;
            label4.Text = "Url con foto del estadio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 12F);
            label3.Location = new System.Drawing.Point(397, 114);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(170, 18);
            label3.TabIndex = 58;
            label3.Text = "Url con foto del escudo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F);
            label2.Location = new System.Drawing.Point(359, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(245, 18);
            label2.TabIndex = 55;
            label2.Text = "Nombre del estadio donde reside:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F);
            label1.Location = new System.Drawing.Point(238, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 18);
            label1.TabIndex = 52;
            label1.Text = "Nombre:";
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
            // 
            // prbBarra
            // 
            this.prbBarra.Location = new System.Drawing.Point(13, 428);
            this.prbBarra.Name = "prbBarra";
            this.prbBarra.Size = new System.Drawing.Size(580, 25);
            this.prbBarra.Step = 3;
            this.prbBarra.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbBarra.TabIndex = 1;
            // 
            // tboxsBuscar
            // 
            this.tboxsBuscar.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxsBuscar.Location = new System.Drawing.Point(137, 195);
            this.tboxsBuscar.Name = "tboxsBuscar";
            this.tboxsBuscar.Size = new System.Drawing.Size(145, 23);
            this.tboxsBuscar.TabIndex = 69;
            // 
            // tboxsId
            // 
            this.tboxsId.Enabled = false;
            this.tboxsId.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxsId.Location = new System.Drawing.Point(20, 58);
            this.tboxsId.Name = "tboxsId";
            this.tboxsId.Size = new System.Drawing.Size(145, 23);
            this.tboxsId.TabIndex = 67;
            // 
            // cbSelec
            // 
            this.cbSelec.AutoSize = true;
            this.cbSelec.Enabled = false;
            this.cbSelec.Font = new System.Drawing.Font("Arial", 12F);
            this.cbSelec.Location = new System.Drawing.Point(149, 225);
            this.cbSelec.Name = "cbSelec";
            this.cbSelec.Size = new System.Drawing.Size(123, 22);
            this.cbSelec.TabIndex = 66;
            this.cbSelec.Text = "Seleccionado";
            this.cbSelec.UseVisualStyleBackColor = true;
            // 
            // TabaDatos
            // 
            this.TabaDatos.AllowUserToAddRows = false;
            this.TabaDatos.AllowUserToDeleteRows = false;
            this.TabaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sId,
            this.sNombre,
            this.sEstadio});
            this.TabaDatos.Location = new System.Drawing.Point(10, 253);
            this.TabaDatos.Name = "TabaDatos";
            this.TabaDatos.ReadOnly = true;
            this.TabaDatos.Size = new System.Drawing.Size(344, 150);
            this.TabaDatos.TabIndex = 65;
            this.TabaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabaDatos_CellContentClick);
            // 
            // sId
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            this.sId.DefaultCellStyle = dataGridViewCellStyle1;
            this.sId.HeaderText = "Id";
            this.sId.Name = "sId";
            this.sId.ReadOnly = true;
            this.sId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sNombre
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            this.sNombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.sNombre.HeaderText = "Nombre";
            this.sNombre.Name = "sNombre";
            this.sNombre.ReadOnly = true;
            this.sNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sEstadio
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            this.sEstadio.DefaultCellStyle = dataGridViewCellStyle3;
            this.sEstadio.HeaderText = "Estadio";
            this.sEstadio.Name = "sEstadio";
            this.sEstadio.ReadOnly = true;
            this.sEstadio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tboxuEstadio
            // 
            this.tboxuEstadio.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxuEstadio.Location = new System.Drawing.Point(203, 148);
            this.tboxuEstadio.Name = "tboxuEstadio";
            this.tboxuEstadio.Size = new System.Drawing.Size(145, 23);
            this.tboxuEstadio.TabIndex = 56;
            // 
            // tboxuEscudo
            // 
            this.tboxuEscudo.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxuEscudo.Location = new System.Drawing.Point(408, 148);
            this.tboxuEscudo.Name = "tboxuEscudo";
            this.tboxuEscudo.Size = new System.Drawing.Size(145, 23);
            this.tboxuEscudo.TabIndex = 57;
            // 
            // tboxsEstadio
            // 
            this.tboxsEstadio.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxsEstadio.Location = new System.Drawing.Point(408, 57);
            this.tboxsEstadio.Name = "tboxsEstadio";
            this.tboxsEstadio.Size = new System.Drawing.Size(145, 23);
            this.tboxsEstadio.TabIndex = 54;
            // 
            // tboxsNombre
            // 
            this.tboxsNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.tboxsNombre.Location = new System.Drawing.Point(203, 57);
            this.tboxsNombre.Name = "tboxsNombre";
            this.tboxsNombre.Size = new System.Drawing.Size(145, 23);
            this.tboxsNombre.TabIndex = 53;
            // 
            // btnElim
            // 
            this.btnElim.Enabled = false;
            this.btnElim.Font = new System.Drawing.Font("Arial", 12F);
            this.btnElim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElim.ImageIndex = 1;
            this.btnElim.ImageList = this.imageList1;
            this.btnElim.Location = new System.Drawing.Point(607, 35);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(117, 45);
            this.btnElim.TabIndex = 72;
            this.btnElim.Text = "Eliminar";
            this.btnElim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_ClickAsync);
            // 
            // btnMod
            // 
            this.btnMod.Enabled = false;
            this.btnMod.Font = new System.Drawing.Font("Arial", 12F);
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.ImageIndex = 3;
            this.btnMod.ImageList = this.imageList1;
            this.btnMod.Location = new System.Drawing.Point(607, 87);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(117, 45);
            this.btnMod.TabIndex = 71;
            this.btnMod.Text = "Modificar";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_ClickAsync);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.ImageIndex = 2;
            this.btnBuscar.ImageList = this.imageList1;
            this.btnBuscar.Location = new System.Drawing.Point(14, 183);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 45);
            this.btnBuscar.TabIndex = 70;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_ClickAsync);
            // 
            // btnReg
            // 
            this.btnReg.Enabled = false;
            this.btnReg.Font = new System.Drawing.Font("Arial", 12F);
            this.btnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReg.ImageIndex = 0;
            this.btnReg.ImageList = this.imageList1;
            this.btnReg.Location = new System.Drawing.Point(607, 138);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(117, 45);
            this.btnReg.TabIndex = 59;
            this.btnReg.Text = "Registrar";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_ClickAsync);
            // 
            // pbEscudo
            // 
            this.pbEscudo.Image = ((System.Drawing.Image)(resources.GetObject("pbEscudo.Image")));
            this.pbEscudo.InitialImage = null;
            this.pbEscudo.Location = new System.Drawing.Point(580, 254);
            this.pbEscudo.Name = "pbEscudo";
            this.pbEscudo.Size = new System.Drawing.Size(191, 149);
            this.pbEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEscudo.TabIndex = 62;
            this.pbEscudo.TabStop = false;
            // 
            // pbEstadio
            // 
            this.pbEstadio.Image = ((System.Drawing.Image)(resources.GetObject("pbEstadio.Image")));
            this.pbEstadio.InitialImage = null;
            this.pbEstadio.Location = new System.Drawing.Point(362, 254);
            this.pbEstadio.Name = "pbEstadio";
            this.pbEstadio.Size = new System.Drawing.Size(191, 149);
            this.pbEstadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstadio.TabIndex = 61;
            this.pbEstadio.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Enabled = false;
            this.btnCargar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.ImageIndex = 6;
            this.btnCargar.ImageList = this.imageList1;
            this.btnCargar.Location = new System.Drawing.Point(607, 423);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(153, 35);
            this.btnCargar.TabIndex = 48;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_ClickAsync);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageIndex = 4;
            this.btnCancelar.ImageList = this.imageList1;
            this.btnCancelar.Location = new System.Drawing.Point(14, 126);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 45);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(179, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 23);
            this.textBox1.TabIndex = 75;
            this.textBox1.Text = "Cargando Datos Por Favor Espere...";
            this.textBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.tboxsBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(label25);
            this.Controls.Add(this.tboxsId);
            this.Controls.Add(this.cbSelec);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.TabaDatos);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.pbEscudo);
            this.Controls.Add(this.pbEstadio);
            this.Controls.Add(this.tboxuEstadio);
            this.Controls.Add(label4);
            this.Controls.Add(this.tboxuEscudo);
            this.Controls.Add(label3);
            this.Controls.Add(this.tboxsEstadio);
            this.Controls.Add(label2);
            this.Controls.Add(this.tboxsNombre);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.prbBarra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Teams";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar prbBarra;
        private System.Windows.Forms.Button btnCargar;
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label textBox1;
    }
}

