using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scroll_Bars
{
    public partial class Bars : Form
    {
        public Bars()
        {
            InitializeComponent();
        }

        private void BarraHorizTeste_Scroll(object sender, ScrollEventArgs e)
        {
            LblTeste.Text = BarraHorizTeste.Value.ToString();
        }
    }
}
