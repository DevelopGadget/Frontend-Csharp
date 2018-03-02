using Client_Web_Api.Controller;
using System;
using System.Threading.Tasks;
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
    }
}
