namespace StockBonBerger.Forms
{
    partial class FormApprov
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
            this.GbDeatilApprov = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.GcDApprov = new DevExpress.XtraGrid.GridControl();
            this.GvDApprov = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GColCodeC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColDFss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColDesignPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColQte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColCodeCategC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GbControlDApprov = new System.Windows.Forms.GroupBox();
            this.TxtPrixApprov = new System.Windows.Forms.MaskedTextBox();
            this.TxtQteApprov = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbPiece = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDeleteDApprov = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSaveDApprov = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNewDApprov = new DevExpress.XtraEditors.SimpleButton();
            this.TxtCodeDetailApprov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GbApprov = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GcApprov = new DevExpress.XtraGrid.GridControl();
            this.GvApprov = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColFss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbFss = new System.Windows.Forms.ComboBox();
            this.BtnDeleteApprov = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSaveApprov = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNewApprov = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodeApprov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GColCodeApprov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GbDeatilApprov.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcDApprov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDApprov)).BeginInit();
            this.GbControlDApprov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.GbApprov.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcApprov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvApprov)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbDeatilApprov
            // 
            this.GbDeatilApprov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbDeatilApprov.Controls.Add(this.groupBox6);
            this.GbDeatilApprov.Controls.Add(this.GbControlDApprov);
            this.GbDeatilApprov.Location = new System.Drawing.Point(12, 171);
            this.GbDeatilApprov.Name = "GbDeatilApprov";
            this.GbDeatilApprov.Size = new System.Drawing.Size(760, 278);
            this.GbDeatilApprov.TabIndex = 5;
            this.GbDeatilApprov.TabStop = false;
            this.GbDeatilApprov.Text = "Détail approvisionnement";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.GcDApprov);
            this.groupBox6.Location = new System.Drawing.Point(13, 159);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(735, 113);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // GcDApprov
            // 
            this.GcDApprov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcDApprov.Location = new System.Drawing.Point(3, 16);
            this.GcDApprov.MainView = this.GvDApprov;
            this.GcDApprov.Name = "GcDApprov";
            this.GcDApprov.Size = new System.Drawing.Size(729, 94);
            this.GcDApprov.TabIndex = 6;
            this.GcDApprov.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvDApprov});
            this.GcDApprov.DoubleClick += new System.EventHandler(this.GcDApprov_DoubleClick);
            // 
            // GvDApprov
            // 
            this.GvDApprov.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColCodeC,
            this.GColDFss,
            this.GColDesignPiece,
            this.GColQte,
            this.GColPrix,
            this.GColCodeCategC,
            this.GColCodeApprov});
            this.GvDApprov.GridControl = this.GcDApprov;
            this.GvDApprov.Name = "GvDApprov";
            this.GvDApprov.OptionsBehavior.Editable = false;
            this.GvDApprov.OptionsSelection.MultiSelect = true;
            this.GvDApprov.OptionsView.ShowGroupPanel = false;
            // 
            // GColCodeC
            // 
            this.GColCodeC.Caption = "Code";
            this.GColCodeC.FieldName = "idDApv";
            this.GColCodeC.Name = "GColCodeC";
            this.GColCodeC.Visible = true;
            this.GColCodeC.VisibleIndex = 0;
            // 
            // GColDFss
            // 
            this.GColDFss.Caption = "Fournisseur";
            this.GColDFss.FieldName = "fournisseur";
            this.GColDFss.Name = "GColDFss";
            this.GColDFss.Visible = true;
            this.GColDFss.VisibleIndex = 1;
            // 
            // GColDesignPiece
            // 
            this.GColDesignPiece.Caption = "Pièce";
            this.GColDesignPiece.FieldName = "designation";
            this.GColDesignPiece.Name = "GColDesignPiece";
            this.GColDesignPiece.Visible = true;
            this.GColDesignPiece.VisibleIndex = 2;
            // 
            // GColQte
            // 
            this.GColQte.AppearanceCell.Options.UseTextOptions = true;
            this.GColQte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.GColQte.Caption = "Quantité";
            this.GColQte.FieldName = "quantite";
            this.GColQte.Name = "GColQte";
            this.GColQte.Visible = true;
            this.GColQte.VisibleIndex = 3;
            // 
            // GColPrix
            // 
            this.GColPrix.AppearanceCell.Options.UseTextOptions = true;
            this.GColPrix.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.GColPrix.Caption = "P.U.";
            this.GColPrix.FieldName = "prix";
            this.GColPrix.Name = "GColPrix";
            this.GColPrix.Visible = true;
            this.GColPrix.VisibleIndex = 4;
            // 
            // GColCodeCategC
            // 
            this.GColCodeCategC.Caption = "CodeCategClient";
            this.GColCodeCategC.FieldName = "idCategC";
            this.GColCodeCategC.Name = "GColCodeCategC";
            // 
            // GbControlDApprov
            // 
            this.GbControlDApprov.Controls.Add(this.TxtPrixApprov);
            this.GbControlDApprov.Controls.Add(this.TxtQteApprov);
            this.GbControlDApprov.Controls.Add(this.label7);
            this.GbControlDApprov.Controls.Add(this.separatorControl1);
            this.GbControlDApprov.Controls.Add(this.label6);
            this.GbControlDApprov.Controls.Add(this.CmbPiece);
            this.GbControlDApprov.Controls.Add(this.label5);
            this.GbControlDApprov.Controls.Add(this.BtnDeleteDApprov);
            this.GbControlDApprov.Controls.Add(this.BtnSaveDApprov);
            this.GbControlDApprov.Controls.Add(this.BtnNewDApprov);
            this.GbControlDApprov.Controls.Add(this.TxtCodeDetailApprov);
            this.GbControlDApprov.Controls.Add(this.label4);
            this.GbControlDApprov.Location = new System.Drawing.Point(13, 19);
            this.GbControlDApprov.Name = "GbControlDApprov";
            this.GbControlDApprov.Size = new System.Drawing.Size(747, 134);
            this.GbControlDApprov.TabIndex = 1;
            this.GbControlDApprov.TabStop = false;
            // 
            // TxtPrixApprov
            // 
            this.TxtPrixApprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtPrixApprov.Location = new System.Drawing.Point(512, 43);
            this.TxtPrixApprov.Mask = "0000000000";
            this.TxtPrixApprov.Name = "TxtPrixApprov";
            this.TxtPrixApprov.Size = new System.Drawing.Size(213, 22);
            this.TxtPrixApprov.TabIndex = 17;
            // 
            // TxtQteApprov
            // 
            this.TxtQteApprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtQteApprov.Location = new System.Drawing.Point(512, 16);
            this.TxtQteApprov.Mask = "0000000000";
            this.TxtQteApprov.Name = "TxtQteApprov";
            this.TxtQteApprov.Size = new System.Drawing.Size(213, 22);
            this.TxtQteApprov.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prix : ";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(361, 20);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 51);
            this.separatorControl1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantité : ";
            // 
            // CmbPiece
            // 
            this.CmbPiece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPiece.FormattingEnabled = true;
            this.CmbPiece.Location = new System.Drawing.Point(120, 47);
            this.CmbPiece.Name = "CmbPiece";
            this.CmbPiece.Size = new System.Drawing.Size(213, 24);
            this.CmbPiece.TabIndex = 8;
            this.CmbPiece.SelectedIndexChanged += new System.EventHandler(this.CmbApprov_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pièce : ";
            // 
            // BtnDeleteDApprov
            // 
            this.BtnDeleteDApprov.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteDApprov.Appearance.Options.UseFont = true;
            this.BtnDeleteDApprov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteDApprov.Image = global::StockBonBerger.Properties.Resources.cancel_16x16;
            this.BtnDeleteDApprov.Location = new System.Drawing.Point(430, 91);
            this.BtnDeleteDApprov.Name = "BtnDeleteDApprov";
            this.BtnDeleteDApprov.Size = new System.Drawing.Size(108, 27);
            this.BtnDeleteDApprov.TabIndex = 5;
            this.BtnDeleteDApprov.Text = "Supprimer";
            this.BtnDeleteDApprov.Click += new System.EventHandler(this.ControleDetailApprov_Click);
            // 
            // BtnSaveDApprov
            // 
            this.BtnSaveDApprov.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveDApprov.Appearance.Options.UseFont = true;
            this.BtnSaveDApprov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveDApprov.Image = global::StockBonBerger.Properties.Resources.apply_16x16;
            this.BtnSaveDApprov.Location = new System.Drawing.Point(311, 91);
            this.BtnSaveDApprov.Name = "BtnSaveDApprov";
            this.BtnSaveDApprov.Size = new System.Drawing.Size(108, 27);
            this.BtnSaveDApprov.TabIndex = 3;
            this.BtnSaveDApprov.Text = "Enregistrer";
            this.BtnSaveDApprov.Click += new System.EventHandler(this.ControleDetailApprov_Click);
            // 
            // BtnNewDApprov
            // 
            this.BtnNewDApprov.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewDApprov.Appearance.Options.UseFont = true;
            this.BtnNewDApprov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewDApprov.Image = global::StockBonBerger.Properties.Resources.add_16x16;
            this.BtnNewDApprov.Location = new System.Drawing.Point(192, 91);
            this.BtnNewDApprov.Name = "BtnNewDApprov";
            this.BtnNewDApprov.Size = new System.Drawing.Size(108, 27);
            this.BtnNewDApprov.TabIndex = 4;
            this.BtnNewDApprov.Text = "Nouveau";
            this.BtnNewDApprov.Click += new System.EventHandler(this.ControleDetailApprov_Click);
            // 
            // TxtCodeDetailApprov
            // 
            this.TxtCodeDetailApprov.Enabled = false;
            this.TxtCodeDetailApprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeDetailApprov.Location = new System.Drawing.Point(120, 19);
            this.TxtCodeDetailApprov.Name = "TxtCodeDetailApprov";
            this.TxtCodeDetailApprov.ReadOnly = true;
            this.TxtCodeDetailApprov.Size = new System.Drawing.Size(213, 22);
            this.TxtCodeDetailApprov.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code : ";
            // 
            // GbApprov
            // 
            this.GbApprov.Controls.Add(this.groupBox4);
            this.GbApprov.Controls.Add(this.groupBox3);
            this.GbApprov.Location = new System.Drawing.Point(12, 12);
            this.GbApprov.Name = "GbApprov";
            this.GbApprov.Size = new System.Drawing.Size(760, 153);
            this.GbApprov.TabIndex = 4;
            this.GbApprov.TabStop = false;
            this.GbApprov.Text = "Approvisionnement";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GcApprov);
            this.groupBox4.Location = new System.Drawing.Point(416, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 124);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // GcApprov
            // 
            this.GcApprov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcApprov.Location = new System.Drawing.Point(3, 16);
            this.GcApprov.MainView = this.GvApprov;
            this.GcApprov.Name = "GcApprov";
            this.GcApprov.Size = new System.Drawing.Size(326, 105);
            this.GcApprov.TabIndex = 6;
            this.GcApprov.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvApprov});
            this.GcApprov.DoubleClick += new System.EventHandler(this.GcApprov_DoubleClick);
            // 
            // GvApprov
            // 
            this.GvApprov.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColId,
            this.GColDate,
            this.GColFss});
            this.GvApprov.GridControl = this.GcApprov;
            this.GvApprov.Name = "GvApprov";
            this.GvApprov.OptionsBehavior.Editable = false;
            this.GvApprov.OptionsSelection.MultiSelect = true;
            this.GvApprov.OptionsView.ShowGroupPanel = false;
            // 
            // GColId
            // 
            this.GColId.Caption = "Code";
            this.GColId.FieldName = "id";
            this.GColId.Name = "GColId";
            this.GColId.Visible = true;
            this.GColId.VisibleIndex = 0;
            // 
            // GColDate
            // 
            this.GColDate.Caption = "Date";
            this.GColDate.DisplayFormat.FormatString = "d";
            this.GColDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GColDate.FieldName = "date_approv";
            this.GColDate.Name = "GColDate";
            this.GColDate.Visible = true;
            this.GColDate.VisibleIndex = 1;
            // 
            // GColFss
            // 
            this.GColFss.Caption = "Fournisseur";
            this.GColFss.FieldName = "fournisseur";
            this.GColFss.Name = "GColFss";
            this.GColFss.Visible = true;
            this.GColFss.VisibleIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbFss);
            this.groupBox3.Controls.Add(this.BtnDeleteApprov);
            this.groupBox3.Controls.Add(this.BtnSaveApprov);
            this.groupBox3.Controls.Add(this.BtnNewApprov);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TxtCodeApprov);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 124);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // CmbFss
            // 
            this.CmbFss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFss.FormattingEnabled = true;
            this.CmbFss.Location = new System.Drawing.Point(131, 46);
            this.CmbFss.Name = "CmbFss";
            this.CmbFss.Size = new System.Drawing.Size(239, 24);
            this.CmbFss.TabIndex = 9;
            this.CmbFss.SelectedIndexChanged += new System.EventHandler(this.CmbApprov_SelectedIndexChanged);
            // 
            // BtnDeleteApprov
            // 
            this.BtnDeleteApprov.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteApprov.Appearance.Options.UseFont = true;
            this.BtnDeleteApprov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteApprov.Image = global::StockBonBerger.Properties.Resources.cancel_16x16;
            this.BtnDeleteApprov.Location = new System.Drawing.Point(263, 83);
            this.BtnDeleteApprov.Name = "BtnDeleteApprov";
            this.BtnDeleteApprov.Size = new System.Drawing.Size(108, 27);
            this.BtnDeleteApprov.TabIndex = 5;
            this.BtnDeleteApprov.Text = "Supprimer";
            this.BtnDeleteApprov.Click += new System.EventHandler(this.ControleApprov_Click);
            // 
            // BtnSaveApprov
            // 
            this.BtnSaveApprov.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveApprov.Appearance.Options.UseFont = true;
            this.BtnSaveApprov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveApprov.Image = global::StockBonBerger.Properties.Resources.apply_16x16;
            this.BtnSaveApprov.Location = new System.Drawing.Point(143, 83);
            this.BtnSaveApprov.Name = "BtnSaveApprov";
            this.BtnSaveApprov.Size = new System.Drawing.Size(108, 27);
            this.BtnSaveApprov.TabIndex = 3;
            this.BtnSaveApprov.Text = "Enregistrer";
            this.BtnSaveApprov.Click += new System.EventHandler(this.ControleApprov_Click);
            // 
            // BtnNewApprov
            // 
            this.BtnNewApprov.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewApprov.Appearance.Options.UseFont = true;
            this.BtnNewApprov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewApprov.Image = global::StockBonBerger.Properties.Resources.add_16x16;
            this.BtnNewApprov.Location = new System.Drawing.Point(24, 83);
            this.BtnNewApprov.Name = "BtnNewApprov";
            this.BtnNewApprov.Size = new System.Drawing.Size(108, 27);
            this.BtnNewApprov.TabIndex = 4;
            this.BtnNewApprov.Text = "Nouveau";
            this.BtnNewApprov.Click += new System.EventHandler(this.ControleApprov_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fournisseur : ";
            // 
            // TxtCodeApprov
            // 
            this.TxtCodeApprov.Enabled = false;
            this.TxtCodeApprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeApprov.Location = new System.Drawing.Point(131, 19);
            this.TxtCodeApprov.Name = "TxtCodeApprov";
            this.TxtCodeApprov.ReadOnly = true;
            this.TxtCodeApprov.Size = new System.Drawing.Size(239, 22);
            this.TxtCodeApprov.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code : ";
            // 
            // GColCodeApprov
            // 
            this.GColCodeApprov.Caption = "Code Approv";
            this.GColCodeApprov.FieldName = "idDApv";
            this.GColCodeApprov.Name = "GColCodeApprov";
            // 
            // FormApprov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.GbDeatilApprov);
            this.Controls.Add(this.GbApprov);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormApprov";
            this.Text = "Approvisionnement";
            this.Load += new System.EventHandler(this.FormApprov_Load);
            this.GbDeatilApprov.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcDApprov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDApprov)).EndInit();
            this.GbControlDApprov.ResumeLayout(false);
            this.GbControlDApprov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.GbApprov.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcApprov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvApprov)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDeatilApprov;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraGrid.GridControl GcDApprov;
        private DevExpress.XtraGrid.Views.Grid.GridView GvDApprov;
        private DevExpress.XtraGrid.Columns.GridColumn GColCodeC;
        private DevExpress.XtraGrid.Columns.GridColumn GColDesignPiece;
        private DevExpress.XtraGrid.Columns.GridColumn GColQte;
        private DevExpress.XtraGrid.Columns.GridColumn GColCodeCategC;
        private System.Windows.Forms.GroupBox GbControlDApprov;
        private System.Windows.Forms.MaskedTextBox TxtQteApprov;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbPiece;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteDApprov;
        private DevExpress.XtraEditors.SimpleButton BtnSaveDApprov;
        private DevExpress.XtraEditors.SimpleButton BtnNewDApprov;
        private System.Windows.Forms.TextBox TxtCodeDetailApprov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GbApprov;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl GcApprov;
        private DevExpress.XtraGrid.Views.Grid.GridView GvApprov;
        private DevExpress.XtraGrid.Columns.GridColumn GColId;
        private DevExpress.XtraGrid.Columns.GridColumn GColDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteApprov;
        private DevExpress.XtraEditors.SimpleButton BtnSaveApprov;
        private DevExpress.XtraEditors.SimpleButton BtnNewApprov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodeApprov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbFss;
        private System.Windows.Forms.MaskedTextBox TxtPrixApprov;
        private DevExpress.XtraGrid.Columns.GridColumn GColFss;
        private DevExpress.XtraGrid.Columns.GridColumn GColPrix;
        private DevExpress.XtraGrid.Columns.GridColumn GColDFss;
        private DevExpress.XtraGrid.Columns.GridColumn GColCodeApprov;
    }
}