namespace PierrotApp7
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Węzeł1");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Węzeł0", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Węzeł3");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Węzeł4");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Węzeł2", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Węzeł6");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Węzeł5", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazynToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMagazyn = new System.Windows.Forms.MenuStrip();
            this.dokumentyMagazynoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentySADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStart = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.kontrahenciDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaKontrahentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wojewodztwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powiatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrKontahentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontoFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.płatnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćPktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartośćPktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontoRaksFMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaKlasyfikacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaGrupyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handlowiecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailKontrahentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allegroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jPKKlasyfikacjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontrahenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new PierrotApp7.Database1DataSet();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RefKontrahenci = new System.Windows.Forms.Timer(this.components);
            this.kontrahenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontrahenciTableAdapter = new PierrotApp7.Database1DataSetTableAdapters.KontrahenciTableAdapter();
            this.tableAdapterManager = new PierrotApp7.Database1DataSetTableAdapters.TableAdapterManager();
            this.operacjeHandloweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartotekiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamówieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przycisk1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przycisk2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuMagazyn.SuspendLayout();
            this.MenuStart.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.magazynToolStripMenuItem,
            this.operacjeHandloweToolStripMenuItem,
            this.crMToolStripMenuItem,
            this.raportyToolStripMenuItem,
            this.kartotekiToolStripMenuItem,
            this.inneToolStripMenuItem,
            this.administratorToolStripMenuItem,
            this.oknaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Checked = true;
            this.startToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // magazynToolStripMenuItem
            // 
            this.magazynToolStripMenuItem.Name = "magazynToolStripMenuItem";
            this.magazynToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.magazynToolStripMenuItem.Text = "Magazyn";
            this.magazynToolStripMenuItem.Click += new System.EventHandler(this.magazynToolStripMenuItem_Click);
            // 
            // MenuMagazyn
            // 
            this.MenuMagazyn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentyMagazynoweToolStripMenuItem,
            this.dokumentySADToolStripMenuItem});
            this.MenuMagazyn.Location = new System.Drawing.Point(0, 24);
            this.MenuMagazyn.Name = "MenuMagazyn";
            this.MenuMagazyn.Size = new System.Drawing.Size(838, 24);
            this.MenuMagazyn.TabIndex = 1;
            this.MenuMagazyn.Text = "menuStrip2";
            this.MenuMagazyn.Visible = false;
            // 
            // dokumentyMagazynoweToolStripMenuItem
            // 
            this.dokumentyMagazynoweToolStripMenuItem.Name = "dokumentyMagazynoweToolStripMenuItem";
            this.dokumentyMagazynoweToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.dokumentyMagazynoweToolStripMenuItem.Text = "Dokumenty Magazynowe";
            // 
            // dokumentySADToolStripMenuItem
            // 
            this.dokumentySADToolStripMenuItem.Name = "dokumentySADToolStripMenuItem";
            this.dokumentySADToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.dokumentySADToolStripMenuItem.Text = "Dokumenty SAD";
            // 
            // MenuStart
            // 
            this.MenuStart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przycisk1ToolStripMenuItem,
            this.przycisk2ToolStripMenuItem,
            this.zamówieniaToolStripMenuItem});
            this.MenuStart.Location = new System.Drawing.Point(0, 24);
            this.MenuStart.Name = "MenuStart";
            this.MenuStart.Size = new System.Drawing.Size(1108, 80);
            this.MenuStart.TabIndex = 0;
            this.MenuStart.Text = "menuStrip2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 350);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kontrahenci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 34);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1094, 254);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.SplitterWidth = 12;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "Węzeł1";
            treeNode15.Text = "Węzeł1";
            treeNode16.Name = "Węzeł0";
            treeNode16.Text = "Węzeł0";
            treeNode17.Name = "Węzeł3";
            treeNode17.Text = "Węzeł3";
            treeNode18.Name = "Węzeł4";
            treeNode18.Text = "Węzeł4";
            treeNode19.Name = "Węzeł2";
            treeNode19.Text = "Węzeł2";
            treeNode20.Name = "Węzeł6";
            treeNode20.Text = "Węzeł6";
            treeNode21.Name = "Węzeł5";
            treeNode21.Text = "Węzeł5";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode19,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(172, 254);
            this.treeView1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.kontrahenciDataGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Size = new System.Drawing.Size(910, 254);
            this.splitContainer2.SplitterDistance = 131;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // kontrahenciDataGridView
            // 
            this.kontrahenciDataGridView.AllowUserToAddRows = false;
            this.kontrahenciDataGridView.AllowUserToDeleteRows = false;
            this.kontrahenciDataGridView.AutoGenerateColumns = false;
            this.kontrahenciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kontrahenciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaKontrahentaDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.krajDataGridViewTextBoxColumn,
            this.wojewodztwoDataGridViewTextBoxColumn,
            this.powiatDataGridViewTextBoxColumn,
            this.nrKontahentaDataGridViewTextBoxColumn,
            this.kontoFKDataGridViewTextBoxColumn,
            this.rEGONDataGridViewTextBoxColumn,
            this.płatnikDataGridViewTextBoxColumn,
            this.uwagiDataGridViewTextBoxColumn,
            this.ilośćPktDataGridViewTextBoxColumn,
            this.wartośćPktDataGridViewTextBoxColumn,
            this.kontoRaksFMDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.nazwaKlasyfikacjiDataGridViewTextBoxColumn,
            this.nazwaGrupyDataGridViewTextBoxColumn,
            this.handlowiecDataGridViewTextBoxColumn,
            this.emailKontrahentaDataGridViewTextBoxColumn,
            this.nrTelefonuDataGridViewTextBoxColumn,
            this.allegroDataGridViewTextBoxColumn,
            this.vcDataGridViewTextBoxColumn,
            this.jPKKlasyfikacjaDataGridViewTextBoxColumn});
            this.kontrahenciDataGridView.DataSource = this.kontrahenciBindingSource1;
            this.kontrahenciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kontrahenciDataGridView.Location = new System.Drawing.Point(0, 0);
            this.kontrahenciDataGridView.Name = "kontrahenciDataGridView";
            this.kontrahenciDataGridView.ReadOnly = true;
            this.kontrahenciDataGridView.Size = new System.Drawing.Size(910, 131);
            this.kontrahenciDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaKontrahentaDataGridViewTextBoxColumn
            // 
            this.nazwaKontrahentaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa kontrahenta";
            this.nazwaKontrahentaDataGridViewTextBoxColumn.HeaderText = "Nazwa kontrahenta";
            this.nazwaKontrahentaDataGridViewTextBoxColumn.Name = "nazwaKontrahentaDataGridViewTextBoxColumn";
            this.nazwaKontrahentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            this.nIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            this.miastoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // krajDataGridViewTextBoxColumn
            // 
            this.krajDataGridViewTextBoxColumn.DataPropertyName = "Kraj";
            this.krajDataGridViewTextBoxColumn.HeaderText = "Kraj";
            this.krajDataGridViewTextBoxColumn.Name = "krajDataGridViewTextBoxColumn";
            this.krajDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wojewodztwoDataGridViewTextBoxColumn
            // 
            this.wojewodztwoDataGridViewTextBoxColumn.DataPropertyName = "Wojewodztwo";
            this.wojewodztwoDataGridViewTextBoxColumn.HeaderText = "Wojewodztwo";
            this.wojewodztwoDataGridViewTextBoxColumn.Name = "wojewodztwoDataGridViewTextBoxColumn";
            this.wojewodztwoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powiatDataGridViewTextBoxColumn
            // 
            this.powiatDataGridViewTextBoxColumn.DataPropertyName = "Powiat";
            this.powiatDataGridViewTextBoxColumn.HeaderText = "Powiat";
            this.powiatDataGridViewTextBoxColumn.Name = "powiatDataGridViewTextBoxColumn";
            this.powiatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrKontahentaDataGridViewTextBoxColumn
            // 
            this.nrKontahentaDataGridViewTextBoxColumn.DataPropertyName = "Nr kontahenta";
            this.nrKontahentaDataGridViewTextBoxColumn.HeaderText = "Nr kontahenta";
            this.nrKontahentaDataGridViewTextBoxColumn.Name = "nrKontahentaDataGridViewTextBoxColumn";
            this.nrKontahentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontoFKDataGridViewTextBoxColumn
            // 
            this.kontoFKDataGridViewTextBoxColumn.DataPropertyName = "Konto FK";
            this.kontoFKDataGridViewTextBoxColumn.HeaderText = "Konto FK";
            this.kontoFKDataGridViewTextBoxColumn.Name = "kontoFKDataGridViewTextBoxColumn";
            this.kontoFKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEGONDataGridViewTextBoxColumn
            // 
            this.rEGONDataGridViewTextBoxColumn.DataPropertyName = "REGON";
            this.rEGONDataGridViewTextBoxColumn.HeaderText = "REGON";
            this.rEGONDataGridViewTextBoxColumn.Name = "rEGONDataGridViewTextBoxColumn";
            this.rEGONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // płatnikDataGridViewTextBoxColumn
            // 
            this.płatnikDataGridViewTextBoxColumn.DataPropertyName = "Płatnik";
            this.płatnikDataGridViewTextBoxColumn.HeaderText = "Płatnik";
            this.płatnikDataGridViewTextBoxColumn.Name = "płatnikDataGridViewTextBoxColumn";
            this.płatnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uwagiDataGridViewTextBoxColumn
            // 
            this.uwagiDataGridViewTextBoxColumn.DataPropertyName = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.HeaderText = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.Name = "uwagiDataGridViewTextBoxColumn";
            this.uwagiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilośćPktDataGridViewTextBoxColumn
            // 
            this.ilośćPktDataGridViewTextBoxColumn.DataPropertyName = "Ilość pkt_";
            this.ilośćPktDataGridViewTextBoxColumn.HeaderText = "Ilość pkt_";
            this.ilośćPktDataGridViewTextBoxColumn.Name = "ilośćPktDataGridViewTextBoxColumn";
            this.ilośćPktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wartośćPktDataGridViewTextBoxColumn
            // 
            this.wartośćPktDataGridViewTextBoxColumn.DataPropertyName = "Wartość pkt_";
            this.wartośćPktDataGridViewTextBoxColumn.HeaderText = "Wartość pkt_";
            this.wartośćPktDataGridViewTextBoxColumn.Name = "wartośćPktDataGridViewTextBoxColumn";
            this.wartośćPktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontoRaksFMDataGridViewTextBoxColumn
            // 
            this.kontoRaksFMDataGridViewTextBoxColumn.DataPropertyName = "Konto Raks FM";
            this.kontoRaksFMDataGridViewTextBoxColumn.HeaderText = "Konto Raks FM";
            this.kontoRaksFMDataGridViewTextBoxColumn.Name = "kontoRaksFMDataGridViewTextBoxColumn";
            this.kontoRaksFMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "Pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaKlasyfikacjiDataGridViewTextBoxColumn
            // 
            this.nazwaKlasyfikacjiDataGridViewTextBoxColumn.DataPropertyName = "Nazwa klasyfikacji";
            this.nazwaKlasyfikacjiDataGridViewTextBoxColumn.HeaderText = "Nazwa klasyfikacji";
            this.nazwaKlasyfikacjiDataGridViewTextBoxColumn.Name = "nazwaKlasyfikacjiDataGridViewTextBoxColumn";
            this.nazwaKlasyfikacjiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaGrupyDataGridViewTextBoxColumn
            // 
            this.nazwaGrupyDataGridViewTextBoxColumn.DataPropertyName = "Nazwa grupy";
            this.nazwaGrupyDataGridViewTextBoxColumn.HeaderText = "Nazwa grupy";
            this.nazwaGrupyDataGridViewTextBoxColumn.Name = "nazwaGrupyDataGridViewTextBoxColumn";
            this.nazwaGrupyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // handlowiecDataGridViewTextBoxColumn
            // 
            this.handlowiecDataGridViewTextBoxColumn.DataPropertyName = "Handlowiec";
            this.handlowiecDataGridViewTextBoxColumn.HeaderText = "Handlowiec";
            this.handlowiecDataGridViewTextBoxColumn.Name = "handlowiecDataGridViewTextBoxColumn";
            this.handlowiecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailKontrahentaDataGridViewTextBoxColumn
            // 
            this.emailKontrahentaDataGridViewTextBoxColumn.DataPropertyName = "E-mail kontrahenta";
            this.emailKontrahentaDataGridViewTextBoxColumn.HeaderText = "E-mail kontrahenta";
            this.emailKontrahentaDataGridViewTextBoxColumn.Name = "emailKontrahentaDataGridViewTextBoxColumn";
            this.emailKontrahentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrTelefonuDataGridViewTextBoxColumn
            // 
            this.nrTelefonuDataGridViewTextBoxColumn.DataPropertyName = "Nr telefonu";
            this.nrTelefonuDataGridViewTextBoxColumn.HeaderText = "Nr telefonu";
            this.nrTelefonuDataGridViewTextBoxColumn.Name = "nrTelefonuDataGridViewTextBoxColumn";
            this.nrTelefonuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allegroDataGridViewTextBoxColumn
            // 
            this.allegroDataGridViewTextBoxColumn.DataPropertyName = "Allegro";
            this.allegroDataGridViewTextBoxColumn.HeaderText = "Allegro";
            this.allegroDataGridViewTextBoxColumn.Name = "allegroDataGridViewTextBoxColumn";
            this.allegroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vcDataGridViewTextBoxColumn
            // 
            this.vcDataGridViewTextBoxColumn.DataPropertyName = "Vc";
            this.vcDataGridViewTextBoxColumn.HeaderText = "Vc";
            this.vcDataGridViewTextBoxColumn.Name = "vcDataGridViewTextBoxColumn";
            this.vcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jPKKlasyfikacjaDataGridViewTextBoxColumn
            // 
            this.jPKKlasyfikacjaDataGridViewTextBoxColumn.DataPropertyName = "JPK Klasyfikacja";
            this.jPKKlasyfikacjaDataGridViewTextBoxColumn.HeaderText = "JPK Klasyfikacja";
            this.jPKKlasyfikacjaDataGridViewTextBoxColumn.Name = "jPKKlasyfikacjaDataGridViewTextBoxColumn";
            this.jPKKlasyfikacjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontrahenciBindingSource1
            // 
            this.kontrahenciBindingSource1.DataMember = "Kontrahenci";
            this.kontrahenciBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(910, 113);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(902, 87);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(902, 87);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 33);
            this.panel2.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(248, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(167, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(86, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(5, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dodaj";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 31);
            this.panel1.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(449, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "Odśwież";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artykuły";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RefKontrahenci
            // 
            this.RefKontrahenci.Enabled = true;
            this.RefKontrahenci.Interval = 5000;
            this.RefKontrahenci.Tick += new System.EventHandler(this.RefKontrahenci_Tick);
            // 
            // kontrahenciBindingSource
            // 
            this.kontrahenciBindingSource.DataMember = "Kontrahenci";
            this.kontrahenciBindingSource.DataSource = this.database1DataSet;
            // 
            // kontrahenciTableAdapter
            // 
            this.kontrahenciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KontrahenciTableAdapter = this.kontrahenciTableAdapter;
            this.tableAdapterManager.UpdateOrder = PierrotApp7.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // operacjeHandloweToolStripMenuItem
            // 
            this.operacjeHandloweToolStripMenuItem.Name = "operacjeHandloweToolStripMenuItem";
            this.operacjeHandloweToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.operacjeHandloweToolStripMenuItem.Text = "Operacje handlowe";
            // 
            // crMToolStripMenuItem
            // 
            this.crMToolStripMenuItem.Name = "crMToolStripMenuItem";
            this.crMToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.crMToolStripMenuItem.Text = "CrM";
            // 
            // raportyToolStripMenuItem
            // 
            this.raportyToolStripMenuItem.Name = "raportyToolStripMenuItem";
            this.raportyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.raportyToolStripMenuItem.Text = "Raporty";
            // 
            // kartotekiToolStripMenuItem
            // 
            this.kartotekiToolStripMenuItem.Name = "kartotekiToolStripMenuItem";
            this.kartotekiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.kartotekiToolStripMenuItem.Text = "Kartoteki";
            // 
            // inneToolStripMenuItem
            // 
            this.inneToolStripMenuItem.Name = "inneToolStripMenuItem";
            this.inneToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.inneToolStripMenuItem.Text = "Inne";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // oknaToolStripMenuItem
            // 
            this.oknaToolStripMenuItem.Name = "oknaToolStripMenuItem";
            this.oknaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.oknaToolStripMenuItem.Text = "Okna";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // zamówieniaToolStripMenuItem
            // 
            this.zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            this.zamówieniaToolStripMenuItem.Size = new System.Drawing.Size(84, 76);
            this.zamówieniaToolStripMenuItem.Text = "Zamówienia";
            // 
            // przycisk1ToolStripMenuItem
            // 
            this.przycisk1ToolStripMenuItem.AutoSize = false;
            this.przycisk1ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.przycisk1ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.przycisk1ToolStripMenuItem.Name = "przycisk1ToolStripMenuItem";
            this.przycisk1ToolStripMenuItem.Size = new System.Drawing.Size(79, 76);
            this.przycisk1ToolStripMenuItem.Text = "Pulpit informacyjny";
            this.przycisk1ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.przycisk1ToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.przycisk1ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 454);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MenuStart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MenuMagazyn);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuMagazyn.ResumeLayout(false);
            this.MenuMagazyn.PerformLayout();
            this.MenuStart.ResumeLayout(false);
            this.MenuStart.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazynToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuMagazyn;
        private System.Windows.Forms.ToolStripMenuItem dokumentyMagazynoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentySADToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStart;
        private System.Windows.Forms.ToolStripMenuItem przycisk1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przycisk2ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource kontrahenciBindingSource;
        private Database1DataSetTableAdapters.KontrahenciTableAdapter kontrahenciTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView kontrahenciDataGridView;
        private System.Windows.Forms.Timer RefKontrahenci;
        private System.Windows.Forms.BindingSource kontrahenciBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaKontrahentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wojewodztwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powiatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrKontahentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontoFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn płatnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćPktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartośćPktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontoRaksFMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaKlasyfikacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaGrupyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handlowiecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailKontrahentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allegroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jPKKlasyfikacjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem operacjeHandloweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartotekiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamówieniaToolStripMenuItem;
    }
}

