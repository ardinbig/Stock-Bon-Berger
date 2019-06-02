namespace StockBonBerger.Forms
{
    partial class FormClient
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.GcClient = new DevExpress.XtraGrid.GridControl();
            this.GvClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GColCodeC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColNoms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColCategClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColCodeCategC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtAdresseClient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmailClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.TxtPhoneClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbCategClient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDeleteClient = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSaveClient = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNewClient = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNomsClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodeClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GcCategClient = new DevExpress.XtraGrid.GridControl();
            this.GvCategClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteCategC = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSaveCategC = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNewCategC = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDesignCategClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodeCategClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvClient)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcCategClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCategClient)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 278);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.GcClient);
            this.groupBox6.Location = new System.Drawing.Point(13, 185);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(735, 87);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // GcClient
            // 
            this.GcClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcClient.Location = new System.Drawing.Point(3, 16);
            this.GcClient.MainView = this.GvClient;
            this.GcClient.Name = "GcClient";
            this.GcClient.Size = new System.Drawing.Size(729, 68);
            this.GcClient.TabIndex = 6;
            this.GcClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvClient});
            this.GcClient.DoubleClick += new System.EventHandler(this.GvClient_DoubleClick);
            // 
            // GvClient
            // 
            this.GvClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColCodeC,
            this.GColNoms,
            this.GColCategClient,
            this.GColPhone,
            this.GColEmail,
            this.GColAdresse,
            this.GColCodeCategC});
            this.GvClient.GridControl = this.GcClient;
            this.GvClient.Name = "GvClient";
            this.GvClient.OptionsBehavior.Editable = false;
            this.GvClient.OptionsSelection.MultiSelect = true;
            this.GvClient.OptionsView.ShowGroupPanel = false;
            // 
            // GColCodeC
            // 
            this.GColCodeC.Caption = "Code";
            this.GColCodeC.FieldName = "idClient";
            this.GColCodeC.Name = "GColCodeC";
            this.GColCodeC.Visible = true;
            this.GColCodeC.VisibleIndex = 0;
            // 
            // GColNoms
            // 
            this.GColNoms.Caption = "Noms";
            this.GColNoms.FieldName = "noms";
            this.GColNoms.Name = "GColNoms";
            this.GColNoms.Visible = true;
            this.GColNoms.VisibleIndex = 1;
            // 
            // GColCategClient
            // 
            this.GColCategClient.Caption = "Catégorie";
            this.GColCategClient.FieldName = "categorie";
            this.GColCategClient.Name = "GColCategClient";
            this.GColCategClient.Visible = true;
            this.GColCategClient.VisibleIndex = 2;
            // 
            // GColPhone
            // 
            this.GColPhone.Caption = "Téléphone";
            this.GColPhone.FieldName = "phone";
            this.GColPhone.Name = "GColPhone";
            this.GColPhone.Visible = true;
            this.GColPhone.VisibleIndex = 3;
            // 
            // GColEmail
            // 
            this.GColEmail.Caption = "Email";
            this.GColEmail.FieldName = "email";
            this.GColEmail.Name = "GColEmail";
            this.GColEmail.Visible = true;
            this.GColEmail.VisibleIndex = 4;
            // 
            // GColAdresse
            // 
            this.GColAdresse.Caption = "Adresse";
            this.GColAdresse.FieldName = "adresse";
            this.GColAdresse.Name = "GColAdresse";
            this.GColAdresse.Visible = true;
            this.GColAdresse.VisibleIndex = 5;
            // 
            // GColCodeCategC
            // 
            this.GColCodeCategC.Caption = "CodeCategClient";
            this.GColCodeCategC.FieldName = "idCategC";
            this.GColCodeCategC.Name = "GColCodeCategC";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtAdresseClient);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TxtEmailClient);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.separatorControl1);
            this.groupBox5.Controls.Add(this.TxtPhoneClient);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.CmbCategClient);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.BtnDeleteClient);
            this.groupBox5.Controls.Add(this.BtnSaveClient);
            this.groupBox5.Controls.Add(this.BtnNewClient);
            this.groupBox5.Controls.Add(this.TxtNomsClient);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.TxtCodeClient);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(13, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(747, 160);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // TxtAdresseClient
            // 
            this.TxtAdresseClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdresseClient.Location = new System.Drawing.Point(519, 73);
            this.TxtAdresseClient.Name = "TxtAdresseClient";
            this.TxtAdresseClient.Size = new System.Drawing.Size(213, 22);
            this.TxtAdresseClient.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adresse : ";
            // 
            // TxtEmailClient
            // 
            this.TxtEmailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailClient.Location = new System.Drawing.Point(519, 46);
            this.TxtEmailClient.Name = "TxtEmailClient";
            this.TxtEmailClient.Size = new System.Drawing.Size(213, 22);
            this.TxtEmailClient.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(414, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email : ";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(365, 20);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 75);
            this.separatorControl1.TabIndex = 11;
            // 
            // TxtPhoneClient
            // 
            this.TxtPhoneClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhoneClient.Location = new System.Drawing.Point(519, 19);
            this.TxtPhoneClient.Name = "TxtPhoneClient";
            this.TxtPhoneClient.Size = new System.Drawing.Size(213, 22);
            this.TxtPhoneClient.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Téléphone : ";
            // 
            // CmbCategClient
            // 
            this.CmbCategClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategClient.FormattingEnabled = true;
            this.CmbCategClient.Location = new System.Drawing.Point(120, 73);
            this.CmbCategClient.Name = "CmbCategClient";
            this.CmbCategClient.Size = new System.Drawing.Size(213, 24);
            this.CmbCategClient.TabIndex = 8;
            this.CmbCategClient.SelectedIndexChanged += new System.EventHandler(this.CmbCategClient_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Catégorie : ";
            // 
            // BtnDeleteClient
            // 
            this.BtnDeleteClient.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteClient.Appearance.Options.UseFont = true;
            this.BtnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteClient.Image = global::StockBonBerger.Properties.Resources.cancel_16x16;
            this.BtnDeleteClient.Location = new System.Drawing.Point(426, 118);
            this.BtnDeleteClient.Name = "BtnDeleteClient";
            this.BtnDeleteClient.Size = new System.Drawing.Size(108, 27);
            this.BtnDeleteClient.TabIndex = 5;
            this.BtnDeleteClient.Text = "Supprimer";
            this.BtnDeleteClient.Click += new System.EventHandler(this.ControleClient_Click);
            // 
            // BtnSaveClient
            // 
            this.BtnSaveClient.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveClient.Appearance.Options.UseFont = true;
            this.BtnSaveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveClient.Image = global::StockBonBerger.Properties.Resources.apply_16x16;
            this.BtnSaveClient.Location = new System.Drawing.Point(307, 118);
            this.BtnSaveClient.Name = "BtnSaveClient";
            this.BtnSaveClient.Size = new System.Drawing.Size(108, 27);
            this.BtnSaveClient.TabIndex = 3;
            this.BtnSaveClient.Text = "Enregistrer";
            this.BtnSaveClient.Click += new System.EventHandler(this.ControleClient_Click);
            // 
            // BtnNewClient
            // 
            this.BtnNewClient.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewClient.Appearance.Options.UseFont = true;
            this.BtnNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewClient.Image = global::StockBonBerger.Properties.Resources.add_16x16;
            this.BtnNewClient.Location = new System.Drawing.Point(188, 118);
            this.BtnNewClient.Name = "BtnNewClient";
            this.BtnNewClient.Size = new System.Drawing.Size(108, 27);
            this.BtnNewClient.TabIndex = 4;
            this.BtnNewClient.Text = "Nouveau";
            this.BtnNewClient.Click += new System.EventHandler(this.ControleClient_Click);
            // 
            // TxtNomsClient
            // 
            this.TxtNomsClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomsClient.Location = new System.Drawing.Point(120, 46);
            this.TxtNomsClient.Name = "TxtNomsClient";
            this.TxtNomsClient.Size = new System.Drawing.Size(213, 22);
            this.TxtNomsClient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Noms : ";
            // 
            // TxtCodeClient
            // 
            this.TxtCodeClient.Enabled = false;
            this.TxtCodeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeClient.Location = new System.Drawing.Point(120, 19);
            this.TxtCodeClient.Name = "TxtCodeClient";
            this.TxtCodeClient.ReadOnly = true;
            this.TxtCodeClient.Size = new System.Drawing.Size(213, 22);
            this.TxtCodeClient.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catégorie de client";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GcCategClient);
            this.groupBox4.Location = new System.Drawing.Point(416, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 124);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // GcCategClient
            // 
            this.GcCategClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcCategClient.Location = new System.Drawing.Point(3, 16);
            this.GcCategClient.MainView = this.GvCategClient;
            this.GcCategClient.Name = "GcCategClient";
            this.GcCategClient.Size = new System.Drawing.Size(326, 105);
            this.GcCategClient.TabIndex = 6;
            this.GcCategClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvCategClient});
            this.GcCategClient.DoubleClick += new System.EventHandler(this.GvCategClient_DoubleClick);
            // 
            // GvCategClient
            // 
            this.GvCategClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColId,
            this.GColDescription});
            this.GvCategClient.GridControl = this.GcCategClient;
            this.GvCategClient.Name = "GvCategClient";
            this.GvCategClient.OptionsBehavior.Editable = false;
            this.GvCategClient.OptionsSelection.MultiSelect = true;
            this.GvCategClient.OptionsView.ShowGroupPanel = false;
            // 
            // GColId
            // 
            this.GColId.Caption = "Code";
            this.GColId.FieldName = "id";
            this.GColId.Name = "GColId";
            this.GColId.Visible = true;
            this.GColId.VisibleIndex = 0;
            // 
            // GColDescription
            // 
            this.GColDescription.Caption = "Désignation";
            this.GColDescription.FieldName = "designation";
            this.GColDescription.Name = "GColDescription";
            this.GColDescription.Visible = true;
            this.GColDescription.VisibleIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnDeleteCategC);
            this.groupBox3.Controls.Add(this.BtnSaveCategC);
            this.groupBox3.Controls.Add(this.BtnNewCategC);
            this.groupBox3.Controls.Add(this.TxtDesignCategClient);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TxtCodeCategClient);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 124);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // BtnDeleteCategC
            // 
            this.BtnDeleteCategC.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCategC.Appearance.Options.UseFont = true;
            this.BtnDeleteCategC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteCategC.Image = global::StockBonBerger.Properties.Resources.cancel_16x16;
            this.BtnDeleteCategC.Location = new System.Drawing.Point(263, 83);
            this.BtnDeleteCategC.Name = "BtnDeleteCategC";
            this.BtnDeleteCategC.Size = new System.Drawing.Size(108, 27);
            this.BtnDeleteCategC.TabIndex = 5;
            this.BtnDeleteCategC.Text = "Supprimer";
            this.BtnDeleteCategC.Click += new System.EventHandler(this.ControleCategClient_Click);
            // 
            // BtnSaveCategC
            // 
            this.BtnSaveCategC.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCategC.Appearance.Options.UseFont = true;
            this.BtnSaveCategC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveCategC.Image = global::StockBonBerger.Properties.Resources.apply_16x16;
            this.BtnSaveCategC.Location = new System.Drawing.Point(143, 83);
            this.BtnSaveCategC.Name = "BtnSaveCategC";
            this.BtnSaveCategC.Size = new System.Drawing.Size(108, 27);
            this.BtnSaveCategC.TabIndex = 3;
            this.BtnSaveCategC.Text = "Enregistrer";
            this.BtnSaveCategC.Click += new System.EventHandler(this.ControleCategClient_Click);
            // 
            // BtnNewCategC
            // 
            this.BtnNewCategC.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewCategC.Appearance.Options.UseFont = true;
            this.BtnNewCategC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewCategC.Image = global::StockBonBerger.Properties.Resources.add_16x16;
            this.BtnNewCategC.Location = new System.Drawing.Point(24, 83);
            this.BtnNewCategC.Name = "BtnNewCategC";
            this.BtnNewCategC.Size = new System.Drawing.Size(108, 27);
            this.BtnNewCategC.TabIndex = 4;
            this.BtnNewCategC.Text = "Nouveau";
            this.BtnNewCategC.Click += new System.EventHandler(this.ControleCategClient_Click);
            // 
            // TxtDesignCategClient
            // 
            this.TxtDesignCategClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesignCategClient.Location = new System.Drawing.Point(131, 46);
            this.TxtDesignCategClient.Name = "TxtDesignCategClient";
            this.TxtDesignCategClient.Size = new System.Drawing.Size(239, 22);
            this.TxtDesignCategClient.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Désignation : ";
            // 
            // TxtCodeCategClient
            // 
            this.TxtCodeCategClient.Enabled = false;
            this.TxtCodeCategClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeCategClient.Location = new System.Drawing.Point(131, 19);
            this.TxtCodeCategClient.Name = "TxtCodeCategClient";
            this.TxtCodeCategClient.ReadOnly = true;
            this.TxtCodeCategClient.Size = new System.Drawing.Size(239, 22);
            this.TxtCodeCategClient.TabIndex = 1;
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
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvClient)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcCategClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCategClient)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraGrid.GridControl GcClient;
        private DevExpress.XtraGrid.Views.Grid.GridView GvClient;
        private DevExpress.XtraGrid.Columns.GridColumn GColCodeC;
        private DevExpress.XtraGrid.Columns.GridColumn GColNoms;
        private DevExpress.XtraGrid.Columns.GridColumn GColCategClient;
        private DevExpress.XtraGrid.Columns.GridColumn GColPhone;
        private DevExpress.XtraGrid.Columns.GridColumn GColEmail;
        private DevExpress.XtraGrid.Columns.GridColumn GColAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn GColCodeCategC;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtAdresseClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmailClient;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.TextBox TxtPhoneClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCategClient;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteClient;
        private DevExpress.XtraEditors.SimpleButton BtnSaveClient;
        private DevExpress.XtraEditors.SimpleButton BtnNewClient;
        private System.Windows.Forms.TextBox TxtNomsClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodeClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl GcCategClient;
        private DevExpress.XtraGrid.Views.Grid.GridView GvCategClient;
        private DevExpress.XtraGrid.Columns.GridColumn GColId;
        private DevExpress.XtraGrid.Columns.GridColumn GColDescription;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteCategC;
        private DevExpress.XtraEditors.SimpleButton BtnSaveCategC;
        private DevExpress.XtraEditors.SimpleButton BtnNewCategC;
        private System.Windows.Forms.TextBox TxtDesignCategClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodeCategClient;
        private System.Windows.Forms.Label label1;
    }
}