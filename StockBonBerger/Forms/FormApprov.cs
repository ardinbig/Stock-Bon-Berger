using StockBonBerger_Data;
using StockBonBerger_Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockBonBerger.Forms
{
    public partial class FormApprov : Form
    {
        private Approvisionnement approv = null;
        private DetailApprovisionnement detailApprov = null;
        private int _idFss = 0;
        private int _idPiece = 0;
        private bool _initCmbState = false;

        public FormApprov()
        {
            InitializeComponent();
        }

        #region Common

        private void FormApprov_Load(object sender, EventArgs e)
        {
            GbControlDApprov.Enabled = false;
            BtnDeleteApprov.Enabled = false;
            BtnDeleteDApprov.Enabled = false;
            LoadCombo();
            LoadGridControle();
            _initCmbState = true;
        }

        private void CmbFss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _idFss = Glossaire.Instance.SelectId(Constants.Table.FOURNISSEUR, "noms", CmbFss.Text);
            }
            else
            {
                CmbFss.SelectedIndex = -1;
            }
        }

        private void LoadCombo()
        {
            CmbFss.DataSource = Glossaire.Instance.LoadString("noms", Constants.Table.FOURNISSEUR);
            CmbPiece.DataSource = Glossaire.Instance.LoadString("designation", Constants.Table.PIECE);
        }

        private void LoadGridControle(int rank = 0)
        {
            if (rank == 1)
            {
                GcApprov.DataSource = Glossaire.Instance.LoadGrid(Constants.Table.APPROVISIONNEMENT, "id");
            }
            else if (rank == 2)
            {
                GcDApprov.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_DETAIL_APPROV, "idApprov");
            }
            else
            {
                GcApprov.DataSource = Glossaire.Instance.LoadGrid(Constants.Table.APPROVISIONNEMENT, "id");
            }
        }

        private void ClearFields(int rank = 0)
        {
            if (rank == 1)
            {
                TxtCodeApprov.Clear();
                _initCmbState = false;
                CmbFss.SelectedIndex = -1;
                _initCmbState = true;
                BtnDeleteApprov.Enabled = false;
            }
            else
            {
                TxtCodeDetailApprov.Clear();
                TxtPrixApprov.Clear();
                TxtQteApprov.Clear();

                _initCmbState = false;
                CmbPiece.SelectedIndex = -1;
                _initCmbState = true;
                CmbPiece.Focus();
                BtnDeleteDApprov.Enabled = false;
            }
        }

        private bool IsNotEmpty(int rank)
        {
            if (rank == 1)
            {
                if (!string.IsNullOrEmpty(CmbFss.Text) && string.IsNullOrEmpty(TxtCodeApprov.Text))
                    return true;
                else
                    return false;
            }
            else if (rank == 2)
            {
                if (!string.IsNullOrEmpty(CmbPiece.Text) && !string.IsNullOrEmpty(TxtQteApprov.Text) &&
                    !string.IsNullOrEmpty(TxtPrixApprov.Text) && string.IsNullOrEmpty(TxtCodeDetailApprov.Text))
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
