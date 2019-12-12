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
using TobbbformosPizzaAlkalmazasTobbTabla.Model;
using System.Diagnostics;

namespace TobbformosMvcPizzaTobbTabla
{
    public partial class FormPizzaFutarKft : Form
    {
        /// <summary>
        /// Pizzákat tartalmazó adattábla
        /// </summary>
        private DataTable pizzasDT = new DataTable();
        /// <summary>
        /// Tárolja a pizzákat listában
        /// </summary>
        private Repository repo = new Repository();

        bool ujAdatfelvitel = false;

        private void buttonBetoltesPizzak_Click(object sender, EventArgs e)
        {
            //Adatbázisban pizza tábla kezelése
            RepositoryDatabaseTablePizza rtp = new RepositoryDatabaseTablePizza();
            //A repo-ba lévő pizza listát feltölti az adatbázisból
            repo.setPizzas(rtp.getPizzasFromDatabaseTable());
            frissitAdatokkalDataGriedViewt();
            beallitPizzaDataGriViewt();
            beallitGombokatIndulaskor();            

            dataGridViewPizzak.SelectionChanged += DataGridViewPizzak_SelectionChanged;
        }

        private void beallitGombokatIndulaskor()
        {
            panelPizza.Visible = false;
            panelModositTorolGombok.Visible = false ;
            if (dataGridViewPizzak.SelectedRows.Count != 0)
                buttonUjPizza.Visible = false;
            else
                buttonUjPizza.Visible = true;
        }

        private void DataGridViewPizzak_SelectionChanged(object sender, EventArgs e)
        {
            
            if (ujAdatfelvitel)
            {
                beallitGombokatKattintaskor();
            }           
            if (dataGridViewPizzak.SelectedRows.Count == 1)
            {
                panelPizza.Visible = true;
                panelModositTorolGombok.Visible = true;
                buttonUjPizza.Visible = true;
                textBoxPizzaAzonosito.Text =
                    dataGridViewPizzak.SelectedRows[0].Cells[0].Value.ToString();
                textBoxPizzaNev.Text =
                    dataGridViewPizzak.SelectedRows[0].Cells[1].Value.ToString();
                textBoxPizzaAr.Text =
                    dataGridViewPizzak.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                panelPizza.Visible = false;
                panelModositTorolGombok.Visible = false;
                buttonUjPizza.Visible = false;
            }
        }

        private void frissitAdatokkalDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő pizza listából
            pizzasDT = repo.getPizzaDataTableFromList();
            //Pizza DataGridView-nak a forrása a pizza adattábla
            dataGridViewPizzak.DataSource = null;
            dataGridViewPizzak.DataSource = pizzasDT;
        }

        private void beallitPizzaDataGriViewt()
        {
            pizzasDT.Columns[0].ColumnName = "Azonosító";
            pizzasDT.Columns[0].Caption = "Pizza azonosító";
            pizzasDT.Columns[1].ColumnName = "Név";
            pizzasDT.Columns[1].Caption = "Pizza név";
            pizzasDT.Columns[2].ColumnName = "Ár";
            pizzasDT.Columns[2].Caption = "Pizza ár";

            dataGridViewPizzak.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPizzak.ReadOnly = true;
            dataGridViewPizzak.AllowUserToDeleteRows = false;
            dataGridViewPizzak.AllowUserToAddRows = false;
            dataGridViewPizzak.MultiSelect = false;
        }

