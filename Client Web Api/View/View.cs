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
            if (Equipos.AccesoInternet())
            {
                textBox1.Text = "Datos Cargando Por Favor Espere...";
                ProgressAsync();
                tboxsNombre.Focus();
            }
            else
            {
                Internet();
            }

        }

        private async void btnCargar_ClickAsync(object sender, EventArgs e)
        {
            if (Equipos.AccesoInternet())
            {
                textBox1.Text = "Datos Cargando Por Favor Espere...";
                btnCargar.Enabled = false;
                if (Tablas(await Equipos.Read())) Progress();
                btnCancelar.PerformClick();
            }
            else
            {
                Internet();
            }

        }

        private void TabaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Equipos.AccesoInternet()) Check();
            else Internet();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BorrarText();
            ControlEn(false);
            pbEstadio.Image = Properties.Resources.select;
            pbEscudo.Image = Properties.Resources.select;
        }

        private async void btnReg_ClickAsync(object sender, EventArgs e)
        {
            if (Equipos.AccesoInternet())
            {
                ControlEn(false);
                btnReg.Enabled = false;
                textBox1.Text = "Registrando Por Favor Espere...";
                btnBuscar.Enabled = false;
                if (ValText())
                {
                    if (Equipos.Create(new EquiposModel(tboxsNombre.Text.ToUpper(), tboxsEstadio.Text.ToUpper(),
                                            new Uri(tboxuEstadio.Text), new Uri(tboxuEscudo.Text))))
                    {
                        MessageBox.Show("Se Ha Registrado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha Ocurrido Un Error Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (Tablas(await Equipos.Read())) Progress();
            }
            else
            {
                Internet();
            }

        }

        private async void btnMod_ClickAsync(object sender, EventArgs e)
        {
            if (Equipos.AccesoInternet())
            {
                ControlEn(false);
                btnReg.Enabled = false;
                textBox1.Text = "Modificando Por Favor Espere...";
                btnBuscar.Enabled = false;
                if (ValText())
                {
                    if (Equipos.Update(tboxsId.Text, new EquiposModel(tboxsNombre.Text.ToUpper(), tboxsEstadio.Text.ToUpper(),
                                            new Uri(tboxuEstadio.Text), new Uri(tboxuEscudo.Text))))
                    {
                        MessageBox.Show("Se Ha Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha Ocurrido Un Error Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (Tablas(await Equipos.Read())) Progress();
            }
            else
            {
                Internet();
            }
        }

        private async void btnBuscar_ClickAsync(object sender, EventArgs e)
        {
            if (Equipos.AccesoInternet())
            {
                try
                {
                    ControlEn(false);
                    btnReg.Enabled = false;
                    textBox1.Text = "Datos Cargando Por Favor Espere...";
                    btnBuscar.Enabled = false;
                    if (string.IsNullOrEmpty(tboxsBuscar.Text))
                    {
                        MessageBox.Show("Por Favor Ingrese Algun Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (Tablas(await Equipos.Read())) Progress();
                    }
                    else if (await Equipos.Read(tboxsBuscar.Text) == null)
                    {
                        MessageBox.Show("No Se Ha Encontrado Ninguna Coincidencia", "No Hay Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        List<EquiposModel> v = new List<EquiposModel>();
                        v.Add(await Equipos.Read(tboxsBuscar.Text));
                        if (Tablas(v)) Progress();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No Se Ha Encontrado Ninguna Coincidencia", "No Hay Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Tablas(await Equipos.Read())) Progress();
                }
                textBox1.Text = "Listo...";
                ControlEn(false);
                btnBuscar.Enabled = true;
            }
            else
            {
                Internet();
            }

           

        }

        private async void btnElim_ClickAsync(object sender, EventArgs e)
        {
            if (Equipos.AccesoInternet())
            {
                ControlEn(false);
                btnReg.Enabled = false;
                textBox1.Text = "Eliminando Por Favor Espere...";
                btnBuscar.Enabled = false;
                if (Equipos.Delete(tboxsId.Text))
                {
                    MessageBox.Show("Se Ha Eliminado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha Ocurrido Un Error Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Tablas(await Equipos.Read())) Progress();
            }
            else
            {
                Internet();
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
            if (!Equipos.AccesoInternet())
            {
                Internet();
            }
            else
            {
                try
                {
                    textBox1.Text = "Datos Cargando Por Favor Espere...";
                    var v = await Equipos.Read();
                    if (v == null)
                    {
                        MessageBox.Show("Se ha Producido Un Error Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "Verifique Su Conexión A Internet";
                        btnCargar.Enabled = true;
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

        }

        private bool Tablas(List<EquiposModel> v1)
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
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha Producido Un Error Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "Verifique Su Conexión A Internet";
                btnCargar.Enabled = true;
                return false;
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
            btnCancelar.PerformClick();
            if (!Equipos.AccesoInternet())
            {
                Internet();
            }
        }

        private void Internet()
        {
            ControlEn(false);
            btnReg.Enabled = false;
            btnBuscar.Enabled = false;
            btnCargar.Enabled = true;
            textBox1.Text = "Verifique Su Conexión A Internet";
            MessageBox.Show("Verifique Su Conexión A Internet ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool ValText()
        {
            if (string.IsNullOrEmpty(tboxsNombre.Text) || string.IsNullOrEmpty(tboxsEstadio.Text) ||
                                string.IsNullOrEmpty(tboxuEscudo.Text) || string.IsNullOrEmpty(tboxuEstadio.Text))
            {
                MessageBox.Show("Por Favor Todos Los Campos Deben Ser Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Equipos.Validar(tboxuEstadio.Text) || !Equipos.Validar(tboxuEscudo.Text))
            {
                MessageBox.Show("Por Favor Digite Url Validas De Imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
