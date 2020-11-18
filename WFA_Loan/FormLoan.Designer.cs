
namespace WFA_Loan
{
    partial class FormLoan
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAmountLoan = new System.Windows.Forms.TextBox();
            this.labelAmountLoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBoxInterestRate = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxPeriodicity = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNbMensuality = new System.Windows.Forms.Label();
            this.labelRefund = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxInterestRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(36, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nom";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(208, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAmountLoan
            // 
            this.textBoxAmountLoan.Location = new System.Drawing.Point(208, 84);
            this.textBoxAmountLoan.Name = "textBoxAmountLoan";
            this.textBoxAmountLoan.Size = new System.Drawing.Size(230, 20);
            this.textBoxAmountLoan.TabIndex = 3;
            this.textBoxAmountLoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelAmountLoan
            // 
            this.labelAmountLoan.AutoSize = true;
            this.labelAmountLoan.Location = new System.Drawing.Point(36, 91);
            this.labelAmountLoan.Name = "labelAmountLoan";
            this.labelAmountLoan.Size = new System.Drawing.Size(87, 13);
            this.labelAmountLoan.TabIndex = 2;
            this.labelAmountLoan.Text = "Capital Emprunté";
            this.labelAmountLoan.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Durée en mois du remboursement";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(208, 130);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(230, 17);
            this.hScrollBar1.TabIndex = 5;
            // 
            // groupBoxInterestRate
            // 
            this.groupBoxInterestRate.Controls.Add(this.radioButton9);
            this.groupBoxInterestRate.Controls.Add(this.radioButton8);
            this.groupBoxInterestRate.Controls.Add(this.radioButton7);
            this.groupBoxInterestRate.Location = new System.Drawing.Point(469, 36);
            this.groupBoxInterestRate.Name = "groupBoxInterestRate";
            this.groupBoxInterestRate.Size = new System.Drawing.Size(89, 125);
            this.groupBoxInterestRate.TabIndex = 3;
            this.groupBoxInterestRate.TabStop = false;
            this.groupBoxInterestRate.Text = "Taux d\'intérêt";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(24, 30);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(39, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Tag = "7";
            this.radioButton7.Text = "7%";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(24, 61);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(39, 17);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.Tag = "8";
            this.radioButton8.Text = "8%";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(24, 93);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(39, 17);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.Tag = "9";
            this.radioButton9.Text = "9%";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(609, 43);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(609, 86);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // listBoxPeriodicity
            // 
            this.listBoxPeriodicity.FormattingEnabled = true;
            this.listBoxPeriodicity.Location = new System.Drawing.Point(39, 228);
            this.listBoxPeriodicity.Name = "listBoxPeriodicity";
            this.listBoxPeriodicity.Size = new System.Drawing.Size(162, 95);
            this.listBoxPeriodicity.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Périodicité de remboursement";
            // 
            // labelNbMensuality
            // 
            this.labelNbMensuality.AutoSize = true;
            this.labelNbMensuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelNbMensuality.Location = new System.Drawing.Point(356, 228);
            this.labelNbMensuality.Name = "labelNbMensuality";
            this.labelNbMensuality.Size = new System.Drawing.Size(24, 25);
            this.labelNbMensuality.TabIndex = 10;
            this.labelNbMensuality.Text = "0";
            // 
            // labelRefund
            // 
            this.labelRefund.AutoSize = true;
            this.labelRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelRefund.Location = new System.Drawing.Point(386, 228);
            this.labelRefund.Name = "labelRefund";
            this.labelRefund.Size = new System.Drawing.Size(172, 25);
            this.labelRefund.TabIndex = 11;
            this.labelRefund.Text = "remboursements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.Location = new System.Drawing.Point(464, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "0 $";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRefund);
            this.Controls.Add(this.labelNbMensuality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPeriodicity);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxInterestRate);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAmountLoan);
            this.Controls.Add(this.labelAmountLoan);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprunter";
            this.groupBoxInterestRate.ResumeLayout(false);
            this.groupBoxInterestRate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAmountLoan;
        private System.Windows.Forms.Label labelAmountLoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox groupBoxInterestRate;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxPeriodicity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNbMensuality;
        private System.Windows.Forms.Label labelRefund;
        private System.Windows.Forms.Label label3;
    }
}

