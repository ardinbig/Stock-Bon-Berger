namespace StockBonBerger.Forms
{
    partial class FormCommande
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
            this.GbApprov = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GcCmd = new DevExpress.XtraGrid.GridControl();
            this.GvCmd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbClient = new System.Windows.Forms.ComboBox();
            this.BtnDeleteCmd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSaveCmd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNewCmd = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodeCmd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbDeatilApprov = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.GcDCmd = new DevExpress.XtraGrid.GridControl();
            this.GvDCmd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GColCodeC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColDClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColDesignPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColQte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColCodeCategC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColCodeCmd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GbControlDApprov = new System.Windows.Forms.GroupBox();
            this.TxtPrixCmd = new System.Windows.Forms.MaskedTextBox();
            this.TxtQteCmd = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbPiece = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDeleteDCmd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSaveDCmd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNewDCmd = new DevExpress.XtraEditors.SimpleButton();
            this.TxtCodeDetailCmd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GbApprov.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCmd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.GbDeatilApprov.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcDCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDCmd)).BeginInit();
            this.GbControlDApprov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbApprov
            // 
            this.GbApprov.Controls.Add(this.groupBox4);
            this.GbApprov.Controls.Add(this.groupBox3);
            this.GbApprov.Location = new System.Drawing.Point(12, 12);
            this.GbApprov.Name = "GbApprov";
            this.GbApprov.Size = new System.Drawing.Size(760, 153);
            this.GbApprov.TabIndex = 5;
            this.GbApprov.TabStop = false;
            this.GbApprov.Text = "Commande";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GcCmd);
            this.groupBox4.Location = new System.Drawing.Point(416, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 124);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // GcCmd
            // 
            this.GcCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcCmd.Location = new System.Drawing.Point(3, 16);
            this.GcCmd.MainView = this.GvCmd;
            this.GcCmd.Name = "GcCmd";
            this.GcCmd.Size = new System.Drawing.Size(326, 105);
            this.GcCmd.TabIndex = 6;
            this.GcCmd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvCmd});
            // 
            // GvCmd
            // 
            this.GvCmd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColId,
            this.GColDate,
            this.GColClient});
            this.GvCmd.GridControl = this.GcCmd;
            this.GvCmd.Name = "GvCmd";
            this.GvCmd.OptionsBehavior.Editable = false;
            this.GvCmd.OptionsSelection.MultiSelect = true;
            this.GvCmd.OptionsView.ShowGroupPanel = false;
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
            this.GColDate.FieldName = "date_cmd";
            this.GColDate.Name = "GColDate";
            this.GColDate.Visible = true;
            this.GColDate.VisibleIndex = 1;
            // 
            // GColClient
            // 
            this.GColClient.Caption = "Client";
            this.GColClient.FieldName = "client";
            this.GColClient.Name = "GColClient";
            this.GColClient.Visible = true;
            this.GColClient.VisibleIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbClient);
            this.groupBox3.Controls.Add(this.BtnDeleteCmd);
            this.groupBox3.Controls.Add(this.BtnSaveCmd);
            this.groupBox3.Controls.Add(this.BtnNewCmd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TxtCodeCmd);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 124);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // CmbClient
            // 
            this.CmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbClient.FormattingEnabled = true;
            this.CmbClient.Location = new System.Drawing.Point(131, 46);
            this.CmbClient.Name = "CmbClient";
            this.CmbClient.Size = new System.Drawing.Size(239, 24);
            this.CmbClient.TabIndex = 9;
            // 
            // BtnDeleteCmd
            // 
            this.BtnDeleteCmd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCmd.Appearance.Options.UseFont = true;
            this.BtnDeleteCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteCmd.Image = global::StockBonBerger.Properties.Resources.cancel_16x16;
            this.BtnDeleteCmd.Location = new System.Drawing.Point(263, 83);
            this.BtnDeleteCmd.Name = "BtnDeleteCmd";
            this.BtnDeleteCmd.Size = new System.Drawing.Size(108, 27);
            this.BtnDeleteCmd.TabIndex = 5;
            this.BtnDeleteCmd.Text = "Supprimer";
            // 
            // BtnSaveCmd
            // 
            this.BtnSaveCmd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCmd.Appearance.Options.UseFont = true;
            this.BtnSaveCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveCmd.Image = global::StockBonBerger.Properties.Resources.apply_16x16;
            this.BtnSaveCmd.Location = new System.Drawing.Point(143, 83);
            this.BtnSaveCmd.Name = "BtnSaveCmd";
            this.BtnSaveCmd.Size = new System.Drawing.Size(108, 27);
            this.BtnSaveCmd.TabIndex = 3;
            this.BtnSaveCmd.Text = "Enregistrer";
            // 
            // BtnNewCmd
            // 
            this.BtnNewCmd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewCmd.Appearance.Options.UseFont = true;
            this.BtnNewCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewCmd.Image = global::StockBonBerger.Properties.Resources.add_16x16;
            this.BtnNewCmd.Location = new System.Drawing.Point(24, 83);
            this.BtnNewCmd.Name = "BtnNewCmd";
            this.BtnNewCmd.Size = new System.Drawing.Size(108, 27);
            this.BtnNewCmd.TabIndex = 4;
            this.BtnNewCmd.Text = "Nouveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client : ";
            // 
            // TxtCodeCmd
            // 
            this.TxtCodeCmd.Enabled = false;
            this.TxtCodeCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeCmd.Location = new System.Drawing.Point(131, 19);
            this.TxtCodeCmd.Name = "TxtCodeCmd";
            this.TxtCodeCmd.ReadOnly = true;
            this.TxtCodeCmd.Size = new System.Drawing.Size(239, 22);
            this.TxtCodeCmd.TabIndex = 1;
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
            this.GbDeatilApprov.TabIndex = 6;
            this.GbDeatilApprov.TabStop = false;
            this.GbDeatilApprov.Text = "Détail commande";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.GcDCmd);
            this.groupBox6.Location = new System.Drawing.Point(13, 159);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(735, 113);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // GcDCmd
            // 
            this.GcDCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcDCmd.Location = new System.Drawing.Point(3, 16);
            this.GcDCmd.MainView = this.GvDCmd;
            this.GcDCmd.Name = "GcDCmd";
            this.GcDCmd.Size = new System.Drawing.Size(729, 94);
            this.GcDCmd.TabIndex = 6;
            this.GcDCmd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvDCmd});
            // 
            // GvDCmd
            // 
            this.GvDCmd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColCodeC,
            this.GColDClient,
            this.GColDesignPiece,
            this.GColQte,
            this.GColPrix,
            this.GColCodeCategC,
            this.GColCodeCmd});
            this.GvDCmd.GridControl = this.GcDCmd;
            this.GvDCmd.Name = "GvDCmd";
            this.GvDCmd.OptionsBehavior.Editable = false;
            this.GvDCmd.OptionsSelection.MultiSelect = true;
            this.GvDCmd.OptionsView.ShowGroupPanel = false;
            // 
            // GColCodeC
            // 
            this.GColCodeC.Caption = "Code";
            this.GColCodeC.FieldName = "idDApv";
            this.GColCodeC.Name = "GColCodeC";
            this.GColCodeC.Visible = true;
            this.GColCodeC.VisibleIndex = 0;
            // 
            // GColDClient
            // 
            this.GColDClient.Caption = "Client";
            this.GColDClient.FieldName = "client";
            this.GColDClient.Name = "GColDClient";
            this.GColDClient.Visible = true;
            this.GColDClient.VisibleIndex = 1;
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
            // GColCodeCmd
            // 
            this.GColCodeCmd.Caption = "Code Approv";
            this.GColCodeCmd.FieldName = "idDApv";
            this.GColCodeCmd.Name = "GColCodeCmd";
            // 
            // GbControlDApprov
            // 
            this.GbControlDApprov.Controls.Add(this.TxtPrixCmd);
            this.GbControlDApprov.Controls.Add(this.TxtQteCmd);
            this.GbControlDApprov.Controls.Add(this.label7);
            this.GbControlDApprov.Controls.Add(this.separatorControl1);
            this.GbControlDApprov.Controls.Add(this.label6);
            this.GbControlDApprov.Controls.Add(this.CmbPiece);
            this.GbControlDApprov.Controls.Add(this.label5);
            this.GbControlDApprov.Controls.Add(this.BtnDeleteDCmd);
            this.GbControlDApprov.Controls.Add(this.BtnSaveDCmd);
            this.GbControlDApprov.Controls.Add(this.BtnNewDCmd);
            this.GbControlDApprov.Controls.Add(this.TxtCodeDetailCmd);
            this.GbControlDApprov.Controls.Add(this.label4);
            this.GbControlDApprov.Location = new System.Drawing.Point(13, 19);
            this.GbControlDApprov.Name = "GbControlDApprov";
            this.GbControlDApprov.Size = new System.Drawing.Size(747, 134);
            this.GbControlDApprov.TabIndex = 1;
            this.GbControlDApprov.TabStop = false;
            // 
            // TxtPrixCmd
            // 
            this.TxtPrixCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtPrixCmd.Location = new System.Drawing.Point(512, 43);
            this.TxtPrixCmd.Mask = "0000000000";
            this.TxtPrixCmd.Name = "TxtPrixCmd";
            this.TxtPrixCmd.Size = new System.Drawing.Size(213, 22);
            this.TxtPrixCmd.TabIndex = 17;
            // 
            // TxtQteCmd
            // 
            this.TxtQteCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtQteCmd.Location = new System.Drawing.Point(512, 16);
            this.TxtQteCmd.Mask = "0000000000";
            this.TxtQteCmd.Name = "TxtQteCmd";
            this.TxtQteCmd.Size = new System.Drawing.Size(213, 22);
            this.TxtQteCmd.TabIndex = 16;
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
            // BtnDeleteDCmd
            // 
            this.BtnDeleteDCmd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteDCmd.Appearance.Options.UseFont = true;
            this.BtnDeleteDCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteDCmd.Image = global::StockBonBerger.Properties.Resources.cancel_16x16;
            this.BtnDeleteDCmd.Location = new System.Drawing.Point(430, 91);
            this.BtnDeleteDCmd.Name = "BtnDeleteDCmd";
            this.BtnDeleteDCmd.Size = new System.Drawing.Size(108, 27);
            this.BtnDeleteDCmd.TabIndex = 5;
            this.BtnDeleteDCmd.Text = "Supprimer";
            // 
            // BtnSaveDCmd
            // 
            this.BtnSaveDCmd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveDCmd.Appearance.Options.UseFont = true;
            this.BtnSaveDCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveDCmd.Image = global::StockBonBerger.Properties.Resources.apply_16x16;
            this.BtnSaveDCmd.Location = new System.Drawing.Point(311, 91);
            this.BtnSaveDCmd.Name = "BtnSaveDCmd";
            this.BtnSaveDCmd.Size = new System.Drawing.Size(108, 27);
            this.BtnSaveDCmd.TabIndex = 3;
            this.BtnSaveDCmd.Text = "Enregistrer";
            // 
            // BtnNewDCmd
            // 
            this.BtnNewDCmd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewDCmd.Appearance.Options.UseFont = true;
            this.BtnNewDCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewDCmd.Image = global::StockBonBerger.Properties.Resources.add_16x16;
            this.BtnNewDCmd.Location = new System.Drawing.Point(192, 91);
            this.BtnNewDCmd.Name = "BtnNewDCmd";
            this.BtnNewDCmd.Size = new System.Drawing.Size(108, 27);
            this.BtnNewDCmd.TabIndex = 4;
            this.BtnNewDCmd.Text = "Nouveau";
            // 
            // TxtCodeDetailCmd
            // 
            this.TxtCodeDetailCmd.Enabled = false;
            this.TxtCodeDetailCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeDetailCmd.Location = new System.Drawing.Point(120, 19);
            this.TxtCodeDetailCmd.Name = "TxtCodeDetailCmd";
            this.TxtCodeDetailCmd.ReadOnly = true;
            this.TxtCodeDetailCmd.Size = new System.Drawing.Size(213, 22);
            this.TxtCodeDetailCmd.TabIndex = 1;
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
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.GbDeatilApprov);
            this.Controls.Add(this.GbApprov);
            this.Name = "FormCommande";
            this.Text = "Commande";
            this.GbApprov.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCmd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GbDeatilApprov.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcDCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDCmd)).EndInit();
            this.GbControlDApprov.ResumeLayout(false);
            this.GbControlDApprov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbApprov;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl GcCmd;
        private DevExpress.XtraGrid.Views.Grid.GridView GvCmd;
        private DevExpress.XtraGrid.Columns.GridColumn GColId;
        private DevExpress.XtraGrid.Columns.GridColumn GColDate;
        private DevExpress.XtraGrid.Columns.GridColumn GColClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmbClient;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteCmd;
        private DevExpress.XtraEditors.SimpleButton BtnSaveCmd;
        private DevExpress.XtraEditors.SimpleButton BtnNewCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodeCmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbDeatilApprov;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraGrid.GridControl GcDCmd;
        private DevExpress.XtraGrid.Views.Grid.GridView GvDCmd;
        private DevExpress.XtraGrid.Columns.GridColumn GColCodeC;
        private DevExpress.XtraGrid.Columns.GridColumn GColDClient;
        private DevExpress.XtraGrid.Columns.GridColumn GColDesignPiece;
        private DevExpress.XtraGrid.Columns.GridColumn GColQte;
        private DevExpress.XtraGrid.Columns.GridColumn GColPrix;
        private DevExpress.XtraGrid.Columns.GridColumn GColCodeCategC;
        private DevExpress.XtraGrid.Columns.GridColumn GColCodeCmd;
        private System.Windows.Forms.GroupBox GbControlDApprov;
        private System.Windows.Forms.MaskedTextBox TxtPrixCmd;
        private System.Windows.Forms.MaskedTextBox TxtQteCmd;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbPiece;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteDCmd;
        private DevExpress.XtraEditors.SimpleButton BtnSaveDCmd;
        private DevExpress.XtraEditors.SimpleButton BtnNewDCmd;
        private System.Windows.Forms.TextBox TxtCodeDetailCmd;
        private System.Windows.Forms.Label label4;
    }
}