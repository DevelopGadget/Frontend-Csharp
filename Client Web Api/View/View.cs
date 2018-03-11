using Client_Web_Api.Controller;
using Client_Web_Api.Model;
using System;
using System.Collections;
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
        private JugadoresController Jugadores = new JugadoresController();

        private void View_Load(object sender, EventArgs e)
        {
            if (Equipos.AccesoInternet())
            {
                textBox1.Text = "Datos Cargando Por Favor Espere...";
                ProgressAsync();
                tboxsNombre.Focus();
                listaComboAsync();
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
            if (Equipos.AccesoInternet()) CheckEquipo();
            else Internet();
        }


        private void tableJug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Jugadores.AccesoInternet()) CheckJugadores();
            else Internet();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BorrarText(tboxsId, tboxsNombre, tboxsEstadio, tboxuEscudo, tboxuEstadio, tboxsBuscar);
            ControlEn(btnReg, btnMod, btnElim, cbSelec, false);
            pbEstadio.Image = Properties.Resources.select;
            pbEscudo.Image = Properties.Resources.select;
        }

        private void btnCancelarJug_Click(object sender, EventArgs e)
        {
            BorrarText(tboxIdJug, tboxsNombreJug, tboxiEdadJug, tboxsPosicionJug, tboxuNacionalidadJug, tboxsNacionalidadJug);
            ControlEn(btnRegJug, btnModJug, btnElimJug, cbSelecJug, false);
            pbClubJug.Image = Properties.Resources.select;
            pbNacionalidadJug.Image = Properties.Resources.select;
        }

        private async void btnReg_ClickAsync(object sender, EventArgs e)
        {
            if (Equipos.AccesoInternet())
            {
                ControlEn(btnReg, btnMod, btnElim, cbSelec, false);
                btnReg.Enabled = false;
                textBox1.Text = "Registrando Por Favor Espere...";
                btnBuscar.Enabled = false;
                if (ValTextEquipos())
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

        private async void btnRegJug_ClickAsync(object sender, EventArgs e)
        {
            if (Jugadores.AccesoInternet())
            {
                ControlEn(btnRegJug, btnModJug, btnElimJug, cbSelecJug, false);
                btnRegJug.Enabled = false;
                textBox1.Text = "Registrando Por Favor Espere...";
                btnBuscarJug.Enabled = false;
                if (ValTextJugadores())
                {
                    if (Jugadores.Create(new JugadoresModel(tboxsNombreJug.Text.ToUpper(), Int16.Parse(tboxiEdadJug.Text), tboxsPosicionJug.Text.ToUpper(),
                        await Equipos.Read(tboxIdJug.Text), tboxsNacionalidadJug.Text.ToUpper(), new Uri(tboxuNacionalidadJug.Text))))
                    {
                        MessageBox.Show("Se Ha Registrado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha Ocurrido Un Error Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (Tablas(await Jugadores.Read())) Progress();
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
                if (ValTextEquipos())
                {
                    if (MessageBox.Show("¿Desea Modificar Este Documento?", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ControlEn(btnReg, btnMod, btnElim, cbSelec, false);
                        btnReg.Enabled = false;
                        textBox1.Text = "Modificando Por Favor Espere...";
                        btnBuscar.Enabled = false;
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
                }
                if (Tablas(await Equipos.Read())) Progress();
            }
            else
            {
                Internet();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAsync(btnReg, btnMod, btnElim, cbSelec, tboxsBuscar.Text, true);
        }

        private void btnBuscarJug_Click(object sender, EventArgs e)
        {
            BuscarAsync(btnRegJug, btnModJug, btnElimJug, cbSelecJug, tboxBuscarJug.Text, true);
        }

        private async void btnElim_ClickAsync(object sender, EventArgs e)
        {
            if (Equipos.AccesoInternet())
            {
                if (MessageBox.Show("¿Desea Eliminar Este Documento?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ControlEn(btnReg, btnMod, btnElim, cbSelec, false);
                    btnReg.Enabled = false;
                    textBox1.Text = "Eliminando Por Favor Espere...";
                    btnBuscar.Enabled = false;
                    if (Equipos.Delete(tboxsId.Text))
                    {
                        MessageBox.Show("Se Ha Eliminado Correctamente", "Correcto", MessageBoxButtons.OK,  MessageBoxIcon.Information);
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

        private void comboClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboClub.SelectedIndex != 0)
            {
                string h = "";
                for (int i = 0; i < comboClub.SelectedItem.ToString().Length; i++)
                {
                    if (comboClub.SelectedItem.ToString()[i] == ',')
                    {
                        for (int b = i+1; b < comboClub.SelectedItem.ToString().Length; b++)
                        {
                            h += comboClub.SelectedItem.ToString()[b];
                        }
                        tboxIdJug.Text = h;
                        Clipboard.SetText(h);
                        break;
                    }
                }
            } 
        }

        private void CheckEquipo()
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
                    ControlEn(btnReg, btnMod, btnElim, cbSelec, true);
                    MessageBox.Show("Id Copiado Al Portapapeles", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }


        private void CheckJugadores()
        {
            for (int i = 0; i < Jugadores.Jugadores.Count; i++)
            {
                if (tableJug.CurrentRow.Cells[0].Value.Equals(Jugadores.Jugadores[i].Id))
                {
                    Clipboard.SetText(Jugadores.Jugadores[i].Id);
                    pbNacionalidadJug.ImageLocation = Jugadores.Jugadores[i].uNacionalidad.ToString();
                    pbClubJug.ImageLocation = Jugadores.Jugadores[i].sEquipo.uEscudo.ToString();
                    tboxIdJug.Text = Jugadores.Jugadores[i].Id;
                    tboxsNombreJug.Text = Jugadores.Jugadores[i].sNombre;
                    tboxiEdadJug.Text = Jugadores.Jugadores[i].iEdad.ToString();
                    tboxsPosicionJug.Text = Jugadores.Jugadores[i].sPosicion.ToString();
                    tboxuNacionalidadJug.Text = Jugadores.Jugadores[i].uNacionalidad.ToString();
                    tboxsNacionalidadJug.Text = Jugadores.Jugadores[i].sNacionalidad.ToString();
                    ControlEn(btnReg, btnMod, btnElim, cbSelec, true);
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
                        Tablas(await Jugadores.Read());
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

        private bool Tablas(List<JugadoresModel> v1)
        {
            try
            {
                while (tableJug.Rows.Count != 0)
                {
                    tableJug.Rows.RemoveAt(0);
                }
                foreach (JugadoresModel Ob in v1)
                {
                    tableJug.Rows.Add(new String[] { Ob.Id, Ob.sNombre, Ob.sPosicion, Ob.iEdad + "" });
                }
                listaComboAsync();
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

        private void BorrarText(TextBox Id, TextBox sNombre, TextBox Url, TextBox Url1, TextBox Buscar, TextBox Url3)
        {
            Id.Text = null;
            sNombre.Text = null;
            Url.Text = null;
            Url1.Text = null;
            Buscar.Text = null;
            Url3.Text = null;
            tboxBuscarJug.Text = null;
        }

        private void ControlEn(Button btnReg, Button btnMod, Button btnElim, CheckBox cbSelec, bool cond)
        {
            btnMod.Enabled = cond;
            btnElim.Enabled = cond;
            btnReg.Enabled = !cond;
            cbSelec.Checked = cond;
            comboClub.SelectedItem = 0;
        }

        private void Progress()
        {
            VistaPro(true);
            BorrarText(tboxsId, tboxsNombre, tboxsEstadio, tboxuEscudo, tboxuEstadio, tboxsBuscar);
            BorrarText(tboxIdJug, tboxsNombreJug, tboxiEdadJug, tboxsPosicionJug, tboxuNacionalidadJug, tboxsNacionalidadJug);
            prbBarra.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                prbBarra.PerformStep();
                Thread.Sleep(15);
            }
            VistaPro(false);
            btnCargar.Enabled = true;
            ControlEn(btnReg, btnMod, btnElim, cbSelec, false);
            ControlEn(btnRegJug, btnModJug, btnElimJug, cbSelecJug, false);
            textBox1.Text = "Datos Cargados";
            btnCancelar.PerformClick();
            if (!Equipos.AccesoInternet())
            {
                Internet();
            }
        }

        private void Internet()
        {
            ControlEn(btnReg, btnMod, btnElim, cbSelec, false);
            ControlEn(btnRegJug, btnModJug, btnElimJug, cbSelecJug, false);
            NoInt(btnReg, btnBuscar, false);
            NoInt(btnRegJug, btnBuscarJug, false);
            btnCargar.Enabled = true;
            textBox1.Text = "Verifique Su Conexión A Internet";
            MessageBox.Show("Verifique Su Conexión A Internet ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NoInt(Button btnReg, Button btnBuscar, bool cond)
        {
            btnReg.Enabled = cond;
            btnBuscar.Enabled = cond;
        }

        private void VistaPro(bool cond)
        {
            textBox1.Enabled = true;
            textBox1.Text = "Datos Cargando Por Favor Espere...";
            textBox1.Enabled = false;
            btnCargar.Enabled = !cond;
            prbBarra.Visible = cond;
            ControlEn(btnReg, btnMod, btnElim, cbSelec, !cond);
            ControlEn(btnRegJug, btnModJug, btnElimJug, cbSelecJug, !cond);
            NoInt(btnReg, btnBuscar, !cond);
            NoInt(btnRegJug, btnBuscarJug, !cond);
        }

        private bool ValTextEquipos()
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

        private bool ValTextJugadores()
        {
            if (string.IsNullOrEmpty(tboxsNombreJug.Text) || string.IsNullOrEmpty(tboxuNacionalidadJug.Text) ||
                string.IsNullOrEmpty(tboxsPosicionJug.Text) || string.IsNullOrEmpty(tboxsNacionalidadJug.Text) ||
                string.IsNullOrEmpty(tboxiEdadJug.Text) || Int32.Parse(comboClub.SelectedItem + "") == 0)
            {
                MessageBox.Show("Por Favor Todos Los Campos Deben Ser Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Equipos.Validar(tboxuNacionalidadJug.Text))
            {
                MessageBox.Show("Por Favor Digite Url Validas De Imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void BuscarAsync(Button btnReg, Button btnMod, Button btnElim, CheckBox cbSelec, string Buscar, bool lista)
        {
            if (Equipos.AccesoInternet())
            {
                try
                {
                    bool Linull = false;
                    ControlEn(btnReg, btnMod, btnElim, cbSelec, false);
                    btnReg.Enabled = false;
                    textBox1.Text = "Datos Cargando Por Favor Espere...";
                    btnBuscar.Enabled = false;
                    if (lista)
                    {
                        if (await Equipos.Read(Buscar) == null) Linull = true;
                    }
                    else
                    {
                        if (await Jugadores.Read(Buscar) == null) Linull = true;
                    }
                    if (string.IsNullOrEmpty(Buscar))
                    {
                        MessageBox.Show("Por Favor Ingrese Algun Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if(lista) if (Tablas(await Equipos.Read())) Progress();
                        else if (Tablas(await Jugadores.Read())) Progress();
                    }
                    else if (Linull)
                    {
                        MessageBox.Show("No Se Ha Encontrado Ninguna Coincidencia", "No Hay Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (lista)
                        {
                            List<EquiposModel> v = new List<EquiposModel>();
                            v.Add(await Equipos.Read(Buscar));
                            if (Tablas(v)) Progress();
                        }
                        else
                        {
                            List<JugadoresModel> v = new List<JugadoresModel>();
                            v.Add(await Jugadores.Read(Buscar));
                            if (Tablas(v)) Progress();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No Se Ha Encontrado Ninguna Coincidencia", "No Hay Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Tablas(await Jugadores.Read())) Progress();
                }
                textBox1.Text = "Listo...";
                ControlEn(btnReg, btnMod, btnElim, cbSelec, true);
                btnBuscar.Enabled = true;
            }
            else
            {
                Internet();
            }
        }

        private async void listaComboAsync()
        {
            comboClub.Items.Clear();
            comboClub.Items.Add("Seleccione Un Club");
            comboClub.SelectedIndex = 0;
            foreach (EquiposModel ob in await Equipos.Read())
            {
                comboClub.Items.Add(ob.sNombre+","+ob.Id);
            }
        }

    }
}
