using Client_Web_Api.Controller;
using Client_Web_Api.Model;
using System;
using System.Collections.Generic;
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
            ProgressAsync();
            tboxsNombre.Focus();
        }

        private async void btnCargar_ClickAsync(object sender, EventArgs e)
        {
            Tablas(await Equipos.Read());
        }

        private void TabaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Check();
        }

        private async void btnBuscar_ClickAsync(object sender, EventArgs e)
        {
            BorrarText();
            ControlEn(false);
            try
            {
                if (string.IsNullOrEmpty(tboxsBuscar.Text))
                {
                    MessageBox.Show("Por Favor Ingrese Algun Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (await Equipos.Read(tboxsBuscar.Text) == null)
                {
                    MessageBox.Show("No Se Ha Encontrado Ninguna Coincidencia", "No Hay Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    List<EquiposModel> v = new List<EquiposModel>();
                    v.Add(await Equipos.Read(tboxsBuscar.Text));
                    Tablas(v);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Se Ha Encontrado Ninguna Coincidencia", "No Hay Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Check()
        {
            for (int i = 0; i < Equipos.Equipos.Count; i++)
            {
                if (TabaDatos.CurrentRow.Cells[0].Value.Equals(Equipos.Equipos[i].Id))
                {
                    pbEstadio.ImageLocation = Equipos.Equipos[i].uEstadio.ToString();
                    pbEscudo.ImageLocation = Equipos.Equipos[i].uEscudo.ToString();
                    tboxsId.Text = Equipos.Equipos[i].Id;
                    tboxsNombre.Text = Equipos.Equipos[i].sNombre;
                    tboxsEstadio.Text = Equipos.Equipos[i].sEstadio;
                    tboxuEstadio.Text = Equipos.Equipos[i].uEstadio.ToString();
                    tboxuEscudo.Text = Equipos.Equipos[i].uEscudo.ToString();
                    ControlEn(true);
                    break;
                }
            }
        }

        private async void ProgressAsync()
        {
            try
            {
                prbBarra.Value = 0;
                var v = await Equipos.Read();
                prbBarra.Step = 1;
                if (v == null)
                {
                    MessageBox.Show("Se ha Producido Un Error Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Tablas(await Equipos.Read());
                }
                for (int i = prbBarra.Minimum; i < prbBarra.Maximum; i = (int) i + prbBarra.Step)
                {
                    prbBarra.PerformStep();
                }
            }
            catch (Exception)
            {
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

    }
}
