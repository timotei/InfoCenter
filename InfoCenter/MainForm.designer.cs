using InfoCenter.Controls;

namespace InfoCenter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("(General)", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("(General)", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("lstGrupRaspunsuri", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("lstGrupTotal", System.Windows.Forms.HorizontalAlignment.Left);
            InfoCenter.Controls.CustomGridViewTextBoxColumn<InfoCenter.Classes.UnitateTestare> customGridViewTextBoxColumn_11 = new InfoCenter.Controls.CustomGridViewTextBoxColumn<InfoCenter.Classes.UnitateTestare>();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            InfoCenter.Controls.CustomGridViewCommandColumn customGridViewCommandColumn1 = new InfoCenter.Controls.CustomGridViewCommandColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.RadRibbonBarCommandTab radRibbonBarCommandTab1 = new Telerik.WinControls.UI.RadRibbonBarCommandTab();
            Telerik.WinControls.UI.RadRibbonBarCommandTab radRibbonBarCommandTab2 = new Telerik.WinControls.UI.RadRibbonBarCommandTab();
            Telerik.WinControls.UI.RadRibbonBarCommandTab radRibbonBarCommandTab3 = new Telerik.WinControls.UI.RadRibbonBarCommandTab();
            Telerik.WinControls.UI.RadRibbonBarCommandTab radRibbonBarCommandTab4 = new Telerik.WinControls.UI.RadRibbonBarCommandTab();
            Telerik.WinControls.UI.RadRibbonBarCommandTab radRibbonBarCommandTab5 = new Telerik.WinControls.UI.RadRibbonBarCommandTab();
            this.radRibbonBarChunk2 = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radRibbonBarButtonGroup5 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.lblNumarLectii = new Telerik.WinControls.UI.RadLabelElement();
            this.lblNumarProbleme = new Telerik.WinControls.UI.RadLabelElement();
            this.lblNumarTeste = new Telerik.WinControls.UI.RadLabelElement();
            this.radRibbonBarChunk3 = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radImageButtonElement1 = new Telerik.WinControls.UI.RadImageButtonElement();
            this.ribbonTabStart = new Telerik.WinControls.UI.TabItem();
            this.radChunkInfLectie = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radGroup13 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.lblNivelLectie = new Telerik.WinControls.UI.RadLabelElement();
            this.btnProblemeLectie = new Telerik.WinControls.UI.RadButtonElement();
            this.btnTesteLectie = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTabLectii = new Telerik.WinControls.UI.TabItem();
            this.radChunkInfoProblema = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radGroup4 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.lblDificultateProblema = new Telerik.WinControls.UI.RadLabelElement();
            this.radChunkCautareProbleme = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radGroup7 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.radGroup10 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.comboCautaProblema = new Telerik.WinControls.UI.RadComboBoxElement();
            this.btnCautaProbleme = new Telerik.WinControls.UI.RadButtonElement();
            this.btnToateProblemele = new Telerik.WinControls.UI.RadButtonElement();
            this.radGroup11 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.comboCautaCuvantCheie = new Telerik.WinControls.UI.RadComboBoxElement();
            this.btnCautaCuvantCheie = new Telerik.WinControls.UI.RadButtonElement();
            this.btnToateCuvinteleCheie = new Telerik.WinControls.UI.RadButtonElement();
            this.radChunkActiuniProblema = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radGroup5 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnSalvare = new Telerik.WinControls.UI.RadSplitButtonElement();
            this.radMenuSalvare = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSalvareCa = new Telerik.WinControls.UI.RadMenuItem();
            this.radGroup15 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnMaresteCerinta = new Telerik.WinControls.UI.RadButtonElement();
            this.btnMaresteSursa = new Telerik.WinControls.UI.ActionButtonElement();
            this.btnRezolvaProblema = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTabProbleme = new Telerik.WinControls.UI.TabItem();
            this.radChunkInformatiiTest = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnLblNivelTest = new Telerik.WinControls.UI.RadLabelElement();
            this.lblPunctaj = new Telerik.WinControls.UI.RadLabelElement();
            this.lblTimpScurs = new Telerik.WinControls.UI.RadLabelElement();
            this.radChunkActiuniTest = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnIncepeTest = new Telerik.WinControls.UI.ActionButtonElement();
            this.btnResetTest = new Telerik.WinControls.UI.ActionButtonElement();
            this.btnCorecteazaTest = new Telerik.WinControls.UI.ActionButtonElement();
            this.ribbonTabTeste = new Telerik.WinControls.UI.TabItem();
            this.radChunkActiuniCompilator = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radRibbonBarButtonGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnExecuta = new Telerik.WinControls.UI.RadButtonElement();
            this.btnTestareProgram = new Telerik.WinControls.UI.RadButtonElement();
            this.btnTestareAutomaticaProgram = new Telerik.WinControls.UI.RadButtonElement();
            this.btnSaveCodSursa = new Telerik.WinControls.UI.RadButtonElement();
            this.btnFragmenteDeCod = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarChunk1 = new Telerik.WinControls.UI.RadRibbonBarChunk();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.radRibbonBarButtonGroup3 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.comboFont2 = new Telerik.WinControls.UI.RadComboBoxElement();
            this.radComboBoxItem12 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem13 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem14 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem15 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem16 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem17 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem18 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radRibbonBarButtonGroup9 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.comboFontSize2 = new Telerik.WinControls.UI.RadComboBoxElement();
            this.radComboBoxItem25 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem26 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem27 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem28 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.btnFontDecrease2 = new Telerik.WinControls.UI.RadButtonElement();
            this.btnFontIncrease2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarButtonGroup4 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.ribbonTabCompilator = new Telerik.WinControls.UI.TabItem();
            this.radComboBoxItem6 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem7 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem8 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem9 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem10 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.radComboBoxItem11 = new Telerik.WinControls.UI.RadComboBoxItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLinkCompilator = new System.Windows.Forms.LinkLabel();
            this.lblAutentificareProfesor = new System.Windows.Forms.LinkLabel();
            this.lblLinkTeste = new System.Windows.Forms.LinkLabel();
            this.lblLinkProbleme = new System.Windows.Forms.LinkLabel();
            this.lblLinkLectii = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageLectii = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gBoxListaLectii = new System.Windows.Forms.GroupBox();
            this.cuprinsLectii = new Telerik.WinControls.UI.RadTreeView();
            this.gBoxContinutLectie = new System.Windows.Forms.GroupBox();
            this.lblStartLectie = new System.Windows.Forms.Label();
            this.navigatorLectii = new System.Windows.Forms.WebBrowser();
            this.tabPageProbleme = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlSubProbleme = new System.Windows.Forms.TabControl();
            this.tabPageListaProbleme = new System.Windows.Forms.TabPage();
            this.listaProbleme = new System.Windows.Forms.ListView();
            this.colHeaderTitluProblema = new System.Windows.Forms.ColumnHeader();
            this.tabPageCuvinteCheie = new System.Windows.Forms.TabPage();
            this.splitContainerCuvinteCheie = new System.Windows.Forms.SplitContainer();
            this.listaCuvinteCheie = new Telerik.WinControls.UI.RadTreeView();
            this.gBoxRezCautareCuvinte = new System.Windows.Forms.GroupBox();
            this.listaRezultateCautareProbleme = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.gBoxCerinta = new System.Windows.Forms.GroupBox();
            this.txtCerintaProblema = new System.Windows.Forms.RichTextBox();
            this.gBoxSursa = new System.Windows.Forms.GroupBox();
            this.txtSursaProblema = new InfoCenter.Controls.CompilerTextBox();
            this.tabPageTeste = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.gBoxListaTeste = new System.Windows.Forms.GroupBox();
            this.listaTeste = new Telerik.WinControls.UI.RadTreeView();
            this.tabControlSubTeste = new System.Windows.Forms.TabControl();
            this.tabPageSubiectTest = new System.Windows.Forms.TabPage();
            this.btnIntrebareUrmatoare = new Telerik.WinControls.UI.RadButton();
            this.btnIntrebareAnterioara = new Telerik.WinControls.UI.RadButton();
            this.lblTitluTest = new System.Windows.Forms.Label();
            this.panelTestFinish = new System.Windows.Forms.Panel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.lblTestTerminat = new Telerik.WinControls.UI.RadLabel();
            this.panelWelcomeTest = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tabPageCorectareTest = new System.Windows.Forms.TabPage();
            this.listaCorectareTest = new System.Windows.Forms.ListView();
            this.colHeaderNrCrt = new System.Windows.Forms.ColumnHeader();
            this.colHeaderRaspAles = new System.Windows.Forms.ColumnHeader();
            this.colHeaderRaspCorect = new System.Windows.Forms.ColumnHeader();
            this.colHeaderPunctaj = new System.Windows.Forms.ColumnHeader();
            this.tabPageCompilator = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLinkProgramNou = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodSursa = new System.Windows.Forms.Label();
            this.txtCodSursa = new InfoCenter.Controls.CompilerTextBox();
            this.tabControlSubCompilator = new System.Windows.Forms.TabControl();
            this.tabPageRezultatCompilare = new System.Windows.Forms.TabPage();
            this.txtRezultatCompilare = new System.Windows.Forms.TextBox();
            this.tabPageTestareProgram = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControlDateIntrare = new System.Windows.Forms.TabControl();
            this.tabcin = new System.Windows.Forms.TabPage();
            this.txtDateIntrareProgram = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControlDateIesire = new System.Windows.Forms.TabControl();
            this.tabcout = new System.Windows.Forms.TabPage();
            this.txtRezultatProgram = new System.Windows.Forms.TextBox();
            this.tabPageTestareAutomata = new System.Windows.Forms.TabPage();
            this.btnAdaugaTestare = new Telerik.WinControls.UI.RadButton();
            this.btnVerifica = new Telerik.WinControls.UI.RadDropDownButton();
            this.radMenuSelectate = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuToate = new Telerik.WinControls.UI.RadMenuItem();
            this.gridVerificare = new Telerik.WinControls.UI.RadGridView();
            this.lblNoTest = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ribbonBar = new Telerik.WinControls.UI.RadRibbonBar();
            this.radMenuReloadInfo = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuUpdateApplication = new Telerik.WinControls.UI.RadMenuItem();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.toolStripStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.toolStripProgressBar = new Telerik.WinControls.UI.RadProgressBarElement();
            this.radLabelCopyright = new Telerik.WinControls.UI.RadLabelElement();
            this.toolStripConnectedMode = new Telerik.WinControls.UI.RadLabelElement();
            this.toolStripDataOra = new Telerik.WinControls.UI.RadLabelElement();
            this.btnFontItalic2 = new Telerik.WinControls.UI.RadToggleButtonElement();
            this.btnFontBold2 = new Telerik.WinControls.UI.RadToggleButtonElement();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.testTimer = new InfoCenter.Controls.CustomTimer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboCautaProblema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCautaCuvantCheie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboFont2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboFontSize2)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            this.tabPageLectii.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gBoxListaLectii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuprinsLectii)).BeginInit();
            this.gBoxContinutLectie.SuspendLayout();
            this.tabPageProbleme.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlSubProbleme.SuspendLayout();
            this.tabPageListaProbleme.SuspendLayout();
            this.tabPageCuvinteCheie.SuspendLayout();
            this.splitContainerCuvinteCheie.Panel1.SuspendLayout();
            this.splitContainerCuvinteCheie.Panel2.SuspendLayout();
            this.splitContainerCuvinteCheie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCuvinteCheie)).BeginInit();
            this.gBoxRezCautareCuvinte.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.gBoxCerinta.SuspendLayout();
            this.gBoxSursa.SuspendLayout();
            this.tabPageTeste.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.gBoxListaTeste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTeste)).BeginInit();
            this.tabControlSubTeste.SuspendLayout();
            this.tabPageSubiectTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIntrebareUrmatoare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIntrebareAnterioara)).BeginInit();
            this.panelTestFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTestTerminat)).BeginInit();
            this.panelWelcomeTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.tabPageCorectareTest.SuspendLayout();
            this.tabPageCompilator.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlSubCompilator.SuspendLayout();
            this.tabPageRezultatCompilare.SuspendLayout();
            this.tabPageTestareProgram.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControlDateIntrare.SuspendLayout();
            this.tabcin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlDateIesire.SuspendLayout();
            this.tabcout.SuspendLayout();
            this.tabPageTestareAutomata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdaugaTestare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVerificare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVerificare.MasterGridViewTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBarChunk2
            // 
            this.radRibbonBarChunk2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup5});
            this.radRibbonBarChunk2.Name = "radRibbonBarChunk2";
            this.radRibbonBarChunk2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radRibbonBarChunk2.Text = "Informaţii Info Center";
            // 
            // radRibbonBarButtonGroup5
            // 
            this.radRibbonBarButtonGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblNumarLectii,
            this.lblNumarProbleme,
            this.lblNumarTeste});
            this.radRibbonBarButtonGroup5.MinSize = new System.Drawing.Size(22, 22);
            this.radRibbonBarButtonGroup5.Name = "radRibbonBarButtonGroup5";
            this.radRibbonBarButtonGroup5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup5.ShowBackColor = false;
            this.radRibbonBarButtonGroup5.ShowBorder = false;
            this.radRibbonBarButtonGroup5.Text = "radRibbonBarButtonGroup5";
            // 
            // lblNumarLectii
            // 
            this.lblNumarLectii.Name = "lblNumarLectii";
            this.lblNumarLectii.Text = "Număr lecţii:";
            // 
            // lblNumarProbleme
            // 
            this.lblNumarProbleme.Name = "lblNumarProbleme";
            this.lblNumarProbleme.Text = "Număr probleme:";
            // 
            // lblNumarTeste
            // 
            this.lblNumarTeste.Name = "lblNumarTeste";
            this.lblNumarTeste.Text = "Număr teste:";
            // 
            // radRibbonBarChunk3
            // 
            this.radRibbonBarChunk3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radImageButtonElement1});
            this.radRibbonBarChunk3.Name = "radRibbonBarChunk3";
            this.radRibbonBarChunk3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radRibbonBarChunk3.Text = " ";
            // 
            // radImageButtonElement1
            // 
            this.radImageButtonElement1.CanFocus = true;
            this.radImageButtonElement1.Class = "RibbonBarButtonElement";
            this.radImageButtonElement1.Image = global::InfoCenter.Properties.Resources.logoc;
            this.radImageButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radImageButtonElement1.Name = "radImageButtonElement1";
            this.radImageButtonElement1.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.radImageButtonElement1.Text = "imageC";
            // 
            // ribbonTabStart
            // 
            this.ribbonTabStart.CanFocus = true;
            this.ribbonTabStart.Class = "TabItem";
            // 
            // ribbonTabStart.ContentPanel
            // 
            this.ribbonTabStart.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ribbonTabStart.ContentPanel.CausesValidation = true;
            this.ribbonTabStart.Name = "ribbonTabStart";
            this.ribbonTabStart.Text = "Pagina de start";
            this.ribbonTabStart.Click += new System.EventHandler(this.ribbonTabStartPage_Click);
            // 
            // radChunkInfLectie
            // 
            this.radChunkInfLectie.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGroup13});
            this.radChunkInfLectie.Name = "radChunkInfLectie";
            this.radChunkInfLectie.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radChunkInfLectie.Text = "Informaţii lecţie";
            this.radChunkInfLectie.ToolTipText = null;
            // 
            // radGroup13
            // 
            this.radGroup13.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblNivelLectie,
            this.btnProblemeLectie,
            this.btnTesteLectie});
            this.radGroup13.MinSize = new System.Drawing.Size(22, 22);
            this.radGroup13.Name = "radGroup13";
            this.radGroup13.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radGroup13.Padding = new System.Windows.Forms.Padding(1);
            this.radGroup13.ShowBackColor = false;
            this.radGroup13.ShowBorder = false;
            this.radGroup13.Text = "radGroup13";
            this.radGroup13.ToolTipText = null;
            // 
            // lblNivelLectie
            // 
            this.lblNivelLectie.CanFocus = true;
            this.lblNivelLectie.Class = "RibbonBarButtonElement";
            this.lblNivelLectie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblNivelLectie.Image = global::InfoCenter.Properties.Resources._0_star_rating;
            this.lblNivelLectie.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNivelLectie.Name = "lblNivelLectie";
            this.lblNivelLectie.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblNivelLectie.Text = "Dificultate";
            this.lblNivelLectie.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNivelLectie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lblNivelLectie.ToolTipText = "Afişează nivelul necesar pentru parcurgerea lecţiei selectate (1 stea - începător" +
                "; 2 stele - mediu; 3 stele - avansat).";
            // 
            // btnProblemeLectie
            // 
            this.btnProblemeLectie.CanFocus = true;
            this.btnProblemeLectie.Class = "RibbonBarButtonElement";
            this.btnProblemeLectie.Enabled = false;
            this.btnProblemeLectie.Image = global::InfoCenter.Properties.Resources.imgProbleme32;
            this.btnProblemeLectie.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProblemeLectie.Name = "btnProblemeLectie";
            this.btnProblemeLectie.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnProblemeLectie.Text = "Problemele asociate";
            this.btnProblemeLectie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProblemeLectie.ToolTipText = "Afişează problemele asociate lecţiei selectate.";
            this.btnProblemeLectie.Click += new System.EventHandler(this.btnProblemeLectie_Click);
            // 
            // btnTesteLectie
            // 
            this.btnTesteLectie.CanFocus = true;
            this.btnTesteLectie.Class = "RibbonBarButtonElement";
            this.btnTesteLectie.Enabled = false;
            this.btnTesteLectie.Image = global::InfoCenter.Properties.Resources.imgTest32;
            this.btnTesteLectie.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTesteLectie.Name = "btnTesteLectie";
            this.btnTesteLectie.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnTesteLectie.Text = "Testele asociate";
            this.btnTesteLectie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTesteLectie.ToolTipText = "Afişează testele asociate lecţiei selectate.";
            this.btnTesteLectie.Click += new System.EventHandler(this.btnTesteLectie_Click);
            // 
            // ribbonTabLectii
            // 
            this.ribbonTabLectii.CanFocus = true;
            this.ribbonTabLectii.Class = "TabItem";
            // 
            // ribbonTabLectii.ContentPanel
            // 
            this.ribbonTabLectii.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ribbonTabLectii.ContentPanel.CausesValidation = true;
            this.ribbonTabLectii.KeyTip = " ";
            this.ribbonTabLectii.Name = "ribbonTabLectii";
            this.ribbonTabLectii.Text = "Lecţii";
            this.ribbonTabLectii.ToolTipText = null;
            this.ribbonTabLectii.Click += new System.EventHandler(this.ribbonTabLectii_Click);
            // 
            // radChunkInfoProblema
            // 
            this.radChunkInfoProblema.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGroup4});
            this.radChunkInfoProblema.Name = "radChunkInfoProblema";
            this.radChunkInfoProblema.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radChunkInfoProblema.Text = "Informaţii problemă";
            this.radChunkInfoProblema.ToolTipText = null;
            // 
            // radGroup4
            // 
            this.radGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblDificultateProblema});
            this.radGroup4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radGroup4.MinSize = new System.Drawing.Size(22, 22);
            this.radGroup4.Name = "radGroup4";
            this.radGroup4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radGroup4.Padding = new System.Windows.Forms.Padding(1);
            this.radGroup4.ShowBackColor = false;
            this.radGroup4.ShowBorder = false;
            this.radGroup4.Text = "radGroup4";
            this.radGroup4.ToolTipText = null;
            // 
            // lblDificultateProblema
            // 
            this.lblDificultateProblema.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblDificultateProblema.CanFocus = true;
            this.lblDificultateProblema.Class = "RibbonLabelElement";
            this.lblDificultateProblema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblDificultateProblema.Image = global::InfoCenter.Properties.Resources._0_star_rating;
            this.lblDificultateProblema.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDificultateProblema.Name = "lblDificultateProblema";
            this.lblDificultateProblema.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblDificultateProblema.Text = "Dificultate:";
            this.lblDificultateProblema.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDificultateProblema.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.lblDificultateProblema.ToolTipText = "Afişează nivelul necesar pentru rezolvarea problemei selectate (1 stea - începăto" +
                "r; 2 stele - mediu; 3 stele - avansat).";
            // 
            // radChunkCautareProbleme
            // 
            this.radChunkCautareProbleme.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGroup7});
            this.radChunkCautareProbleme.Name = "radChunkCautareProbleme";
            this.radChunkCautareProbleme.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radChunkCautareProbleme.Text = "Căutare probleme şi cuvinte cheie";
            this.radChunkCautareProbleme.ToolTipText = null;
            // 
            // radGroup7
            // 
            this.radGroup7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGroup10,
            this.radGroup11});
            this.radGroup7.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radGroup7.MinSize = new System.Drawing.Size(22, 22);
            this.radGroup7.Name = "radGroup7";
            this.radGroup7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radGroup7.ShowBackColor = false;
            this.radGroup7.ShowBorder = false;
            this.radGroup7.Text = "radGroup7";
            this.radGroup7.ToolTipText = null;
            // 
            // radGroup10
            // 
            this.radGroup10.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.comboCautaProblema,
            this.btnCautaProbleme,
            this.btnToateProblemele});
            this.radGroup10.Margin = new System.Windows.Forms.Padding(2);
            this.radGroup10.MinSize = new System.Drawing.Size(22, 22);
            this.radGroup10.Name = "radGroup10";
            this.radGroup10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radGroup10.ShowBackColor = true;
            this.radGroup10.ShowBorder = true;
            this.radGroup10.Text = "radGroup10";
            this.radGroup10.ToolTipText = null;
            // 
            // comboCautaProblema
            // 
            this.comboCautaProblema.ArrowButtonMinWidth = 16;
            this.comboCautaProblema.DefaultValue = null;
            this.comboCautaProblema.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.comboCautaProblema.EditorElement = this.comboCautaProblema;
            this.comboCautaProblema.Focusable = true;
            this.comboCautaProblema.MaxDropDownItems = 9;
            this.comboCautaProblema.MaxSize = new System.Drawing.Size(140, 0);
            this.comboCautaProblema.MaxValue = null;
            this.comboCautaProblema.MinSize = new System.Drawing.Size(140, 0);
            this.comboCautaProblema.MinValue = null;
            this.comboCautaProblema.Name = "comboCautaProblema";
            this.comboCautaProblema.NullValue = null;
            this.comboCautaProblema.OwnerOffset = 0;
            this.comboCautaProblema.ReadOnly = false;
            this.comboCautaProblema.Text = "(Caută problemă)";
            this.comboCautaProblema.ToolTipText = "Caută în titlurile problemelor după o anumită secventă şi afişează rezultatele.";
            this.comboCautaProblema.Value = null;
            this.comboCautaProblema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboCautaProblema_KeyPress);
            // 
            // btnCautaProbleme
            // 
            this.btnCautaProbleme.CanFocus = true;
            this.btnCautaProbleme.Class = "ButtonElement";
            this.btnCautaProbleme.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnCautaProbleme.Name = "btnCautaProbleme";
            this.btnCautaProbleme.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCautaProbleme.ShowBorder = false;
            this.btnCautaProbleme.Text = "Caută problemă";
            this.btnCautaProbleme.ToolTipText = "Caută în titlurile şi cerinţa problemelor după o anumită secventă şi afişează rez" +
                "ultatele.";
            this.btnCautaProbleme.Click += new System.EventHandler(this.btnCautaProbleme_Click);
            // 
            // btnToateProblemele
            // 
            this.btnToateProblemele.CanFocus = true;
            this.btnToateProblemele.Class = "ButtonElement";
            this.btnToateProblemele.Image = global::InfoCenter.Properties.Resources.imgToate16;
            this.btnToateProblemele.Name = "btnToateProblemele";
            this.btnToateProblemele.Padding = new System.Windows.Forms.Padding(1);
            this.btnToateProblemele.ShowBorder = false;
            this.btnToateProblemele.ToolTipText = "Afişează toate problemele.";
            this.btnToateProblemele.Click += new System.EventHandler(this.btnToateProblemele_Click);
            // 
            // radGroup11
            // 
            this.radGroup11.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.comboCautaCuvantCheie,
            this.btnCautaCuvantCheie,
            this.btnToateCuvinteleCheie});
            this.radGroup11.Margin = new System.Windows.Forms.Padding(2);
            this.radGroup11.MinSize = new System.Drawing.Size(22, 22);
            this.radGroup11.Name = "radGroup11";
            this.radGroup11.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radGroup11.ShowBackColor = true;
            this.radGroup11.ShowBorder = true;
            this.radGroup11.Text = "radGroup11";
            this.radGroup11.ToolTipText = null;
            // 
            // comboCautaCuvantCheie
            // 
            this.comboCautaCuvantCheie.ArrowButtonMinWidth = 16;
            this.comboCautaCuvantCheie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCautaCuvantCheie.DefaultValue = null;
            this.comboCautaCuvantCheie.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.comboCautaCuvantCheie.EditorElement = this.comboCautaCuvantCheie;
            this.comboCautaCuvantCheie.Focusable = true;
            this.comboCautaCuvantCheie.MaxSize = new System.Drawing.Size(140, 0);
            this.comboCautaCuvantCheie.MaxValue = null;
            this.comboCautaCuvantCheie.MinSize = new System.Drawing.Size(140, 0);
            this.comboCautaCuvantCheie.MinValue = null;
            this.comboCautaCuvantCheie.Name = "comboCautaCuvantCheie";
            this.comboCautaCuvantCheie.NullValue = null;
            this.comboCautaCuvantCheie.OwnerOffset = 0;
            this.comboCautaCuvantCheie.ReadOnly = false;
            this.comboCautaCuvantCheie.Text = "(Caută cuvânt cheie)";
            this.comboCautaCuvantCheie.ToolTipText = "Caută în cuvintele cheie ale problemelor după o anumită secventă şi afişează rezu" +
                "ltatele.";
            this.comboCautaCuvantCheie.Value = null;
            this.comboCautaCuvantCheie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboCautaCuvantCheie_KeyPress);
            // 
            // btnCautaCuvantCheie
            // 
            this.btnCautaCuvantCheie.CanFocus = true;
            this.btnCautaCuvantCheie.Class = "ButtonElement";
            this.btnCautaCuvantCheie.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnCautaCuvantCheie.Name = "btnCautaCuvantCheie";
            this.btnCautaCuvantCheie.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCautaCuvantCheie.ShowBorder = false;
            this.btnCautaCuvantCheie.Text = "Caută cuvânt cheie";
            this.btnCautaCuvantCheie.ToolTipText = "Caută în cuvintele cheie ale problemelor după o anumită secventă şi afişează rezu" +
                "ltatele.";
            this.btnCautaCuvantCheie.Click += new System.EventHandler(this.btnCautaCuvantCheie_Click);
            // 
            // btnToateCuvinteleCheie
            // 
            this.btnToateCuvinteleCheie.CanFocus = true;
            this.btnToateCuvinteleCheie.Class = "ButtonElement";
            this.btnToateCuvinteleCheie.Image = global::InfoCenter.Properties.Resources.imgToate16;
            this.btnToateCuvinteleCheie.Name = "btnToateCuvinteleCheie";
            this.btnToateCuvinteleCheie.Padding = new System.Windows.Forms.Padding(1);
            this.btnToateCuvinteleCheie.ShowBorder = false;
            this.btnToateCuvinteleCheie.ToolTipText = "Afişează toate cuvintele cheie.";
            this.btnToateCuvinteleCheie.Click += new System.EventHandler(this.btnToateCuvinteleCheie_Click);
            // 
            // radChunkActiuniProblema
            // 
            this.radChunkActiuniProblema.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGroup5,
            this.radGroup15});
            this.radChunkActiuniProblema.Name = "radChunkActiuniProblema";
            this.radChunkActiuniProblema.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radChunkActiuniProblema.Text = "Acţiuni problemă";
            this.radChunkActiuniProblema.ToolTipText = null;
            // 
            // radGroup5
            // 
            this.radGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnSalvare});
            this.radGroup5.MinSize = new System.Drawing.Size(22, 22);
            this.radGroup5.Name = "radGroup5";
            this.radGroup5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radGroup5.Padding = new System.Windows.Forms.Padding(1);
            this.radGroup5.ShowBackColor = false;
            this.radGroup5.ShowBorder = false;
            this.radGroup5.Text = "radGroup5";
            this.radGroup5.ToolTipText = null;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvare.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            this.btnSalvare.AutoSize = false;
            this.btnSalvare.BackColor = System.Drawing.Color.Empty;
            this.btnSalvare.Bounds = new System.Drawing.Rectangle(0, 0, 61, 61);
            this.btnSalvare.CanFocus = true;
            this.btnSalvare.Class = "RibbonBarButtonElement";
            this.btnSalvare.DefaultItem = null;
            this.btnSalvare.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down;
            this.btnSalvare.ExpandArrowButton = false;
            this.btnSalvare.HasTwoColumnDropDown = false;
            this.btnSalvare.Image = global::InfoCenter.Properties.Resources.imgSaveAs32;
            this.btnSalvare.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvare.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSalvare,
            this.radMenuSalvareCa});
            this.btnSalvare.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Padding = new System.Windows.Forms.Padding(0, -3, 0, 0);
            this.btnSalvare.StringAlignment = System.Drawing.StringAlignment.Center;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvare.ToolTipText = "Salvează codul sursă al problemei selectate într-un fişier specificat sau în dosa" +
                "rul de salvare rapidă.";
            // 
            // radMenuSalvare
            // 
            this.radMenuSalvare.Image = global::InfoCenter.Properties.Resources.imgSave32_2;
            this.radMenuSalvare.Name = "radMenuSalvare";
            this.radMenuSalvare.Text = "Salvare Rapidă";
            this.radMenuSalvare.ToolTipText = "Salvează codul sursă al problemei selectate în dosarul pentru salvare rapidă dacă" +
                " acesta a fost definit.";
            this.radMenuSalvare.Click += new System.EventHandler(this.btnSalvareRapida_Click);
            // 
            // radMenuSalvareCa
            // 
            this.radMenuSalvareCa.Image = global::InfoCenter.Properties.Resources.imgSaveAs32_2;
            this.radMenuSalvareCa.Name = "radMenuSalvareCa";
            this.radMenuSalvareCa.Text = "Salvare";
            this.radMenuSalvareCa.ToolTipText = "Salvează codul sursă al problemei selectate într-un fişier specificat.";
            this.radMenuSalvareCa.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // radGroup15
            // 
            this.radGroup15.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnMaresteCerinta,
            this.btnMaresteSursa,
            this.btnRezolvaProblema});
            this.radGroup15.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroup15.Name = "radGroup15";
            this.radGroup15.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radGroup15.Padding = new System.Windows.Forms.Padding(1);
            this.radGroup15.ShowBackColor = false;
            this.radGroup15.ShowBorder = false;
            this.radGroup15.ToolTipText = null;
            // 
            // btnMaresteCerinta
            // 
            this.btnMaresteCerinta.CanFocus = true;
            this.btnMaresteCerinta.Class = "RibbonBarButtonElement";
            this.btnMaresteCerinta.Image = global::InfoCenter.Properties.Resources.imgZoom32;
            this.btnMaresteCerinta.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaresteCerinta.Name = "btnMaresteCerinta";
            this.btnMaresteCerinta.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnMaresteCerinta.Text = "Măreşte cerinţa";
            this.btnMaresteCerinta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMaresteCerinta.ToolTipText = "Afişează cerinţa într-o fereastră mai mare.";
            this.btnMaresteCerinta.Click += new System.EventHandler(this.btnMaresteCerinta_Click);
            // 
            // btnMaresteSursa
            // 
            this.btnMaresteSursa.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMaresteSursa.CanFocus = true;
            this.btnMaresteSursa.Class = "RibbonBarButtonElement";
            this.btnMaresteSursa.Image = global::InfoCenter.Properties.Resources.imgZoom32;
            this.btnMaresteSursa.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaresteSursa.Name = "btnMaresteSursa";
            this.btnMaresteSursa.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnMaresteSursa.Text = "Măreşte codul sursă";
            this.btnMaresteSursa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMaresteSursa.ToolTipText = "Afişează codul sursă într-o fereastră mai mare.";
            this.btnMaresteSursa.Click += new System.EventHandler(this.btnMaresteSursa_Click);
            // 
            // btnRezolvaProblema
            // 
            this.btnRezolvaProblema.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRezolvaProblema.CanFocus = true;
            this.btnRezolvaProblema.Class = "RibbonBarButtonElement";
            this.btnRezolvaProblema.Image = global::InfoCenter.Properties.Resources.imgOptiuni;
            this.btnRezolvaProblema.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRezolvaProblema.Name = "btnRezolvaProblema";
            this.btnRezolvaProblema.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnRezolvaProblema.Text = "Rezolvă problema";
            this.btnRezolvaProblema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRezolvaProblema.ToolTipText = "Compilează codul sursă al problemei selectate şi afişează rezultatul compilării.";
            this.btnRezolvaProblema.Click += new System.EventHandler(this.btnRezolvaProblema_Click);
            // 
            // ribbonTabProbleme
            // 
            this.ribbonTabProbleme.CanFocus = true;
            this.ribbonTabProbleme.Class = "TabItem";
            // 
            // ribbonTabProbleme.ContentPanel
            // 
            this.ribbonTabProbleme.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ribbonTabProbleme.ContentPanel.CausesValidation = true;
            this.ribbonTabProbleme.KeyTip = " ";
            this.ribbonTabProbleme.Name = "ribbonTabProbleme";
            this.ribbonTabProbleme.Text = "Probleme";
            this.ribbonTabProbleme.ToolTipText = null;
            this.ribbonTabProbleme.Click += new System.EventHandler(this.ribbonTabProbleme_Click);
            // 
            // radChunkInformatiiTest
            // 
            this.radChunkInformatiiTest.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGroup2});
            this.radChunkInformatiiTest.Name = "radChunkInformatiiTest";
            this.radChunkInformatiiTest.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radChunkInformatiiTest.Text = "Informaţii Test";
            this.radChunkInformatiiTest.ToolTipText = null;
            // 
            // radGroup2
            // 
            this.radGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnLblNivelTest,
            this.lblPunctaj,
            this.lblTimpScurs});
            this.radGroup2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radGroup2.MinSize = new System.Drawing.Size(22, 22);
            this.radGroup2.Name = "radGroup2";
            this.radGroup2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radGroup2.Padding = new System.Windows.Forms.Padding(1);
            this.radGroup2.ShowBackColor = false;
            this.radGroup2.ShowBorder = false;
            this.radGroup2.Text = "radGroup2";
            this.radGroup2.ToolTipText = null;
            // 
            // btnLblNivelTest
            // 
            this.btnLblNivelTest.CanFocus = true;
            this.btnLblNivelTest.Class = "RibbonBarButtonElement";
            this.btnLblNivelTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnLblNivelTest.Image = global::InfoCenter.Properties.Resources._0_star_rating;
            this.btnLblNivelTest.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLblNivelTest.Name = "btnLblNivelTest";
            this.btnLblNivelTest.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnLblNivelTest.Text = "Nivel test";
            this.btnLblNivelTest.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnLblNivelTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLblNivelTest.ToolTipText = "Afişează nivelul necesar pentru rezolvarea testului selectat (1 stea - începător;" +
                " 2 stele - mediu; 3 stele - avansat).";
            // 
            // lblPunctaj
            // 
            this.lblPunctaj.CanFocus = true;
            this.lblPunctaj.Class = "RibbonBarButtonElement";
            this.lblPunctaj.Enabled = false;
            this.lblPunctaj.Image = global::InfoCenter.Properties.Resources.imgPunctaj32;
            this.lblPunctaj.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblPunctaj.Text = "Punctaj: -";
            this.lblPunctaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lblPunctaj.ToolTipText = "Afişează punctajul primit pentru rezolvarea testului.";
            // 
            // lblTimpScurs
            // 
            this.lblTimpScurs.CanFocus = true;
            this.lblTimpScurs.Class = "RibbonBarButtonElement";
            this.lblTimpScurs.Enabled = false;
            this.lblTimpScurs.Image = global::InfoCenter.Properties.Resources.imgClock32;
            this.lblTimpScurs.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimpScurs.Name = "lblTimpScurs";
            this.lblTimpScurs.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblTimpScurs.Text = "Timp Scurs: -";
            this.lblTimpScurs.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimpScurs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lblTimpScurs.ToolTipText = "Afişează timpul scurs de la începerea testului.";
            // 
            // radChunkActiuniTest
            // 
            this.radChunkActiuniTest.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGroup1});
            this.radChunkActiuniTest.Name = "radChunkActiuniTest";
            this.radChunkActiuniTest.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radChunkActiuniTest.Text = "Acţiuni test";
            this.radChunkActiuniTest.ToolTipText = null;
            // 
            // radGroup1
            // 
            this.radGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnIncepeTest,
            this.btnResetTest,
            this.btnCorecteazaTest});
            this.radGroup1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.radGroup1.MinSize = new System.Drawing.Size(22, 22);
            this.radGroup1.Name = "radGroup1";
            this.radGroup1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radGroup1.Padding = new System.Windows.Forms.Padding(1);
            this.radGroup1.ShowBackColor = false;
            this.radGroup1.ShowBorder = false;
            this.radGroup1.Text = "radGroup1";
            this.radGroup1.ToolTipText = null;
            // 
            // btnIncepeTest
            // 
            this.btnIncepeTest.CanFocus = true;
            this.btnIncepeTest.Class = "RibbonBarButtonElement";
            this.btnIncepeTest.Image = global::InfoCenter.Properties.Resources.imgPlay32;
            this.btnIncepeTest.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIncepeTest.Name = "btnIncepeTest";
            this.btnIncepeTest.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnIncepeTest.Text = "Începe testul";
            this.btnIncepeTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncepeTest.ToolTipText = "Începe rezolvarea testului selectat.";
            this.btnIncepeTest.Click += new System.EventHandler(this.btnIncepeTest_Click);
            // 
            // btnResetTest
            // 
            this.btnResetTest.CanFocus = true;
            this.btnResetTest.Class = "RibbonBarButtonElement";
            this.btnResetTest.Image = global::InfoCenter.Properties.Resources.imgRefresh32;
            this.btnResetTest.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResetTest.Name = "btnResetTest";
            this.btnResetTest.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnResetTest.Text = "Reîncepe testul";
            this.btnResetTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnResetTest.ToolTipText = "Resetează testul fără a verifica corectitudinea răspunsurilor.";
            this.btnResetTest.Click += new System.EventHandler(this.btnResetTest_Click);
            // 
            // btnCorecteazaTest
            // 
            this.btnCorecteazaTest.CanFocus = true;
            this.btnCorecteazaTest.Class = "RibbonBarButtonElement";
            this.btnCorecteazaTest.Image = global::InfoCenter.Properties.Resources.imgSetariImprimanta;
            this.btnCorecteazaTest.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCorecteazaTest.Name = "btnCorecteazaTest";
            this.btnCorecteazaTest.Text = "Corectează testul";
            this.btnCorecteazaTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCorecteazaTest.ToolTipText = "Opreşte testul, verifică corectitudinea răspunsurilor şi afişează punctajul obţin" +
                "ut.";
            this.btnCorecteazaTest.Click += new System.EventHandler(this.btnCorecteazaTest_Click);
            // 
            // ribbonTabTeste
            // 
            this.ribbonTabTeste.CanFocus = true;
            this.ribbonTabTeste.Class = "TabItem";
            // 
            // ribbonTabTeste.ContentPanel
            // 
            this.ribbonTabTeste.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ribbonTabTeste.ContentPanel.CausesValidation = true;
            this.ribbonTabTeste.KeyTip = " ";
            this.ribbonTabTeste.Name = "ribbonTabTeste";
            this.ribbonTabTeste.Text = "Teste";
            this.ribbonTabTeste.ToolTipText = null;
            this.ribbonTabTeste.Click += new System.EventHandler(this.ribbonTabTeste_Click);
            // 
            // radChunkActiuniCompilator
            // 
            this.radChunkActiuniCompilator.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup1});
            this.radChunkActiuniCompilator.Name = "radChunkActiuniCompilator";
            this.radChunkActiuniCompilator.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radChunkActiuniCompilator.Text = "Acţiuni compilator";
            this.radChunkActiuniCompilator.ToolTipText = null;
            // 
            // radRibbonBarButtonGroup1
            // 
            this.radRibbonBarButtonGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnExecuta,
            this.btnTestareProgram,
            this.btnTestareAutomaticaProgram,
            this.btnSaveCodSursa,
            this.btnFragmenteDeCod});
            this.radRibbonBarButtonGroup1.MinSize = new System.Drawing.Size(22, 22);
            this.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radRibbonBarButtonGroup1.Padding = new System.Windows.Forms.Padding(1);
            this.radRibbonBarButtonGroup1.ShowBackColor = false;
            this.radRibbonBarButtonGroup1.ShowBorder = false;
            this.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.ToolTipText = null;
            // 
            // btnExecuta
            // 
            this.btnExecuta.CanFocus = true;
            this.btnExecuta.Class = "RibbonBarButtonElement";
            this.btnExecuta.Image = global::InfoCenter.Properties.Resources.imgRun1;
            this.btnExecuta.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnExecuta.Text = "Execută programul";
            this.btnExecuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // btnTestareProgram
            // 
            this.btnTestareProgram.CanFocus = true;
            this.btnTestareProgram.Class = "RibbonBarButtonElement";
            this.btnTestareProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnTestareProgram.Image")));
            this.btnTestareProgram.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTestareProgram.Name = "btnTestareProgram";
            this.btnTestareProgram.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnTestareProgram.Text = "Date de intrare";
            this.btnTestareProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTestareProgram.ToolTipText = "Testează codul sursă din compilator cu date de la tastatură.";
            this.btnTestareProgram.Click += new System.EventHandler(this.btnTestareProgram_Click);
            // 
            // btnTestareAutomaticaProgram
            // 
            this.btnTestareAutomaticaProgram.CanFocus = true;
            this.btnTestareAutomaticaProgram.Class = "RibbonBarButtonElement";
            this.btnTestareAutomaticaProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnTestareAutomaticaProgram.Image")));
            this.btnTestareAutomaticaProgram.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTestareAutomaticaProgram.Name = "btnTestareAutomaticaProgram";
            this.btnTestareAutomaticaProgram.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnTestareAutomaticaProgram.Text = "Teste automate";
            this.btnTestareAutomaticaProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTestareAutomaticaProgram.ToolTipText = "Testează codul sursă din compilator cu date predefinite.";
            this.btnTestareAutomaticaProgram.Click += new System.EventHandler(this.btnTestareAutomaticaProgram_Click);
            // 
            // btnSaveCodSursa
            // 
            this.btnSaveCodSursa.CanFocus = true;
            this.btnSaveCodSursa.Class = "RibbonBarButtonElement";
            this.btnSaveCodSursa.Image = global::InfoCenter.Properties.Resources.imgSave32;
            this.btnSaveCodSursa.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveCodSursa.Name = "btnSaveCodSursa";
            this.btnSaveCodSursa.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btnSaveCodSursa.Text = "Salvează codul sursă";
            this.btnSaveCodSursa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveCodSursa.ToolTipText = "Salvează codul sursă scris în compilator (CTRL+S)";
            this.btnSaveCodSursa.Click += new System.EventHandler(this.btnSaveCodSursa_Click);
            // 
            // btnFragmenteDeCod
            // 
            this.btnFragmenteDeCod.CanFocus = true;
            this.btnFragmenteDeCod.Class = "RibbonBarButtonElement";
            this.btnFragmenteDeCod.Image = global::InfoCenter.Properties.Resources.codesnippet32;
            this.btnFragmenteDeCod.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFragmenteDeCod.Name = "btnFragmenteDeCod";
            this.btnFragmenteDeCod.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btnFragmenteDeCod.Text = "Fragmente de cod";
            this.btnFragmenteDeCod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFragmenteDeCod.Click += new System.EventHandler(this.btnFragmenteDeCod_Click);
            // 
            // radRibbonBarChunk1
            // 
            this.radRibbonBarChunk1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup2});
            this.radRibbonBarChunk1.Name = "radRibbonBarChunk1";
            this.radRibbonBarChunk1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radRibbonBarChunk1.Text = "Font cod sursă";
            this.radRibbonBarChunk1.ToolTipText = null;
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radRibbonBarButtonGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup3,
            this.radRibbonBarButtonGroup4});
            this.radRibbonBarButtonGroup2.MinSize = new System.Drawing.Size(22, 22);
            this.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup2.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.radRibbonBarButtonGroup2.ShowBackColor = false;
            this.radRibbonBarButtonGroup2.ShowBorder = false;
            this.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.ToolTipText = null;
            // 
            // radRibbonBarButtonGroup3
            // 
            this.radRibbonBarButtonGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.comboFont2,
            this.radRibbonBarButtonGroup9});
            this.radRibbonBarButtonGroup3.Name = "radRibbonBarButtonGroup3";
            this.radRibbonBarButtonGroup3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup3.ShowBackColor = false;
            this.radRibbonBarButtonGroup3.ShowBorder = true;
            this.radRibbonBarButtonGroup3.Text = "radRibbonBarButtonGroup3";
            this.radRibbonBarButtonGroup3.ToolTipText = null;
            // 
            // comboFont2
            // 
            this.comboFont2.ArrowButtonMinWidth = 16;
            this.comboFont2.AutoSize = false;
            this.comboFont2.Bounds = new System.Drawing.Rectangle(0, 0, 146, 21);
            this.comboFont2.DefaultValue = null;
            this.comboFont2.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.comboFont2.EditorElement = this.comboFont2;
            this.comboFont2.Focusable = true;
            this.comboFont2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radComboBoxItem12,
            this.radComboBoxItem13,
            this.radComboBoxItem14,
            this.radComboBoxItem15,
            this.radComboBoxItem16,
            this.radComboBoxItem17,
            this.radComboBoxItem18});
            this.comboFont2.MaxSize = new System.Drawing.Size(140, 0);
            this.comboFont2.MaxValue = null;
            this.comboFont2.MinSize = new System.Drawing.Size(140, 0);
            this.comboFont2.MinValue = null;
            this.comboFont2.Name = "comboFont2";
            this.comboFont2.NullValue = null;
            this.comboFont2.OwnerOffset = 0;
            this.comboFont2.ReadOnly = false;
            this.comboFont2.Text = "(Font)";
            this.comboFont2.ToolTipText = null;
            this.comboFont2.Value = null;
            this.comboFont2.TextChanged += new System.EventHandler(this.comboFont2_TextChanged);
            // 
            // radComboBoxItem12
            // 
            this.radComboBoxItem12.Name = "radComboBoxItem12";
            this.radComboBoxItem12.Text = "Arial";
            this.radComboBoxItem12.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem12.ToolTipText = null;
            // 
            // radComboBoxItem13
            // 
            this.radComboBoxItem13.Name = "radComboBoxItem13";
            this.radComboBoxItem13.Text = "Comic Sans MS";
            this.radComboBoxItem13.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem13.ToolTipText = null;
            // 
            // radComboBoxItem14
            // 
            this.radComboBoxItem14.Name = "radComboBoxItem14";
            this.radComboBoxItem14.Text = "Courier New";
            this.radComboBoxItem14.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem14.ToolTipText = null;
            // 
            // radComboBoxItem15
            // 
            this.radComboBoxItem15.Name = "radComboBoxItem15";
            this.radComboBoxItem15.Text = "Georgia";
            this.radComboBoxItem15.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem15.ToolTipText = null;
            // 
            // radComboBoxItem16
            // 
            this.radComboBoxItem16.Name = "radComboBoxItem16";
            this.radComboBoxItem16.Text = "Tahoma";
            this.radComboBoxItem16.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem16.ToolTipText = null;
            // 
            // radComboBoxItem17
            // 
            this.radComboBoxItem17.Name = "radComboBoxItem17";
            this.radComboBoxItem17.Text = "Times New Roman";
            this.radComboBoxItem17.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem17.ToolTipText = null;
            // 
            // radComboBoxItem18
            // 
            this.radComboBoxItem18.Name = "radComboBoxItem18";
            this.radComboBoxItem18.Text = "Verdana";
            this.radComboBoxItem18.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem18.ToolTipText = null;
            // 
            // radRibbonBarButtonGroup9
            // 
            this.radRibbonBarButtonGroup9.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.comboFontSize2,
            this.btnFontDecrease2,
            this.btnFontIncrease2});
            this.radRibbonBarButtonGroup9.Name = "radRibbonBarButtonGroup9";
            this.radRibbonBarButtonGroup9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radRibbonBarButtonGroup9.ShowBackColor = true;
            this.radRibbonBarButtonGroup9.ShowBorder = true;
            this.radRibbonBarButtonGroup9.Text = "radRibbonBarButtonGroup9";
            // 
            // comboFontSize2
            // 
            this.comboFontSize2.ArrowButtonMinWidth = 16;
            this.comboFontSize2.AutoSize = false;
            this.comboFontSize2.Bounds = new System.Drawing.Rectangle(0, 0, 50, 21);
            this.comboFontSize2.DefaultValue = null;
            this.comboFontSize2.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.comboFontSize2.EditorElement = this.comboFontSize2;
            this.comboFontSize2.Focusable = true;
            this.comboFontSize2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radComboBoxItem25,
            this.radComboBoxItem26,
            this.radComboBoxItem27,
            this.radComboBoxItem28});
            this.comboFontSize2.MaxSize = new System.Drawing.Size(140, 0);
            this.comboFontSize2.MaxValue = null;
            this.comboFontSize2.MinSize = new System.Drawing.Size(140, 0);
            this.comboFontSize2.MinValue = null;
            this.comboFontSize2.Name = "comboFontSize2";
            this.comboFontSize2.NullValue = null;
            this.comboFontSize2.OwnerOffset = 0;
            this.comboFontSize2.Padding = new System.Windows.Forms.Padding(1);
            this.comboFontSize2.ReadOnly = false;
            this.comboFontSize2.Text = "10";
            this.comboFontSize2.ToolTipText = null;
            this.comboFontSize2.Value = null;
            this.comboFontSize2.TextChanged += new System.EventHandler(this.comboFontSize2_TextChanged);
            // 
            // radComboBoxItem25
            // 
            this.radComboBoxItem25.Name = "radComboBoxItem25";
            this.radComboBoxItem25.Text = "8";
            this.radComboBoxItem25.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem25.ToolTipText = null;
            // 
            // radComboBoxItem26
            // 
            this.radComboBoxItem26.Name = "radComboBoxItem26";
            this.radComboBoxItem26.Text = "10";
            this.radComboBoxItem26.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem26.ToolTipText = null;
            // 
            // radComboBoxItem27
            // 
            this.radComboBoxItem27.Name = "radComboBoxItem27";
            this.radComboBoxItem27.Text = "13";
            this.radComboBoxItem27.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem27.ToolTipText = null;
            // 
            // radComboBoxItem28
            // 
            this.radComboBoxItem28.Name = "radComboBoxItem28";
            this.radComboBoxItem28.Text = "18";
            this.radComboBoxItem28.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem28.ToolTipText = null;
            // 
            // btnFontDecrease2
            // 
            this.btnFontDecrease2.CanFocus = true;
            this.btnFontDecrease2.Class = "ButtonElement";
            this.btnFontDecrease2.Image = global::InfoCenter.Properties.Resources.imgDecreaseFont16;
            this.btnFontDecrease2.Margin = new System.Windows.Forms.Padding(2);
            this.btnFontDecrease2.Name = "btnFontDecrease2";
            this.btnFontDecrease2.Padding = new System.Windows.Forms.Padding(2);
            this.btnFontDecrease2.ShowBorder = false;
            this.btnFontDecrease2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFontDecrease2.ToolTipText = null;
            this.btnFontDecrease2.Click += new System.EventHandler(this.btnFontDecrease2_Click);
            // 
            // btnFontIncrease2
            // 
            this.btnFontIncrease2.CanFocus = true;
            this.btnFontIncrease2.Class = "ButtonElement";
            this.btnFontIncrease2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnFontIncrease2.Image = global::InfoCenter.Properties.Resources.imgIncreaseFont16;
            this.btnFontIncrease2.Margin = new System.Windows.Forms.Padding(2);
            this.btnFontIncrease2.Name = "btnFontIncrease2";
            this.btnFontIncrease2.Padding = new System.Windows.Forms.Padding(2);
            this.btnFontIncrease2.ShowBorder = false;
            this.btnFontIncrease2.Text = "radButtonElement3";
            this.btnFontIncrease2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFontIncrease2.ToolTipText = null;
            this.btnFontIncrease2.Click += new System.EventHandler(this.btnFontIncrease2_Click);
            // 
            // radRibbonBarButtonGroup4
            // 
            this.radRibbonBarButtonGroup4.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.radRibbonBarButtonGroup4.Name = "radRibbonBarButtonGroup4";
            this.radRibbonBarButtonGroup4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radRibbonBarButtonGroup4.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.radRibbonBarButtonGroup4.ShowBackColor = true;
            this.radRibbonBarButtonGroup4.ShowBorder = true;
            this.radRibbonBarButtonGroup4.Text = "radRibbonBarButtonGroup4";
            this.radRibbonBarButtonGroup4.ToolTipText = null;
            // 
            // ribbonTabCompilator
            // 
            this.ribbonTabCompilator.CanFocus = true;
            this.ribbonTabCompilator.Class = "TabItem";
            // 
            // ribbonTabCompilator.ContentPanel
            // 
            this.ribbonTabCompilator.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ribbonTabCompilator.ContentPanel.CausesValidation = true;
            this.ribbonTabCompilator.IsSelected = true;
            this.ribbonTabCompilator.KeyTip = " ";
            this.ribbonTabCompilator.Name = "ribbonTabCompilator";
            this.ribbonTabCompilator.Text = "Rezolvă";
            this.ribbonTabCompilator.ToolTipText = null;
            this.ribbonTabCompilator.Click += new System.EventHandler(this.ribbonTabCompilator_Click);
            // 
            // radComboBoxItem6
            // 
            this.radComboBoxItem6.Name = "radComboBoxItem6";
            this.radComboBoxItem6.Text = "8";
            this.radComboBoxItem6.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem6.ToolTipText = null;
            // 
            // radComboBoxItem7
            // 
            this.radComboBoxItem7.Name = "radComboBoxItem7";
            this.radComboBoxItem7.Text = "9";
            this.radComboBoxItem7.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem7.ToolTipText = null;
            // 
            // radComboBoxItem8
            // 
            this.radComboBoxItem8.Name = "radComboBoxItem8";
            this.radComboBoxItem8.Text = "10";
            this.radComboBoxItem8.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem8.ToolTipText = null;
            // 
            // radComboBoxItem9
            // 
            this.radComboBoxItem9.Name = "radComboBoxItem9";
            this.radComboBoxItem9.Text = "13";
            this.radComboBoxItem9.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem9.ToolTipText = null;
            // 
            // radComboBoxItem10
            // 
            this.radComboBoxItem10.Name = "radComboBoxItem10";
            this.radComboBoxItem10.Text = "20";
            this.radComboBoxItem10.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem10.ToolTipText = null;
            // 
            // radComboBoxItem11
            // 
            this.radComboBoxItem11.Name = "radComboBoxItem11";
            this.radComboBoxItem11.Text = "25";
            this.radComboBoxItem11.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radComboBoxItem11.ToolTipText = null;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageStart);
            this.tabControlMain.Controls.Add(this.tabPageLectii);
            this.tabControlMain.Controls.Add(this.tabPageProbleme);
            this.tabControlMain.Controls.Add(this.tabPageTeste);
            this.tabControlMain.Controls.Add(this.tabPageCompilator);
            this.tabControlMain.Location = new System.Drawing.Point(0, 118);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(951, 509);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageStart
            // 
            this.tabPageStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageStart.BackgroundImage")));
            this.tabPageStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageStart.Controls.Add(this.label10);
            this.tabPageStart.Controls.Add(this.label9);
            this.tabPageStart.Controls.Add(this.label4);
            this.tabPageStart.Controls.Add(this.label3);
            this.tabPageStart.Controls.Add(this.lblLinkCompilator);
            this.tabPageStart.Controls.Add(this.lblAutentificareProfesor);
            this.tabPageStart.Controls.Add(this.lblLinkTeste);
            this.tabPageStart.Controls.Add(this.lblLinkProbleme);
            this.tabPageStart.Controls.Add(this.lblLinkLectii);
            this.tabPageStart.Controls.Add(this.label2);
            this.tabPageStart.ForeColor = System.Drawing.Color.White;
            this.tabPageStart.Location = new System.Drawing.Point(4, 22);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStart.Size = new System.Drawing.Size(943, 483);
            this.tabPageStart.TabIndex = 4;
            this.tabPageStart.Text = "Pagina de start";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Aici este locul perfect!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(315, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "şi programare,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "înveţi C++";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dacă doreşti să ";
            // 
            // lblLinkCompilator
            // 
            this.lblLinkCompilator.AutoSize = true;
            this.lblLinkCompilator.BackColor = System.Drawing.Color.Transparent;
            this.lblLinkCompilator.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkCompilator.ForeColor = System.Drawing.Color.White;
            this.lblLinkCompilator.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLinkCompilator.Location = new System.Drawing.Point(38, 287);
            this.lblLinkCompilator.Name = "lblLinkCompilator";
            this.lblLinkCompilator.Size = new System.Drawing.Size(63, 19);
            this.lblLinkCompilator.TabIndex = 8;
            this.lblLinkCompilator.TabStop = true;
            this.lblLinkCompilator.Text = "Rezolvă";
            this.lblLinkCompilator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCompilator_LinkClicked);
            // 
            // lblAutentificareProfesor
            // 
            this.lblAutentificareProfesor.AutoSize = true;
            this.lblAutentificareProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutentificareProfesor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutentificareProfesor.ForeColor = System.Drawing.Color.White;
            this.lblAutentificareProfesor.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAutentificareProfesor.Location = new System.Drawing.Point(12, 416);
            this.lblAutentificareProfesor.Name = "lblAutentificareProfesor";
            this.lblAutentificareProfesor.Size = new System.Drawing.Size(454, 16);
            this.lblAutentificareProfesor.TabIndex = 6;
            this.lblAutentificareProfesor.TabStop = true;
            this.lblAutentificareProfesor.Text = "> Dacă sunteţi profesor şi vreţi să modificaţi conţinutul aplicaţiei daţi click a" +
                "ici.";
            this.lblAutentificareProfesor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAutentificareProfesor_LinkClicked);
            // 
            // lblLinkTeste
            // 
            this.lblLinkTeste.AutoSize = true;
            this.lblLinkTeste.BackColor = System.Drawing.Color.Transparent;
            this.lblLinkTeste.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkTeste.ForeColor = System.Drawing.Color.White;
            this.lblLinkTeste.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLinkTeste.Location = new System.Drawing.Point(38, 252);
            this.lblLinkTeste.Name = "lblLinkTeste";
            this.lblLinkTeste.Size = new System.Drawing.Size(47, 19);
            this.lblLinkTeste.TabIndex = 5;
            this.lblLinkTeste.TabStop = true;
            this.lblLinkTeste.Text = "Teste";
            this.lblLinkTeste.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkTest_LinkClicked);
            // 
            // lblLinkProbleme
            // 
            this.lblLinkProbleme.AutoSize = true;
            this.lblLinkProbleme.BackColor = System.Drawing.Color.Transparent;
            this.lblLinkProbleme.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkProbleme.ForeColor = System.Drawing.Color.White;
            this.lblLinkProbleme.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLinkProbleme.Location = new System.Drawing.Point(38, 218);
            this.lblLinkProbleme.Name = "lblLinkProbleme";
            this.lblLinkProbleme.Size = new System.Drawing.Size(76, 19);
            this.lblLinkProbleme.TabIndex = 4;
            this.lblLinkProbleme.TabStop = true;
            this.lblLinkProbleme.Text = "Probleme";
            this.lblLinkProbleme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkProbleme_LinkClicked);
            // 
            // lblLinkLectii
            // 
            this.lblLinkLectii.AutoSize = true;
            this.lblLinkLectii.BackColor = System.Drawing.Color.Transparent;
            this.lblLinkLectii.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkLectii.ForeColor = System.Drawing.Color.White;
            this.lblLinkLectii.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLinkLectii.Location = new System.Drawing.Point(38, 185);
            this.lblLinkLectii.Name = "lblLinkLectii";
            this.lblLinkLectii.Size = new System.Drawing.Size(45, 19);
            this.lblLinkLectii.TabIndex = 3;
            this.lblLinkLectii.TabStop = true;
            this.lblLinkLectii.Text = "Lecţii";
            this.lblLinkLectii.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkLectii_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(338, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bun venit la Info Center!";
            // 
            // tabPageLectii
            // 
            this.tabPageLectii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageLectii.Controls.Add(this.splitContainer3);
            this.tabPageLectii.Location = new System.Drawing.Point(4, 22);
            this.tabPageLectii.Name = "tabPageLectii";
            this.tabPageLectii.Size = new System.Drawing.Size(943, 483);
            this.tabPageLectii.TabIndex = 0;
            this.tabPageLectii.Text = "Lecţii";
            this.tabPageLectii.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gBoxListaLectii);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gBoxContinutLectie);
            this.splitContainer3.Size = new System.Drawing.Size(943, 483);
            this.splitContainer3.SplitterDistance = 222;
            this.splitContainer3.TabIndex = 2;
            // 
            // gBoxListaLectii
            // 
            this.gBoxListaLectii.Controls.Add(this.cuprinsLectii);
            this.gBoxListaLectii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxListaLectii.Location = new System.Drawing.Point(0, 0);
            this.gBoxListaLectii.Name = "gBoxListaLectii";
            this.gBoxListaLectii.Size = new System.Drawing.Size(222, 483);
            this.gBoxListaLectii.TabIndex = 1;
            this.gBoxListaLectii.TabStop = false;
            this.gBoxListaLectii.Text = "Listă lecţii";
            // 
            // cuprinsLectii
            // 
            this.cuprinsLectii.BackColor = System.Drawing.Color.White;
            this.cuprinsLectii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuprinsLectii.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.cuprinsLectii.Location = new System.Drawing.Point(3, 16);
            this.cuprinsLectii.Name = "cuprinsLectii";
            this.cuprinsLectii.Size = new System.Drawing.Size(216, 464);
            this.cuprinsLectii.TabIndex = 0;
            this.cuprinsLectii.Selected += new System.EventHandler(this.cuprinsLectii_Selected);
            // 
            // gBoxContinutLectie
            // 
            this.gBoxContinutLectie.Controls.Add(this.lblStartLectie);
            this.gBoxContinutLectie.Controls.Add(this.navigatorLectii);
            this.gBoxContinutLectie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxContinutLectie.Location = new System.Drawing.Point(0, 0);
            this.gBoxContinutLectie.Name = "gBoxContinutLectie";
            this.gBoxContinutLectie.Size = new System.Drawing.Size(717, 483);
            this.gBoxContinutLectie.TabIndex = 1;
            this.gBoxContinutLectie.TabStop = false;
            this.gBoxContinutLectie.Text = "Conţinutul lecţiei";
            // 
            // lblStartLectie
            // 
            this.lblStartLectie.AutoSize = true;
            this.lblStartLectie.BackColor = System.Drawing.Color.White;
            this.lblStartLectie.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartLectie.ForeColor = System.Drawing.Color.Black;
            this.lblStartLectie.Location = new System.Drawing.Point(138, 193);
            this.lblStartLectie.Name = "lblStartLectie";
            this.lblStartLectie.Size = new System.Drawing.Size(428, 23);
            this.lblStartLectie.TabIndex = 1;
            this.lblStartLectie.Text = "Pentru a începe alege o lecţie din lista din stânga.";
            // 
            // navigatorLectii
            // 
            this.navigatorLectii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigatorLectii.Location = new System.Drawing.Point(3, 16);
            this.navigatorLectii.Margin = new System.Windows.Forms.Padding(0);
            this.navigatorLectii.MinimumSize = new System.Drawing.Size(20, 20);
            this.navigatorLectii.Name = "navigatorLectii";
            this.navigatorLectii.Size = new System.Drawing.Size(711, 464);
            this.navigatorLectii.TabIndex = 0;
            this.navigatorLectii.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPageProbleme
            // 
            this.tabPageProbleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageProbleme.Controls.Add(this.splitContainer1);
            this.tabPageProbleme.Location = new System.Drawing.Point(4, 22);
            this.tabPageProbleme.Name = "tabPageProbleme";
            this.tabPageProbleme.Size = new System.Drawing.Size(943, 483);
            this.tabPageProbleme.TabIndex = 1;
            this.tabPageProbleme.Text = "Probleme";
            this.tabPageProbleme.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlSubProbleme);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(943, 483);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControlSubProbleme
            // 
            this.tabControlSubProbleme.Controls.Add(this.tabPageListaProbleme);
            this.tabControlSubProbleme.Controls.Add(this.tabPageCuvinteCheie);
            this.tabControlSubProbleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSubProbleme.Location = new System.Drawing.Point(0, 0);
            this.tabControlSubProbleme.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlSubProbleme.Name = "tabControlSubProbleme";
            this.tabControlSubProbleme.SelectedIndex = 0;
            this.tabControlSubProbleme.Size = new System.Drawing.Size(259, 483);
            this.tabControlSubProbleme.TabIndex = 2;
            // 
            // tabPageListaProbleme
            // 
            this.tabPageListaProbleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageListaProbleme.Controls.Add(this.listaProbleme);
            this.tabPageListaProbleme.Location = new System.Drawing.Point(4, 22);
            this.tabPageListaProbleme.Name = "tabPageListaProbleme";
            this.tabPageListaProbleme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListaProbleme.Size = new System.Drawing.Size(251, 457);
            this.tabPageListaProbleme.TabIndex = 1;
            this.tabPageListaProbleme.Text = "Probleme";
            // 
            // listaProbleme
            // 
            this.listaProbleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.listaProbleme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderTitluProblema});
            this.listaProbleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaProbleme.GridLines = true;
            listViewGroup1.Header = "(General)";
            listViewGroup1.Name = "groupGeneral";
            this.listaProbleme.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listaProbleme.Location = new System.Drawing.Point(3, 3);
            this.listaProbleme.Name = "listaProbleme";
            this.listaProbleme.Size = new System.Drawing.Size(245, 451);
            this.listaProbleme.TabIndex = 2;
            this.listaProbleme.UseCompatibleStateImageBehavior = false;
            this.listaProbleme.View = System.Windows.Forms.View.Details;
            this.listaProbleme.SelectedIndexChanged += new System.EventHandler(this.listaProbleme_SelectedIndexChanged);
            // 
            // colHeaderTitluProblema
            // 
            this.colHeaderTitluProblema.Text = "Titlu problema";
            this.colHeaderTitluProblema.Width = 225;
            // 
            // tabPageCuvinteCheie
            // 
            this.tabPageCuvinteCheie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageCuvinteCheie.Controls.Add(this.splitContainerCuvinteCheie);
            this.tabPageCuvinteCheie.Location = new System.Drawing.Point(4, 22);
            this.tabPageCuvinteCheie.Name = "tabPageCuvinteCheie";
            this.tabPageCuvinteCheie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCuvinteCheie.Size = new System.Drawing.Size(251, 457);
            this.tabPageCuvinteCheie.TabIndex = 0;
            this.tabPageCuvinteCheie.Text = "Cuvinte Cheie";
            // 
            // splitContainerCuvinteCheie
            // 
            this.splitContainerCuvinteCheie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCuvinteCheie.Location = new System.Drawing.Point(3, 3);
            this.splitContainerCuvinteCheie.Name = "splitContainerCuvinteCheie";
            this.splitContainerCuvinteCheie.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCuvinteCheie.Panel1
            // 
            this.splitContainerCuvinteCheie.Panel1.Controls.Add(this.listaCuvinteCheie);
            // 
            // splitContainerCuvinteCheie.Panel2
            // 
            this.splitContainerCuvinteCheie.Panel2.Controls.Add(this.gBoxRezCautareCuvinte);
            this.splitContainerCuvinteCheie.Panel2Collapsed = true;
            this.splitContainerCuvinteCheie.Size = new System.Drawing.Size(245, 451);
            this.splitContainerCuvinteCheie.SplitterDistance = 220;
            this.splitContainerCuvinteCheie.SplitterWidth = 5;
            this.splitContainerCuvinteCheie.TabIndex = 0;
            // 
            // listaCuvinteCheie
            // 
            this.listaCuvinteCheie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.listaCuvinteCheie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaCuvinteCheie.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.listaCuvinteCheie.Location = new System.Drawing.Point(0, 0);
            this.listaCuvinteCheie.Name = "listaCuvinteCheie";
            this.listaCuvinteCheie.Size = new System.Drawing.Size(245, 451);
            this.listaCuvinteCheie.TabIndex = 2;
            this.listaCuvinteCheie.ThemeName = "ControlDefault";
            this.listaCuvinteCheie.Selected += new System.EventHandler(this.listaCuvinteCheie_Selected);
            // 
            // gBoxRezCautareCuvinte
            // 
            this.gBoxRezCautareCuvinte.Controls.Add(this.listaRezultateCautareProbleme);
            this.gBoxRezCautareCuvinte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxRezCautareCuvinte.Location = new System.Drawing.Point(0, 0);
            this.gBoxRezCautareCuvinte.Name = "gBoxRezCautareCuvinte";
            this.gBoxRezCautareCuvinte.Size = new System.Drawing.Size(150, 46);
            this.gBoxRezCautareCuvinte.TabIndex = 0;
            this.gBoxRezCautareCuvinte.TabStop = false;
            this.gBoxRezCautareCuvinte.Text = "Rezultate căutare:";
            // 
            // listaRezultateCautareProbleme
            // 
            this.listaRezultateCautareProbleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.listaRezultateCautareProbleme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listaRezultateCautareProbleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaRezultateCautareProbleme.GridLines = true;
            listViewGroup2.Header = "(General)";
            listViewGroup2.Name = "groupGeneral";
            this.listaRezultateCautareProbleme.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listaRezultateCautareProbleme.Location = new System.Drawing.Point(3, 16);
            this.listaRezultateCautareProbleme.Name = "listaRezultateCautareProbleme";
            this.listaRezultateCautareProbleme.ShowGroups = false;
            this.listaRezultateCautareProbleme.Size = new System.Drawing.Size(144, 27);
            this.listaRezultateCautareProbleme.TabIndex = 3;
            this.listaRezultateCautareProbleme.UseCompatibleStateImageBehavior = false;
            this.listaRezultateCautareProbleme.View = System.Windows.Forms.View.Details;
            this.listaRezultateCautareProbleme.SelectedIndexChanged += new System.EventHandler(this.listaRezultateCautareProbleme_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titlu problema";
            this.columnHeader2.Width = 225;
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
            this.splitContainer4.Panel1.Controls.Add(this.gBoxCerinta);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.gBoxSursa);
            this.splitContainer4.Size = new System.Drawing.Size(680, 483);
            this.splitContainer4.SplitterDistance = 71;
            this.splitContainer4.TabIndex = 3;
            // 
            // gBoxCerinta
            // 
            this.gBoxCerinta.Controls.Add(this.txtCerintaProblema);
            this.gBoxCerinta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxCerinta.Location = new System.Drawing.Point(0, 0);
            this.gBoxCerinta.Name = "gBoxCerinta";
            this.gBoxCerinta.Size = new System.Drawing.Size(680, 71);
            this.gBoxCerinta.TabIndex = 4;
            this.gBoxCerinta.TabStop = false;
            this.gBoxCerinta.Text = "Cerinţa";
            // 
            // txtCerintaProblema
            // 
            this.txtCerintaProblema.BackColor = System.Drawing.Color.White;
            this.txtCerintaProblema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCerintaProblema.Location = new System.Drawing.Point(3, 16);
            this.txtCerintaProblema.Name = "txtCerintaProblema";
            this.txtCerintaProblema.ReadOnly = true;
            this.txtCerintaProblema.Size = new System.Drawing.Size(674, 52);
            this.txtCerintaProblema.TabIndex = 0;
            this.txtCerintaProblema.Text = "(cerinţă problemă)";
            // 
            // gBoxSursa
            // 
            this.gBoxSursa.Controls.Add(this.txtSursaProblema);
            this.gBoxSursa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxSursa.Location = new System.Drawing.Point(0, 0);
            this.gBoxSursa.Name = "gBoxSursa";
            this.gBoxSursa.Size = new System.Drawing.Size(680, 408);
            this.gBoxSursa.TabIndex = 2;
            this.gBoxSursa.TabStop = false;
            this.gBoxSursa.Text = "Codul sursă:";
            // 
            // txtSursaProblema
            // 
            this.txtSursaProblema.AutoSize = true;
            this.txtSursaProblema.BackColor = System.Drawing.Color.White;
            this.txtSursaProblema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSursaProblema.Location = new System.Drawing.Point(3, 16);
            this.txtSursaProblema.Name = "txtSursaProblema";
            this.txtSursaProblema.Size = new System.Drawing.Size(674, 389);
            this.txtSursaProblema.TabIndex = 0;
            // 
            // tabPageTeste
            // 
            this.tabPageTeste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageTeste.Controls.Add(this.splitContainer6);
            this.tabPageTeste.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeste.Name = "tabPageTeste";
            this.tabPageTeste.Size = new System.Drawing.Size(943, 483);
            this.tabPageTeste.TabIndex = 2;
            this.tabPageTeste.Text = "Teste";
            this.tabPageTeste.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.gBoxListaTeste);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.tabControlSubTeste);
            this.splitContainer6.Size = new System.Drawing.Size(943, 483);
            this.splitContainer6.SplitterDistance = 212;
            this.splitContainer6.TabIndex = 3;
            // 
            // gBoxListaTeste
            // 
            this.gBoxListaTeste.Controls.Add(this.listaTeste);
            this.gBoxListaTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxListaTeste.Location = new System.Drawing.Point(0, 0);
            this.gBoxListaTeste.Name = "gBoxListaTeste";
            this.gBoxListaTeste.Size = new System.Drawing.Size(212, 483);
            this.gBoxListaTeste.TabIndex = 2;
            this.gBoxListaTeste.TabStop = false;
            this.gBoxListaTeste.Text = "Listă Teste:";
            // 
            // listaTeste
            // 
            this.listaTeste.BackColor = System.Drawing.Color.White;
            this.listaTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaTeste.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.listaTeste.Location = new System.Drawing.Point(3, 16);
            this.listaTeste.Name = "listaTeste";
            this.listaTeste.Size = new System.Drawing.Size(206, 464);
            this.listaTeste.TabIndex = 0;
            this.listaTeste.Selected += new System.EventHandler(this.listaTeste_Selected);
            // 
            // tabControlSubTeste
            // 
            this.tabControlSubTeste.Controls.Add(this.tabPageSubiectTest);
            this.tabControlSubTeste.Controls.Add(this.tabPageCorectareTest);
            this.tabControlSubTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSubTeste.Location = new System.Drawing.Point(0, 0);
            this.tabControlSubTeste.Name = "tabControlSubTeste";
            this.tabControlSubTeste.SelectedIndex = 0;
            this.tabControlSubTeste.Size = new System.Drawing.Size(727, 483);
            this.tabControlSubTeste.TabIndex = 4;
            // 
            // tabPageSubiectTest
            // 
            this.tabPageSubiectTest.AutoScroll = true;
            this.tabPageSubiectTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageSubiectTest.Controls.Add(this.btnIntrebareUrmatoare);
            this.tabPageSubiectTest.Controls.Add(this.btnIntrebareAnterioara);
            this.tabPageSubiectTest.Controls.Add(this.lblTitluTest);
            this.tabPageSubiectTest.Controls.Add(this.panelTestFinish);
            this.tabPageSubiectTest.Controls.Add(this.panelWelcomeTest);
            this.tabPageSubiectTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubiectTest.Name = "tabPageSubiectTest";
            this.tabPageSubiectTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubiectTest.Size = new System.Drawing.Size(719, 457);
            this.tabPageSubiectTest.TabIndex = 0;
            this.tabPageSubiectTest.Text = "Subiect";
            // 
            // btnIntrebareUrmatoare
            // 
            this.btnIntrebareUrmatoare.Location = new System.Drawing.Point(559, 218);
            this.btnIntrebareUrmatoare.Name = "btnIntrebareUrmatoare";
            this.btnIntrebareUrmatoare.Size = new System.Drawing.Size(138, 23);
            this.btnIntrebareUrmatoare.TabIndex = 1;
            this.btnIntrebareUrmatoare.Text = "Următoarea întrebare >";
            this.btnIntrebareUrmatoare.Visible = false;
            this.btnIntrebareUrmatoare.Click += new System.EventHandler(this.btnIntrebareUrmatoare_Click);
            // 
            // btnIntrebareAnterioara
            // 
            this.btnIntrebareAnterioara.Location = new System.Drawing.Point(30, 218);
            this.btnIntrebareAnterioara.Name = "btnIntrebareAnterioara";
            this.btnIntrebareAnterioara.Size = new System.Drawing.Size(138, 23);
            this.btnIntrebareAnterioara.TabIndex = 1;
            this.btnIntrebareAnterioara.Text = "< Întrebarea anterioară";
            this.btnIntrebareAnterioara.Visible = false;
            this.btnIntrebareAnterioara.Click += new System.EventHandler(this.btnIntrebareInainte_Click);
            // 
            // lblTitluTest
            // 
            this.lblTitluTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitluTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitluTest.Location = new System.Drawing.Point(3, 3);
            this.lblTitluTest.Name = "lblTitluTest";
            this.lblTitluTest.Size = new System.Drawing.Size(713, 30);
            this.lblTitluTest.TabIndex = 0;
            this.lblTitluTest.Text = "-Titlu-";
            this.lblTitluTest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitluTest.Visible = false;
            // 
            // panelTestFinish
            // 
            this.panelTestFinish.Controls.Add(this.radLabel5);
            this.panelTestFinish.Controls.Add(this.lblTestTerminat);
            this.panelTestFinish.Location = new System.Drawing.Point(68, 68);
            this.panelTestFinish.Name = "panelTestFinish";
            this.panelTestFinish.Size = new System.Drawing.Size(567, 305);
            this.panelTestFinish.TabIndex = 7;
            this.panelTestFinish.Visible = false;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.radLabel5.Location = new System.Drawing.Point(74, 164);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(392, 20);
            this.radLabel5.TabIndex = 6;
            this.radLabel5.Text = "<html>Dacă doreşti să vezi ce ai greşit intră la tabul <b>\"Corectare\"</b>";
            // 
            // lblTestTerminat
            // 
            this.lblTestTerminat.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.lblTestTerminat.Location = new System.Drawing.Point(74, 100);
            this.lblTestTerminat.Name = "lblTestTerminat";
            this.lblTestTerminat.Size = new System.Drawing.Size(405, 44);
            this.lblTestTerminat.TabIndex = 5;
            this.lblTestTerminat.Text = "<html>Ai terminat testul cu un punctaj de: {0} din {1} (total:{3}%)<br>          " +
                "                            Felicitări!<br><br>";
            this.lblTestTerminat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelWelcomeTest
            // 
            this.panelWelcomeTest.Controls.Add(this.label8);
            this.panelWelcomeTest.Controls.Add(this.radLabel3);
            this.panelWelcomeTest.Controls.Add(this.radLabel2);
            this.panelWelcomeTest.Controls.Add(this.radLabel1);
            this.panelWelcomeTest.Location = new System.Drawing.Point(68, 76);
            this.panelWelcomeTest.Name = "panelWelcomeTest";
            this.panelWelcomeTest.Size = new System.Drawing.Size(567, 305);
            this.panelWelcomeTest.TabIndex = 2;
            this.panelWelcomeTest.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label8.Location = new System.Drawing.Point(231, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Baftă!";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.radLabel3.Location = new System.Drawing.Point(20, 80);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(524, 20);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "<html>Pentru a începe testul apasă butonul <b>\"Începe testul\"</b> din meniul de d" +
                "easupra";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.radLabel2.Location = new System.Drawing.Point(60, 130);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(440, 20);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "<html>Dacă vrei să reîncepi testul foloseşte butonul <b>\"Reîncepe testul\"</b>.";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.radLabel1.Location = new System.Drawing.Point(3, 165);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.StretchHorizontally = true;
            this.radLabel1.RootElement.StretchVertically = true;
            this.radLabel1.Size = new System.Drawing.Size(532, 66);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "<html>Când ai terminat de completat testul poţi apăsa butonul <b>\"Corectează test" +
                "ul\"</b><br>pentru a vedea rezultatele.";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabPageCorectareTest
            // 
            this.tabPageCorectareTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageCorectareTest.Controls.Add(this.listaCorectareTest);
            this.tabPageCorectareTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageCorectareTest.Name = "tabPageCorectareTest";
            this.tabPageCorectareTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCorectareTest.Size = new System.Drawing.Size(719, 457);
            this.tabPageCorectareTest.TabIndex = 1;
            this.tabPageCorectareTest.Text = "Corectare";
            // 
            // listaCorectareTest
            // 
            this.listaCorectareTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderNrCrt,
            this.colHeaderRaspAles,
            this.colHeaderRaspCorect,
            this.colHeaderPunctaj});
            this.listaCorectareTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.listaCorectareTest.GridLines = true;
            listViewGroup3.Header = "lstGrupRaspunsuri";
            listViewGroup3.Name = "Raspunsuri";
            listViewGroup4.Header = "lstGrupTotal";
            listViewGroup4.Name = "Punctaj Total";
            this.listaCorectareTest.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.listaCorectareTest.Location = new System.Drawing.Point(3, 3);
            this.listaCorectareTest.MultiSelect = false;
            this.listaCorectareTest.Name = "listaCorectareTest";
            this.listaCorectareTest.ShowGroups = false;
            this.listaCorectareTest.Size = new System.Drawing.Size(608, 451);
            this.listaCorectareTest.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listaCorectareTest.TabIndex = 0;
            this.listaCorectareTest.UseCompatibleStateImageBehavior = false;
            this.listaCorectareTest.View = System.Windows.Forms.View.Details;
            // 
            // colHeaderNrCrt
            // 
            this.colHeaderNrCrt.Text = "Nr. Crt";
            // 
            // colHeaderRaspAles
            // 
            this.colHeaderRaspAles.Text = "Raspuns utilizator";
            this.colHeaderRaspAles.Width = 220;
            // 
            // colHeaderRaspCorect
            // 
            this.colHeaderRaspCorect.Text = "Raspuns Corect";
            this.colHeaderRaspCorect.Width = 220;
            // 
            // colHeaderPunctaj
            // 
            this.colHeaderPunctaj.Text = "Punctaj Acordat";
            this.colHeaderPunctaj.Width = 100;
            // 
            // tabPageCompilator
            // 
            this.tabPageCompilator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageCompilator.Controls.Add(this.splitContainer2);
            this.tabPageCompilator.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompilator.Name = "tabPageCompilator";
            this.tabPageCompilator.Size = new System.Drawing.Size(943, 483);
            this.tabPageCompilator.TabIndex = 3;
            this.tabPageCompilator.Text = "Compilator";
            this.tabPageCompilator.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.txtCodSursa);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControlSubCompilator);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Size = new System.Drawing.Size(943, 483);
            this.splitContainer2.SplitterDistance = 545;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLinkProgramNou);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCodSursa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 36);
            this.panel1.TabIndex = 2;
            // 
            // lblLinkProgramNou
            // 
            this.lblLinkProgramNou.AutoSize = true;
            this.lblLinkProgramNou.Location = new System.Drawing.Point(5, 4);
            this.lblLinkProgramNou.Name = "lblLinkProgramNou";
            this.lblLinkProgramNou.Size = new System.Drawing.Size(67, 13);
            this.lblLinkProgramNou.TabIndex = 3;
            this.lblLinkProgramNou.TabStop = true;
            this.lblLinkProgramNou.Text = "Program nou";
            this.lblLinkProgramNou.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkProgramNou_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(317, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(Folosiţi *.in -> intrare; *.out -> ieşire)";
            // 
            // lblCodSursa
            // 
            this.lblCodSursa.Location = new System.Drawing.Point(5, 19);
            this.lblCodSursa.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodSursa.Name = "lblCodSursa";
            this.lblCodSursa.Size = new System.Drawing.Size(69, 15);
            this.lblCodSursa.TabIndex = 0;
            this.lblCodSursa.Text = "Cod sursă:";
            // 
            // txtCodSursa
            // 
            this.txtCodSursa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodSursa.AutoSize = true;
            this.txtCodSursa.Location = new System.Drawing.Point(0, 42);
            this.txtCodSursa.Name = "txtCodSursa";
            this.txtCodSursa.Size = new System.Drawing.Size(542, 438);
            this.txtCodSursa.TabIndex = 1;
            // 
            // tabControlSubCompilator
            // 
            this.tabControlSubCompilator.Controls.Add(this.tabPageRezultatCompilare);
            this.tabControlSubCompilator.Controls.Add(this.tabPageTestareProgram);
            this.tabControlSubCompilator.Controls.Add(this.tabPageTestareAutomata);
            this.tabControlSubCompilator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSubCompilator.Location = new System.Drawing.Point(5, 5);
            this.tabControlSubCompilator.Name = "tabControlSubCompilator";
            this.tabControlSubCompilator.SelectedIndex = 0;
            this.tabControlSubCompilator.Size = new System.Drawing.Size(384, 473);
            this.tabControlSubCompilator.TabIndex = 0;
            // 
            // tabPageRezultatCompilare
            // 
            this.tabPageRezultatCompilare.Controls.Add(this.txtRezultatCompilare);
            this.tabPageRezultatCompilare.Location = new System.Drawing.Point(4, 22);
            this.tabPageRezultatCompilare.Name = "tabPageRezultatCompilare";
            this.tabPageRezultatCompilare.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRezultatCompilare.Size = new System.Drawing.Size(376, 447);
            this.tabPageRezultatCompilare.TabIndex = 0;
            this.tabPageRezultatCompilare.Text = "Rezultat compilator";
            this.tabPageRezultatCompilare.UseVisualStyleBackColor = true;
            // 
            // txtRezultatCompilare
            // 
            this.txtRezultatCompilare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.txtRezultatCompilare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRezultatCompilare.Location = new System.Drawing.Point(3, 3);
            this.txtRezultatCompilare.Multiline = true;
            this.txtRezultatCompilare.Name = "txtRezultatCompilare";
            this.txtRezultatCompilare.ReadOnly = true;
            this.txtRezultatCompilare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRezultatCompilare.Size = new System.Drawing.Size(370, 441);
            this.txtRezultatCompilare.TabIndex = 0;
            this.txtRezultatCompilare.Click += new System.EventHandler(this.txtRezultatCompilare_Click);
            // 
            // tabPageTestareProgram
            // 
            this.tabPageTestareProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.tabPageTestareProgram.Controls.Add(this.splitContainer5);
            this.tabPageTestareProgram.Location = new System.Drawing.Point(4, 22);
            this.tabPageTestareProgram.Name = "tabPageTestareProgram";
            this.tabPageTestareProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestareProgram.Size = new System.Drawing.Size(376, 447);
            this.tabPageTestareProgram.TabIndex = 1;
            this.tabPageTestareProgram.Text = "Testare manuală";
            this.tabPageTestareProgram.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer5.Size = new System.Drawing.Size(370, 441);
            this.splitContainer5.SplitterDistance = 192;
            this.splitContainer5.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControlDateIntrare);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date de intrare:";
            // 
            // tabControlDateIntrare
            // 
            this.tabControlDateIntrare.Controls.Add(this.tabcin);
            this.tabControlDateIntrare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDateIntrare.Location = new System.Drawing.Point(3, 16);
            this.tabControlDateIntrare.Name = "tabControlDateIntrare";
            this.tabControlDateIntrare.SelectedIndex = 0;
            this.tabControlDateIntrare.Size = new System.Drawing.Size(364, 173);
            this.tabControlDateIntrare.TabIndex = 1;
            // 
            // tabcin
            // 
            this.tabcin.Controls.Add(this.txtDateIntrareProgram);
            this.tabcin.Location = new System.Drawing.Point(4, 22);
            this.tabcin.Name = "tabcin";
            this.tabcin.Padding = new System.Windows.Forms.Padding(3);
            this.tabcin.Size = new System.Drawing.Size(356, 147);
            this.tabcin.TabIndex = 1;
            this.tabcin.Text = "Console In";
            this.tabcin.UseVisualStyleBackColor = true;
            // 
            // txtDateIntrareProgram
            // 
            this.txtDateIntrareProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateIntrareProgram.Location = new System.Drawing.Point(3, 3);
            this.txtDateIntrareProgram.Multiline = true;
            this.txtDateIntrareProgram.Name = "txtDateIntrareProgram";
            this.txtDateIntrareProgram.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDateIntrareProgram.Size = new System.Drawing.Size(350, 141);
            this.txtDateIntrareProgram.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControlDateIesire);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezultat:";
            // 
            // tabControlDateIesire
            // 
            this.tabControlDateIesire.Controls.Add(this.tabcout);
            this.tabControlDateIesire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDateIesire.Location = new System.Drawing.Point(3, 16);
            this.tabControlDateIesire.Name = "tabControlDateIesire";
            this.tabControlDateIesire.SelectedIndex = 0;
            this.tabControlDateIesire.Size = new System.Drawing.Size(364, 226);
            this.tabControlDateIesire.TabIndex = 0;
            // 
            // tabcout
            // 
            this.tabcout.Controls.Add(this.txtRezultatProgram);
            this.tabcout.Location = new System.Drawing.Point(4, 22);
            this.tabcout.Name = "tabcout";
            this.tabcout.Padding = new System.Windows.Forms.Padding(3);
            this.tabcout.Size = new System.Drawing.Size(356, 200);
            this.tabcout.TabIndex = 0;
            this.tabcout.Text = "Console Out";
            this.tabcout.UseVisualStyleBackColor = true;
            // 
            // txtRezultatProgram
            // 
            this.txtRezultatProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.txtRezultatProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRezultatProgram.Location = new System.Drawing.Point(3, 3);
            this.txtRezultatProgram.Multiline = true;
            this.txtRezultatProgram.Name = "txtRezultatProgram";
            this.txtRezultatProgram.ReadOnly = true;
            this.txtRezultatProgram.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRezultatProgram.Size = new System.Drawing.Size(350, 194);
            this.txtRezultatProgram.TabIndex = 1;
            // 
            // tabPageTestareAutomata
            // 
            this.tabPageTestareAutomata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPageTestareAutomata.Controls.Add(this.btnAdaugaTestare);
            this.tabPageTestareAutomata.Controls.Add(this.btnVerifica);
            this.tabPageTestareAutomata.Controls.Add(this.gridVerificare);
            this.tabPageTestareAutomata.Controls.Add(this.lblNoTest);
            this.tabPageTestareAutomata.Location = new System.Drawing.Point(4, 22);
            this.tabPageTestareAutomata.Name = "tabPageTestareAutomata";
            this.tabPageTestareAutomata.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestareAutomata.Size = new System.Drawing.Size(376, 447);
            this.tabPageTestareAutomata.TabIndex = 2;
            this.tabPageTestareAutomata.Text = "Testare predefinită";
            this.tabPageTestareAutomata.UseVisualStyleBackColor = true;
            // 
            // btnAdaugaTestare
            // 
            this.btnAdaugaTestare.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdaugaTestare.Location = new System.Drawing.Point(195, 412);
            this.btnAdaugaTestare.Name = "btnAdaugaTestare";
            this.btnAdaugaTestare.Size = new System.Drawing.Size(175, 23);
            this.btnAdaugaTestare.TabIndex = 2;
            this.btnAdaugaTestare.Text = "Adaugă un test nou";
            this.btnAdaugaTestare.Click += new System.EventHandler(this.btnAdaugaTestare_Click);
            // 
            // btnVerifica
            // 
            this.btnVerifica.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerifica.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSelectate,
            this.radMenuToate});
            this.btnVerifica.Location = new System.Drawing.Point(6, 412);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(176, 23);
            this.btnVerifica.TabIndex = 1;
            this.btnVerifica.Text = "Verifică testele";
            // 
            // radMenuSelectate
            // 
            this.radMenuSelectate.Name = "radMenuSelectate";
            this.radMenuSelectate.Text = "Testele bifate";
            this.radMenuSelectate.Click += new System.EventHandler(this.radMenuSelectate_Click);
            // 
            // radMenuToate
            // 
            this.radMenuToate.Name = "radMenuToate";
            this.radMenuToate.Text = "Toate testele";
            this.radMenuToate.Click += new System.EventHandler(this.radMenuToate_Click);
            // 
            // gridVerificare
            // 
            this.gridVerificare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVerificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.gridVerificare.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridVerificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridVerificare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridVerificare.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.gridVerificare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridVerificare.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.gridVerificare.MasterGridViewTemplate.AddNewRowPosition = Telerik.WinControls.UI.PinnedRowPosition.Bottom;
            this.gridVerificare.MasterGridViewTemplate.AllowAddNewRow = false;
            this.gridVerificare.MasterGridViewTemplate.AllowDeleteRow = false;
            customGridViewTextBoxColumn_11.CustomStruct = null;
            customGridViewTextBoxColumn_11.DataType = typeof(InfoCenter.Classes.UnitateTestare);
            customGridViewTextBoxColumn_11.FieldAlias = "column1";
            customGridViewTextBoxColumn_11.HeaderText = "Nume test";
            customGridViewTextBoxColumn_11.ReadOnly = true;
            customGridViewTextBoxColumn_11.UniqueName = "colNume";
            customGridViewTextBoxColumn_11.Width = 232;
            gridViewCheckBoxColumn1.DataType = typeof(bool);
            gridViewCheckBoxColumn1.FieldAlias = "column2";
            gridViewCheckBoxColumn1.HeaderText = " ";
            gridViewCheckBoxColumn1.UniqueName = "colVerifica";
            gridViewCheckBoxColumn1.Width = 27;
            customGridViewCommandColumn1.DataType = typeof(System.Drawing.Image);
            customGridViewCommandColumn1.DefaultText = " ";
            customGridViewCommandColumn1.FieldAlias = "column3";
            customGridViewCommandColumn1.HeaderText = "Verifică";
            customGridViewCommandColumn1.UniqueName = "colVerific";
            customGridViewCommandColumn1.UseDefaultText = true;
            customGridViewCommandColumn1.Width = 58;
            gridViewImageColumn1.DataType = typeof(System.Drawing.Image);
            gridViewImageColumn1.FieldAlias = "column1";
            gridViewImageColumn1.HeaderText = "Rezultat";
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewImageColumn1.UniqueName = "colRezultat";
            gridViewImageColumn1.Width = 63;
            this.gridVerificare.MasterGridViewTemplate.Columns.Add(customGridViewTextBoxColumn_11);
            this.gridVerificare.MasterGridViewTemplate.Columns.Add(gridViewCheckBoxColumn1);
            this.gridVerificare.MasterGridViewTemplate.Columns.Add(customGridViewCommandColumn1);
            this.gridVerificare.MasterGridViewTemplate.Columns.Add(gridViewImageColumn1);
            this.gridVerificare.MasterGridViewTemplate.EnableSorting = false;
            this.gridVerificare.MasterGridViewTemplate.ShowRowHeaderColumn = false;
            this.gridVerificare.Name = "gridVerificare";
            this.gridVerificare.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.None;
            this.gridVerificare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridVerificare.ShowGroupPanel = false;
            this.gridVerificare.Size = new System.Drawing.Size(528, 403);
            this.gridVerificare.TabIndex = 0;
            this.gridVerificare.Text = "radGridViewPreview";
            this.gridVerificare.Visible = false;
            this.gridVerificare.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridVerificare_CellDoubleClick);
            this.gridVerificare.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.gridVerificare_CellFormatting);
            this.gridVerificare.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gridVerificare_CommandCellClick);
            // 
            // lblNoTest
            // 
            this.lblNoTest.BackColor = System.Drawing.Color.Transparent;
            this.lblNoTest.Location = new System.Drawing.Point(93, 130);
            this.lblNoTest.Name = "lblNoTest";
            this.lblNoTest.Size = new System.Drawing.Size(215, 38);
            this.lblNoTest.TabIndex = 0;
            this.lblNoTest.Text = "Nu există nici un test asociat problemei selectate sau creat de utilizator";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titlu";
            this.columnHeader1.Width = 178;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Salvează codul sursă";
            // 
            // ribbonBar
            // 
            this.ribbonBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            radRibbonBarCommandTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarChunk2,
            this.radRibbonBarChunk3});
            radRibbonBarCommandTab1.Tab = this.ribbonTabStart;
            radRibbonBarCommandTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radChunkInfLectie});
            radRibbonBarCommandTab2.Tab = this.ribbonTabLectii;
            radRibbonBarCommandTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radChunkInfoProblema,
            this.radChunkCautareProbleme,
            this.radChunkActiuniProblema});
            radRibbonBarCommandTab3.Tab = this.ribbonTabProbleme;
            radRibbonBarCommandTab4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radChunkInformatiiTest,
            this.radChunkActiuniTest});
            radRibbonBarCommandTab4.Tab = this.ribbonTabTeste;
            radRibbonBarCommandTab5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radChunkActiuniCompilator,
            this.radRibbonBarChunk1});
            radRibbonBarCommandTab5.Tab = this.ribbonTabCompilator;
            this.ribbonBar.CommandTabs.AddRange(new Telerik.WinControls.UI.RadRibbonBarCommandTab[] {
            radRibbonBarCommandTab1,
            radRibbonBarCommandTab2,
            radRibbonBarCommandTab3,
            radRibbonBarCommandTab4,
            radRibbonBarCommandTab5});
            this.ribbonBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar.EnableKeyMap = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.ribbonBar.ExitButton.ButtonElement.Class = "RadMenuButtonElement";
            this.ribbonBar.ExitButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ribbonBar.ExitButton.Image = global::InfoCenter.Properties.Resources.imgClose32;
            this.ribbonBar.ExitButton.Text = "Închide Info Center";
            this.ribbonBar.ExitButton.Click += new System.EventHandler(this.radMenuIesire_Click);
            this.ribbonBar.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar.MinimumSize = new System.Drawing.Size(0, 141);
            this.ribbonBar.Name = "ribbonBar";
            // 
            // 
            // 
            // 
            // 
            // 
            this.ribbonBar.OptionsButton.ButtonElement.Class = "RadMenuButtonElement";
            this.ribbonBar.OptionsButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ribbonBar.OptionsButton.Image = global::InfoCenter.Properties.Resources.imgOptiuni;
            this.ribbonBar.OptionsButton.Text = "Opţiuni";
            this.ribbonBar.OptionsButton.Click += new System.EventHandler(this.radMenuOptiuni_Click);
            this.ribbonBar.QuickAccessToolbarBelowRibbon = false;
            // 
            // 
            // 
            this.ribbonBar.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.ribbonBar.RootElement.MinSize = new System.Drawing.Size(0, 141);
            this.ribbonBar.RootElement.ToolTipText = null;
            this.ribbonBar.Size = new System.Drawing.Size(950, 141);
            this.ribbonBar.StartButtonImage = global::InfoCenter.Properties.Resources.logoRibbon;
            this.ribbonBar.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuReloadInfo,
            this.radMenuUpdateApplication});
            this.ribbonBar.StartMenuWidth = 400;
            this.ribbonBar.TabIndex = 1;
            this.ribbonBar.Text = "Info Center";
            this.ribbonBar.ThemeName = "ControlDefault";
            // 
            // radMenuReloadInfo
            // 
            this.radMenuReloadInfo.Image = global::InfoCenter.Properties.Resources.imgRefresh32;
            this.radMenuReloadInfo.Name = "radMenuReloadInfo";
            this.radMenuReloadInfo.Text = "Re-încară informaţiile";
            this.radMenuReloadInfo.Click += new System.EventHandler(this.radMenuReloadInfo_Click);
            // 
            // radMenuUpdateApplication
            // 
            this.radMenuUpdateApplication.Image = global::InfoCenter.Properties.Resources.imgBacup;
            this.radMenuUpdateApplication.Name = "radMenuUpdateApplication";
            this.radMenuUpdateApplication.Text = "Actualizează aplicaţia";
            this.radMenuUpdateApplication.Click += new System.EventHandler(this.radMenuUpdateApplication_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = true;
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.toolStripStatus,
            this.toolStripProgressBar,
            this.radLabelCopyright,
            this.toolStripConnectedMode,
            this.toolStripDataOra});
            this.statusStrip.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Overflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 625);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(950, 25);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "radStatusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatus.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripStatus.Name = "toolStripStatus";
            this.statusStrip.SetSpring(this.toolStripStatus, false);
            this.toolStripStatus.Text = "Stare program";
            this.toolStripStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolStripStatus.Click += new System.EventHandler(this.toolStripStatus_Click);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolStripProgressBar.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.toolStripProgressBar.ClipDrawing = true;
            this.toolStripProgressBar.DefaultSize = new System.Drawing.Size(130, 16);
            this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.ShowProgressIndicator = true;
            this.statusStrip.SetSpring(this.toolStripProgressBar, false);
            this.toolStripProgressBar.Text = "0%";
            this.toolStripProgressBar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolStripProgressBar.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radLabelCopyright
            // 
            this.radLabelCopyright.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLabelCopyright.AutoSize = false;
            this.radLabelCopyright.Bounds = new System.Drawing.Rectangle(0, 0, 380, 19);
            this.radLabelCopyright.Margin = new System.Windows.Forms.Padding(1);
            this.radLabelCopyright.Name = "radLabelCopyright";
            this.statusStrip.SetSpring(this.radLabelCopyright, false);
            this.radLabelCopyright.Text = "                          | Copyright 2008-2009 © Timotei Dolean |";
            this.radLabelCopyright.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLabelCopyright.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radLabelCopyright.Click += new System.EventHandler(this.toolStripLabelCopyright_Click);
            // 
            // toolStripConnectedMode
            // 
            this.toolStripConnectedMode.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripConnectedMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripConnectedMode.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripConnectedMode.Name = "toolStripConnectedMode";
            this.statusStrip.SetSpring(this.toolStripConnectedMode, false);
            this.toolStripConnectedMode.Text = "Mod neconectat";
            this.toolStripConnectedMode.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // toolStripDataOra
            // 
            this.toolStripDataOra.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripDataOra.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripDataOra.Name = "toolStripDataOra";
            this.statusStrip.SetSpring(this.toolStripDataOra, false);
            this.toolStripDataOra.Text = "Data curentă:";
            this.toolStripDataOra.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFontItalic2
            // 
            this.btnFontItalic2.CanFocus = true;
            this.btnFontItalic2.Class = "ButtonElement";
            this.btnFontItalic2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnFontItalic2.Image = global::InfoCenter.Properties.Resources.imgItalic16;
            this.btnFontItalic2.IsChecked = false;
            this.btnFontItalic2.Margin = new System.Windows.Forms.Padding(2);
            this.btnFontItalic2.Name = "btnFontItalic2";
            this.btnFontItalic2.Padding = new System.Windows.Forms.Padding(2);
            this.btnFontItalic2.ShowBorder = false;
            this.btnFontItalic2.Text = "radButtonElement4";
            this.btnFontItalic2.ToolTipText = null;
            // 
            // btnFontBold2
            // 
            this.btnFontBold2.CanFocus = true;
            this.btnFontBold2.Class = "ButtonElement";
            this.btnFontBold2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnFontBold2.Image = global::InfoCenter.Properties.Resources.imgBold16;
            this.btnFontBold2.IsChecked = false;
            this.btnFontBold2.Margin = new System.Windows.Forms.Padding(2);
            this.btnFontBold2.Name = "btnFontBold2";
            this.btnFontBold2.Padding = new System.Windows.Forms.Padding(2);
            this.btnFontBold2.ShowBorder = false;
            this.btnFontBold2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFontBold2.ToolTipText = null;
            // 
            // radMenuButtonItem1
            // 
            // 
            // 
            // 
            this.radMenuButtonItem1.ButtonElement.Class = "RadMenuButtonElement";
            this.radMenuButtonItem1.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.Text = "Re-încarcă informaţiile";
            this.radMenuButtonItem1.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // testTimer
            // 
            this.testTimer._started = false;
            this.testTimer.Hours = 0;
            this.testTimer.Interval = 1000;
            this.testTimer.Minutes = 0;
            this.testTimer.Seconds = 0;
            this.testTimer.Tick += new System.EventHandler(this.testTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ribbonBar);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::InfoCenter.Properties.Resources.iconInfoCenter;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info Center";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.comboCautaProblema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCautaCuvantCheie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboFont2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboFontSize2)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            this.tabPageStart.PerformLayout();
            this.tabPageLectii.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.gBoxListaLectii.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuprinsLectii)).EndInit();
            this.gBoxContinutLectie.ResumeLayout(false);
            this.gBoxContinutLectie.PerformLayout();
            this.tabPageProbleme.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControlSubProbleme.ResumeLayout(false);
            this.tabPageListaProbleme.ResumeLayout(false);
            this.tabPageCuvinteCheie.ResumeLayout(false);
            this.splitContainerCuvinteCheie.Panel1.ResumeLayout(false);
            this.splitContainerCuvinteCheie.Panel2.ResumeLayout(false);
            this.splitContainerCuvinteCheie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaCuvinteCheie)).EndInit();
            this.gBoxRezCautareCuvinte.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.gBoxCerinta.ResumeLayout(false);
            this.gBoxSursa.ResumeLayout(false);
            this.gBoxSursa.PerformLayout();
            this.tabPageTeste.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            this.gBoxListaTeste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaTeste)).EndInit();
            this.tabControlSubTeste.ResumeLayout(false);
            this.tabPageSubiectTest.ResumeLayout(false);
            this.tabPageSubiectTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIntrebareUrmatoare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIntrebareAnterioara)).EndInit();
            this.panelTestFinish.ResumeLayout(false);
            this.panelTestFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTestTerminat)).EndInit();
            this.panelWelcomeTest.ResumeLayout(false);
            this.panelWelcomeTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.tabPageCorectareTest.ResumeLayout(false);
            this.tabPageCompilator.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlSubCompilator.ResumeLayout(false);
            this.tabPageRezultatCompilare.ResumeLayout(false);
            this.tabPageRezultatCompilare.PerformLayout();
            this.tabPageTestareProgram.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControlDateIntrare.ResumeLayout(false);
            this.tabcin.ResumeLayout(false);
            this.tabcin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControlDateIesire.ResumeLayout(false);
            this.tabcout.ResumeLayout(false);
            this.tabcout.PerformLayout();
            this.tabPageTestareAutomata.ResumeLayout(false);
            this.tabPageTestareAutomata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdaugaTestare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVerificare.MasterGridViewTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVerificare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private Telerik.WinControls.UI.RadRibbonBar ribbonBar;
        private Telerik.WinControls.UI.TabItem ribbonTabLectii;
        private Telerik.WinControls.UI.TabItem ribbonTabProbleme;
        private Telerik.WinControls.UI.TabItem ribbonTabTeste;
        private Telerik.WinControls.UI.RadRibbonBarChunk radChunkCautareProbleme;
        private Telerik.WinControls.UI.RadRibbonBarChunk radChunkInformatiiTest;
        private Telerik.WinControls.UI.TabItem ribbonTabCompilator;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radGroup1;
        private Telerik.WinControls.UI.ActionButtonElement btnIncepeTest;
        private Telerik.WinControls.UI.ActionButtonElement btnResetTest;
        private Telerik.WinControls.UI.RadRibbonBarChunk radChunkActiuniTest;
        private Telerik.WinControls.UI.RadLabelElement lblTimpScurs;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radGroup2;
        private Telerik.WinControls.UI.RadLabelElement lblPunctaj;
        private Telerik.WinControls.UI.ActionButtonElement btnCorecteazaTest;
        private Telerik.WinControls.UI.RadRibbonBarChunk radChunkInfoProblema;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radGroup4;
        private Telerik.WinControls.UI.RadLabelElement lblDificultateProblema;
        private Telerik.WinControls.UI.RadRibbonBarChunk radChunkActiuniProblema;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radGroup5;
        private Telerik.WinControls.UI.RadSplitButtonElement btnSalvare;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radGroup7;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radGroup10;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radGroup11;
        private Telerik.WinControls.UI.RadComboBoxElement comboCautaProblema;
        private Telerik.WinControls.UI.RadButtonElement btnCautaProbleme;
        private Telerik.WinControls.UI.RadComboBoxElement comboCautaCuvantCheie;
        private Telerik.WinControls.UI.RadButtonElement btnCautaCuvantCheie;
        private Telerik.WinControls.UI.ActionButtonElement btnMaresteSursa;
        private Telerik.WinControls.UI.RadLabelElement btnLblNivelTest;
        private Telerik.WinControls.UI.RadRibbonBarChunk radChunkInfLectie;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radGroup13;
        private Telerik.WinControls.UI.RadButtonElement btnProblemeLectie;
        private Telerik.WinControls.UI.RadButtonElement btnTesteLectie;
        private Telerik.WinControls.UI.RadLabelElement lblNivelLectie;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageLectii;
        private System.Windows.Forms.TabPage tabPageProbleme;
        private System.Windows.Forms.TabPage tabPageTeste;
        private System.Windows.Forms.TabPage tabPageCompilator;
        private System.Windows.Forms.TabControl tabControlSubProbleme;
        private System.Windows.Forms.TabPage tabPageCuvinteCheie;
        private System.Windows.Forms.GroupBox gBoxContinutLectie;
        private System.Windows.Forms.WebBrowser navigatorLectii;
        private Telerik.WinControls.UI.RadButtonElement btnRezolvaProblema;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem6;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem7;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem8;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem9;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem10;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem11;
        private Telerik.WinControls.UI.RadButtonElement btnMaresteCerinta;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radGroup15;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private CustomTimer testTimer;
        private Telerik.WinControls.UI.RadRibbonBarChunk radChunkActiuniCompilator;
        private Telerik.WinControls.UI.RadButtonElement btnToateProblemele;
        private Telerik.WinControls.UI.RadButtonElement btnToateCuvinteleCheie;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gBoxSursa;
        private InfoCenter.Controls.CompilerTextBox txtSursaProblema;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblCodSursa;
        private InfoCenter.Controls.CompilerTextBox txtCodSursa;
        private System.Windows.Forms.TabControl tabControlSubCompilator;
        private System.Windows.Forms.TabPage tabPageRezultatCompilare;
        private System.Windows.Forms.TabPage tabPageTestareProgram;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPageTestareAutomata;
        private Telerik.WinControls.UI.RadButtonElement btnTestareProgram;
        private System.Windows.Forms.TextBox txtRezultatCompilare;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButtonElement btnTestareAutomaticaProgram;
        private Telerik.WinControls.UI.RadRibbonBarChunk radRibbonBarChunk1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup3;
        private Telerik.WinControls.UI.RadComboBoxElement comboFont2;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup4;
        private Telerik.WinControls.UI.RadButtonElement btnFontDecrease2;
        private Telerik.WinControls.UI.RadButtonElement btnFontIncrease2;
        private Telerik.WinControls.UI.RadComboBoxElement comboFontSize2;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem12;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem13;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem14;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem15;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem16;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem17;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem18;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem25;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem26;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem27;
        private Telerik.WinControls.UI.RadComboBoxItem radComboBoxItem28;
        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadLabelElement toolStripStatus;
        private Telerik.WinControls.UI.RadProgressBarElement toolStripProgressBar;
        private Telerik.WinControls.UI.RadLabelElement radLabelCopyright;
        private Telerik.WinControls.UI.RadLabelElement toolStripConnectedMode;
        private Telerik.WinControls.UI.RadLabelElement toolStripDataOra;
        private Telerik.WinControls.UI.RadMenuItem radMenuSalvare;
        private Telerik.WinControls.UI.RadMenuItem radMenuSalvareCa;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gBoxListaLectii;
        private Telerik.WinControls.UI.RadTreeView cuprinsLectii;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox gBoxCerinta;
        private System.Windows.Forms.RichTextBox txtCerintaProblema;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup9;
        private Telerik.WinControls.UI.RadToggleButtonElement btnFontItalic2;
        private Telerik.WinControls.UI.RadToggleButtonElement btnFontBold2;
        private Telerik.WinControls.UI.RadButtonElement btnExecuta;
        private Telerik.WinControls.UI.RadGridView gridVerificare;
        private Telerik.WinControls.UI.RadDropDownButton btnVerifica;
        private Telerik.WinControls.UI.RadMenuItem radMenuSelectate;
        private Telerik.WinControls.UI.RadMenuItem radMenuToate;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.GroupBox gBoxListaTeste;
        private Telerik.WinControls.UI.RadTreeView listaTeste;
        private System.Windows.Forms.TabControl tabControlSubTeste;
        private System.Windows.Forms.TabPage tabPageSubiectTest;
        private System.Windows.Forms.Label lblTitluTest;
        private System.Windows.Forms.TabPage tabPageCorectareTest;
        private System.Windows.Forms.ListView listaCorectareTest;
        private System.Windows.Forms.ColumnHeader colHeaderNrCrt;
        private System.Windows.Forms.ColumnHeader colHeaderRaspAles;
        private System.Windows.Forms.ColumnHeader colHeaderRaspCorect;
        private System.Windows.Forms.ColumnHeader colHeaderPunctaj;
        private System.Windows.Forms.TabControl tabControlDateIntrare;
        private System.Windows.Forms.TabPage tabcin;
        private System.Windows.Forms.TextBox txtDateIntrareProgram;
        private System.Windows.Forms.TabControl tabControlDateIesire;
        private System.Windows.Forms.TabPage tabcout;
        private System.Windows.Forms.TextBox txtRezultatProgram;
        private Telerik.WinControls.UI.RadButton btnAdaugaTestare;
        private System.Windows.Forms.SplitContainer splitContainerCuvinteCheie;
        private Telerik.WinControls.UI.RadTreeView listaCuvinteCheie;
        private System.Windows.Forms.GroupBox gBoxRezCautareCuvinte;
        private Telerik.WinControls.UI.RadButtonElement btnSaveCodSursa;
        private System.Windows.Forms.Label lblNoTest;
        private Telerik.WinControls.UI.TabItem ribbonTabStart;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblLinkLectii;
        private Telerik.WinControls.UI.RadRibbonBarChunk radRibbonBarChunk2;
        private System.Windows.Forms.LinkLabel lblLinkTeste;
        private System.Windows.Forms.LinkLabel lblLinkProbleme;
        private System.Windows.Forms.LinkLabel lblAutentificareProfesor;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup5;
        private Telerik.WinControls.UI.RadLabelElement lblNumarLectii;
        private Telerik.WinControls.UI.RadLabelElement lblNumarProbleme;
        private Telerik.WinControls.UI.RadLabelElement lblNumarTeste;
        private System.Windows.Forms.TabPage tabPageListaProbleme;
        private System.Windows.Forms.ListView listaProbleme;
        private System.Windows.Forms.ColumnHeader colHeaderTitluProblema;
        private System.Windows.Forms.ListView listaRezultateCautareProbleme;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.LinkLabel lblLinkCompilator;
        private Telerik.WinControls.UI.RadButton btnIntrebareUrmatoare;
        private Telerik.WinControls.UI.RadButton btnIntrebareAnterioara;
        private System.Windows.Forms.Panel panelWelcomeTest;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Label label8;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.Panel panelTestFinish;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel lblTestTerminat;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuReloadInfo;
        private System.Windows.Forms.Label lblStartLectie;
        private Telerik.WinControls.UI.RadRibbonBarChunk radRibbonBarChunk3;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement btnFragmenteDeCod;
        private Telerik.WinControls.UI.RadMenuItem radMenuUpdateApplication;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblLinkProgramNou;
    }
}