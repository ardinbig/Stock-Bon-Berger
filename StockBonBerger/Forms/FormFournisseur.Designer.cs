namespace StockBonBerger.Forms
{
    partial class FormFournisseur
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteFss = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSaveFss = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNewFss = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtAdresseFss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmailFss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNomsFss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTelephoneFss = new System.Windows.Forms.TextBox();
            this.TxtCodeFss = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GcFss = new DevExpress.XtraGrid.GridControl();
            this.GvFss = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColNoms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GColAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcFss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvFss)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fournisseur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDeleteFss);
            this.groupBox2.Controls.Add(this.BtnSaveFss);
            this.groupBox2.Controls.Add(this.BtnNewFss);
            this.groupBox2.Location = new System.Drawing.Point(450, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnDeleteFss
            // 
            this.BtnDeleteFss.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteFss.Appearance.Options.UseFont = true;
            this.BtnDeleteFss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteFss.Image = global::StockBonBerger.Properties.Resources.cancel_16x16;
            this.BtnDeleteFss.Location = new System.Drawing.Point(21, 118);
            this.BtnDeleteFss.Name = "BtnDeleteFss";
            this.BtnDeleteFss.Size = new System.Drawing.Size(108, 31);
            this.BtnDeleteFss.TabIndex = 5;
            this.BtnDeleteFss.Text = "Supprimer";
            this.BtnDeleteFss.Click += new System.EventHandler(this.ControleFss_Click);
            // 
            // BtnSaveFss
            // 
            this.BtnSaveFss.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveFss.Appearance.Options.UseFont = true;
            this.BtnSaveFss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveFss.Image = global::StockBonBerger.Properties.Resources.apply_16x16;
            this.BtnSaveFss.Location = new System.Drawing.Point(21, 70);
            this.BtnSaveFss.Name = "BtnSaveFss";
            this.BtnSaveFss.Size = new System.Drawing.Size(108, 31);
            this.BtnSaveFss.TabIndex = 3;
            this.BtnSaveFss.Text = "Enregistrer";
            this.BtnSaveFss.Click += new System.EventHandler(this.ControleFss_Click);
            // 
            // BtnNewFss
            // 
            this.BtnNewFss.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewFss.Appearance.Options.UseFont = true;
            this.BtnNewFss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewFss.Image = global::StockBonBerger.Properties.Resources.add_16x16;
            this.BtnNewFss.Location = new System.Drawing.Point(21, 22);
            this.BtnNewFss.Name = "BtnNewFss";
            this.BtnNewFss.Size = new System.Drawing.Size(108, 31);
            this.BtnNewFss.TabIndex = 4;
            this.BtnNewFss.Text = "Nouveau";
            this.BtnNewFss.Click += new System.EventHandler(this.ControleFss_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtAdresseFss);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtEmailFss);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TxtNomsFss);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TxtTelephoneFss);
            this.groupBox3.Controls.Add(this.TxtCodeFss);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 167);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // TxtAdresseFss
            // 
            this.TxtAdresseFss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdresseFss.Location = new System.Drawing.Point(137, 127);
            this.TxtAdresseFss.Name = "TxtAdresseFss";
            this.TxtAdresseFss.Size = new System.Drawing.Size(251, 22);
            this.TxtAdresseFss.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Adresse : ";
            // 
            // TxtEmailFss
            // 
            this.TxtEmailFss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailFss.Location = new System.Drawing.Point(137, 100);
            this.TxtEmailFss.Name = "TxtEmailFss";
            this.TxtEmailFss.Size = new System.Drawing.Size(251, 22);
            this.TxtEmailFss.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email : ";
            // 
            // TxtNomsFss
            // 
            this.TxtNomsFss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomsFss.Location = new System.Drawing.Point(137, 46);
            this.TxtNomsFss.Name = "TxtNomsFss";
            this.TxtNomsFss.Size = new System.Drawing.Size(251, 22);
            this.TxtNomsFss.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Noms : ";
            // 
            // TxtTelephoneFss
            // 
            this.TxtTelephoneFss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelephoneFss.Location = new System.Drawing.Point(137, 73);
            this.TxtTelephoneFss.Name = "TxtTelephoneFss";
            this.TxtTelephoneFss.Size = new System.Drawing.Size(251, 22);
            this.TxtTelephoneFss.TabIndex = 2;
            // 
            // TxtCodeFss
            // 
            this.TxtCodeFss.Enabled = false;
            this.TxtCodeFss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeFss.Location = new System.Drawing.Point(137, 19);
            this.TxtCodeFss.Name = "TxtCodeFss";
            this.TxtCodeFss.ReadOnly = true;
            this.TxtCodeFss.Size = new System.Drawing.Size(251, 22);
            this.TxtCodeFss.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Téléphone : ";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GcFss);
            this.groupBox4.Location = new System.Drawing.Point(12, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 209);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // GcFss
            // 
            this.GcFss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GcFss.Location = new System.Drawing.Point(3, 16);
            this.GcFss.MainView = this.GvFss;
            this.GcFss.Name = "GcFss";
            this.GcFss.Size = new System.Drawing.Size(754, 190);
            this.GcFss.TabIndex = 6;
            this.GcFss.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvFss});
            // 
            // GvFss
            // 
            this.GvFss.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColId,
            this.GColNoms,
            this.GColPhone,
            this.GColEmail,
            this.GColAdresse});
            this.GvFss.GridControl = this.GcFss;
            this.GvFss.Name = "GvFss";
            this.GvFss.OptionsBehavior.Editable = false;
            this.GvFss.OptionsSelection.MultiSelect = true;
            this.GvFss.OptionsView.ShowGroupPanel = false;
            // 
            // GColId
            // 
            this.GColId.Caption = "Code";
            this.GColId.FieldName = "id";
            this.GColId.Name = "GColId";
            this.GColId.Visible = true;
            this.GColId.VisibleIndex = 0;
            // 
            // GColNoms
            // 
            this.GColNoms.Caption = "Désignation";
            this.GColNoms.FieldName = "noms";
            this.GColNoms.Name = "GColNoms";
            this.GColNoms.Visible = true;
            this.GColNoms.VisibleIndex = 1;
            // 
            // GColPhone
            // 
            this.GColPhone.Caption = "Phone";
            this.GColPhone.FieldName = "phone";
            this.GColPhone.Name = "GColPhone";
            this.GColPhone.Visible = true;
            this.GColPhone.VisibleIndex = 2;
            // 
            // GColEmail
            // 
            this.GColEmail.Caption = "Email";
            this.GColEmail.FieldName = "email";
            this.GColEmail.Name = "GColEmail";
            this.GColEmail.Visible = true;
            this.GColEmail.VisibleIndex = 3;
            // 
            // GColAdresse
            // 
            this.GColAdresse.Caption = "Adresse";
            this.GColAdresse.FieldName = "adresse";
            this.GColAdresse.Name = "GColAdresse";
            this.GColAdresse.Visible = true;
            this.GColAdresse.VisibleIndex = 4;
            // 
            // FormFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormFournisseur";
            this.Text = "Fournisseur";
            this.Load += new System.EventHandler(this.FormFournisseur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcFss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvFss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl GcFss;
        private DevExpress.XtraGrid.Views.Grid.GridView GvFss;
        private DevExpress.XtraGrid.Columns.GridColumn GColId;
        private DevExpress.XtraGrid.Columns.GridColumn GColNoms;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteFss;
        private DevExpress.XtraEditors.SimpleButton BtnSaveFss;
        private DevExpress.XtraEditors.SimpleButton BtnNewFss;
        private System.Windows.Forms.TextBox TxtNomsFss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodeFss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtAdresseFss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmailFss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTelephoneFss;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn GColPhone;
        private DevExpress.XtraGrid.Columns.GridColumn GColEmail;
        private DevExpress.XtraGrid.Columns.GridColumn GColAdresse;
    }
}