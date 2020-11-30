using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using CM_CustomerLoan;
using CL_Check;
using CL_Periodicity;

namespace WFA_Loan
{
    public partial class FormLoan : Form
    {

        private BindingList<Periodicity> _listBoxPeriodicity;

        private CustomerLoan customerLoan;

        public FormLoan()
        {
            customerLoan = new CustomerLoan();

            InitializeComponent();

            // Préridicity
            _listBoxPeriodicity = new BindingList<Periodicity>(Enum.GetValues(typeof(Periodicity)).OfType<Periodicity>().ToList());
            listBoxPeriodicity.DataSource = _listBoxPeriodicity;
          
            UpdateAllFields();
        }

        /// <summary>
        /// button "Save" check all text boxes and error icones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if ((Check.CheckName(textBoxName.Text) == "") & (Check.CheckAmount(textBoxAmountLoan.Text) == ""))
            {
                //SaveAllTextBox();
                string validationOutput = "Nom :  " + textBoxName.Text + "\nMontant :   " + textBoxAmountLoan.Text.ToString();
                MessageBox.Show(validationOutput, "Emprunt valide");

            }
            else
            {
                CheckAllFields();
                SystemSounds.Beep.Play();
            }
        }

        /// <summary>
        /// button "Reset" clear all text boxes and error icones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAmountLoan.Clear();

            errorProvider.SetError(textBoxName, null);
            errorProvider.SetError(textBoxAmountLoan, null);

