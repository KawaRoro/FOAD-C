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
        }

        private void btnAddValidate_Click(object sender, EventArgs e)
        {
            lbListElements.Items.Add(tbNewElement.Text);
            tblSelectedText.Text = tbNewElement.Text;
            tblItemCountSelected.Text = lbListElements.Items.Count.ToString();

            // Buttons
            btnAddValidate.Enabled = false;
            btnSelectIndex.Enabled = true;
            btnEmptyList.Enabled = true;

            // Actions
            tbNewElement.Clear();
            tbNewElement.Focus();
        }

        private void btnSelectIndex_Click(object sender, EventArgs e)
        {
            int NbItemCountSelect = int.Parse(tblItemCountSelected.Text);
            int NbRealItemCountSelect = NbItemCountSelect - 1;
            lbListElements.SetSelected(NbItemCountSelect - 1, true);
            tblSelectedIndex.Text = Convert.ToString(NbItemCountSelect);
            tblSelectedText.Text = lbListElements.SelectedItem.ToString();
        }

        private void btnEmptyList_Click(object sender, EventArgs e)
        {
            // List Items
            lbListElements.Items.Clear();

            // Text box
            tbNewElement.Clear();
            tbIndexElement.Clear();
            tblItemCountSelected.Clear();
            tblSelectedIndex.Clear();
            tblSelectedText.Clear();

            // Buttons
            btnAddValidate.Enabled = false;
            btnSelectIndex.Enabled = false;
            //Enabled = false;
            btnEmptyList.Enabled = false;
        }

        private void tbNewElement_TextChanged(object sender, EventArgs e)
        {
            string newElementError = Verification.CheckName(tbNewElement.Text);
            bool beDuplicate = lbListElements.Items.Contains(tbNewElement.Text);

            if((newElementError != "") & (btnAddValidate.Enabled = false))
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

        private void tbIndexElement_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbListElements_SelectedIndexChanged(object sender, EventArgs e)
        {

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
