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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Węzeł1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Węzeł0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Węzeł3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Węzeł4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Węzeł2", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Węzeł6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Węzeł5", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Węzeł0");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Węzeł3");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Węzeł4");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Węzeł2", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazynToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeHandloweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartotekiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMagazyn = new System.Windows.Forms.MenuStrip();
            this.dokumentyMagazynoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentySADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStart = new System.Windows.Forms.MenuStrip();
            this.przycisk1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przycisk2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamówieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zleceniaProdukcyjneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprzedażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentyHandloweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozrachunkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentyFinansoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrahenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artykułyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ePocztaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zleceniaSerwisoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uprawnieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaUżyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaFirmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zestawieniaIAnalizyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponowneLogowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńDatęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Kontrahenci = new System.Windows.Forms.TabPage();
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
            this.Artykuly = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.artykulyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artykulyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1Artykuly = new PierrotApp7.Database1Artykuly();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RefKontrahenci = new System.Windows.Forms.Timer(this.components);
            this.kontrahenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontrahenciTableAdapter = new PierrotApp7.Database1DataSetTableAdapters.KontrahenciTableAdapter();
            this.tableAdapterManager = new PierrotApp7.Database1DataSetTableAdapters.TableAdapterManager();
            this.artykulyTableAdapter = new PierrotApp7.Database1ArtykulyTableAdapters.ArtykulyTableAdapter();
            this.tableAdapterManager1 = new PierrotApp7.Database1ArtykulyTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            this.MenuMagazyn.SuspendLayout();
            this.MenuStart.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Kontrahenci.SuspendLayout();
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
            this.Artykuly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artykulyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artykulyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1Artykuly)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1722, 24);
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
            // MenuMagazyn
            // 
            this.MenuMagazyn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentyMagazynoweToolStripMenuItem,
            this.dokumentySADToolStripMenuItem});
            this.MenuMagazyn.Location = new System.Drawing.Point(0, 0);
            this.MenuMagazyn.Name = "MenuMagazyn";
            this.MenuMagazyn.Size = new System.Drawing.Size(1592, 24);
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
            this.zamówieniaToolStripMenuItem,
            this.zleceniaProdukcyjneToolStripMenuItem,
            this.sprzedażToolStripMenuItem,
            this.dokumentyHandloweToolStripMenuItem,
            this.rozrachunkiToolStripMenuItem,
            this.dokumentyFinansoweToolStripMenuItem,
            this.kontrahenciToolStripMenuItem,
            this.artykułyToolStripMenuItem,
            this.crMToolStripMenuItem1,
            this.ePocztaToolStripMenuItem,
            this.ofertyToolStripMenuItem,
            this.zleceniaSerwisoweToolStripMenuItem,
            this.uprawnieniaToolStripMenuItem,
            this.konfiguracjaUżyToolStripMenuItem,
            this.konfiguracjaFirmyToolStripMenuItem,
            this.zestawieniaIAnalizyToolStripMenuItem,
            this.ponowneLogowanieToolStripMenuItem,
            this.zmieńDatęToolStripMenuItem});
            this.MenuStart.Location = new System.Drawing.Point(0, 24);
            this.MenuStart.Name = "MenuStart";
            this.MenuStart.Size = new System.Drawing.Size(1722, 80);
            this.MenuStart.TabIndex = 0;
            this.MenuStart.Text = "menuStrip2";
            // 
            // przycisk1ToolStripMenuItem
            // 
            this.przycisk1ToolStripMenuItem.AutoSize = false;
            this.przycisk1ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.przycisk1ToolStripMenuItem.Enabled = false;
            this.przycisk1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("przycisk1ToolStripMenuItem.Image")));
            this.przycisk1ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.przycisk1ToolStripMenuItem.Name = "przycisk1ToolStripMenuItem";
            this.przycisk1ToolStripMenuItem.Size = new System.Drawing.Size(122, 76);
            this.przycisk1ToolStripMenuItem.Text = "Pulpit informacyjny";
            this.przycisk1ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.przycisk1ToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.przycisk1ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // przycisk2ToolStripMenuItem
            // 
            this.przycisk2ToolStripMenuItem.Enabled = false;
            this.przycisk2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("przycisk2ToolStripMenuItem.Image")));
            this.przycisk2ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.przycisk2ToolStripMenuItem.Name = "przycisk2ToolStripMenuItem";
            this.przycisk2ToolStripMenuItem.Size = new System.Drawing.Size(79, 76);
            // 
            // zamówieniaToolStripMenuItem
            // 
            this.zamówieniaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zamówieniaToolStripMenuItem.Enabled = false;
            this.zamówieniaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zamówieniaToolStripMenuItem.Image")));
            this.zamówieniaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            this.zamówieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 76);
            this.zamówieniaToolStripMenuItem.Text = "Zamówienia";
            // 
            // zleceniaProdukcyjneToolStripMenuItem
            // 
            this.zleceniaProdukcyjneToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zleceniaProdukcyjneToolStripMenuItem.Enabled = false;
            this.zleceniaProdukcyjneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zleceniaProdukcyjneToolStripMenuItem.Image")));
            this.zleceniaProdukcyjneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zleceniaProdukcyjneToolStripMenuItem.Name = "zleceniaProdukcyjneToolStripMenuItem";
            this.zleceniaProdukcyjneToolStripMenuItem.Size = new System.Drawing.Size(79, 76);
            this.zleceniaProdukcyjneToolStripMenuItem.Text = "Zlecenia produkcyjne";
            // 
            // sprzedażToolStripMenuItem
            // 
            this.sprzedażToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sprzedażToolStripMenuItem.Enabled = false;
            this.sprzedażToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sprzedażToolStripMenuItem.Image")));
            this.sprzedażToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sprzedażToolStripMenuItem.Name = "sprzedażToolStripMenuItem";
            this.sprzedażToolStripMenuItem.Size = new System.Drawing.Size(65, 76);
            this.sprzedażToolStripMenuItem.Text = "Sprzedaż detaliczna";
            // 
            // dokumentyHandloweToolStripMenuItem
            // 
            this.dokumentyHandloweToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dokumentyHandloweToolStripMenuItem.Enabled = false;
            this.dokumentyHandloweToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dokumentyHandloweToolStripMenuItem.Image")));
            this.dokumentyHandloweToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dokumentyHandloweToolStripMenuItem.Name = "dokumentyHandloweToolStripMenuItem";
            this.dokumentyHandloweToolStripMenuItem.Size = new System.Drawing.Size(69, 76);
            this.dokumentyHandloweToolStripMenuItem.Text = "Dokumenty handlowe";
            // 
            // rozrachunkiToolStripMenuItem
            // 
            this.rozrachunkiToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rozrachunkiToolStripMenuItem.Enabled = false;
            this.rozrachunkiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rozrachunkiToolStripMenuItem.Image")));
            this.rozrachunkiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rozrachunkiToolStripMenuItem.Name = "rozrachunkiToolStripMenuItem";
            this.rozrachunkiToolStripMenuItem.Size = new System.Drawing.Size(79, 76);
            this.rozrachunkiToolStripMenuItem.Text = "Rozrachunki";
            // 
            // dokumentyFinansoweToolStripMenuItem
            // 
            this.dokumentyFinansoweToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dokumentyFinansoweToolStripMenuItem.Enabled = false;
            this.dokumentyFinansoweToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dokumentyFinansoweToolStripMenuItem.Image")));
            this.dokumentyFinansoweToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dokumentyFinansoweToolStripMenuItem.Name = "dokumentyFinansoweToolStripMenuItem";
            this.dokumentyFinansoweToolStripMenuItem.Size = new System.Drawing.Size(69, 76);
            this.dokumentyFinansoweToolStripMenuItem.Text = "Dokumenty finansowe";
            // 
            // kontrahenciToolStripMenuItem
            // 
            this.kontrahenciToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kontrahenciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kontrahenciToolStripMenuItem.Image")));
            this.kontrahenciToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kontrahenciToolStripMenuItem.Name = "kontrahenciToolStripMenuItem";
            this.kontrahenciToolStripMenuItem.Size = new System.Drawing.Size(79, 76);
            this.kontrahenciToolStripMenuItem.Text = "Kontrahenci";
            this.kontrahenciToolStripMenuItem.Click += new System.EventHandler(this.kontrahenciToolStripMenuItem_Click);
            // 
            // artykułyToolStripMenuItem
            // 
            this.artykułyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.artykułyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("artykułyToolStripMenuItem.Image")));
            this.artykułyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.artykułyToolStripMenuItem.Name = "artykułyToolStripMenuItem";
            this.artykułyToolStripMenuItem.Size = new System.Drawing.Size(59, 76);
            this.artykułyToolStripMenuItem.Text = "Artykuły";
            this.artykułyToolStripMenuItem.Click += new System.EventHandler(this.artykułyToolStripMenuItem_Click);
            // 
            // crMToolStripMenuItem1
            // 
            this.crMToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.crMToolStripMenuItem1.Enabled = false;
            this.crMToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("crMToolStripMenuItem1.Image")));
            this.crMToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.crMToolStripMenuItem1.Name = "crMToolStripMenuItem1";
            this.crMToolStripMenuItem1.Size = new System.Drawing.Size(59, 76);
            this.crMToolStripMenuItem1.Text = "CrM";
            // 
            // ePocztaToolStripMenuItem
            // 
            this.ePocztaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ePocztaToolStripMenuItem.Enabled = false;
            this.ePocztaToolStripMenuItem.Image = global::PierrotApp7.Properties.Resources.ePoczta1;
            this.ePocztaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ePocztaToolStripMenuItem.Name = "ePocztaToolStripMenuItem";
            this.ePocztaToolStripMenuItem.Size = new System.Drawing.Size(59, 76);
            this.ePocztaToolStripMenuItem.Text = "e-Poczta";
            // 
            // ofertyToolStripMenuItem
            // 
            this.ofertyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ofertyToolStripMenuItem.Enabled = false;
            this.ofertyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ofertyToolStripMenuItem.Image")));
            this.ofertyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ofertyToolStripMenuItem.Name = "ofertyToolStripMenuItem";
            this.ofertyToolStripMenuItem.Size = new System.Drawing.Size(49, 76);
            this.ofertyToolStripMenuItem.Text = "Oferty";
            // 
            // zleceniaSerwisoweToolStripMenuItem
            // 
            this.zleceniaSerwisoweToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zleceniaSerwisoweToolStripMenuItem.Enabled = false;
            this.zleceniaSerwisoweToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zleceniaSerwisoweToolStripMenuItem.Image")));
            this.zleceniaSerwisoweToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zleceniaSerwisoweToolStripMenuItem.Name = "zleceniaSerwisoweToolStripMenuItem";
            this.zleceniaSerwisoweToolStripMenuItem.Size = new System.Drawing.Size(79, 76);
            this.zleceniaSerwisoweToolStripMenuItem.Text = "Zlecenia serwisowe";
            // 
            // uprawnieniaToolStripMenuItem
            // 
            this.uprawnieniaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uprawnieniaToolStripMenuItem.Enabled = false;
            this.uprawnieniaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uprawnieniaToolStripMenuItem.Image")));
            this.uprawnieniaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uprawnieniaToolStripMenuItem.Name = "uprawnieniaToolStripMenuItem";
            this.uprawnieniaToolStripMenuItem.Size = new System.Drawing.Size(79, 76);
            this.uprawnieniaToolStripMenuItem.Text = "Uprawnienia";
            // 
            // konfiguracjaUżyToolStripMenuItem
            // 
            this.konfiguracjaUżyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.konfiguracjaUżyToolStripMenuItem.Enabled = false;
            this.konfiguracjaUżyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("konfiguracjaUżyToolStripMenuItem.Image")));
            this.konfiguracjaUżyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.konfiguracjaUżyToolStripMenuItem.Name = "konfiguracjaUżyToolStripMenuItem";
            this.konfiguracjaUżyToolStripMenuItem.Size = new System.Drawing.Size(79, 76);
            this.konfiguracjaUżyToolStripMenuItem.Text = "Konfiguracja użytkownika";
            // 
            // konfiguracjaFirmyToolStripMenuItem
            // 
            this.konfiguracjaFirmyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.konfiguracjaFirmyToolStripMenuItem.Enabled = false;
            this.konfiguracjaFirmyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("konfiguracjaFirmyToolStripMenuItem.Image")));
            this.konfiguracjaFirmyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.konfiguracjaFirmyToolStripMenuItem.Name = "konfiguracjaFirmyToolStripMenuItem";
            this.konfiguracjaFirmyToolStripMenuItem.Size = new System.Drawing.Size(76, 76);
            this.konfiguracjaFirmyToolStripMenuItem.Text = "Konfiguracja firmy";
            // 
            // zestawieniaIAnalizyToolStripMenuItem
            // 
            this.zestawieniaIAnalizyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zestawieniaIAnalizyToolStripMenuItem.Enabled = false;
            this.zestawieniaIAnalizyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zestawieniaIAnalizyToolStripMenuItem.Image")));
            this.zestawieniaIAnalizyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zestawieniaIAnalizyToolStripMenuItem.Name = "zestawieniaIAnalizyToolStripMenuItem";
            this.zestawieniaIAnalizyToolStripMenuItem.Size = new System.Drawing.Size(79, 76);
            this.zestawieniaIAnalizyToolStripMenuItem.Text = "Zestawienia i analizy";
            // 
            // ponowneLogowanieToolStripMenuItem
            // 
            this.ponowneLogowanieToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ponowneLogowanieToolStripMenuItem.Enabled = false;
            this.ponowneLogowanieToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ponowneLogowanieToolStripMenuItem.Image")));
            this.ponowneLogowanieToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ponowneLogowanieToolStripMenuItem.Name = "ponowneLogowanieToolStripMenuItem";
            this.ponowneLogowanieToolStripMenuItem.Size = new System.Drawing.Size(69, 76);
            this.ponowneLogowanieToolStripMenuItem.Text = "Ponowne logowanie";
            // 
            // zmieńDatęToolStripMenuItem
            // 
            this.zmieńDatęToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zmieńDatęToolStripMenuItem.Enabled = false;
            this.zmieńDatęToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zmieńDatęToolStripMenuItem.Image")));
            this.zmieńDatęToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zmieńDatęToolStripMenuItem.Name = "zmieńDatęToolStripMenuItem";
            this.zmieńDatęToolStripMenuItem.Size = new System.Drawing.Size(49, 76);
            this.zmieńDatęToolStripMenuItem.Text = "Zmień datę";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Kontrahenci);
            this.tabControl1.Controls.Add(this.Artykuly);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1722, 662);
            this.tabControl1.TabIndex = 2;
            // 
            // Kontrahenci
            // 
            this.Kontrahenci.Controls.Add(this.splitContainer1);
            this.Kontrahenci.Controls.Add(this.panel2);
            this.Kontrahenci.Controls.Add(this.panel1);
            this.Kontrahenci.Location = new System.Drawing.Point(4, 22);
            this.Kontrahenci.Name = "Kontrahenci";
            this.Kontrahenci.Padding = new System.Windows.Forms.Padding(3);
            this.Kontrahenci.Size = new System.Drawing.Size(1714, 636);
            this.Kontrahenci.TabIndex = 0;
            this.Kontrahenci.Text = "Kontrahenci";
            this.Kontrahenci.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Size = new System.Drawing.Size(1708, 566);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.SplitterWidth = 12;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Węzeł1";
            treeNode1.Text = "Węzeł1";
            treeNode2.Name = "Węzeł0";
            treeNode2.Text = "Węzeł0";
            treeNode3.Name = "Węzeł3";
            treeNode3.Text = "Węzeł3";
            treeNode4.Name = "Węzeł4";
            treeNode4.Text = "Węzeł4";
            treeNode5.Name = "Węzeł2";
            treeNode5.Text = "Węzeł2";
            treeNode6.Name = "Węzeł6";
            treeNode6.Text = "Węzeł6";
            treeNode7.Name = "Węzeł5";
            treeNode7.Text = "Węzeł5";
            treeNode8.Name = "Węzeł0";
            treeNode8.Text = "Węzeł0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(268, 566);
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
            this.splitContainer2.Size = new System.Drawing.Size(1428, 566);
            this.splitContainer2.SplitterDistance = 290;
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
            this.kontrahenciDataGridView.Size = new System.Drawing.Size(1428, 290);
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
            this.tabControl2.Size = new System.Drawing.Size(1428, 266);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1420, 240);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1420, 240);
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
            this.panel2.Location = new System.Drawing.Point(3, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1708, 33);
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
            this.button7.Text = "Popraw";
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
            this.panel1.Size = new System.Drawing.Size(1708, 31);
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
            // Artykuly
            // 
            this.Artykuly.Controls.Add(this.splitContainer3);
            this.Artykuly.Controls.Add(this.panel4);
            this.Artykuly.Controls.Add(this.panel3);
            this.Artykuly.Location = new System.Drawing.Point(4, 22);
            this.Artykuly.Name = "Artykuly";
            this.Artykuly.Padding = new System.Windows.Forms.Padding(3);
            this.Artykuly.Size = new System.Drawing.Size(1714, 636);
            this.Artykuly.TabIndex = 1;
            this.Artykuly.Text = "Artykuły";
            this.Artykuly.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 34);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.treeView2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1708, 566);
            this.splitContainer3.SplitterDistance = 268;
            this.splitContainer3.SplitterWidth = 12;
            this.splitContainer3.TabIndex = 3;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode9.Name = "Węzeł3";
            treeNode9.Text = "Węzeł3";
            treeNode10.Name = "Węzeł4";
            treeNode10.Text = "Węzeł4";
            treeNode11.Name = "Węzeł2";
            treeNode11.Text = "Węzeł2";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView2.Size = new System.Drawing.Size(268, 566);
            this.treeView2.TabIndex = 0;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.AutoScroll = true;
            this.splitContainer4.Panel1.Controls.Add(this.artykulyDataGridView);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl3);
            this.splitContainer4.Size = new System.Drawing.Size(1428, 566);
            this.splitContainer4.SplitterDistance = 290;
            this.splitContainer4.SplitterWidth = 10;
            this.splitContainer4.TabIndex = 0;
            // 
            // artykulyDataGridView
            // 
            this.artykulyDataGridView.AllowUserToAddRows = false;
            this.artykulyDataGridView.AllowUserToDeleteRows = false;
            this.artykulyDataGridView.AutoGenerateColumns = false;
            this.artykulyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artykulyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42});
            this.artykulyDataGridView.DataSource = this.artykulyBindingSource;
            this.artykulyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artykulyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.artykulyDataGridView.Name = "artykulyDataGridView";
            this.artykulyDataGridView.ReadOnly = true;
            this.artykulyDataGridView.Size = new System.Drawing.Size(1428, 290);
            this.artykulyDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nazwa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "R";
            this.dataGridViewTextBoxColumn3.HeaderText = "R";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IloscDostępna";
            this.dataGridViewTextBoxColumn4.HeaderText = "IloscDostępna";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Stan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Stan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Zarezerwowano";
            this.dataGridViewTextBoxColumn6.HeaderText = "Zarezerwowano";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StanMin";
            this.dataGridViewTextBoxColumn7.HeaderText = "StanMin";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "jm";
            this.dataGridViewTextBoxColumn8.HeaderText = "jm";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CenaZakupuNetto";
            this.dataGridViewTextBoxColumn9.HeaderText = "CenaZakupuNetto";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CenaSprzedazyNetto";
            this.dataGridViewTextBoxColumn10.HeaderText = "CenaSprzedazyNetto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "IndeksKatalogowy";
            this.dataGridViewTextBoxColumn11.HeaderText = "IndeksKatalogowy";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "IndeksHandlowy";
            this.dataGridViewTextBoxColumn12.HeaderText = "IndeksHandlowy";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "KodKreskowy";
            this.dataGridViewTextBoxColumn13.HeaderText = "KodKreskowy";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PLU";
            this.dataGridViewTextBoxColumn14.HeaderText = "PLU";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CenaZakupuBrutto";
            this.dataGridViewTextBoxColumn15.HeaderText = "CenaZakupuBrutto";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "NazwaCd";
            this.dataGridViewTextBoxColumn16.HeaderText = "NazwaCd";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "NazwaOrginalna";
            this.dataGridViewTextBoxColumn17.HeaderText = "NazwaOrginalna";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "CenaSprzedazyBrutto";
            this.dataGridViewTextBoxColumn18.HeaderText = "CenaSprzedazyBrutto";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "StanMax";
            this.dataGridViewTextBoxColumn19.HeaderText = "StanMax";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Waga";
            this.dataGridViewTextBoxColumn20.HeaderText = "Waga";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Wysokosc";
            this.dataGridViewTextBoxColumn21.HeaderText = "Wysokosc";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Szerokosc";
            this.dataGridViewTextBoxColumn22.HeaderText = "Szerokosc";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Glebokosc";
            this.dataGridViewTextBoxColumn23.HeaderText = "Glebokosc";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Lokaliza";
            this.dataGridViewTextBoxColumn24.HeaderText = "Lokaliza";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "DostawcyDostarcza";
            this.dataGridViewTextBoxColumn25.HeaderText = "DostawcyDostarcza";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "OdbiorcyOdbiora";
            this.dataGridViewTextBoxColumn26.HeaderText = "OdbiorcyOdbiora";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Waluta";
            this.dataGridViewTextBoxColumn27.HeaderText = "Waluta";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "CenaZakupuBruttoWal";
            this.dataGridViewTextBoxColumn28.HeaderText = "CenaZakupuBruttoWal";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "WaluBrutto";
            this.dataGridViewTextBoxColumn29.HeaderText = "WaluBrutto";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Zamiennik";
            this.dataGridViewTextBoxColumn30.HeaderText = "Zamiennik";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "VatZakupu";
            this.dataGridViewTextBoxColumn31.HeaderText = "VatZakupu";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "VatSprzedazy";
            this.dataGridViewTextBoxColumn32.HeaderText = "VatSprzedazy";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "PKWiU";
            this.dataGridViewTextBoxColumn33.HeaderText = "PKWiU";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Marza";
            this.dataGridViewTextBoxColumn34.HeaderText = "Marza";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Producent";
            this.dataGridViewTextBoxColumn35.HeaderText = "Producent";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "NrArtykulu";
            this.dataGridViewTextBoxColumn36.HeaderText = "NrArtykulu";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Zał";
            this.dataGridViewTextBoxColumn37.HeaderText = "Zał";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Wyroznik";
            this.dataGridViewTextBoxColumn38.HeaderText = "Wyroznik";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "IndeksProducenta";
            this.dataGridViewTextBoxColumn39.HeaderText = "IndeksProducenta";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "KodCN";
            this.dataGridViewTextBoxColumn40.HeaderText = "KodCN";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Kraj";
            this.dataGridViewTextBoxColumn41.HeaderText = "Kraj";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "JPKKlasyfikacja";
            this.dataGridViewTextBoxColumn42.HeaderText = "JPKKlasyfikacja";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // artykulyBindingSource
            // 
            this.artykulyBindingSource.DataMember = "Artykuly";
            this.artykulyBindingSource.DataSource = this.database1Artykuly;
            // 
            // database1Artykuly
            // 
            this.database1Artykuly.DataSetName = "Database1Artykuly";
            this.database1Artykuly.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage14);
            this.tabControl3.Controls.Add(this.tabPage15);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1428, 266);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(1420, 240);
            this.tabPage14.TabIndex = 0;
            this.tabPage14.Text = "tabPage14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(1420, 240);
            this.tabPage15.TabIndex = 1;
            this.tabPage15.Text = "tabPage15";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button17);
            this.panel4.Controls.Add(this.button18);
            this.panel4.Controls.Add(this.button19);
            this.panel4.Controls.Add(this.button20);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 600);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1708, 33);
            this.panel4.TabIndex = 2;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(248, 5);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 8;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(167, 5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 7;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(86, 5);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 6;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(5, 5);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 5;
            this.button20.Text = "Dodaj";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1708, 31);
            this.panel3.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(449, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 9;
            this.button11.Text = "Odśwież";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(329, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 4;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(248, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 3;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(167, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 2;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(86, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 1;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(5, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 0;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1714, 636);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Pulpit Informacyjny";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1714, 636);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1714, 636);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1714, 636);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1714, 636);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1714, 636);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1714, 636);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1714, 636);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1714, 636);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(1714, 636);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(1714, 636);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(1714, 636);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "tabPage13";
            this.tabPage13.UseVisualStyleBackColor = true;
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
            // artykulyTableAdapter
            // 
            this.artykulyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ArtykulyTableAdapter = this.artykulyTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = PierrotApp7.Database1ArtykulyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 766);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MenuStart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MenuMagazyn);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuMagazyn.ResumeLayout(false);
            this.MenuMagazyn.PerformLayout();
            this.MenuStart.ResumeLayout(false);
            this.MenuStart.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Kontrahenci.ResumeLayout(false);
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
            this.Artykuly.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artykulyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artykulyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1Artykuly)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Kontrahenci;
        private System.Windows.Forms.TabPage Artykuly;
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
        private System.Windows.Forms.ToolStripMenuItem zleceniaProdukcyjneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprzedażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentyHandloweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozrachunkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentyFinansoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrahenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artykułyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ePocztaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zleceniaSerwisoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uprawnieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaUżyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaFirmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zestawieniaIAnalizyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponowneLogowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńDatęToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private Database1Artykuly database1Artykuly;
        private System.Windows.Forms.BindingSource artykulyBindingSource;
        private Database1ArtykulyTableAdapters.ArtykulyTableAdapter artykulyTableAdapter;
        private Database1ArtykulyTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView artykulyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
    }
}