            buttonSave.Enabled = false;
        }

        //hScrollBarTimeInMonth
        public void UpdateAllFields()
        {

            //hScrollBarTimeInMonth.Value = customerLoan.TimeInMonth;
            //labelNbMensuality.Text = customerLoan.NumberOfRefund().ToString();
            //textBoxTimeByMonth.Text = customerLoan.NumberOfRefund().ToString();
            //customerLoan.TimeInMonth = this.hScrollBarTimeInMonth.Value;
            //textBoxTimeByMonth.Text = this.hScrollBarTimeInMonth.Value.ToString();

            int periodicity = Convert.ToInt32(customerLoan.Periodicity);
            float saveCapital = customerLoan.BorrowCapital;
            float.TryParse(textBoxAmountLoan.Text, out float calculateCapital);

            switch (customerLoan.PercentageRate)
            {
                case 7:
                    radioButton7.Checked = true;
                    break;
                case 8:
                    radioButton8.Checked = true;
                    break;
                case 9:
                    radioButton9.Checked = true;
                    break;
                default:
                    radioButton7.Checked = true;
                    break;
            }

            switch (customerLoan.Periodicity)
            {
                case Periodicity.Mensuel:
                    listBoxPeriodicity.SetSelected(0, true);
                    break;
                case Periodicity.Bimestriel:
                    listBoxPeriodicity.SetSelected(1, true);
                    break;
                case Periodicity.Trimestriel:
                    listBoxPeriodicity.SetSelected(2, true);
                    break;
                case Periodicity.Semestriel:
                    listBoxPeriodicity.SetSelected(3, true);
                    break;
                case Periodicity.Annuel:
                    listBoxPeriodicity.SetSelected(4, true);
                    break;
                default:
                    listBoxPeriodicity.SetSelected(0, true);
                    break;
            }

            // Met à jour la durée de remboursement en mois en fonction de la périodicité 
            if (hScrollBarTimeInMonth.Value % periodicity == 0)
            {
                customerLoan.TimeInMonth = hScrollBarTimeInMonth.Value;
                labelNbMensuality.Text = hScrollBarTimeInMonth.Value.ToString();
                textBoxTimeByMonth.Text = hScrollBarTimeInMonth.Value.ToString();
            }
            else
            {
                hScrollBarTimeInMonth.Value += 1;
                labelNbMensuality.Text = labelNbMensuality.Text + 1;
                textBoxTimeByMonth.Text = textBoxTimeByMonth.Text + 1;
            }

            hScrollBarTimeInMonth.Value = customerLoan.TimeInMonth;

            textBoxName.Text = customerLoan.Name;
            labelNbMensuality.Text = customerLoan.NumberOfRefund().ToString();
            //labelAmount.Text = customerLoan.AmountOfEachSteps().ToString() + " €";
            labelAmount.Text = Math.Round(customerLoan.AmountOfEachSteps(), 2).ToString() + " €";

            if (saveCapital != calculateCapital)
            {
                textBoxAmountLoan.Text = customerLoan.BorrowCapital.ToString();
            }



        }

        private void CheckAllFields()
        {
            // Check each field
            if (!(Check.CheckName(textBoxName.Text) == ""))
            {
                errorProvider.SetError(textBoxName, Check.CheckName(textBoxName.Text));
                textBoxName.Focus();
            }
            else
            {
                errorProvider.SetError(textBoxName, null);
            }

            if (!(Check.CheckName(textBoxAmountLoan.Text) == ""))
            {
                errorProvider.SetError(textBoxAmountLoan, Check.CheckAmount(textBoxAmountLoan.Text));
                textBoxAmountLoan.Focus();
            }
            else
            {
                errorProvider.SetError(textBoxAmountLoan, null);
            }
            
            // All is checked
            if ((Check.CheckName(textBoxName.Text) == "") & (Check.CheckAmount(textBoxAmountLoan.Text) == "") )
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonReset.Enabled = true;

            if (!(Check.CheckName(textBoxName.Text) == ""))
            {
                errorProvider.SetError(textBoxName, Check.CheckName(textBoxName.Text));
                buttonSave.Enabled = false;
            }
            else
            {
                customerLoan.Name = textBoxName.Text.ToString();
                errorProvider.SetError(textBoxName, null);
                buttonSave.Enabled = true;
                //UpdateAllFields();
            }
        }

        private void textBoxAmountLoan_TextChanged(object sender, EventArgs e)
        {
            buttonReset.Enabled = true;

            if (!(Check.CheckAmount(textBoxAmountLoan.Text) == ""))
            {
                errorProvider.SetError(textBoxAmountLoan, Check.CheckAmount(textBoxAmountLoan.Text));
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.SetError(textBoxAmountLoan, null);
                buttonSave.Enabled = true;

                customerLoan.BorrowCapital = Convert.ToInt32(textBoxAmountLoan.Text);

                UpdateAllFields();
            }
        }

        private void hScrollBarTimeInMonth_Scroll(object sender, ScrollEventArgs e)
        {
            this.UpdateAllFields();
        }

        private void textBoxTimeByMonth_TextChanged(object sender, EventArgs e)
        {
            this.UpdateAllFields();
        }

        private void listBoxPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {

            Periodicity savePeriodicity = customerLoan.Periodicity;
            Periodicity nextPeriodicity = customerLoan.Periodicity;

            switch (listBoxPeriodicity.SelectedItem)
            {
                case Periodicity.Mensuel:
                    nextPeriodicity = Periodicity.Mensuel;
                    //customerLoan.Periodicity = Periodicity.Mensuel;
                    break;

                case Periodicity.Bimestriel:
                    nextPeriodicity = Periodicity.Bimestriel;
                    //customerLoan.Periodicity = Periodicity.Bimestriel;
                    break;

                case Periodicity.Trimestriel:
                    nextPeriodicity = Periodicity.Trimestriel;
                    //customerLoan.Periodicity = Periodicity.Trimestriel;
                    break;

                case Periodicity.Semestriel:
                    nextPeriodicity = Periodicity.Semestriel;
                    //customerLoan.Periodicity = Periodicity.Semestriel;
                    break;

                case Periodicity.Annuel:
                    nextPeriodicity = Periodicity.Annuel;
                    //customerLoan.Periodicity = Periodicity.Annuel;
                    break;

                default:
                    nextPeriodicity = Periodicity.Mensuel;
                    //customerLoan.Periodicity = Periodicity.Mensuel;
                    break;
            }

            if (savePeriodicity != nextPeriodicity)
            {
                customerLoan.Periodicity = nextPeriodicity;
                //int PeriodicityByMonth = Convert.ToInt32(textBoxPeriodicity.Text.ToString());
                int PeriodicityByMonth = (int) customerLoan.Periodicity;

                hScrollBarTimeInMonth.LargeChange = PeriodicityByMonth;
                hScrollBarTimeInMonth.SmallChange = PeriodicityByMonth;

                this.UpdateAllFields();
            }
        }

        private void textBoxPeriodicity_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxInterestRate_Enter(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                customerLoan.PercentageRate = 7;
            }
            if (radioButton8.Checked)
            {
                customerLoan.PercentageRate = 8;
            }
            if (radioButton9.Checked)
            {
                customerLoan.PercentageRate = 9;
            }

            this.UpdateAllFields();
        }

        private void labelRefund_Click(object sender, EventArgs e)
        {

        }
    }
}
