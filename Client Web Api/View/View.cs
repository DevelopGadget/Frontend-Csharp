using Client_Web_Api.Controller;
using Client_Web_Api.Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Client_Web_Api
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private EquiposController Equipos = new EquiposController();

        private void View_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Datos Cargando Por Favor Espere...";
            ProgressAsync();
            tboxsNombre.Focus();
        }

        private async void btnCargar_ClickAsync(object sender, EventArgs e)
        {
            textBox1.Text = "Datos Cargando Por Favor Espere...";
            btnCargar.Enabled = false;
            Tablas(await Equipos.Read());
            Progress();
            btnCancelar.PerformClick();
        }

        private void TabaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Check();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BorrarText();
            ControlEn(false);
            pbEstadio.Image = Properties.Resources.select;
            pbEscudo.Image = Properties.Resources.select;
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxsNombre.Text) || string.IsNullOrEmpty(tboxsEstadio.Text) ||
                string.IsNullOrEmpty(tboxuEscudo.Text) || string.IsNullOrEmpty(tboxuEstadio.Text))
            {
                MessageBox.Show("Por Favor Todos Los Campos Deben Ser Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(!Equipos.Validar(tboxuEstadio.Text))
            {
                MessageBox.Show("Por Favor Digite Url Validas De Imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_ClickAsync(object sender, EventArgs e)
        {
            textBox1.Text = "Datos Cargando Por Favor Espere...";
            ControlEn(false);
            try
            {
                if (string.IsNullOrEmpty(tboxsBuscar.Text))
                {
                    MessageBox.Show("Por Favor Ingrese Algun Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Tablas(await Equipos.Read());
                    Progress();
                }
                else if (await Equipos.Read(tboxsBuscar.Text) == null)
                {
                    MessageBox.Show("No Se Ha Encontrado Ninguna Coincidencia", "No Hay Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    List<EquiposModel> v = new List<EquiposModel>();
                    v.Add(await Equipos.Read(tboxsBuscar.Text));
                    Progress();
                    Tablas(v);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Se Ha Encontrado Ninguna Coincidencia", "No Hay Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tablas(await Equipos.Read());
                Progress();
            }
            
        }

        private void Check()
        {
            for (int i = 0; i < Equipos.Equipos.Count; i++)
            {
                if (TabaDatos.CurrentRow.Cells[0].Value.Equals(Equipos.Equipos[i].Id))
                {
                    Clipboard.SetText(Equipos.Equipos[i].Id);
                    pbEstadio.ImageLocation = Equipos.Equipos[i].uEstadio.ToString();
                    pbEscudo.ImageLocation = Equipos.Equipos[i].uEscudo.ToString();
                    tboxsId.Text = Equipos.Equipos[i].Id;
                    tboxsNombre.Text = Equipos.Equipos[i].sNombre;
                    tboxsEstadio.Text = Equipos.Equipos[i].sEstadio;
                    tboxuEstadio.Text = Equipos.Equipos[i].uEstadio.ToString();
                    tboxuEscudo.Text = Equipos.Equipos[i].uEscudo.ToString();
                    ControlEn(true);
                    MessageBox.Show("Id Copiado Al Portapapeles", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private async void ProgressAsync()
        {
            btnCargar.Enabled = false;
            try
            {
                textBox1.Text = "Datos Cargando Por Favor Espere...";
                var v = await Equipos.Read();
                if (v == null)
                {
                    MessageBox.Show("Se ha Producido Un Error Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Tablas(await Equipos.Read());
                    Progress();
                }

            }
            catch (Exception)
            {
                btnCargar.Enabled = true;
                MessageBox.Show("Tiempo De Espera Agotado Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tablas(List<EquiposModel> v1)
        {
            try
            {
                while (TabaDatos.Rows.Count != 0)
                {
                    TabaDatos.Rows.RemoveAt(0);
                }
                foreach (EquiposModel Ob in v1)
                {
                    TabaDatos.Rows.Add(new String[] { Ob.Id, Ob.sNombre, Ob.sEstadio });
                }
            }
            catch (Exception)
            {

            }
        }

        private void BorrarText()
        {
            tboxsId.Text = null;
            tboxsNombre.Text = null;
            tboxsEstadio.Text = null;
            tboxuEstadio.Text = null;
            tboxuEscudo.Text = null;
            tboxsBuscar.Text = null;
        }

        private void ControlEn(bool cond)
        {
            btnMod.Enabled = cond;
            btnElim.Enabled = cond;
            btnReg.Enabled = !cond;
            cbSelec.Checked = cond;
        }
        private void Progress()
        {
            VistaPro(true);
            BorrarText();
            prbBarra.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                prbBarra.PerformStep();
                Thread.Sleep(15);
            }
            VistaPro(false);
            btnCargar.Enabled = true;
            ControlEn(false);
            textBox1.Text = "Datos Cargados";
        }

        private void VistaPro(bool cond)
        {
            textBox1.Enabled = true;
            textBox1.Text = "Datos Cargando Por Favor Espere...";
            textBox1.Enabled = false;
            btnCargar.Enabled = !cond;
            prbBarra.Visible = cond;
            ControlEn(!cond);
            btnReg.Enabled = !cond;
            btnBuscar.Enabled = !cond;
        }

    }
}
