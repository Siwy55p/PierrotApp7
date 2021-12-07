using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PierrotApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void F2_UpdateEventHandler1(object sender, KontrahenciDodaj args)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStart.Visible = true;
            MenuMagazyn.Visible = false;
        }

        private void magazynToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStart.Visible = false;
            MenuMagazyn.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KontrahenciDodaj kontAdd = new KontrahenciDodaj();
            kontAdd.Show();
        }

        private void kontrahenciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kontrahenciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Kontrahenci' . Możesz go przenieść lub usunąć.
            this.kontrahenciTableAdapter.Fill(this.database1DataSet.Kontrahenci);

        }

        private void button10_Click(object sender, EventArgs e) //Refresh Przycisk
        {
            this.kontrahenciTableAdapter.Fill(this.database1DataSet.Kontrahenci);
        }

        private void RefKontrahenci_Tick(object sender, EventArgs e)
        {
            this.kontrahenciTableAdapter.Fill(this.database1DataSet.Kontrahenci);
        }
    }
}
