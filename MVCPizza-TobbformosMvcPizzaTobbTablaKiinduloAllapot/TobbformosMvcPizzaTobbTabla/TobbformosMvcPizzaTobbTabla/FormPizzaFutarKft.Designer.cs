namespace TobbformosMvcPizzaTobbTabla
{
    partial class FormPizzaFutarKft
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPizzaFutarKft));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.egyformosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futárToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megrendelőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egytöbbKapkcsolatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.többtöbbKapcsolatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesztadatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adatbázisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adatázbázisLétrehozásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feltöltésTesztadatokkalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törölTesztadatokatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törölAdatbázisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatus = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelHibauzenet = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelPizza = new System.Windows.Forms.ToolStripLabel();
            this.toolStripToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabControlPizzaFutarKFT = new System.Windows.Forms.TabControl();
            this.tabPagePizzak = new System.Windows.Forms.TabPage();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.panelModositTorolGombok = new System.Windows.Forms.Panel();
            this.buttonModositPizza = new System.Windows.Forms.Button();
            this.buttonTorolPizza = new System.Windows.Forms.Button();
            this.buttonUjMentes = new System.Windows.Forms.Button();
            this.panelPizza = new System.Windows.Forms.Panel();
            this.textBoxPizzaAr = new System.Windows.Forms.TextBox();
            this.labelPizzaAr = new System.Windows.Forms.Label();
            this.textBoxPizzaNev = new System.Windows.Forms.TextBox();
            this.labelPizzaNev = new System.Windows.Forms.Label();
            this.textBoxPizzaAzonosito = new System.Windows.Forms.TextBox();
            this.labelPizzaAzonosito = new System.Windows.Forms.Label();
            this.buttonUjPizza = new System.Windows.Forms.Button();
            this.buttonBetoltesPizzak = new System.Windows.Forms.Button();
            this.dataGridViewPizzak = new System.Windows.Forms.DataGridView();
            this.tabPageFutarok = new System.Windows.Forms.TabPage();
            this.tabPageMegrendelok = new System.Windows.Forms.TabPage();
            this.errorProviderPizzaName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPizzaPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStripStatus.SuspendLayout();
            this.toolStripToolbar.SuspendLayout();
            this.tabControlPizzaFutarKFT.SuspendLayout();
            this.tabPagePizzak.SuspendLayout();
            this.panelModositTorolGombok.SuspendLayout();
            this.panelPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizzak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPizzaName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPizzaPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.egyformosToolStripMenuItem,
            this.egytöbbKapkcsolatToolStripMenuItem,
            this.többtöbbKapcsolatToolStripMenuItem,
            this.tesztadatokToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // egyformosToolStripMenuItem
            // 
            this.egyformosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem,
            this.futárToolStripMenuItem,
            this.megrendelőToolStripMenuItem});
            this.egyformosToolStripMenuItem.Name = "egyformosToolStripMenuItem";
            this.egyformosToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.egyformosToolStripMenuItem.Text = "Egytáblás lekérdezések";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            this.pizzaToolStripMenuItem.Click += new System.EventHandler(this.pizzaToolStripMenuItem_Click);
            // 
            // futárToolStripMenuItem
            // 
            this.futárToolStripMenuItem.Name = "futárToolStripMenuItem";
            this.futárToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.futárToolStripMenuItem.Text = "Futár";
            this.futárToolStripMenuItem.Click += new System.EventHandler(this.futárToolStripMenuItem_Click);
            // 
            // megrendelőToolStripMenuItem
            // 
            this.megrendelőToolStripMenuItem.Name = "megrendelőToolStripMenuItem";
            this.megrendelőToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.megrendelőToolStripMenuItem.Text = "Megrendelő";
            this.megrendelőToolStripMenuItem.Click += new System.EventHandler(this.megrendelőToolStripMenuItem_Click);
            // 
            // egytöbbKapkcsolatToolStripMenuItem
            // 
            this.egytöbbKapkcsolatToolStripMenuItem.Name = "egytöbbKapkcsolatToolStripMenuItem";
            this.egytöbbKapkcsolatToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.egytöbbKapkcsolatToolStripMenuItem.Text = "Egy-több kapkcsolat";
            // 
            // többtöbbKapcsolatToolStripMenuItem
            // 
            this.többtöbbKapcsolatToolStripMenuItem.Name = "többtöbbKapcsolatToolStripMenuItem";
            this.többtöbbKapcsolatToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.többtöbbKapcsolatToolStripMenuItem.Text = "Több-több kapcsolat";
            // 
            // tesztadatokToolStripMenuItem
            // 
            this.tesztadatokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatbázisToolStripMenuItem});
            this.tesztadatokToolStripMenuItem.Name = "tesztadatokToolStripMenuItem";
            this.tesztadatokToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.tesztadatokToolStripMenuItem.Text = "Tesztadatok";
            // 
            // adatbázisToolStripMenuItem
            // 
            this.adatbázisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatázbázisLétrehozásToolStripMenuItem,
            this.feltöltésTesztadatokkalToolStripMenuItem,
            this.törölTesztadatokatToolStripMenuItem,
            this.törölAdatbázisToolStripMenuItem});
            this.adatbázisToolStripMenuItem.Name = "adatbázisToolStripMenuItem";
            this.adatbázisToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adatbázisToolStripMenuItem.Text = "Adatbázis";
            // 
            // adatázbázisLétrehozásToolStripMenuItem
            // 
            this.adatázbázisLétrehozásToolStripMenuItem.Name = "adatázbázisLétrehozásToolStripMenuItem";
            this.adatázbázisLétrehozásToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.adatázbázisLétrehozásToolStripMenuItem.Text = "Adatázbázis létrehozás";
            this.adatázbázisLétrehozásToolStripMenuItem.Click += new System.EventHandler(this.adatázbázisLétrehozásToolStripMenuItem_Click);
            // 
            // feltöltésTesztadatokkalToolStripMenuItem
            // 
            this.feltöltésTesztadatokkalToolStripMenuItem.Name = "feltöltésTesztadatokkalToolStripMenuItem";
            this.feltöltésTesztadatokkalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.feltöltésTesztadatokkalToolStripMenuItem.Text = "Feltöltés tesztadatokkal";
            this.feltöltésTesztadatokkalToolStripMenuItem.Click += new System.EventHandler(this.feltöltésTesztadatokkalToolStripMenuItem_Click);
            // 
            // törölTesztadatokatToolStripMenuItem
            // 
            this.törölTesztadatokatToolStripMenuItem.Name = "törölTesztadatokatToolStripMenuItem";
            this.törölTesztadatokatToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.törölTesztadatokatToolStripMenuItem.Text = "Töröl tesztadatokat";
            this.törölTesztadatokatToolStripMenuItem.Click += new System.EventHandler(this.törölTesztadatokatToolStripMenuItem_Click);
            // 
            // törölAdatbázisToolStripMenuItem
            // 
            this.törölAdatbázisToolStripMenuItem.Name = "törölAdatbázisToolStripMenuItem";
            this.törölAdatbázisToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.törölAdatbázisToolStripMenuItem.Text = "Töröl adatbázis";
            this.törölAdatbázisToolStripMenuItem.Click += new System.EventHandler(this.törölAdatbázisToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelHibauzenet,
            this.toolStripLabelPizza});
            this.toolStripStatus.Location = new System.Drawing.Point(0, 704);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(1008, 25);
            this.toolStripStatus.TabIndex = 1;
            this.toolStripStatus.Text = "toolStrip1";
            // 
            // toolStripLabelHibauzenet
            // 
            this.toolStripLabelHibauzenet.Name = "toolStripLabelHibauzenet";
            this.toolStripLabelHibauzenet.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabelPizza
            // 
            this.toolStripLabelPizza.Name = "toolStripLabelPizza";
            this.toolStripLabelPizza.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabelPizza.Text = "Pizzák száma:";
            // 
            // toolStripToolbar
            // 
            this.toolStripToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStripToolbar.Location = new System.Drawing.Point(0, 24);
            this.toolStripToolbar.Name = "toolStripToolbar";
            this.toolStripToolbar.Size = new System.Drawing.Size(1008, 25);
            this.toolStripToolbar.TabIndex = 2;
            this.toolStripToolbar.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // tabControlPizzaFutarKFT
            // 
            this.tabControlPizzaFutarKFT.Controls.Add(this.tabPagePizzak);
            this.tabControlPizzaFutarKFT.Controls.Add(this.tabPageFutarok);
            this.tabControlPizzaFutarKFT.Controls.Add(this.tabPageMegrendelok);
            this.tabControlPizzaFutarKFT.Location = new System.Drawing.Point(0, 52);
            this.tabControlPizzaFutarKFT.Name = "tabControlPizzaFutarKFT";
            this.tabControlPizzaFutarKFT.SelectedIndex = 0;
            this.tabControlPizzaFutarKFT.Size = new System.Drawing.Size(1008, 649);
            this.tabControlPizzaFutarKFT.TabIndex = 3;
            // 
            // tabPagePizzak
            // 
            this.tabPagePizzak.Controls.Add(this.buttonMegsem);
            this.tabPagePizzak.Controls.Add(this.panelModositTorolGombok);
            this.tabPagePizzak.Controls.Add(this.buttonUjMentes);
            this.tabPagePizzak.Controls.Add(this.panelPizza);
            this.tabPagePizzak.Controls.Add(this.buttonUjPizza);
            this.tabPagePizzak.Controls.Add(this.buttonBetoltesPizzak);
            this.tabPagePizzak.Controls.Add(this.dataGridViewPizzak);
            this.tabPagePizzak.Location = new System.Drawing.Point(4, 22);
            this.tabPagePizzak.Name = "tabPagePizzak";
            this.tabPagePizzak.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePizzak.Size = new System.Drawing.Size(1000, 623);
            this.tabPagePizzak.TabIndex = 0;
            this.tabPagePizzak.Text = "Pizzák kezelése";
            this.tabPagePizzak.UseVisualStyleBackColor = true;
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.Location = new System.Drawing.Point(892, 454);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(75, 23);
            this.buttonMegsem.TabIndex = 8;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            this.buttonMegsem.Visible = false;
            this.buttonMegsem.Click += new System.EventHandler(this.buttonMegsem_Click);
            // 
            // panelModositTorolGombok
            // 
            this.panelModositTorolGombok.Controls.Add(this.buttonModositPizza);
            this.panelModositTorolGombok.Controls.Add(this.buttonTorolPizza);
            this.panelModositTorolGombok.Location = new System.Drawing.Point(696, 168);
            this.panelModositTorolGombok.Name = "panelModositTorolGombok";
            this.panelModositTorolGombok.Size = new System.Drawing.Size(271, 62);
            this.panelModositTorolGombok.TabIndex = 7;
            this.panelModositTorolGombok.Visible = false;
            // 
            // buttonModositPizza
            // 
            this.buttonModositPizza.Location = new System.Drawing.Point(16, 19);
            this.buttonModositPizza.Name = "buttonModositPizza";
            this.buttonModositPizza.Size = new System.Drawing.Size(75, 23);
            this.buttonModositPizza.TabIndex = 3;
            this.buttonModositPizza.Text = "Módosít";
            this.buttonModositPizza.UseVisualStyleBackColor = true;
            this.buttonModositPizza.Click += new System.EventHandler(this.buttonModositPizza_Click);
            // 
            // buttonTorolPizza
            // 
            this.buttonTorolPizza.Location = new System.Drawing.Point(152, 19);
            this.buttonTorolPizza.Name = "buttonTorolPizza";
            this.buttonTorolPizza.Size = new System.Drawing.Size(75, 23);
            this.buttonTorolPizza.TabIndex = 4;
            this.buttonTorolPizza.Text = "Töröl";
            this.buttonTorolPizza.UseVisualStyleBackColor = true;
            this.buttonTorolPizza.Click += new System.EventHandler(this.buttonTorolPizza_Click);
            // 
            // buttonUjMentes
            // 
            this.buttonUjMentes.Location = new System.Drawing.Point(892, 425);
            this.buttonUjMentes.Name = "buttonUjMentes";
            this.buttonUjMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonUjMentes.TabIndex = 6;
            this.buttonUjMentes.Text = "Új mentése";
            this.buttonUjMentes.UseVisualStyleBackColor = true;
            this.buttonUjMentes.Visible = false;
            this.buttonUjMentes.Click += new System.EventHandler(this.buttonUjMentes_Click);
            // 
            // panelPizza
            // 
            this.panelPizza.Controls.Add(this.textBoxPizzaAr);
            this.panelPizza.Controls.Add(this.labelPizzaAr);
            this.panelPizza.Controls.Add(this.textBoxPizzaNev);
            this.panelPizza.Controls.Add(this.labelPizzaNev);
            this.panelPizza.Controls.Add(this.textBoxPizzaAzonosito);
            this.panelPizza.Controls.Add(this.labelPizzaAzonosito);
            this.panelPizza.Location = new System.Drawing.Point(696, 246);
            this.panelPizza.Name = "panelPizza";
            this.panelPizza.Size = new System.Drawing.Size(271, 160);
            this.panelPizza.TabIndex = 5;
            this.panelPizza.Visible = false;
            // 
            // textBoxPizzaAr
            // 
            this.textBoxPizzaAr.Location = new System.Drawing.Point(113, 103);
            this.textBoxPizzaAr.Name = "textBoxPizzaAr";
            this.textBoxPizzaAr.Size = new System.Drawing.Size(136, 20);
            this.textBoxPizzaAr.TabIndex = 5;
            this.textBoxPizzaAr.TextChanged += new System.EventHandler(this.textBoxPizzaAr_TextChanged);
            // 
            // labelPizzaAr
            // 
            this.labelPizzaAr.AutoSize = true;
            this.labelPizzaAr.Location = new System.Drawing.Point(13, 103);
            this.labelPizzaAr.Name = "labelPizzaAr";
            this.labelPizzaAr.Size = new System.Drawing.Size(44, 13);
            this.labelPizzaAr.TabIndex = 4;
            this.labelPizzaAr.Text = "Pizza ár";
            // 
            // textBoxPizzaNev
            // 
            this.textBoxPizzaNev.Location = new System.Drawing.Point(113, 65);
            this.textBoxPizzaNev.Name = "textBoxPizzaNev";
            this.textBoxPizzaNev.Size = new System.Drawing.Size(136, 20);
            this.textBoxPizzaNev.TabIndex = 3;
            this.textBoxPizzaNev.TextChanged += new System.EventHandler(this.textBoxPizzaNev_TextChanged);
            // 
            // labelPizzaNev
            // 
            this.labelPizzaNev.AutoSize = true;
            this.labelPizzaNev.Location = new System.Drawing.Point(13, 65);
            this.labelPizzaNev.Name = "labelPizzaNev";
            this.labelPizzaNev.Size = new System.Drawing.Size(53, 13);
            this.labelPizzaNev.TabIndex = 2;
            this.labelPizzaNev.Text = "Pizza név";
            // 
            // textBoxPizzaAzonosito
            // 
            this.textBoxPizzaAzonosito.Location = new System.Drawing.Point(113, 19);
            this.textBoxPizzaAzonosito.Name = "textBoxPizzaAzonosito";
            this.textBoxPizzaAzonosito.ReadOnly = true;
            this.textBoxPizzaAzonosito.Size = new System.Drawing.Size(136, 20);
            this.textBoxPizzaAzonosito.TabIndex = 1;
            // 
            // labelPizzaAzonosito
            // 
            this.labelPizzaAzonosito.AutoSize = true;
            this.labelPizzaAzonosito.Location = new System.Drawing.Point(13, 19);
            this.labelPizzaAzonosito.Name = "labelPizzaAzonosito";
            this.labelPizzaAzonosito.Size = new System.Drawing.Size(82, 13);
            this.labelPizzaAzonosito.TabIndex = 0;
            this.labelPizzaAzonosito.Text = "Pizza azonosító";
            // 
            // buttonUjPizza
            // 
            this.buttonUjPizza.Location = new System.Drawing.Point(696, 425);
            this.buttonUjPizza.Name = "buttonUjPizza";
            this.buttonUjPizza.Size = new System.Drawing.Size(75, 23);
            this.buttonUjPizza.TabIndex = 2;
            this.buttonUjPizza.Text = "Új";
            this.buttonUjPizza.UseVisualStyleBackColor = true;
            this.buttonUjPizza.Visible = false;
            this.buttonUjPizza.Click += new System.EventHandler(this.buttonUjPizza_Click);
            // 
            // buttonBetoltesPizzak
            // 
            this.buttonBetoltesPizzak.Location = new System.Drawing.Point(783, 25);
            this.buttonBetoltesPizzak.Name = "buttonBetoltesPizzak";
            this.buttonBetoltesPizzak.Size = new System.Drawing.Size(75, 23);
            this.buttonBetoltesPizzak.TabIndex = 1;
            this.buttonBetoltesPizzak.Text = "Betöltés";
            this.buttonBetoltesPizzak.UseVisualStyleBackColor = true;
            this.buttonBetoltesPizzak.Click += new System.EventHandler(this.buttonBetoltesPizzak_Click);
            // 
            // dataGridViewPizzak
            // 
            this.dataGridViewPizzak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPizzak.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPizzak.Name = "dataGridViewPizzak";
            this.dataGridViewPizzak.Size = new System.Drawing.Size(652, 623);
            this.dataGridViewPizzak.TabIndex = 0;
            // 
            // tabPageFutarok
            // 
            this.tabPageFutarok.Location = new System.Drawing.Point(4, 22);
            this.tabPageFutarok.Name = "tabPageFutarok";
            this.tabPageFutarok.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFutarok.Size = new System.Drawing.Size(1000, 623);
            this.tabPageFutarok.TabIndex = 1;
            this.tabPageFutarok.Text = "Futárok kezelése";
            this.tabPageFutarok.UseVisualStyleBackColor = true;
            // 
            // tabPageMegrendelok
            // 
            this.tabPageMegrendelok.Location = new System.Drawing.Point(4, 22);
            this.tabPageMegrendelok.Name = "tabPageMegrendelok";
            this.tabPageMegrendelok.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMegrendelok.Size = new System.Drawing.Size(1000, 623);
            this.tabPageMegrendelok.TabIndex = 2;
            this.tabPageMegrendelok.Text = "Megrendelők kezelése";
            this.tabPageMegrendelok.UseVisualStyleBackColor = true;
            // 
            // errorProviderPizzaName
            // 
            this.errorProviderPizzaName.ContainerControl = this;
            // 
            // errorProviderPizzaPrice
            // 
            this.errorProviderPizzaPrice.ContainerControl = this;
            // 
            // FormPizzaFutarKft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControlPizzaFutarKFT);
            this.Controls.Add(this.toolStripToolbar);
            this.Controls.Add(this.toolStripStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPizzaFutarKft";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripStatus.ResumeLayout(false);
            this.toolStripStatus.PerformLayout();
            this.toolStripToolbar.ResumeLayout(false);
            this.toolStripToolbar.PerformLayout();
            this.tabControlPizzaFutarKFT.ResumeLayout(false);
            this.tabPagePizzak.ResumeLayout(false);
            this.panelModositTorolGombok.ResumeLayout(false);
            this.panelPizza.ResumeLayout(false);
            this.panelPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizzak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPizzaName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPizzaPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem egyformosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futárToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megrendelőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egytöbbKapkcsolatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem többtöbbKapcsolatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesztadatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPizza;
        private System.Windows.Forms.ToolStrip toolStripToolbar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TabControl tabControlPizzaFutarKFT;
        private System.Windows.Forms.TabPage tabPagePizzak;
        private System.Windows.Forms.TabPage tabPageFutarok;
        private System.Windows.Forms.TabPage tabPageMegrendelok;
        private System.Windows.Forms.Button buttonTorolPizza;
        private System.Windows.Forms.Button buttonModositPizza;
        private System.Windows.Forms.Button buttonUjPizza;
        private System.Windows.Forms.Button buttonBetoltesPizzak;
        private System.Windows.Forms.DataGridView dataGridViewPizzak;
        private System.Windows.Forms.ToolStripMenuItem adatbázisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adatázbázisLétrehozásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feltöltésTesztadatokkalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törölTesztadatokatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törölAdatbázisToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabelHibauzenet;
        private System.Windows.Forms.Panel panelPizza;
        private System.Windows.Forms.TextBox textBoxPizzaAr;
        private System.Windows.Forms.Label labelPizzaAr;
        private System.Windows.Forms.TextBox textBoxPizzaNev;
        private System.Windows.Forms.Label labelPizzaNev;
        private System.Windows.Forms.TextBox textBoxPizzaAzonosito;
        private System.Windows.Forms.Label labelPizzaAzonosito;
        private System.Windows.Forms.ErrorProvider errorProviderPizzaName;
        private System.Windows.Forms.ErrorProvider errorProviderPizzaPrice;
        private System.Windows.Forms.Panel panelModositTorolGombok;
        private System.Windows.Forms.Button buttonUjMentes;
        private System.Windows.Forms.Button buttonMegsem;
    }
}

