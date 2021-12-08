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
    public partial class DodajArtykul : Form
    {
        public DodajArtykul()
        {
            InitializeComponent();
        }

        private void artykulyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artykulyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1Artykuly);

        }

        private void DodajArtykul_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1Artykuly.Artykuly' . Możesz go przenieść lub usunąć.
            this.artykulyTableAdapter.Fill(this.database1Artykuly.Artykuly);

        }
    }
}
