namespace StockBonBerger
{
    partial class FormPiece
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GcCategPiece = new DevExpress.XtraGrid.GridControl();
            this.GvCategPiece = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteCategP = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSaveCategP = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNewCategP = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDesignCategPiece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodeCategPiece = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnDeletePiece = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSavePiece = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNewPiece = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDesignPiece = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodePiece = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbCateggPiece = new System.Windows.Forms.ComboBox();
            this.TxtNumSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.TxtUsage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLieuFab = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.GcPiece = new DevExpress.XtraGrid.GridControl();
            this.GvPiece = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcCategPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCategPiece)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catégorie de pièce";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GcCategPiece);
            this.groupBox4.Location = new System.Drawing.Point(416, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 124);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // GcCategPiece
            // 
            this.GcCategPiece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcCategPiece.Location = new System.Drawing.Point(3, 16);
            this.GcCategPiece.MainView = this.GvCategPiece;
            this.GcCategPiece.Name = "GcCategPiece";
            this.GcCategPiece.Size = new System.Drawing.Size(326, 105);
            this.GcCategPiece.TabIndex = 6;
            this.GcCategPiece.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvCategPiece});
            // 
            // GvCategPiece
            // 
            this.GvCategPiece.GridControl = this.GcCategPiece;
            this.GvCategPiece.Name = "GvCategPiece";
            this.GvCategPiece.OptionsBehavior.Editable = false;
            this.GvCategPiece.OptionsSelection.MultiSelect = true;
            this.GvCategPiece.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnDeleteCategP);
            this.groupBox3.Controls.Add(this.BtnSaveCategP);
            this.groupBox3.Controls.Add(this.BtnNewCategP);
            this.groupBox3.Controls.Add(this.TxtDesignCategPiece);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TxtCodeCategPiece);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 124);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // BtnDeleteCategP
            // 
            this.BtnDeleteCategP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCategP.Appearance.Options.UseFont = true;
            this.BtnDeleteCategP.Image = global::StockBonBerger.Properties.Resources.cancel_16x16;
            this.BtnDeleteCategP.Location = new System.Drawing.Point(263, 83);
            this.BtnDeleteCategP.Name = "BtnDeleteCategP";
            this.BtnDeleteCategP.Size = new System.Drawing.Size(108, 27);
            this.BtnDeleteCategP.TabIndex = 5;
            this.BtnDeleteCategP.Text = "Supprimer";
            // 
            // BtnSaveCategP
            // 
            this.BtnSaveCategP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCategP.Appearance.Options.UseFont = true;
            this.BtnSaveCategP.Image = global::StockBonBerger.Properties.Resources.apply_16x16;
            this.BtnSaveCategP.Location = new System.Drawing.Point(142, 83);
            this.BtnSaveCategP.Name = "BtnSaveCategP";
            this.BtnSaveCategP.Size = new System.Drawing.Size(108, 27);
            this.BtnSaveCategP.TabIndex = 3;
            this.BtnSaveCategP.Text = "Enregistrer";
            // 
            // BtnNewCategP
            // 
            this.BtnNewCategP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewCategP.Appearance.Options.UseFont = true;
            this.BtnNewCategP.Image = global::StockBonBerger.Properties.Resources.add_16x16;
            this.BtnNewCategP.Location = new System.Drawing.Point(24, 83);
            this.BtnNewCategP.Name = "BtnNewCategP";
            this.BtnNewCategP.Size = new System.Drawing.Size(108, 27);
            this.BtnNewCategP.TabIndex = 4;
            this.BtnNewCategP.Text = "Nouveau";
            // 
            // TxtDesignCategPiece
            // 
            this.TxtDesignCategPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesignCategPiece.Location = new System.Drawing.Point(131, 46);
            this.TxtDesignCategPiece.Name = "TxtDesignCategPiece";
            this.TxtDesignCategPiece.Size = new System.Drawing.Size(239, 22);
            this.TxtDesignCategPiece.TabIndex = 2;
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
            // TxtCodeCategPiece
            // 
            this.TxtCodeCategPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeCategPiece.Location = new System.Drawing.Point(131, 19);
            this.TxtCodeCategPiece.Name = "TxtCodeCategPiece";
            this.TxtCodeCategPiece.ReadOnly = true;
            this.TxtCodeCategPiece.Size = new System.Drawing.Size(239, 22);
            this.TxtCodeCategPiece.TabIndex = 1;
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
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pièce";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtLieuFab);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TxtUsage);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.separatorControl1);
            this.groupBox5.Controls.Add(this.TxtNumSerie);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.CmbCateggPiece);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.BtnDeletePiece);
            this.groupBox5.Controls.Add(this.BtnSavePiece);
            this.groupBox5.Controls.Add(this.BtnNewPiece);
            this.groupBox5.Controls.Add(this.TxtDesignPiece);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.TxtCodePiece);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(13, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(732, 160);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // BtnDeletePiece
            // 
            this.BtnDeletePiece.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletePiece.Appearance.Options.UseFont = true;
            this.BtnDeletePiece.Image = global::StockBonBerger.Properties.Resources.cancel_16x16;
            this.BtnDeletePiece.Location = new System.Drawing.Point(406, 118);
            this.BtnDeletePiece.Name = "BtnDeletePiece";
            this.BtnDeletePiece.Size = new System.Drawing.Size(108, 27);
            this.BtnDeletePiece.TabIndex = 5;
            this.BtnDeletePiece.Text = "Supprimer";
            // 
            // BtnSavePiece
            // 
            this.BtnSavePiece.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSavePiece.Appearance.Options.UseFont = true;
            this.BtnSavePiece.Image = global::StockBonBerger.Properties.Resources.apply_16x16;
            this.BtnSavePiece.Location = new System.Drawing.Point(286, 118);
            this.BtnSavePiece.Name = "BtnSavePiece";
            this.BtnSavePiece.Size = new System.Drawing.Size(108, 27);
            this.BtnSavePiece.TabIndex = 3;
            this.BtnSavePiece.Text = "Enregistrer";
            // 
            // BtnNewPiece
            // 
            this.BtnNewPiece.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewPiece.Appearance.Options.UseFont = true;
            this.BtnNewPiece.Image = global::StockBonBerger.Properties.Resources.add_16x16;
            this.BtnNewPiece.Location = new System.Drawing.Point(168, 118);
            this.BtnNewPiece.Name = "BtnNewPiece";
            this.BtnNewPiece.Size = new System.Drawing.Size(108, 27);
            this.BtnNewPiece.TabIndex = 4;
            this.BtnNewPiece.Text = "Nouveau";
            // 
            // TxtDesignPiece
            // 
            this.TxtDesignPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesignPiece.Location = new System.Drawing.Point(120, 46);
            this.TxtDesignPiece.Name = "TxtDesignPiece";
            this.TxtDesignPiece.Size = new System.Drawing.Size(213, 22);
            this.TxtDesignPiece.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Désignation : ";
            // 
            // TxtCodePiece
            // 
            this.TxtCodePiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodePiece.Location = new System.Drawing.Point(120, 19);
            this.TxtCodePiece.Name = "TxtCodePiece";
            this.TxtCodePiece.ReadOnly = true;
            this.TxtCodePiece.Size = new System.Drawing.Size(213, 22);
            this.TxtCodePiece.TabIndex = 1;
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
            // CmbCateggPiece
            // 
            this.CmbCateggPiece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCateggPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCateggPiece.FormattingEnabled = true;
            this.CmbCateggPiece.Location = new System.Drawing.Point(120, 73);
            this.CmbCateggPiece.Name = "CmbCateggPiece";
            this.CmbCateggPiece.Size = new System.Drawing.Size(213, 24);
            this.CmbCateggPiece.TabIndex = 8;
            // 
            // TxtNumSerie
            // 
            this.TxtNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumSerie.Location = new System.Drawing.Point(482, 19);
            this.TxtNumSerie.Name = "TxtNumSerie";
            this.TxtNumSerie.Size = new System.Drawing.Size(213, 22);
            this.TxtNumSerie.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "N° de série : ";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(345, 22);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 75);
            this.separatorControl1.TabIndex = 11;
            // 
            // TxtUsage
            // 
            this.TxtUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsage.Location = new System.Drawing.Point(482, 46);
            this.TxtUsage.Name = "TxtUsage";
            this.TxtUsage.Size = new System.Drawing.Size(213, 22);
            this.TxtUsage.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Usage : ";
            // 
            // TxtLieuFab
            // 
            this.TxtLieuFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLieuFab.Location = new System.Drawing.Point(482, 73);
            this.TxtLieuFab.Name = "TxtLieuFab";
            this.TxtLieuFab.Size = new System.Drawing.Size(213, 22);
            this.TxtLieuFab.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lieu de Fab : ";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.GcPiece);
            this.groupBox6.Location = new System.Drawing.Point(13, 185);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(735, 87);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // GcPiece
            // 
            this.GcPiece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcPiece.Location = new System.Drawing.Point(3, 16);
            this.GcPiece.MainView = this.GvPiece;
            this.GcPiece.Name = "GcPiece";
            this.GcPiece.Size = new System.Drawing.Size(729, 68);
            this.GcPiece.TabIndex = 6;
            this.GcPiece.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvPiece});
            // 
            // GvPiece
            // 
            this.GvPiece.GridControl = this.GcPiece;
            this.GvPiece.Name = "GvPiece";
            this.GvPiece.OptionsBehavior.Editable = false;
            this.GvPiece.OptionsSelection.MultiSelect = true;
            this.GvPiece.OptionsView.ShowGroupPanel = false;
            // 
            // FormPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPiece";
            this.Text = "Pièce";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcCategPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCategPiece)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvPiece)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtCodeCategPiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl GcCategPiece;
        private DevExpress.XtraGrid.Views.Grid.GridView GvCategPiece;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteCategP;
        private DevExpress.XtraEditors.SimpleButton BtnSaveCategP;
        private DevExpress.XtraEditors.SimpleButton BtnNewCategP;
        private System.Windows.Forms.TextBox TxtDesignCategPiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.SimpleButton BtnDeletePiece;
        private DevExpress.XtraEditors.SimpleButton BtnSavePiece;
        private DevExpress.XtraEditors.SimpleButton BtnNewPiece;
        private System.Windows.Forms.TextBox TxtDesignPiece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodePiece;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtLieuFab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUsage;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.TextBox TxtNumSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCateggPiece;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraGrid.GridControl GcPiece;
        private DevExpress.XtraGrid.Views.Grid.GridView GvPiece;
    }
}