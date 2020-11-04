namespace WFA_exo_003
{
    partial class ListBox
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lNewElement = new System.Windows.Forms.Label();
            this.lIndexElement = new System.Windows.Forms.Label();
            this.lProperty = new System.Windows.Forms.Label();
            this.lList = new System.Windows.Forms.Label();
            this.tbNewElement = new System.Windows.Forms.TextBox();
            this.btnAddValidate = new System.Windows.Forms.Button();
            this.tbIndexElement = new System.Windows.Forms.TextBox();
            this.btnSelectIndex = new System.Windows.Forms.Button();
            this.btnEmptyList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tblItemCountSelected = new System.Windows.Forms.TextBox();
            this.tblSelectedIndex = new System.Windows.Forms.TextBox();
            this.tblSelectedText = new System.Windows.Forms.TextBox();
            this.lbListElements = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisie d\'une liste :";
            // 
            // lNewElement
            // 
            this.lNewElement.AutoSize = true;
            this.lNewElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewElement.Location = new System.Drawing.Point(44, 68);
            this.lNewElement.Name = "lNewElement";
            this.lNewElement.Size = new System.Drawing.Size(120, 16);
            this.lNewElement.TabIndex = 1;
            this.lNewElement.Text = "Nouvel élément:";
            // 
            // lIndexElement
            // 
            this.lIndexElement.AutoSize = true;
            this.lIndexElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIndexElement.Location = new System.Drawing.Point(244, 68);
            this.lIndexElement.Name = "lIndexElement";
            this.lIndexElement.Size = new System.Drawing.Size(108, 16);
            this.lIndexElement.TabIndex = 11;
            this.lIndexElement.Text = "Index élément:";
            // 
            // lProperty
            // 
            this.lProperty.AutoSize = true;
            this.lProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProperty.Location = new System.Drawing.Point(244, 199);
            this.lProperty.Name = "lProperty";
            this.lProperty.Size = new System.Drawing.Size(84, 16);
            this.lProperty.TabIndex = 13;
            this.lProperty.Text = "Propriétés:";
            // 
            // lList
            // 
            this.lList.AutoSize = true;
            this.lList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lList.Location = new System.Drawing.Point(44, 199);
            this.lList.Name = "lList";
            this.lList.Size = new System.Drawing.Size(69, 16);
            this.lList.TabIndex = 12;
            this.lList.Text = "ListListe:";
            // 
            // tbNewElement
            // 
            this.tbNewElement.Location = new System.Drawing.Point(47, 102);
            this.tbNewElement.Name = "tbNewElement";
            this.tbNewElement.Size = new System.Drawing.Size(146, 20);
            this.tbNewElement.TabIndex = 14;
            this.tbNewElement.TextChanged += new System.EventHandler(this.tbNewElement_TextChanged);
            // 
            // btnAddValidate
            // 
            this.btnAddValidate.Location = new System.Drawing.Point(47, 133);
            this.btnAddValidate.Name = "btnAddValidate";
            this.btnAddValidate.Size = new System.Drawing.Size(146, 22);
            this.btnAddValidate.TabIndex = 15;
            this.btnAddValidate.Text = "Ajout liste";
            this.btnAddValidate.UseVisualStyleBackColor = true;
            this.btnAddValidate.Click += new System.EventHandler(this.btnAddValidate_Click);
            // 
            // tbIndexElement
            // 
            this.tbIndexElement.Location = new System.Drawing.Point(247, 102);
            this.tbIndexElement.Name = "tbIndexElement";
            this.tbIndexElement.Size = new System.Drawing.Size(81, 20);
            this.tbIndexElement.TabIndex = 16;
            this.tbIndexElement.TextChanged += new System.EventHandler(this.tbIndexElement_TextChanged);
            // 
            // btnSelectIndex
            // 
            this.btnSelectIndex.Location = new System.Drawing.Point(348, 100);
            this.btnSelectIndex.Name = "btnSelectIndex";
            this.btnSelectIndex.Size = new System.Drawing.Size(146, 22);
            this.btnSelectIndex.TabIndex = 17;
            this.btnSelectIndex.Text = "Sélectionner";
            this.btnSelectIndex.UseVisualStyleBackColor = true;
            this.btnSelectIndex.Click += new System.EventHandler(this.btnSelectIndex_Click);
            // 
            // btnEmptyList
            // 
            this.btnEmptyList.Location = new System.Drawing.Point(348, 133);
            this.btnEmptyList.Name = "btnEmptyList";
            this.btnEmptyList.Size = new System.Drawing.Size(146, 22);
            this.btnEmptyList.TabIndex = 18;
            this.btnEmptyList.Text = "Vider la liste";
            this.btnEmptyList.UseVisualStyleBackColor = true;
            this.btnEmptyList.Click += new System.EventHandler(this.btnEmptyList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(244, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Items Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(244, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "SelectedIndex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(244, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Text";
            // 
            // tblItemCountSelected
            // 
            this.tblItemCountSelected.BackColor = System.Drawing.SystemColors.Control;
            this.tblItemCountSelected.Enabled = false;
            this.tblItemCountSelected.Location = new System.Drawing.Point(377, 240);
            this.tblItemCountSelected.Name = "tblItemCountSelected";
            this.tblItemCountSelected.Size = new System.Drawing.Size(81, 20);
            this.tblItemCountSelected.TabIndex = 23;
            this.tblItemCountSelected.TextChanged += new System.EventHandler(this.tblItemCountSelected_TextChanged);
            // 
            // tblSelectedIndex
            // 
            this.tblSelectedIndex.BackColor = System.Drawing.SystemColors.Control;
            this.tblSelectedIndex.Enabled = false;
            this.tblSelectedIndex.Location = new System.Drawing.Point(377, 295);
            this.tblSelectedIndex.Name = "tblSelectedIndex";
            this.tblSelectedIndex.Size = new System.Drawing.Size(81, 20);
            this.tblSelectedIndex.TabIndex = 24;
            this.tblSelectedIndex.TextChanged += new System.EventHandler(this.tblSelectedIndex_TextChanged);
            // 
            // tblSelectedText
            // 
            this.tblSelectedText.BackColor = System.Drawing.SystemColors.Control;
            this.tblSelectedText.Enabled = false;
            this.tblSelectedText.Location = new System.Drawing.Point(377, 347);
            this.tblSelectedText.Name = "tblSelectedText";
            this.tblSelectedText.Size = new System.Drawing.Size(81, 20);
            this.tblSelectedText.TabIndex = 25;
            this.tblSelectedText.TextChanged += new System.EventHandler(this.tblSelectedText_TextChanged);
            // 
            // lbListElements
            // 
            this.lbListElements.FormattingEnabled = true;
            this.lbListElements.Location = new System.Drawing.Point(47, 240);
            this.lbListElements.Name = "lbListElements";
            this.lbListElements.Size = new System.Drawing.Size(146, 134);
            this.lbListElements.TabIndex = 26;
            this.lbListElements.SelectedIndexChanged += new System.EventHandler(this.lbListElements_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 402);
            this.Controls.Add(this.lbListElements);
            this.Controls.Add(this.tblSelectedText);
            this.Controls.Add(this.tblSelectedIndex);
            this.Controls.Add(this.tblItemCountSelected);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEmptyList);
            this.Controls.Add(this.btnSelectIndex);
            this.Controls.Add(this.tbIndexElement);
            this.Controls.Add(this.btnAddValidate);
            this.Controls.Add(this.tbNewElement);
            this.Controls.Add(this.lProperty);
            this.Controls.Add(this.lList);
            this.Controls.Add(this.lIndexElement);
            this.Controls.Add(this.lNewElement);
            this.Controls.Add(this.label1);
            this.Name = "ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les listes et leurs propriétés";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNewElement;
        private System.Windows.Forms.Label lIndexElement;
        private System.Windows.Forms.Label lProperty;
        private System.Windows.Forms.Label lList;
        private System.Windows.Forms.TextBox tbNewElement;
        private System.Windows.Forms.Button btnAddValidate;
        private System.Windows.Forms.TextBox tbIndexElement;
        private System.Windows.Forms.Button btnSelectIndex;
        private System.Windows.Forms.Button btnEmptyList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tblItemCountSelected;
        private System.Windows.Forms.TextBox tblSelectedIndex;
        private System.Windows.Forms.TextBox tblSelectedText;
        private System.Windows.Forms.ListBox lbListElements;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

