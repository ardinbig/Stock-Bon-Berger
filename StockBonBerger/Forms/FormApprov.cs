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

        private void CmbApprov_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            if (_initCmbState)
            {
                switch (((Control)sender).Name)
                {
                    case "CmbFss":
                        _idFss = Glossaire.Instance.SelectId(Constants.Table.FOURNISSEUR, "noms", CmbFss.Text);
                        break;

                    case "CmbPiece":
                        _idPiece = Glossaire.Instance.SelectId(Constants.Table.PIECE, "designation", CmbPiece.Text);
                        break;
                }
            }
            else
            {
                CmbFss.SelectedIndex = -1;
                CmbPiece.SelectedIndex = -1;
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
                GcApprov.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_APPROV, "id");
            }
            else if (rank == 2)
            {
                GcDApprov.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_DETAIL_APPROV, "id");
            }
            else
            {
                GcApprov.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_APPROV, "id");
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
                GbControlDApprov.Enabled = false;
            }
            else
            {
                TxtCodeDetailApprov.Clear();
                TxtCodeApprov.Clear();
                TxtPrixApprov.Clear();
                TxtQteApprov.Clear();

                _initCmbState = false;
                CmbPiece.SelectedIndex = -1;
                _initCmbState = true;
                CmbPiece.Focus();
                BtnDeleteDApprov.Enabled = false;
                GbApprov.Enabled = true;
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

        #region Approvisionnement

        private void ControleApprovisionnement(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(1))
                    {
                        approv = new Approvisionnement
                        {
                            Code = "0",
                            CodeFournisseur = _idFss.ToString(),
                            Agent = "Admin"    
                            
                            /// TODO: Add current username here ! 
                        };

                        Glossaire.Instance.ControleApprov(approv);
                    }
                    else
                    {
                        approv = new Approvisionnement
                        {
                            Code = TxtCodeApprov.Text.Trim(),
                            CodeFournisseur = _idFss.ToString(),
                            Agent = "Admin"
                        };

                        Glossaire.Instance.ControleApprov(approv, 2);
                    }
                }
                else
                {
                    approv = new Approvisionnement
                    {
                        Code = TxtCodeApprov.Text.Trim(),
                        CodeFournisseur = _idFss.ToString(),
                        Agent = "Admin"
                    };

                    Glossaire.Instance.ControleApprov(approv, 3);
                }

                ClearFields(1);
                LoadCombo();
                LoadGridControle(1);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementeConnexion.Instance.Con != null)
                {
                    if (ImplementeConnexion.Instance.Con.State == System.Data.ConnectionState.Open)
                        ImplementeConnexion.Instance.Con.Close();
                }
            }
        }

        private void ControleApprov_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewApprov":
                    ClearFields(1);
                    break;

                case "BtnSaveApprov":
                    ControleApprovisionnement(true);
                    break;

                case "BtnDeleteApprov":
                    ControleApprovisionnement(false);
                    break;

                default:
                    break;
            }
        }

        private void GcApprov_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TxtCodeApprov.Text = GvApprov.GetFocusedRowCellValue("id").ToString();
                CmbFss.Text = GvApprov.GetFocusedRowCellValue("fournisseur").ToString();
                BtnDeleteApprov.Enabled = true;                

                if (!string.IsNullOrEmpty(TxtCodeApprov.Text) && !string.IsNullOrEmpty(CmbFss.Text))
                {
                    LoadGridControleApprov(Convert.ToInt32(TxtCodeApprov.Text));
                    GbControlDApprov.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadGridControleApprov(int id)
        {
            GcDApprov.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_DETAIL_APPROV, id.ToString(), "idDApv");
        }

        #endregion

        #region Détail approvisionnement

        private void ControleDetailApprovisionnement(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(2))
                    {
                        detailApprov = new DetailApprovisionnement
                        {
                            Code = "0",
                            CodeApprov = Convert.ToInt32(TxtCodeApprov.Text),
                            CodePiece = _idPiece,
                            Prix = double.Parse(TxtPrixApprov.Text),
                            Quantite = Convert.ToInt32(TxtQteApprov.Text)
                        };

                        Glossaire.Instance.ControleApprovDetail(detailApprov);
                    }
                    else
                    {
                        detailApprov = new DetailApprovisionnement
                        {
                            Code = TxtCodeDetailApprov.Text,
                            CodeApprov = Convert.ToInt32(TxtCodeApprov.Text),
                            CodePiece = _idPiece,
                            Prix = Convert.ToDouble(TxtPrixApprov.Text),
                            Quantite = Convert.ToInt32(TxtQteApprov.Text)
                        };

                        Glossaire.Instance.ControleApprovDetail(detailApprov, 2);
                    }
                }
                else
                {
                    detailApprov = new DetailApprovisionnement
                    {
                        Code = TxtCodeDetailApprov.Text,
                        CodeApprov = Convert.ToInt32(TxtCodeApprov.Text),
                        CodePiece = _idPiece,
                        Prix = Convert.ToDouble(TxtPrixApprov.Text),
                        Quantite = Convert.ToInt32(TxtQteApprov.Text)
                    };

                    Glossaire.Instance.ControleApprovDetail(detailApprov, 2);
                }

                ClearFields(2);
                LoadCombo();
                LoadGridControle(2);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementeConnexion.Instance.Con != null)
                {
                    if (ImplementeConnexion.Instance.Con.State == System.Data.ConnectionState.Open)
                        ImplementeConnexion.Instance.Con.Close();
                }
            }
        }

        private void ControleDetailApprov_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewDApprov":
                    ClearFields(2);
                    break;

                case "BtnSaveDApprov":
                    ControleDetailApprovisionnement(true);
                    break;

                case "BtnDeleteDApprov":
                    ControleDetailApprovisionnement(false);
                    break;

                default:
                    break;
            }
        }

        private void GcDApprov_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TxtCodeDetailApprov.Text = GvDApprov.GetFocusedRowCellValue("idDApv").ToString();
                TxtPrixApprov.Text = GvDApprov.GetFocusedRowCellValue("prix").ToString();
                TxtQteApprov.Text = GvDApprov.GetFocusedRowCellValue("quantite").ToString();
                CmbPiece.Text = GvDApprov.GetFocusedRowCellValue("designation").ToString();

                _initCmbState = false;
                CmbFss.Text = GvDApprov.GetFocusedRowCellValue("fournisseur").ToString();
                TxtCodeApprov.Text = GvDApprov.GetFocusedRowCellValue("id").ToString();
                _initCmbState = true;

                BtnDeleteDApprov.Enabled = true;
                GbApprov.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