        private void buttonTorolPizza_Click(object sender, EventArgs e)
        {
            torolHibauzenetet();
            if ((dataGridViewPizzak.Rows == null) ||
                (dataGridViewPizzak.Rows.Count == 0))
                return;
            //A felhasználó által kiválasztott sor a DataGridView-ban            
            int sor = dataGridViewPizzak.SelectedRows[0].Index;
            if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //1. törölni kell a listából
                int id = -1;
                if (!int.TryParse(
                         dataGridViewPizzak.SelectedRows[0].Cells[0].Value.ToString(),
                         out id))
                    return;
                try
                {
                    repo.deletePizzaFromList(id);
                }
                catch (RepositoryExceptionCantDelete recd)
                {
                    kiirHibauzenetet(recd.Message);
                    Debug.WriteLine("A pizza törlés nem sikerült, nincs a listába!");
                }
                //2. törölni kell az adatbázisból
                RepositoryDatabaseTablePizza rdtp = new RepositoryDatabaseTablePizza();
                try
                {
                    rdtp.deletePizzaFromDatabase(id);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                }
                //3. frissíteni kell a DataGridView-t  
                frissitAdatokkalDataGriedViewt();
                if (dataGridViewPizzak.SelectedRows.Count <= 0)
                {
                    buttonUjPizza.Visible = true;
                }
                beallitPizzaDataGriViewt();
            }
        }
        private void buttonModositPizza_Click(object sender, EventArgs e)
        {
            torolHibauzenetet();
            errorProviderPizzaName.Clear();
            errorProviderPizzaPrice.Clear();
            try
            {
                Pizza modosult = new Pizza(
                    Convert.ToInt32(textBoxPizzaAzonosito.Text),
                    textBoxPizzaNev.Text,
                    textBoxPizzaAr.Text
                    );
                int azonosito = Convert.ToInt32(textBoxPizzaAzonosito.Text);
                //1. módosítani a listába
                try
                {
                    repo.updatePizzaInList(azonosito, modosult);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                    return;
                }
                //2. módosítani az adatbáziba
                RepositoryDatabaseTablePizza rdtp = new RepositoryDatabaseTablePizza();
                try
                {
                    rdtp.updatePizzaInDatabase(azonosito, modosult);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                }
                //3. módosítani a DataGridView-ban           
                frissitAdatokkalDataGriedViewt();
            }
            catch (ModelPizzaNotValidNameExeption nvn)
            {
                errorProviderPizzaName.SetError(textBoxPizzaNev, nvn.Message);
            }
            catch (ModelPizzaNotValidPriceExeption nvp)
            {
                errorProviderPizzaName.SetError(textBoxPizzaAr, nvp.Message);
            }
            catch (RepositoryExceptionCantModified recm)
            {
                kiirHibauzenetet(recm.Message);
                Debug.WriteLine("Módosítás nem sikerült, a pizza nincs a listába!");
            }
            catch (Exception ex)
            { }
        }

        private void buttonUjMentes_Click(object sender, EventArgs e)
        {
            torolHibauzenetet();
            errorProviderPizzaName.Clear();
            errorProviderPizzaPrice.Clear();
            try
            {
                Pizza ujPizza = new Pizza(
                    Convert.ToInt32(textBoxPizzaAzonosito.Text),
                    textBoxPizzaNev.Text,
                    textBoxPizzaAr.Text
                    );
                int azonosito = Convert.ToInt32(textBoxPizzaAzonosito.Text);
                //1. Hozzáadni a listához
                try
                {
                    repo.addPizzaToList(ujPizza);
                }
                catch(Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                    return;
                }
                //2. Hozzáadni az adatbázishoz
                RepositoryDatabaseTablePizza rdtp = new RepositoryDatabaseTablePizza();
                try
                {
                    rdtp.insertPizzaToDatabase(ujPizza);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                }
                //3. Frissíteni a DataGridView-t
                beallitGombokatUjPizzaMegsemEsMentes();
                frissitAdatokkalDataGriedViewt();
                if (dataGridViewPizzak.SelectedRows.Count == 1)
                {
                    beallitPizzaDataGriViewt();
                }

            }
            catch (ModelPizzaNotValidNameExeption nvn)
            {
                errorProviderPizzaName.SetError(textBoxPizzaNev, nvn.Message);
            }
            catch (ModelPizzaNotValidPriceExeption nvp)
            {
                errorProviderPizzaName.SetError(textBoxPizzaAr, nvp.Message);
            }
            catch (Exception ex)
            {
            }
        }

        private void buttonUjPizza_Click(object sender, EventArgs e)
        {
            ujAdatfelvitel = true;
            beallitGombokatTextboxokatUjPizzanal();
            int ujPizzaAzonosito = repo.getNextPizzaId();
            textBoxPizzaAzonosito.Text = ujPizzaAzonosito.ToString();
        }

        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            beallitGombokatUjPizzaMegsemEsMentes();
        }    

        private void beallitGombokatUjPizzaMegsemEsMentes()
        {
            if ((dataGridViewPizzak.Rows != null) &&
                (dataGridViewPizzak.Rows.Count > 0))
                dataGridViewPizzak.Rows[0].Selected = true;
            buttonUjMentes.Visible = false;
            buttonMegsem.Visible = false;
            panelModositTorolGombok.Visible = true;
            ujAdatfelvitel = false;

            textBoxPizzaNev.Text = string.Empty;
            textBoxPizzaAr.Text = string.Empty;
          
        }
        private void beallitGombokatTextboxokatUjPizzanal()
        {
            panelPizza.Visible = true;
            panelModositTorolGombok.Visible = false;
            textBoxPizzaNev.Text = string.Empty;
            textBoxPizzaAr.Text = string.Empty;
        }

        private void beallitGombokatKattintaskor()
        {
            ujAdatfelvitel = false;
            buttonUjMentes.Visible = false;
            buttonMegsem.Visible = false;
            panelModositTorolGombok.Visible = true;
            errorProviderPizzaName.Clear();
            errorProviderPizzaPrice.Clear();
        }

        private void textBoxPizzaNev_TextChanged(object sender, EventArgs e)
        {
            kezelUjMegsemGombokat();
        }

        private void textBoxPizzaAr_TextChanged(object sender, EventArgs e)
        {
            kezelUjMegsemGombokat();
        }

        private void kezelUjMegsemGombokat()
        {
            if (ujAdatfelvitel == false)
                return;
            if ((textBoxPizzaNev.Text != string.Empty) ||
                (textBoxPizzaAr.Text != string.Empty))
            {
                buttonUjMentes.Visible = true;
                buttonMegsem.Visible = true;
            }
            else
            {
                buttonUjMentes.Visible = false;
                buttonMegsem.Visible = false;
            }
        }

    }
}
