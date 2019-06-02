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

namespace StockBonBerger
{
    public partial class FormPiece : Form
    {
        private Piece piece = null;
        private CategoriePiece categPiece= null;
        private int _idCategPiece = 0;
        private bool _initCmbState = false;

        public FormPiece()
        {
            InitializeComponent();
        }

        #region Common

        private void FormPiece_Load(object sender, EventArgs e)
        {            
            BtnDeleteCategP.Enabled = false;
            BtnDeletePiece.Enabled = false;
            LoadCombo();
            LoadGridControle();
            _initCmbState = true;
        }

        private void CmbCategPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _idCategPiece = Glossaire.Instance.SelectId(Constants.Table.CATEGORIE_PIECE, CmbCategPiece.Text);
            }
            else
            {
                CmbCategPiece.SelectedIndex = -1;
            }
        }

        private void LoadCombo()
        {
            CmbCategPiece.DataSource = Glossaire.Instance.LoadString("designation", Constants.Table.CATEGORIE_PIECE);
        }

        private void LoadGridControle(int rank = 0)
        {
            if (rank == 1)
            {
                GcCategPiece.DataSource = Glossaire.Instance.LoadGrid(Constants.Table.CATEGORIE_PIECE, "id");
            }
            else if (rank == 2)
            {
                GcPiece.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_PIECES, "idPiece");
            }
            else
            {
                GcPiece.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_PIECES, "idPiece");
                GcCategPiece.DataSource = Glossaire.Instance.LoadGrid(Constants.Table.CATEGORIE_PIECE, "id");
            }
        }

        private void ClearFields(int rank)
        {
            if (rank == 1)
            {
                TxtDesignCategPiece.Clear();
                TxtCodeCategPiece.Clear();
                TxtDesignCategPiece.Focus();
                BtnDeleteCategP.Enabled = false;
            }
            else
            {
                TxtCodePiece.Clear();
                TxtDesignPiece.Clear();
                TxtLieuFab.Clear();
                TxtNumSerie.Clear();
                TxtUsage.Clear();

                _initCmbState = false;
                CmbCategPiece.SelectedIndex = -1;
                _initCmbState = true;
                TxtDesignPiece.Focus();
                BtnDeletePiece.Enabled = false;
            }
        }

        private bool IsNotEmpty(int rank)
        {
            if (rank == 1)
            {
                if (!string.IsNullOrEmpty(TxtDesignCategPiece.Text) && string.IsNullOrEmpty(TxtCodeCategPiece.Text))
                    return true;
                else
                    return false;
            }
            else if (rank == 2)
            {
                if (!string.IsNullOrEmpty(TxtDesignPiece.Text) && !string.IsNullOrEmpty(TxtLieuFab.Text) && 
                    !string.IsNullOrEmpty(TxtNumSerie.Text) && !string.IsNullOrEmpty(TxtUsage.Text) &&
                    string.IsNullOrEmpty(TxtCodePiece.Text) && !string.IsNullOrEmpty(CmbCategPiece.Text))
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

        #region Catégorie Pièce

        private void ControleCategoriePiece(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(1))
                    {
                        categPiece = new CategoriePiece
                        {
                            Code = "0",
                            Designation = TxtDesignCategPiece.Text.ToUpper().Trim()
                        };

                        Glossaire.Instance.ControleCategoriePiece(categPiece);
                    }
                    else
                    {
                        categPiece = new CategoriePiece
                        {
                            Code = TxtCodeCategPiece.Text.Trim(),
                            Designation = TxtDesignCategPiece.Text.ToUpper().Trim()
                        };

                        Glossaire.Instance.ControleCategoriePiece(categPiece, 2);
                    }
                }
                else
                {
                    categPiece = new CategoriePiece
                    {
                        Code = TxtCodeCategPiece.Text.Trim(),
                        Designation = TxtDesignCategPiece.Text.ToUpper().Trim()
                    };

                    Glossaire.Instance.ControleCategoriePiece(categPiece, 3);
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

        private void ControleCategPiece_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewCategP":
                    ClearFields(1);
                    break;

                case "BtnSaveCategP":
                    ControleCategoriePiece(true);
                    break;

                case "BtnDeleteCategP":
                    ControleCategoriePiece(false);
                    break;

                default:
                    break;
            }
        }

        private void GvCategPiece_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TxtDesignCategPiece.Text = GvCategPiece.GetFocusedRowCellValue("designation").ToString();
                TxtCodeCategPiece.Text = GvCategPiece.GetFocusedRowCellValue("id").ToString();
                BtnDeleteCategP.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Pièce

        private void ControlePiece(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(2))
                    {
                        piece = new Piece
                        {
                            Code = "0",
                            Designation = TxtDesignPiece.Text.ToUpper().Trim(),
                            CodeCategoriePiece = _idCategPiece.ToString(),
                            LieuFabrication = TxtLieuFab.Text.ToUpper().Trim(),
                            NumeroSerie = TxtNumSerie.Text.ToUpper().Trim(),
                            Usage = TxtUsage.Text.ToUpper().Trim()
                        };

                        Glossaire.Instance.ControlePiece(piece);
                    }
                    else
                    {
                        piece = new Piece
                        {
                            Code = TxtCodePiece.Text,
                            Designation = TxtDesignPiece.Text.ToUpper().Trim(),
                            CodeCategoriePiece = _idCategPiece.ToString(),
                            LieuFabrication = TxtLieuFab.Text.ToUpper().Trim(),
                            NumeroSerie = TxtNumSerie.Text.ToUpper().Trim(),
                            Usage = TxtUsage.Text.ToUpper().Trim()
                        };

                        Glossaire.Instance.ControlePiece(piece, 2);
                    }
                }
                else
                {
                    piece = new Piece
                    {
                        Code = TxtCodePiece.Text,
                        Designation = TxtDesignPiece.Text.ToUpper().Trim(),
                        CodeCategoriePiece = _idCategPiece.ToString(),
                        LieuFabrication = TxtLieuFab.Text.ToUpper().Trim(),
                        NumeroSerie = TxtNumSerie.Text.ToUpper().Trim(),
                        Usage = TxtUsage.Text.ToUpper().Trim()
                    };

                    Glossaire.Instance.ControlePiece(piece, 3);
                }

                ClearFields(2);
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

        private void ControlePiece_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewPiece":
                    ClearFields(2);
                    break;

                case "BtnSavePiece":
                    ControlePiece(true);
                    break;

                case "BtnDeletePiece":
                    ControlePiece(false);
                    break;

                default:
                    break;
            }
        }

        private void GvPiece_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                _initCmbState = true;

                TxtCodePiece.Text = GvPiece.GetFocusedRowCellValue("idPiece").ToString();
                CmbCategPiece.Text = GvPiece.GetFocusedRowCellValue("categorie").ToString();
                TxtDesignPiece.Text = GvPiece.GetFocusedRowCellValue("designation").ToString();
                TxtLieuFab.Text = GvPiece.GetFocusedRowCellValue("lieu_fabrication").ToString();
                TxtNumSerie.Text = GvPiece.GetFocusedRowCellValue("numero_serie").ToString();
                TxtUsage.Text = GvPiece.GetFocusedRowCellValue("usage").ToString();

                BtnDeletePiece.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
