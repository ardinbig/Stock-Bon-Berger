using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockBonBerger_Data;
using StockBonBerger_Data.Models;

namespace StockBonBerger.Forms
{
    public partial class FormCommande : Form
    {
        private Commande cmd = null;
        private DetailCommande detailCmd = null;
        private int _idClient = 0;
        private int _idPiece = 0;
        private bool _initCmbState = false;

        public FormCommande()
        {
            InitializeComponent();
        }

        #region Common

        private void FormCommande_Load(object sender, EventArgs e)
        {
            GbControlDCmd.Enabled = false;
            BtnDeleteCmd.Enabled = false;
            BtnDeleteDCmd.Enabled = false;
            LoadCombo();
            LoadGridControle();
            _initCmbState = true;
        }

        private void CmbCommande_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_initCmbState)
            {
                switch (((Control)sender).Name)
                {
                    case "CmbClient":
                        _idClient = Glossaire.Instance.SelectId(Constants.Table.CLIENT, "noms", CmbClient.Text);
                        break;

                    case "CmbPiece":
                        _idPiece = Glossaire.Instance.SelectId(Constants.Table.PIECE, "designation", CmbPiece.Text);
                        break;
                }
            }
            else
            {
                CmbClient.SelectedIndex = -1;
                CmbPiece.SelectedIndex = -1;
            }
        }

        private void LoadCombo()
        {
            CmbClient.DataSource = Glossaire.Instance.LoadString("noms", Constants.Table.CLIENT);
            CmbPiece.DataSource = Glossaire.Instance.LoadString("designation", Constants.Table.PIECE);
        }

        private void LoadGridControle(int rank = 0)
        {
            if (rank == 1)
            {
                GcCmd.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_CMD, "id");
            }
            else if (rank == 2)
            {
                GcCmd.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_DETAIL_CMD, "id");
            }
            else
            {
                GcCmd.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_CMD, "id");
            }
        }

        private void ClearFields(int rank = 0)
        {
            if (rank == 1)
            {
                TxtCodeCmd.Clear();
                _initCmbState = false;
                CmbClient.SelectedIndex = -1;
                _initCmbState = true;
                BtnDeleteCmd.Enabled = false;
                GbControlDCmd.Enabled = false;
            }
            else
            {
                TxtCodeDetailCmd.Clear();
                TxtCodeCmd.Clear();
                TxtPrixCmd.Clear();
                TxtQteCmd.Clear();

                _initCmbState = false;
                CmbPiece.SelectedIndex = -1;
                _initCmbState = true;
                CmbPiece.Focus();
                BtnDeleteDCmd.Enabled = false;
                GbCmd.Enabled = true;
            }
        }

        private bool IsNotEmpty(int rank)
        {
            if (rank == 1)
            {
                if (!string.IsNullOrEmpty(CmbClient.Text) && string.IsNullOrEmpty(TxtCodeCmd.Text))
                    return true;
                else
                    return false;
            }
            else if (rank == 2)
            {
                if (!string.IsNullOrEmpty(CmbPiece.Text) && !string.IsNullOrEmpty(TxtQteCmd.Text) &&
                    !string.IsNullOrEmpty(TxtPrixCmd.Text) && string.IsNullOrEmpty(TxtCodeDetailCmd.Text))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
