using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TobbformosMvcPizzaTobbTabla
{
    public partial class FormPizzaFutarKft : Form
    {


        public FormPizzaFutarKft()
        {
            InitializeComponent();
            beallitKezdoFormot();
        }

        public void beallitKezdoFormot()
        {
            this.Size = new Size(1024, 768);
            this.Text = "Pizza Futar KFT.";
        }

        private void megrendelőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlPizzaFutarKFT.SelectTab("tabPageMegrendelok");
        }

        private void futárToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlPizzaFutarKFT.SelectTab("tabPageFutarok");
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlPizzaFutarKFT.SelectTab("tabPagePizzak");
        }
    }
}
