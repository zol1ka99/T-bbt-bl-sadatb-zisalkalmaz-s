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
        RepositoryDatabase rd = new RepositoryDatabase();
        RepositoryDatabaseTablePizza rdPizza = new RepositoryDatabaseTablePizza();
        RepositoryDatabaseTableCustomer rdCustomer = new RepositoryDatabaseTableCustomer();
        RepositoryDatabaseTableCourier rdCourier = new RepositoryDatabaseTableCourier();
        RepositoryDatabaseTableOrder rdOrder = new RepositoryDatabaseTableOrder();
        RepositoryDatabaseTableItem rdItem = new RepositoryDatabaseTableItem();

        private void torolHibauzenetet()
        {
            toolStripLabelHibauzenet.ForeColor = Color.Black;
            toolStripLabelHibauzenet.Text = "";
        }
        private void kiirHibauzenetet(string hibauzenet)
        {
            toolStripLabelHibauzenet.ForeColor = Color.Red;
            toolStripLabelHibauzenet.Text = hibauzenet;
        }

        private void adatázbázisLétrehozásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();
                rd.createDatabase();
            }
            catch (Exception ex)
            {
                kiirHibauzenetet("Adatbázis létrehozási hiba!");
            }
        }

        private void törölAdatbázisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();
                rd.deleteDatabase();
            }
            catch (Exception ex)
            {
                kiirHibauzenetet("Adatbázis törlési hiba!");
            }
        }

        private void feltöltésTesztadatokkalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();
                rdPizza.createTablePizza();
                rdCustomer.createTableCustomer();
                rdCourier.createTableCourier();
                rdOrder.createTableOrder();
                rdItem.createTableOrder();

                rdPizza.fillPizzasWithTestDataFromSQLCommand();
                rdCustomer.fillCustomerkWithTestDataFromSQLCommand();
                rdCourier.fillCourierWithTestDataFromSQLCommand();
                rdOrder.fillOrderWithTestDataFromSQLCommand();
                rdItem.fillOrderWithTestDataFromSQLCommand();
            }
            catch (Exception ex)
            {
                kiirHibauzenetet("Tesztadatok felöltése sikertelen!");
            }
        }

        private void törölTesztadatokatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();
                rdPizza.deleteTablePizza();
                rdCustomer.deleteTableCustomer();
            }
            catch (Exception ex)
            {
                kiirHibauzenetet("Táblák törlése sikertelen!");
            }
        }
    }
}
