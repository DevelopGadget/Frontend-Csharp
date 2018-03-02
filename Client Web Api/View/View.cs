using Client_Web_Api.Controller;
using Client_Web_Api.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Web_Api
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            Listar();
        }
    
        private EquiposController Equipos = new EquiposController();

        private void View_Load(object sender, EventArgs e)
        {
            ProgressAsync();
            tboxsNombreReg.Focus();
        }

        private void tableRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Check(tableRegistro, cbReg, pbEstadioReg, pbEscudoReg, tboxsIdReg);
        }

        private void tableMod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Check(tableMod, cbMod, pbEstadioMod, pbEscudoMod, tboxsIdMod);
        }

        private void Check(DataGridView Tabla, CheckBox Check, PictureBox Estadio, PictureBox Escudo, TextBox Id)
        {
            for (int i = 0; i < Equipos.Equipos.Count; i++)
            {
                if (Tabla.CurrentRow.Cells[0].Value.Equals(Equipos.Equipos[i].Id))
                {
                    PictBox(Estadio, Escudo, Equipos.Equipos[i].uEstadio.ToString(), 
                        Equipos.Equipos[i].uEscudo.ToString());
                    Check.Checked = true;
                    Id.Text = Equipos.Equipos[i].Id;                 
                    break;
                }
            }
        }

        private void PictBox(PictureBox Estadio, PictureBox Escudo, string Url_Estadio, string Url_Escudo)
        {
            Estadio.ImageLocation = Url_Estadio;
            Escudo.ImageLocation = Url_Escudo;
        }

        private async void ProgressAsync()
        {
            var v = await Equipos.Read();
            prbBarra.Step = 1;
            for (int i = prbBarra.Minimum; i < prbBarra.Maximum; i = i + prbBarra.Step)
            {
                prbBarra.PerformStep();
            }
            if (v == null)
            {
                MessageBox.Show("Se ha Producido Un Error Vuelva A Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Tablas(DataGridView Table)
        {
            while (Table.Rows.Count != 0)
            {
                Table.Rows.RemoveAt(0);
            }
            foreach (EquiposModel Ob in await Equipos.Read())
            {
                Table.Rows.Add(new String[] {Ob.Id, Ob.sNombre, Ob.sEstadio });
            }
        }

        private void Listar()
        {
            Tablas(tableRegistro);
            Tablas(tableMod);
            Tablas(tableElim);
            Tablas(tableBus);
        }

        private void BorrarTextBox(TextBox sNombre, TextBox sEstadio, TextBox uEstadio, TextBox uEscudo)
        {
            sNombre.Text = null;
            sEstadio.Text = null;
            uEstadio.Text = null;
            uEscudo.Text = null;
        }

        private void tPestañas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
