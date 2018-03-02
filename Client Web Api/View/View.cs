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

        private async void Tablas(DataGridView Table)
        {
            while (Table.Rows.Count != 0)
            {
                Table.Rows.RemoveAt(0);
            }
            foreach (EquiposModel Ob in await Equipos.Read())
            {
                Table.Rows.Add(new String[] {Ob.sNombre, Ob.sEstadio });
            }
        }

        private void Listar()
        {
            Tablas(tableRegistro);
            Tablas(tableMod);
            Tablas(tableElim);
            Tablas(tableBuscar);
        }
    }
}
