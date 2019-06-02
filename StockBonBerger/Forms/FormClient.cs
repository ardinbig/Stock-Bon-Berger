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
    public partial class FormClient : Form
    {
        private Client client = null;
        private CategorieClient categClient = null;
        private int _idCategClient = 0;
        private bool _initCmbState = false;

        public FormClient()
        {
            InitializeComponent();
        }

        #region Common

        private void FormClient_Load(object sender, EventArgs e)
        {
            BtnDeleteCategC.Enabled = false;
            BtnDeleteClient.Enabled = false;
            LoadCombo();
            LoadGridControle();
            _initCmbState = true;
        }

        private void CmbCateggClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _idCategClient = Glossaire.Instance.SelectId(Constants.Table.CATEGORIE_CLIENT, CmbCategClient.Text);
            }
            else
            {
                CmbCategClient.SelectedIndex = -1;
            }
        }

        private void LoadCombo()
        {
            CmbCategClient.DataSource = Glossaire.Instance.LoadString("designation", Constants.Table.CATEGORIE_CLIENT);
        }

        private void LoadGridControle(int rank = 0)
        {
            if (rank == 1)
            {
                GcCategClient.DataSource = Glossaire.Instance.LoadGrid(Constants.Table.CATEGORIE_CLIENT, "id");
            }
            else if (rank == 2)
            {
                GcClient.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_CLIENTS, "idClient");
            }
            else
            {
                GcClient.DataSource = Glossaire.Instance.LoadGrid(Constants.View.LIST_CLIENTS, "idClient");
                GcCategClient.DataSource = Glossaire.Instance.LoadGrid(Constants.Table.CATEGORIE_CLIENT, "id");
            }
        }

        private void ClearFields(int rank)
        {
            if (rank == 1)
            {
                TxtDesignCategClient.Clear();
                TxtCodeCategClient.Clear();
                TxtDesignCategClient.Focus();
                BtnDeleteCategC.Enabled = false;
            }
            else
            {
                TxtCodeClient.Clear();
                TxtNomsClient.Clear();
                TxtPhoneClient.Clear();
                TxtEmailClient.Clear();
                TxtAdresseClient.Clear();

                _initCmbState = false;
                CmbCategClient.SelectedIndex = -1;
                _initCmbState = true;
                TxtNomsClient.Focus();
                BtnDeleteClient.Enabled = false;
            }
        }

        private bool IsNotEmpty(int rank)
        {
            if (rank == 1)
            {
                if (!string.IsNullOrEmpty(TxtDesignCategClient.Text) && string.IsNullOrEmpty(TxtCodeCategClient.Text))
                    return true;
                else
                    return false;
            }
            else if (rank == 2)
            {
                if (!string.IsNullOrEmpty(TxtNomsClient.Text) && !string.IsNullOrEmpty(CmbCategClient.Text))
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

        #region Catégorie Client

        private void ControleCategorieClient(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(1))
                    {
                        categClient = new CategorieClient
                        {
                            Code = "0",
                            Designation = TxtDesignCategClient.Text.ToUpper().Trim()
                        };

                        Glossaire.Instance.ControleCategorieClient(categClient);
                    }
                    else
                    {
                        categClient = new CategorieClient
                        {
                            Code = TxtCodeCategClient.Text.Trim(),
                            Designation = TxtDesignCategClient.Text.ToUpper().Trim()
                        };

                        Glossaire.Instance.ControleCategorieClient(categClient, 2);
                    }
                }
                else
                {
                    categClient = new CategorieClient
                    {
                        Code = TxtCodeCategClient.Text.Trim(),
                        Designation = TxtDesignCategClient.Text.ToUpper().Trim()
                    };

                    Glossaire.Instance.ControleCategorieClient(categClient, 3);
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

        private void ControleCategClient_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewCategC":
                    ClearFields(1);
                    break;

                case "BtnSaveCategC":
                    ControleCategorieClient(true);
                    break;

                case "BtnDeleteCategC":
                    ControleCategorieClient(false);
                    break;

                default:
                    break;
            }
        }

        private void GvCategClient_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TxtDesignCategClient.Text = GvCategClient.GetFocusedRowCellValue("designation").ToString();
                TxtCodeCategClient.Text = GvCategClient.GetFocusedRowCellValue("id").ToString();
                BtnDeleteCategC.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}
