using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TobbbformosPizzaAlkalmazasTobbTabla.Repository;

namespace TobbformosMvcPizzaTobbTabla
{
    public partial class FormPizzaFutarKft : Form
    {

        private void tabControlPizzaFutarKFT_Selected(object sender, TabControlEventArgs e)
        {
            beallitSzamlakTabPagetIndulaskor();
            feltoltComboBoxotMegrendelokkel();
        }

        private void feltoltComboBoxotMegrendelokkel()
        {
            comboBoxMegrendelok.DataSource = repo.getCustomersName();
        }

        private void beallitSzamlakTabPagetIndulaskor()
        {
            listViewRendelesek.Visible = false;
            labelVevoRendeles.Visible = false;
            dataGridViewTetelek.Visible = false;
            labelTetelek.Visible = false;
        }
    }
}
