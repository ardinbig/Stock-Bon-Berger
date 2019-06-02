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
    public partial class FormFournisseur : Form
    {
        private Fournisseur fss = null;

        public FormFournisseur()
        {
            InitializeComponent();
        }

        private void FormFournisseur_Load(object sender, EventArgs e)
        {
            BtnDeleteFss.Enabled = false;
            LoadGridControle();
        }

        private void LoadGridControle(int rank = 0)
        {
            GcFss.DataSource = Glossaire.Instance.LoadGrid(Constants.Table.FOURNISSEUR, "id");
        }

        private bool IsNotEmpty()
        {
            if (!string.IsNullOrEmpty(TxtNomsFss.Text) && string.IsNullOrEmpty(TxtCodeFss.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void ClearFields()
        {
            TxtCodeFss.Clear();
            TxtAdresseFss.Clear();
            TxtEmailFss.Clear();
            TxtNomsFss.Clear();
            TxtTelephoneFss.Clear();
            TxtNomsFss.Focus();

            BtnDeleteFss.Enabled = false;
        }

        private void ControleFss(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty())
                    {
                        fss = new Fournisseur
                        {
                            Code = "0",
                            Noms = TxtNomsFss.Text.ToUpper().Trim(),
                            Email = TxtEmailFss.Text.ToUpper().Trim(),
                            Phone = TxtTelephoneFss.Text.ToUpper().Trim(),
                            Adresse = TxtAdresseFss.Text.ToUpper().Trim()
                        };

                        Glossaire.Instance.ControleFournisseur(fss);
                    }
                    else if(!string.IsNullOrEmpty(TxtCodeFss.Text))
                    {
                        fss = new Fournisseur
                        {
                            Code = TxtCodeFss.Text,
                            Noms = TxtNomsFss.Text.ToUpper().Trim(),
                            Email = TxtEmailFss.Text.ToUpper().Trim(),
                            Phone = TxtTelephoneFss.Text.ToUpper().Trim(),
                            Adresse = TxtAdresseFss.Text.ToUpper().Trim()
                        };

                        Glossaire.Instance.ControleFournisseur(fss, 2);
                    }
                }
                else
                {
                    fss = new Fournisseur
                    {
                        Code = TxtCodeFss.Text,
                        Noms = TxtNomsFss.Text.ToUpper().Trim(),
                        Email = TxtEmailFss.Text.ToUpper().Trim(),
                        Phone = TxtTelephoneFss.Text.ToUpper().Trim(),
                        Adresse = TxtAdresseFss.Text.ToUpper().Trim()
                    };

                    Glossaire.Instance.ControleFournisseur(fss, 3);
                }

                ClearFields();
                LoadGridControle();
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

        private void ControleFss_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewFss":
                    ClearFields();
                    break;

                case "BtnSaveFss":
                    ControleFss(true);
                    break;

                case "BtnDeleteFss":
                    ControleFss(false);
                    break;

                default:
                    break;
            }
        }

        private void GcFss_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TxtAdresseFss.Text = GvFss.GetFocusedRowCellValue("adresse").ToString();
                TxtCodeFss.Text = GvFss.GetFocusedRowCellValue("id").ToString();
                TxtEmailFss.Text = GvFss.GetFocusedRowCellValue("email").ToString();
                TxtNomsFss.Text = GvFss.GetFocusedRowCellValue("noms").ToString();
                TxtTelephoneFss.Text = GvFss.GetFocusedRowCellValue("phone").ToString();
                BtnDeleteFss.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
