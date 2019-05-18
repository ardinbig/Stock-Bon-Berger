using StockBonBerger_Data;
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
    public partial class FormConnection : Form
    {
        private ConnexionType connexionType;
        private FormMain _formMain;

        public FormMain FormMain
        {
            get
            {
                return _formMain;
            }

            set
            {
                _formMain = value;
            }
        }

        public FormConnection()
        {
            InitializeComponent();
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            SetConnection();
        }

        private bool IsNotEmpty()
        {
            if (!string.IsNullOrEmpty(TxtDatabase.Text) && !string.IsNullOrEmpty(TxtPassword.Text) && !string.IsNullOrEmpty(TxtServer.Text) && !string.IsNullOrEmpty(TxtUser.Text))
                return true;
            else
                return false;
        }

        private void SetConnection()
        {
            try
            {
                if (IsNotEmpty())
                {
                    Connection connexion = new Connection();

                    connexion.Server = TxtServer.Text;
                    connexion.Database = TxtDatabase.Text;
                    connexion.User = TxtUser.Text;
                    connexion.Password = TxtPassword.Text;

                    ImplementeConnexion.Instance.Initialise(connexion, connexionType);
                    ImplementeConnexion.Instance.Con.Open();

                    MessageBox.Show("Connexion réussie !", "Connexion à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FormMain.ActivateItems(true);
                    Close();
                }
                else
                {
                    MessageBox.Show("Remplissez tous les champs !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
