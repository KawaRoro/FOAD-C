using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLVerification;

namespace WFA_exo_003
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();

            tbIndexElement.BackColor = SystemColors.Control;
            lbListElements.BackColor = SystemColors.Control;
            btnAddValidate.Enabled = false;
            btnSelectIndex.Enabled = false;
            btnEmptyList.Enabled = false;
        }

        private void btnAddValidate_Click(object sender, EventArgs e)
        {
            lbListElements.Items.Add(tbNewElement.Text);
            tblSelectedText.Text = tbNewElement.Text;
            tblSelectedIndex.Text = lbListElements.Items.Count.ToString();
            tblItemCountSelected.Text = lbListElements.Items.Count.ToString();

            // Buttons
            btnAddValidate.Enabled = false;
            btnSelectIndex.Enabled = false;
            btnEmptyList.Enabled = true;

            // Actions
            tbNewElement.Clear();
            tbNewElement.Focus();

            //tbIndexElement.Text = tbIndexElement.Text.ToString();
            
            // Check text box index element to refresh select
            if(tbIndexElement.Text.ToString() != "")
            {
                tbIndexElement_TextChanged(sender, e);
            }
            tbIndexElement.BackColor = Color.White;
            lbListElements.BackColor = Color.White;
        }

        private void btnSelectIndex_Click(object sender, EventArgs e)
        {
            string newElementError = Verification.CheckNumber(tbIndexElement.Text);
            int listItemCount = lbListElements.Items.Count;

            if (listItemCount != 0)
            {

                if (newElementError != "") // tbIndexElement.Text != "0"
                {
                    errorProvider.SetError(tbIndexElement, newElementError);
                    btnSelectIndex.Enabled = false;
                }
                else
                {

                    int NbItemCountSelect = int.Parse(tbIndexElement.Text);
                    int NbRealItemCountSelect = NbItemCountSelect - 1;// - 1
                    int listItemCountValue = lbListElements.Items.Count;

                    if (NbRealItemCountSelect >= listItemCountValue)
                    {
                        errorProvider.SetError(tbIndexElement, "Le nombre choisi dépasse le nombre d'items présent dans la liste.");
                        btnSelectIndex.Enabled = false;
                    }
                    else if (NbItemCountSelect < 1)
                    {
                        errorProvider.SetError(tbIndexElement, "L'item 0 n'existe pas. La liste commence à l'item 1.");
                        btnSelectIndex.Enabled = false;
                    }
                    else
                    {
                        errorProvider.SetError(tbIndexElement, null);
                        //btnSelectIndex.Enabled = true;

                        lbListElements.SetSelected(NbRealItemCountSelect, true);
                        tblSelectedIndex.Text = Convert.ToString(NbItemCountSelect);
                        tblSelectedText.Text = lbListElements.SelectedItem.ToString();
                    }

                }
            }
            else
            {
                errorProvider.SetError(tbIndexElement, "Veuillez insérer un item");
                btnSelectIndex.Enabled = false;
            }
        }

        private void btnEmptyList_Click(object sender, EventArgs e)
        {
            // Buttons
            btnAddValidate.Enabled = false;
            btnSelectIndex.Enabled = false;
            //Enabled = false;
            btnEmptyList.Enabled = false;

            // List Items
            lbListElements.Items.Clear();

            // Text box
            tbNewElement.Clear();
            tbNewElement.Focus();
            tbIndexElement.Clear();
            tblItemCountSelected.Clear();
            tblSelectedIndex.Clear();
            tblSelectedText.Clear();

            tbIndexElement.BackColor = SystemColors.Control;
            lbListElements.BackColor = SystemColors.Control;
            errorProvider.SetError(tbIndexElement, null);
        }

        private void tbNewElement_TextChanged(object sender, EventArgs e)
        {
            string newElementError = Verification.CheckName(tbNewElement.Text);
            bool beDuplicate = lbListElements.Items.Contains(tbNewElement.Text);

            if (tbNewElement.Text.ToString() != "")
            {
                if ((newElementError != "") & (btnAddValidate.Enabled = false))
                {
                    errorProvider.SetError(tbNewElement, newElementError);
                    btnAddValidate.Enabled = false;
                }
                else if (beDuplicate)
                {
                    errorProvider.SetError(tbNewElement, "Le nouvel item est déjà présent dans la liste.");
                    btnAddValidate.Enabled = false;
                }
                else
                {
                    errorProvider.SetError(tbNewElement, null);
                    btnAddValidate.Enabled = true;
                }
            }
            else
            {
                errorProvider.SetError(tbNewElement, null);
                btnAddValidate.Enabled = false;
            }

        }

        private void tbIndexElement_TextChanged(object sender, EventArgs e)
        {
            if(tbIndexElement.Text.ToString() != "")
            {
                string newElementError = Verification.CheckNumber(tbIndexElement.Text.ToString());
                int listItemCount = lbListElements.Items.Count;

                if (listItemCount != 0)
                {
                    if (newElementError != "")
                    {
                        errorProvider.SetError(tbIndexElement, newElementError);
                        btnSelectIndex.Enabled = false;
                    }
                    else
                    {
                        int listItemCountValue = lbListElements.Items.Count;

                        if (listItemCountValue != 0)
                        {
                            // parse à part
                            int NbItemCountSelect = int.Parse(tbIndexElement.Text);
                            int NbRealItemCountSelect = NbItemCountSelect - 1; //- 1

                            if (NbRealItemCountSelect >= listItemCount)
                            {
                                errorProvider.SetError(tbIndexElement, "Le nombre choisi dépasse le nombre d'items présent dans la liste.");
                                btnSelectIndex.Enabled = false;
                            }
                            else if (NbItemCountSelect < 1)
                            {
                                errorProvider.SetError(tbIndexElement, "L'item 0 n'existe pas. La liste commence à l'item 1.");
                                btnSelectIndex.Enabled = false;
                            }
                            else
                            {
                                errorProvider.SetError(tbIndexElement, null);
                                btnSelectIndex.Enabled = true;

                                /*lbListElements.SetSelected(NbRealItemCountSelect, true);
                                tblSelectedIndex.Text = Convert.ToString(NbItemCountSelect);
                                tblSelectedText.Text = lbListElements.SelectedItem.ToString();*/
                            }
                        }
                        else
                        {
                            errorProvider.SetError(tbIndexElement, "Veuillez insérer un item");
                            btnSelectIndex.Enabled = false;
                            tbIndexElement.BackColor = SystemColors.Control;
                        }


                    }
                }
                else
                {
                    errorProvider.SetError(tbIndexElement, "Veuillez insérer un item");
                    btnSelectIndex.Enabled = false;
                }
            }
            else
            {
                errorProvider.SetError(tbIndexElement, null);
            }
        }

        private void lbListElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            int listItemCount = lbListElements.Items.Count;

            if (listItemCount != 0)
            {
                if (lbListElements.SelectedIndex != -1)
                { 
                    tbIndexElement.Text = Convert.ToString(lbListElements.SelectedIndex + 1); //  + 1
                    tblSelectedIndex.Text = Convert.ToString(lbListElements.SelectedIndex + 1); //  + 1
                    tblSelectedText.Text = lbListElements.SelectedItem.ToString();
                }
            }
            
        }

        private void tblItemCountSelected_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblSelectedIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblSelectedText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
